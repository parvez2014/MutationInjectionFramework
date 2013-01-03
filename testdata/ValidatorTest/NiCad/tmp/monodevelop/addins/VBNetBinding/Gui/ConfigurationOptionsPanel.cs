/*
 * ConfigurationOptionsPanel.cs.
 *
 * Author:
 *   Rolf Bjarne Kvinge <RKvinge@novell.com>
 *
 * Copyright 2008 Novell, Inc. (http://www.novell.com)
 *
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;

using MonoDevelop.Projects;
using MonoDevelop.Ide.Gui.Dialogs;

namespace MonoDevelop.VBNetBinding
{
public class ConfigurationOptionsPanel : MultiConfigItemOptionsPanel
{
    ConfigurationOptionsPanelWidget widget;

    public ConfigurationOptionsPanel()
    {
    }

    public override Gtk.Widget CreatePanelWidget ()
    {
        Console.WriteLine ("ConfigurationOptionsPanel.CreatePanelWidget");
        return (widget = new ConfigurationOptionsPanelWidget (ConfiguredProject));
    }

    public override void LoadConfigData ()
    {
        Console.WriteLine ("ConfigurationOptionsPanel.LoadConfigData");
        widget.Load ((DotNetProjectConfiguration) CurrentConfiguration);
    }

    public override void ApplyChanges ()
    {
        Console.WriteLine ("ConfigurationOptionsPanel.ApplyChanges");
        widget.StorePanelContents ();
    }
}
}