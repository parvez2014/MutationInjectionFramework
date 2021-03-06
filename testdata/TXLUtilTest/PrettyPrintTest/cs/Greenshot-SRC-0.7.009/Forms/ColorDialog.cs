using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Greenshot
{
/// <summary>
/// Description of ColorDialog.
/// </summary>
public partial class ColorDialog
{


    private ColorDialog()
    {

        this.SuspendLayout();
        InitializeComponent();
        lang = Language.GetInstance();
        updateUI();
        this.SuspendLayout();
        this.createColorPalette(5,5,15,15);
        this.createLastUsedColorButtonRow(5,190,15,15);
        this.ResumeLayout();
    }
    public static  ColorDialog GetInstance()
    {
        if(uniqueInstance == null)
        {
            uniqueInstance = new ColorDialog();
        }
        return uniqueInstance;
    }

    private Language lang;
    private static ColorDialog uniqueInstance;
    private List<Button> colorButtons = new List<Button>();
    private List<Button> recentColorButtons = new List<Button>();
    private List<Color> recentColors = new List<Color>();
    private ToolTip toolTip = new ToolTip();
    private bool updateInProgress = false;

    public Color[] RecentColors
    {
        get
        {
            return recentColors.ToArray();
        }
        set
        {
            for(int i=0; i<value.Length; i++)
            {
                recentColors.Add(value[i]);
            }
            updateRecentColorsButtonRow();
        }
    }

    public Color Color
    {
        get
        {
            return colorPanel.BackColor;
        }
        set
        {
            previewColor(value,this);
        }
    }

    private void updateUI()
    {
        this.Text = lang.GetString("colorpicker_title");
        this.btnApply.Text = lang.GetString("colorpicker_apply");
        this.btnTransparent.Text = lang.GetString("colorpicker_transparent");
        this.labelHtmlColor.Text = lang.GetString("colorpicker_htmlcolor");
        this.labelRed.Text = lang.GetString("colorpicker_red");
        this.labelGreen.Text = lang.GetString("colorpicker_green");
        this.labelBlue.Text = lang.GetString("colorpicker_blue");
        this.labelAlpha.Text = lang.GetString("colorpicker_alpha");
        this.labelRecentColors.Text = lang.GetString("colorpicker_recentcolors");
    }

    #region user interface generation
    private void createColorPalette(int x, int y, int w, int h)
    {
        this.createColorButtonColumn(255,0,0, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(255,255/2,0, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(255,255,0, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(255/2,255,0, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(0,255,0, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(0,255,255/2, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(0,255,255, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(0,255/2,255, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(0,0,255, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(255/2,0,255, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(255,0,255, x, y, w, h, 11);
        x += w;
        this.createColorButtonColumn(255,0,255/2, x, y, w, h, 11);
        x += w + 5;
        this.createColorButtonColumn(255/2,255/2,255/2, x, y, w, h, 11);

        this.Controls.AddRange(this.colorButtons.ToArray());
    }
    private void createColorButtonColumn(int red, int green, int blue, int x, int y, int w, int h, int shades)
    {
        int shadedColorsNum = (shades - 1) / 2;
        for(int i=0; i<=shadedColorsNum; i++)
        {
            colorButtons.Add(createColorButton(red * i / shadedColorsNum, green * i /shadedColorsNum, blue * i / shadedColorsNum, x, y + i * h, w, h));
            if(i>0) colorButtons.Add(createColorButton(red + (255 - red) * i / shadedColorsNum, green + (255 - green)* i /shadedColorsNum, blue+ (255 - blue) * i / shadedColorsNum, x, y + (i+shadedColorsNum) * h, w,h));
        }
    }
    private Button createColorButton(int red, int green, int blue, int x, int y, int w, int h)
    {
        return createColorButton(Color.FromArgb(255, red, green, blue), x, y, w, h);
    }
    private Button createColorButton(Color color,  int x, int y, int w, int h)
    {
        Button b = new Button();
        b.BackColor = color;
        b.FlatAppearance.BorderSize = 0;
        b.FlatStyle = FlatStyle.Flat;
        b.Location = new Point(x,y);
        b.Size = new Size(w,h);
        b.TabStop = false;
        b.Click += new System.EventHandler(colorButtonClick);
        toolTip.SetToolTip(b,ColorTranslator.ToHtml(color)+" | R:"+color.R +", G:"+color.G+", B:"+color.B);
        return b;
    }
    private void createLastUsedColorButtonRow(int x, int y, int w, int h)
    {
        for(int i=0; i<12; i++)
        {
            Button b = this.createColorButton(Color.Transparent, x, y, w, h);
            b.Enabled = false;
            recentColorButtons.Add(b);
            x += w;
        }
        this.Controls.AddRange(this.recentColorButtons.ToArray());
    }
    #endregion

    #region update user interface
    private void updateRecentColorsButtonRow()
    {
        for(int i=0; i<recentColors.Count && i<12; i++)
        {
            recentColorButtons[i].BackColor = recentColors[i];
            recentColorButtons[i].Enabled = true;
        }
    }
    private void previewColor(Color c, Control trigger)
    {
        updateInProgress = true;
        this.colorPanel.BackColor = c;
        if(trigger != this.textBoxHtmlColor)
        {
            this.textBoxHtmlColor.Text = System.Drawing.ColorTranslator.ToHtml(c);
        }
        else
        {
            if(!this.textBoxHtmlColor.Text.StartsWith("#"))
            {
                int selStart = this.textBoxHtmlColor.SelectionStart;
                int selLength = this.textBoxHtmlColor.SelectionLength;
                this.textBoxHtmlColor.Text = "#" +this.textBoxHtmlColor.Text;
                this.textBoxHtmlColor.Select(selStart+1, selLength+1);
            }
        }
        if(trigger != this.textBoxRed && trigger != this.textBoxGreen && trigger != this.textBoxBlue && trigger != this.textBoxAlpha)
        {
            this.textBoxRed.Text = c.R.ToString();
            this.textBoxGreen.Text = c.G.ToString();
            this.textBoxBlue.Text = c.B.ToString();
            this.textBoxAlpha.Text = c.A.ToString();
        }
        updateInProgress = false;
    }

    private void addToRecentColors(Color c)
    {
        recentColors.Remove(c);
        recentColors.Insert(0, c);
        if(recentColors.Count > 12) recentColors.RemoveRange(12,recentColors.Count-12);
        updateRecentColorsButtonRow();
    }
    #endregion

    #region textbox event handlers
    void TextBoxHexadecimalTextChanged(object sender, System.EventArgs e)
    {
        if(updateInProgress) return;
        TextBox tb = (TextBox) sender;
        string t = tb.Text.Replace("#","");
        int i = 0;
        Int32.TryParse(t, System.Globalization.NumberStyles.AllowHexSpecifier, Thread.CurrentThread.CurrentCulture, out i);
        Color c = Color.FromArgb(i);
        Color opaqueColor = Color.FromArgb(255, c.R, c.G, c.B);
        previewColor(opaqueColor, tb);
    }
    void TextBoxRGBTextChanged(object sender, System.EventArgs e)
    {
        if(updateInProgress) return;
        TextBox tb = (TextBox) sender;
        previewColor(Color.FromArgb(getColorPartIntFromString(textBoxAlpha.Text),getColorPartIntFromString(textBoxRed.Text),getColorPartIntFromString(textBoxGreen.Text),getColorPartIntFromString(textBoxBlue.Text)), tb);
    }
    void TextBoxGotFocus(object sender, System.EventArgs e)
    {
        this.textBoxHtmlColor.SelectAll();
    }
    void TextBoxKeyDown(object sender, KeyEventArgs e)
    {
        if(e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
        {
            addToRecentColors(colorPanel.BackColor);
        }
    }
    #endregion

    #region button event handlers
    void colorButtonClick(object sender, System.EventArgs e)
    {
        Button b = (Button) sender;
        previewColor(b.BackColor, b);
    }

    void btnTransparentClick(object sender, System.EventArgs e)
    {
        colorButtonClick(sender, e);
    }
    void BtnApplyClick(object sender, System.EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Hide();
        addToRecentColors(colorPanel.BackColor);
    }
    #endregion

    #region helper functions
    private int getColorPartIntFromString(string s)
    {
        int ret = 0;
        Int32.TryParse(s,out ret);
        if(ret < 0) ret = 0;
        else if(ret > 255) ret = 255;
        return ret;
    }

    #endregion
}
}
