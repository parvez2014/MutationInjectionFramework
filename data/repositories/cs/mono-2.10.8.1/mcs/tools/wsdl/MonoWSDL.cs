///
/// MonoWSDL.cs -- a WSDL to proxy code generator.
///
/// Author: Erik LeBel (eriklebel@yahoo.ca)
/// 		Lluis Sanchez (lluis@ximian.com)
///
/// Copyright (C) 2003, Erik LeBel,
///

#if !NET_2_0

using System;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.Schema;
using System.Collections;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Net;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Reflection;

using Microsoft.CSharp;

namespace Mono.WebServices
{
///
/// <summary>
///	Source code generator.
/// </summary>
///
class SourceGenerator
{
    string applicationSiganture 	= null;
    string appSettingURLKey		= null;
    string appSettingBaseURL	= null;
    string language			= "CS";
    string ns			= null;
    string outFilename		= null;
    string protocol			= "Soap";
    bool   server			= false;

    ///
    /// <summary/>
    ///
    public string Language
    {
        // FIXME validate
        set
        {
            language = value;
        }
    }

    ///
    /// <summary/>
    ///
    public string Namespace
    {
        set
        {
            ns = value;
        }
    }

    ///
    /// <summary>
    ///	The file to contain the generated code.
    /// </summary>
    ///
    public string Filename
    {
        set
        {
            outFilename = value;
        }
    }

    ///
    /// <summary/>
    ///
    public string Protocol
    {
        // FIXME validate
        set
        {
            protocol = value;
        }
        get
        {
            return protocol;
        }
    }

    ///
    /// <summary/>
    ///
    public string ApplicationSignature
    {
        set
        {
            applicationSiganture = value;
        }
    }

    ///
    /// <summary/>
    ///
    public string AppSettingURLKey
    {
        set
        {
            appSettingURLKey = value;
        }
    }

    ///
    /// <summary/>
    ///
    public string AppSettingBaseURL
    {
        set
        {
            appSettingBaseURL  = value;
        }
    }

    ///
    /// <summary/>
    ///
    public bool Server
    {
        set
        {
            server = value;
        }
    }

    ///
    /// <summary>
    ///	Generate code for the specified ServiceDescription.
    /// </summary>
    ///
    public bool GenerateCode (ArrayList descriptions, ArrayList schemas)
    {
        // FIXME iterate over each serviceDescription.Services?
        CodeNamespace codeNamespace = GetCodeNamespace();
        CodeCompileUnit codeUnit = new CodeCompileUnit();
        bool hasWarnings = false;

        codeUnit.Namespaces.Add(codeNamespace);

        ServiceDescriptionImporter importer = new ServiceDescriptionImporter();
        importer.ProtocolName = protocol;
        if (server)
            importer.Style = ServiceDescriptionImportStyle.Server;

        foreach (ServiceDescription sd in descriptions)
            importer.AddServiceDescription(sd, appSettingURLKey, appSettingBaseURL);

        foreach (XmlSchema sc in schemas)
            importer.Schemas.Add (sc);

        ServiceDescriptionImportWarnings warnings = importer.Import(codeNamespace, codeUnit);
        if (warnings != 0)
        {
            if ((warnings & ServiceDescriptionImportWarnings.NoCodeGenerated) > 0)
                Console.WriteLine ("WARNING: No proxy class was generated");
            if ((warnings & ServiceDescriptionImportWarnings.NoMethodsGenerated) > 0)
                Console.WriteLine ("WARNING: The proxy class generated includes no methods");
            if ((warnings & ServiceDescriptionImportWarnings.OptionalExtensionsIgnored) > 0)
                Console.WriteLine ("WARNING: At least one optional extension has been ignored");
            if ((warnings & ServiceDescriptionImportWarnings.RequiredExtensionsIgnored) > 0)
                Console.WriteLine ("WARNING: At least one necessary extension has been ignored");
            if ((warnings & ServiceDescriptionImportWarnings.UnsupportedBindingsIgnored) > 0)
                Console.WriteLine ("WARNING: At least one binding is of an unsupported type and has been ignored");
            if ((warnings & ServiceDescriptionImportWarnings.UnsupportedOperationsIgnored) > 0)
                Console.WriteLine ("WARNING: At least one operation is of an unsupported type and has been ignored");
            hasWarnings = true;
        }

        string fileName = null;
        bool hasBindings = false;

        foreach (ServiceDescription desc in descriptions)
        {
            if (fileName == null && desc.Services.Count > 0)
                fileName = desc.Services[0].Name;

            if (desc.Bindings.Count > 0 || desc.Services.Count > 0)
                hasBindings = true;
        }

        if (fileName == null)
            fileName = "output";

        if (hasBindings)
            WriteCodeUnit (codeUnit, fileName);

        return hasWarnings;
    }

    ///
    /// <summary>
    ///	Create the CodeNamespace with the generator's signature commented in.
    /// </summary>
    ///
    CodeNamespace GetCodeNamespace()
    {
        CodeNamespace codeNamespace = new CodeNamespace(ns);

        if (applicationSiganture != null)
        {
            codeNamespace.Comments.Add(new CodeCommentStatement("\n This source code was auto-generated by " + applicationSiganture + "\n"));
        }

        return codeNamespace;
    }

    ///
    /// <summary/>
    ///
    void WriteCodeUnit(CodeCompileUnit codeUnit, string serviceName)
    {
        CodeDomProvider provider = GetProvider();
        ICodeGenerator generator = provider.CreateGenerator();
        CodeGeneratorOptions options = new CodeGeneratorOptions();

        string filename;
        if (outFilename != null)
            filename = outFilename;
        else
            filename = serviceName	+ "." + provider.FileExtension;

        Console.WriteLine ("Writing file '{0}'", filename);
        StreamWriter writer = new StreamWriter(filename);
        generator.GenerateCodeFromCompileUnit(codeUnit, writer, options);
        writer.Close();
    }

    ///
    /// <summary>
    ///	Fetch the Code Provider for the language specified by the 'language' members.
    /// </summary>
    ///
    private CodeDomProvider GetProvider()
    {
        CodeDomProvider provider;
        Type type;

        switch (language.ToUpper ())
        {
        case "CS":
            provider = new CSharpCodeProvider ();
            break;
        case "VB":
            provider = new Microsoft.VisualBasic.VBCodeProvider ();
            break;
        case "BOO":
            type = Type.GetType("Boo.Lang.CodeDom.BooCodeProvider, Boo.Lang.CodeDom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=32c39770e9a21a67");
            if (type != null)
            {
                return (CodeDomProvider) Activator.CreateInstance (type);
            }
            throw new Exception ("Boo.Lang.CodeDom.BooCodeProvider not available");

        default:
            type = Type.GetType(language);
            if (type != null)
            {
                return (CodeDomProvider) Activator.CreateInstance (type);
            }
            throw new Exception ("Unknown language");
        }
        return provider;
    }
}

///
/// <summary>
///	monoWSDL's main application driver. Reads the command-line arguments and dispatch the
///	appropriate handlers.
/// </summary>
///
public class Driver
{
    const string ProductId = "Mono Web Services Description Language Utility";
    const string UsageMessage =
        "wsdl [options] {path | URL} \n\n"
        + "   -d, -domain:domain           Domain of username for server authentication.\n"
        + "   -l, -language:language       Language of generated code. Allowed CS (default)\n"
        + "                                and VB. You can also specify the fully qualified\n"
        + "                                name of a class that implements the\n"
        + "                                System.CodeDom.Compiler.CodeDomProvider Class.\n"
        + "   -n, -namespace:ns            The namespace of the generated code, default\n"
        + "                                namespace if none.\n"
        + "   -nologo                      Surpress the startup logo.\n"
        + "   -o, -out:filename            The target file for generated code.\n"
        + "   -p, -password:pwd            Password used to contact the server.\n"
        + "   -protocol:protocol           Protocol to implement. Allowed: Soap (default),\n"
        + "                                HttpGet or HttpPost.\n"
        + "   -server                      Generate server instead of client proxy code.\n"
        + "   -u, -username:username       Username used to contact the server.\n"
        + "   -proxy:url                   Address of the proxy.\n"
        + "   -pu, -proxyusername:username Username used to contact the proxy.\n"
        + "   -pp, -proxypassword:pwd      Password used to contact the proxy.\n"
        + "   -pd, -proxydomain:domain     Domain of username for proxy authentication.\n"
        + "   -urlkey, -appsettingurlkey:key Configuration key that contains the default\n"
        + "                                url for the generated WS proxy.\n"
        + "   -baseurl, -appsettingbaseurl:url Base url to use when constructing the\n"
        + "                                service url.\n"
        + "   -type:typename,assembly      Generate a proxy for a compiled web service\n"
        + "                                class. The URL parameter can be used to provide\n"
        + "                                the location of the service.\n"
        + "   -sample:[binding/]operation  Display a sample SOAP request and response.\n"
        + "   -?                           Display this message\n"
        + "\n"
        + "Options can be of the forms  -option, --option or /option\n";

    SourceGenerator generator = null;

    ArrayList descriptions = new ArrayList ();
    ArrayList schemas = new ArrayList ();

    bool noLogo = false;
    bool help = false;
    bool hasURL = false;
    string sampleSoap = null;

    string proxyAddress = null;
    string proxyDomain = null;
    string proxyPassword = null;
    string proxyUsername = null;
    string username;
    string password;
    string domain;

    StringCollection urls = new StringCollection ();
    string className;

    ///
    /// <summary>
    ///	Initialize the document retrieval component and the source code generator.
    /// </summary>
    ///
    Driver()
    {
        generator = new SourceGenerator();
        generator.ApplicationSignature = ProductId;
    }

    ///
    /// <summary>
    ///	Interperet the command-line arguments and configure the relavent components.
    /// </summary>
    ///
    void ImportArgument(string argument)
    {
        string optionValuePair;

        if (argument.StartsWith("--"))
        {
            optionValuePair = argument.Substring(2);
        }
        else if (argument.StartsWith("/") || argument.StartsWith("-"))
        {
            optionValuePair = argument.Substring(1);
        }
        else
        {
            hasURL = true;
            urls.Add (argument);
            return;
        }

        string option;
        string value;

        int indexOfEquals = optionValuePair.IndexOf(':');
        if (indexOfEquals > 0)
        {
            option = optionValuePair.Substring(0, indexOfEquals);
            value = optionValuePair.Substring(indexOfEquals + 1);
        }
        else
        {
            option = optionValuePair;
            value = null;
        }

        switch (option)
        {
        case "appsettingurlkey":
        case "urlkey":
            generator.AppSettingURLKey = value;
            break;

        case "appsettingbaseurl":
        case "baseurl":
            generator.AppSettingBaseURL = value;
            break;

        case "d":
        case "domain":
            domain = value;
            break;

        case "l":
        case "language":
            generator.Language = value;
            break;

        case "n":
        case "namespace":
            generator.Namespace = value;
            break;

        case "nologo":
            noLogo = true;
            break;

        case "o":
        case "out":
            generator.Filename = value;
            break;

        case "p":
        case "password":
            password = value;
            break;

        case "protocol":
            generator.Protocol = value;
            break;

        case "proxy":
            proxyAddress = value;
            break;

        case "proxydomain":
        case "pd":
            proxyDomain = value;
            break;

        case "proxypassword":
        case "pp":
            proxyPassword = value;
            break;

        case "proxyusername":
        case "pu":
            proxyUsername = value;
            break;

        case "server":
            generator.Server = true;
            break;

        case "u":
        case "username":
            username = value;
            break;

        case "sample":
            sampleSoap = value;
            break;

        case "type":
        case "t":
            className = value;
            break;

        case "?":
            help = true;
            break;

        default:
            if (argument.StartsWith ("/") && argument.IndexOfAny (Path.InvalidPathChars) == -1)
            {
                hasURL = true;
                urls.Add (argument);
                break;
            }
            else
                throw new Exception("Unknown option '" + option + "'");
        }
    }

    DiscoveryClientProtocol CreateClient ()
    {
        DiscoveryClientProtocol dcc = new DiscoveryClientProtocol ();

        if (username != null || password != null || domain != null)
        {
            NetworkCredential credentials = new NetworkCredential();

            if (username != null)
                credentials.UserName = username;

            if (password != null)
                credentials.Password = password;

            if (domain != null)
                credentials.Domain = domain;

            dcc.Credentials = credentials;
        }

        if (proxyAddress != null)
        {
            WebProxy proxy = new WebProxy (proxyAddress);
            if (proxyUsername != null || proxyPassword != null || proxyDomain != null)
            {
                NetworkCredential credentials = new NetworkCredential();

                if (proxyUsername != null)
                    credentials.UserName = proxyUsername;

                if (proxyPassword != null)
                    credentials.Password = proxyPassword;

                if (proxyDomain != null)
                    credentials.Domain = proxyDomain;

                proxy.Credentials = credentials;
            }
        }

        return dcc;
    }

    ///
    /// <summary>
    ///	Driver's main control flow:
    ///	 - parse arguments
    ///	 - report required messages
    ///	 - terminate if no input
    ///	 - report errors
    /// </summary>
    ///
    int Run(string[] args)
    {
        try
        {
            // parse command line arguments
            foreach (string argument in args)
            {
                ImportArgument(argument);
            }

            if (noLogo == false)
                Console.WriteLine(ProductId);

            if (help || (!hasURL && className == null))
            {
                Console.WriteLine(UsageMessage);
                return 0;
            }

            if (className == null)
            {
                DiscoveryClientProtocol dcc = CreateClient ();

                foreach (string urlEntry in urls)
                {
                    string url = urlEntry;
                    dcc.AllowAutoRedirect = true;
                    if (!url.StartsWith ("http://") && !url.StartsWith ("https://") && !url.StartsWith ("file://"))
                        url = new Uri (Path.GetFullPath (url)).ToString ();

                    dcc.DiscoverAny (url);
                    dcc.ResolveAll ();
                }

                foreach (object doc in dcc.Documents.Values)
                {
                    if (doc is ServiceDescription)
                        descriptions.Add ((ServiceDescription) doc);
                    else if (doc is XmlSchema)
                        schemas.Add ((XmlSchema) doc);
                }

                if (descriptions.Count == 0)
                {
                    Console.WriteLine ("Warning: no classes were generated.");
                    return 0;
                }
            }
            else
            {
                string[] names = className.Split (',');
                if (names.Length != 2) throw new Exception ("Invalid parameter value for 'type'");
                string cls = names[0].Trim ();
                string assembly = names[1].Trim ();

                Assembly asm = Assembly.LoadFrom (assembly);
                Type t = asm.GetType (cls);
                if (t == null) throw new Exception ("Type '" + cls + "' not found in assembly " + assembly);
                ServiceDescriptionReflector reflector = new ServiceDescriptionReflector ();
                foreach (string url in urls)
                    reflector.Reflect (t, url);
                foreach (XmlSchema s in reflector.Schemas)
                    schemas.Add (s);

                foreach (ServiceDescription sd in reflector.ServiceDescriptions)
                    descriptions.Add (sd);
            }

            if (sampleSoap != null)
            {
                ConsoleSampleGenerator.Generate (descriptions, schemas, sampleSoap, generator.Protocol);
                return 0;
            }

            // generate the code
            generator.GenerateCode (descriptions, schemas);
            return 0;
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine (e);
            return 2;
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine (e);
            return 2;
        }
        catch (Exception exception)
        {
            Console.WriteLine("Error: {0}", exception.Message);
            // FIXME: surpress this except for when debug is enabled
            //Console.WriteLine("Stack:\n {0}", exception.StackTrace);
            return 2;
        }
    }

    ///
    /// <summary>
    ///	Application entry point.
    /// </summary>
    ///
    public static int Main(string[] args)
    {
        Driver d = new Driver();
        return d.Run(args);
    }
}
}

#endif
