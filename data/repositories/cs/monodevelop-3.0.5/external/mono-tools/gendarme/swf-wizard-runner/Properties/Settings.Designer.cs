//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gendarme.Properties
{


[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
{

    private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

    public static Settings Default
    {
        get
        {
            return defaultInstance;
        }
    }

    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("1000")]
    public int DefectsLimit
    {
        get
        {
            return ((int)(this["DefectsLimit"]));
        }
        set
        {
            this["DefectsLimit"] = value;
        }
    }

    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("2")]
    public int Severity
    {
        get
        {
            return ((int)(this["Severity"]));
        }
        set
        {
            this["Severity"] = value;
        }
    }

    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("2")]
    public int Confidence
    {
        get
        {
            return ((int)(this["Confidence"]));
        }
        set
        {
            this["Confidence"] = value;
        }
    }

    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("0")]
    public int Scope
    {
        get
        {
            return ((int)(this["Scope"]));
        }
        set
        {
            this["Scope"] = value;
        }
    }

    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public global::System.Collections.Specialized.StringCollection Rules
    {
        get
        {
            return ((global::System.Collections.Specialized.StringCollection)(this["Rules"]));
        }
        set
        {
            this["Rules"] = value;
        }
    }
}
}
