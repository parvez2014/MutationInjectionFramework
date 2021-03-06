
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.CSharp.Project
{
internal partial class CodeGenerationPanelWidget
{
    private global::Gtk.VBox vbox62;
    private global::Gtk.Label label82;
    private global::Gtk.HBox hbox56;
    private global::Gtk.Label label81;
    private global::Gtk.VBox vbox65;
    private global::Gtk.CheckButton generateOverflowChecksCheckButton;
    private global::Gtk.CheckButton enableOptimizationCheckButton;
    private global::Gtk.CheckButton generateDebugInformationCheckButton;
    private global::Gtk.CheckButton generateXmlOutputCheckButton;
    private global::Gtk.HBox hbox4;
    private global::Gtk.Table table1;
    private global::Gtk.HBox hbox1;
    private global::Gtk.ComboBox comboPlatforms;
    private global::Gtk.Label label1;
    private global::Gtk.Label label87;
    private global::Gtk.Entry symbolsEntry;
    private global::Gtk.Label label93;
    private global::Gtk.HBox hbox48;
    private global::Gtk.Label label73;
    private global::Gtk.VBox vbox67;
    private global::Gtk.HBox hbox60;
    private global::Gtk.Label label85;
    private global::Gtk.SpinButton warningLevelSpinButton;
    private global::Gtk.HBox hbox3;
    private global::Gtk.Label label86;
    private global::Gtk.Entry ignoreWarningsEntry;
    private global::Gtk.CheckButton warningsAsErrorsCheckButton;
    private global::Gtk.Label label94;
    private global::Gtk.HBox hbox5;
    private global::Gtk.Label label74;
    private global::Gtk.HBox hbox6;
    private global::Gtk.Label label88;
    private global::Gtk.Entry additionalArgsEntry;

    protected virtual void Build ()
    {
        global::Stetic.Gui.Initialize (this);
        // Widget MonoDevelop.CSharp.Project.CodeGenerationPanelWidget
        global::Stetic.BinContainer.Attach (this);
        this.Name = "MonoDevelop.CSharp.Project.CodeGenerationPanelWidget";
        // Container child MonoDevelop.CSharp.Project.CodeGenerationPanelWidget.Gtk.Container+ContainerChild
        this.vbox62 = new global::Gtk.VBox ();
        this.vbox62.Name = "vbox62";
        this.vbox62.Spacing = 12;
        this.vbox62.BorderWidth = ((uint)(6));
        // Container child vbox62.Gtk.Box+BoxChild
        this.label82 = new global::Gtk.Label ();
        this.label82.Name = "label82";
        this.label82.Xalign = 0F;
        this.label82.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>General Options</b>");
        this.label82.UseMarkup = true;
        this.vbox62.Add (this.label82);
        global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.label82]));
        w1.Position = 0;
        w1.Expand = false;
        w1.Fill = false;
        // Container child vbox62.Gtk.Box+BoxChild
        this.hbox56 = new global::Gtk.HBox ();
        this.hbox56.Name = "hbox56";
        // Container child hbox56.Gtk.Box+BoxChild
        this.label81 = new global::Gtk.Label ();
        this.label81.WidthRequest = 18;
        this.label81.Name = "label81";
        this.hbox56.Add (this.label81);
        global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox56 [this.label81]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child hbox56.Gtk.Box+BoxChild
        this.vbox65 = new global::Gtk.VBox ();
        this.vbox65.Name = "vbox65";
        this.vbox65.Spacing = 6;
        // Container child vbox65.Gtk.Box+BoxChild
        this.generateOverflowChecksCheckButton = new global::Gtk.CheckButton ();
        this.generateOverflowChecksCheckButton.CanFocus = true;
        this.generateOverflowChecksCheckButton.Name = "generateOverflowChecksCheckButton";
        this.generateOverflowChecksCheckButton.Label = global::Mono.Unix.Catalog.GetString ("_Generate overflow checks");
        this.generateOverflowChecksCheckButton.DrawIndicator = true;
        this.generateOverflowChecksCheckButton.UseUnderline = true;
        this.vbox65.Add (this.generateOverflowChecksCheckButton);
        global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox65 [this.generateOverflowChecksCheckButton]));
        w3.Position = 0;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox65.Gtk.Box+BoxChild
        this.enableOptimizationCheckButton = new global::Gtk.CheckButton ();
        this.enableOptimizationCheckButton.CanFocus = true;
        this.enableOptimizationCheckButton.Name = "enableOptimizationCheckButton";
        this.enableOptimizationCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Enable _optimizations");
        this.enableOptimizationCheckButton.DrawIndicator = true;
        this.enableOptimizationCheckButton.UseUnderline = true;
        this.vbox65.Add (this.enableOptimizationCheckButton);
        global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox65 [this.enableOptimizationCheckButton]));
        w4.Position = 1;
        w4.Expand = false;
        w4.Fill = false;
        // Container child vbox65.Gtk.Box+BoxChild
        this.generateDebugInformationCheckButton = new global::Gtk.CheckButton ();
        this.generateDebugInformationCheckButton.CanFocus = true;
        this.generateDebugInformationCheckButton.Name = "generateDebugInformationCheckButton";
        this.generateDebugInformationCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Emit _debugging information");
        this.generateDebugInformationCheckButton.DrawIndicator = true;
        this.generateDebugInformationCheckButton.UseUnderline = true;
        this.vbox65.Add (this.generateDebugInformationCheckButton);
        global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox65 [this.generateDebugInformationCheckButton]));
        w5.Position = 2;
        w5.Expand = false;
        w5.Fill = false;
        // Container child vbox65.Gtk.Box+BoxChild
        this.generateXmlOutputCheckButton = new global::Gtk.CheckButton ();
        this.generateXmlOutputCheckButton.CanFocus = true;
        this.generateXmlOutputCheckButton.Name = "generateXmlOutputCheckButton";
        this.generateXmlOutputCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Generate _xml documentation");
        this.generateXmlOutputCheckButton.Active = true;
        this.generateXmlOutputCheckButton.DrawIndicator = true;
        this.generateXmlOutputCheckButton.UseUnderline = true;
        this.vbox65.Add (this.generateXmlOutputCheckButton);
        global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox65 [this.generateXmlOutputCheckButton]));
        w6.Position = 3;
        w6.Expand = false;
        w6.Fill = false;
        // Container child vbox65.Gtk.Box+BoxChild
        this.hbox4 = new global::Gtk.HBox ();
        this.hbox4.Name = "hbox4";
        this.hbox4.Spacing = 6;
        this.vbox65.Add (this.hbox4);
        global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox65 [this.hbox4]));
        w7.Position = 4;
        // Container child vbox65.Gtk.Box+BoxChild
        this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
        this.table1.Name = "table1";
        this.table1.RowSpacing = ((uint)(6));
        this.table1.ColumnSpacing = ((uint)(6));
        // Container child table1.Gtk.Table+TableChild
        this.hbox1 = new global::Gtk.HBox ();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.comboPlatforms = global::Gtk.ComboBox.NewText ();
        this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("Any CPU"));
        this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("x86"));
        this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("x64"));
        this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("Itanium"));
        this.comboPlatforms.Name = "comboPlatforms";
        this.comboPlatforms.Active = 0;
        this.hbox1.Add (this.comboPlatforms);
        global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboPlatforms]));
        w8.Position = 0;
        w8.Expand = false;
        w8.Fill = false;
        this.table1.Add (this.hbox1);
        global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
        w9.TopAttach = ((uint)(1));
        w9.BottomAttach = ((uint)(2));
        w9.LeftAttach = ((uint)(1));
        w9.RightAttach = ((uint)(2));
        w9.YOptions = ((global::Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.label1 = new global::Gtk.Label ();
        this.label1.Name = "label1";
        this.label1.Xalign = 0F;
        this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Platform target:");
        this.table1.Add (this.label1);
        global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
        w10.TopAttach = ((uint)(1));
        w10.BottomAttach = ((uint)(2));
        w10.XOptions = ((global::Gtk.AttachOptions)(4));
        w10.YOptions = ((global::Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.label87 = new global::Gtk.Label ();
        this.label87.Name = "label87";
        this.label87.Xalign = 0F;
        this.label87.LabelProp = global::Mono.Unix.Catalog.GetString ("Define S_ymbols:");
        this.label87.UseUnderline = true;
        this.table1.Add (this.label87);
        global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label87]));
        w11.XOptions = ((global::Gtk.AttachOptions)(4));
        w11.YOptions = ((global::Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.symbolsEntry = new global::Gtk.Entry ();
        this.symbolsEntry.CanFocus = true;
        this.symbolsEntry.Name = "symbolsEntry";
        this.symbolsEntry.IsEditable = true;
        this.symbolsEntry.InvisibleChar = '●';
        this.table1.Add (this.symbolsEntry);
        global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.symbolsEntry]));
        w12.LeftAttach = ((uint)(1));
        w12.RightAttach = ((uint)(2));
        w12.YOptions = ((global::Gtk.AttachOptions)(4));
        this.vbox65.Add (this.table1);
        global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox65 [this.table1]));
        w13.Position = 5;
        this.hbox56.Add (this.vbox65);
        global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox56 [this.vbox65]));
        w14.Position = 1;
        this.vbox62.Add (this.hbox56);
        global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.hbox56]));
        w15.Position = 1;
        w15.Expand = false;
        w15.Fill = false;
        // Container child vbox62.Gtk.Box+BoxChild
        this.label93 = new global::Gtk.Label ();
        this.label93.Name = "label93";
        this.label93.Xalign = 0F;
        this.label93.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Warnings</b>");
        this.label93.UseMarkup = true;
        this.label93.UseUnderline = true;
        this.vbox62.Add (this.label93);
        global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.label93]));
        w16.Position = 2;
        w16.Expand = false;
        w16.Fill = false;
        // Container child vbox62.Gtk.Box+BoxChild
        this.hbox48 = new global::Gtk.HBox ();
        this.hbox48.Name = "hbox48";
        // Container child hbox48.Gtk.Box+BoxChild
        this.label73 = new global::Gtk.Label ();
        this.label73.WidthRequest = 18;
        this.label73.Name = "label73";
        this.hbox48.Add (this.label73);
        global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox48 [this.label73]));
        w17.Position = 0;
        w17.Expand = false;
        w17.Fill = false;
        // Container child hbox48.Gtk.Box+BoxChild
        this.vbox67 = new global::Gtk.VBox ();
        this.vbox67.Name = "vbox67";
        this.vbox67.Spacing = 6;
        // Container child vbox67.Gtk.Box+BoxChild
        this.hbox60 = new global::Gtk.HBox ();
        this.hbox60.Name = "hbox60";
        this.hbox60.Spacing = 6;
        // Container child hbox60.Gtk.Box+BoxChild
        this.label85 = new global::Gtk.Label ();
        this.label85.Name = "label85";
        this.label85.LabelProp = global::Mono.Unix.Catalog.GetString ("_Warning Level:");
        this.label85.UseUnderline = true;
        this.hbox60.Add (this.label85);
        global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox60 [this.label85]));
        w18.Position = 0;
        w18.Expand = false;
        w18.Fill = false;
        // Container child hbox60.Gtk.Box+BoxChild
        this.warningLevelSpinButton = new global::Gtk.SpinButton (0, 4, 1);
        this.warningLevelSpinButton.CanFocus = true;
        this.warningLevelSpinButton.Name = "warningLevelSpinButton";
        this.warningLevelSpinButton.Adjustment.PageIncrement = 1;
        this.warningLevelSpinButton.ClimbRate = 1;
        this.warningLevelSpinButton.Numeric = true;
        this.warningLevelSpinButton.Value = 2;
        this.hbox60.Add (this.warningLevelSpinButton);
        global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox60 [this.warningLevelSpinButton]));
        w19.Position = 1;
        w19.Expand = false;
        w19.Fill = false;
        this.vbox67.Add (this.hbox60);
        global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox67 [this.hbox60]));
        w20.Position = 0;
        w20.Expand = false;
        w20.Fill = false;
        // Container child vbox67.Gtk.Box+BoxChild
        this.hbox3 = new global::Gtk.HBox ();
        this.hbox3.Name = "hbox3";
        this.hbox3.Spacing = 6;
        // Container child hbox3.Gtk.Box+BoxChild
        this.label86 = new global::Gtk.Label ();
        this.label86.Name = "label86";
        this.label86.LabelProp = global::Mono.Unix.Catalog.GetString ("_Ignore warnings:");
        this.label86.UseUnderline = true;
        this.hbox3.Add (this.label86);
        global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label86]));
        w21.Position = 0;
        w21.Expand = false;
        w21.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.ignoreWarningsEntry = new global::Gtk.Entry ();
        this.ignoreWarningsEntry.CanFocus = true;
        this.ignoreWarningsEntry.Name = "ignoreWarningsEntry";
        this.ignoreWarningsEntry.IsEditable = true;
        this.ignoreWarningsEntry.InvisibleChar = '●';
        this.hbox3.Add (this.ignoreWarningsEntry);
        global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.ignoreWarningsEntry]));
        w22.Position = 1;
        this.vbox67.Add (this.hbox3);
        global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox67 [this.hbox3]));
        w23.Position = 1;
        w23.Expand = false;
        w23.Fill = false;
        // Container child vbox67.Gtk.Box+BoxChild
        this.warningsAsErrorsCheckButton = new global::Gtk.CheckButton ();
        this.warningsAsErrorsCheckButton.CanFocus = true;
        this.warningsAsErrorsCheckButton.Name = "warningsAsErrorsCheckButton";
        this.warningsAsErrorsCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Treat warnings as _errors");
        this.warningsAsErrorsCheckButton.DrawIndicator = true;
        this.warningsAsErrorsCheckButton.UseUnderline = true;
        this.vbox67.Add (this.warningsAsErrorsCheckButton);
        global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox67 [this.warningsAsErrorsCheckButton]));
        w24.Position = 2;
        w24.Expand = false;
        w24.Fill = false;
        this.hbox48.Add (this.vbox67);
        global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox48 [this.vbox67]));
        w25.Position = 1;
        this.vbox62.Add (this.hbox48);
        global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.hbox48]));
        w26.Position = 3;
        w26.Expand = false;
        w26.Fill = false;
        // Container child vbox62.Gtk.Box+BoxChild
        this.label94 = new global::Gtk.Label ();
        this.label94.Name = "label94";
        this.label94.Xalign = 0F;
        this.label94.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Additional Options</b>");
        this.label94.UseMarkup = true;
        this.label94.UseUnderline = true;
        this.vbox62.Add (this.label94);
        global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.label94]));
        w27.Position = 4;
        w27.Expand = false;
        w27.Fill = false;
        // Container child vbox62.Gtk.Box+BoxChild
        this.hbox5 = new global::Gtk.HBox ();
        this.hbox5.Name = "hbox5";
        this.hbox5.Spacing = 6;
        // Container child hbox5.Gtk.Box+BoxChild
        this.label74 = new global::Gtk.Label ();
        this.label74.WidthRequest = 18;
        this.label74.Name = "label74";
        this.hbox5.Add (this.label74);
        global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label74]));
        w28.Position = 0;
        w28.Expand = false;
        w28.Fill = false;
        // Container child hbox5.Gtk.Box+BoxChild
        this.hbox6 = new global::Gtk.HBox ();
        this.hbox6.Name = "hbox6";
        this.hbox6.Spacing = 6;
        // Container child hbox6.Gtk.Box+BoxChild
        this.label88 = new global::Gtk.Label ();
        this.label88.Name = "label88";
        this.label88.LabelProp = global::Mono.Unix.Catalog.GetString ("_Additional arguments:");
        this.label88.UseUnderline = true;
        this.hbox6.Add (this.label88);
        global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label88]));
        w29.Position = 0;
        w29.Expand = false;
        w29.Fill = false;
        // Container child hbox6.Gtk.Box+BoxChild
        this.additionalArgsEntry = new global::Gtk.Entry ();
        this.additionalArgsEntry.CanFocus = true;
        this.additionalArgsEntry.Name = "additionalArgsEntry";
        this.additionalArgsEntry.IsEditable = true;
        this.additionalArgsEntry.InvisibleChar = '●';
        this.hbox6.Add (this.additionalArgsEntry);
        global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.additionalArgsEntry]));
        w30.Position = 1;
        this.hbox5.Add (this.hbox6);
        global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.hbox6]));
        w31.Position = 1;
        this.vbox62.Add (this.hbox5);
        global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.hbox5]));
        w32.Position = 5;
        w32.Expand = false;
        w32.Fill = false;
        this.Add (this.vbox62);
        if ((this.Child != null))
        {
            this.Child.ShowAll ();
        }
        this.label87.MnemonicWidget = this.symbolsEntry;
        this.label85.MnemonicWidget = this.warningLevelSpinButton;
        this.label86.MnemonicWidget = this.warningLevelSpinButton;
        this.label88.MnemonicWidget = this.warningLevelSpinButton;
        this.Show ();
    }
}
}
