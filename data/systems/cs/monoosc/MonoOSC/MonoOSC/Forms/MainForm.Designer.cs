// MainForm.Designer.cs created with MonoDevelop
//
//User: eric at 00:01 09/08/2008
//
// Copyright (C) 2008 [Petit Eric, surfzoid@gmail.com]
//
//Permission is hereby granted, free of charge, to any person
//obtaining a copy of this software and associated documentation
//files (the "Software"), to deal in the Software without
//restriction, including without limitation the rights to use,
//copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the
//Software is furnished to do so, subject to the following
//conditions:
//
//The above copyright notice and this permission notice shall be
//included in all copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//OTHER DEALINGS IN THE SOFTWARE.
//

namespace MonoOSC.Forms
{
partial class MainForm
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
        this.tabControl1 = new MonoOSC.TabControlEx();
        this.TabPgMain = new System.Windows.Forms.TabPage();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.splitContainer2 = new System.Windows.Forms.SplitContainer();
        this.GrpBxPrjInf = new System.Windows.Forms.GroupBox();
        this.listViewPrjInf = new System.Windows.Forms.ListView();
        this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.listViewPckg = new System.Windows.Forms.ListView();
        this.ClmPkgName = new System.Windows.Forms.ColumnHeader();
        this.contextMenuStripPkgList = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.toolStripMenuItemDelPkg = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripMenuItemEditMeta = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripContainerProjects = new System.Windows.Forms.ToolStripContainer();
        this.panelProjects = new System.Windows.Forms.Panel();
        this.toolStrip2 = new System.Windows.Forms.ToolStrip();
        this.BtnAddRepo = new System.Windows.Forms.ToolStripButton();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.BtnConnect = new System.Windows.Forms.ToolStripButton();
        this.BtnDisConnect = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        this.nouveauToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
        this.BtnWritePrjMeta = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        this.ouvrirToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.imprimerToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        this.couperToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.copierToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.collerToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.BtnCloseTab = new System.Windows.Forms.ToolStripButton();
        this.BtnDelPkg = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        this.LblProjectName = new System.Windows.Forms.ToolStripLabel();
        this.CmBxPrjName = new System.Windows.Forms.ToolStripComboBox();
        this.BtnDelPrjSubPrj = new System.Windows.Forms.ToolStripButton();
        this.BtnAddPrjSubPrj = new System.Windows.Forms.ToolStripButton();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.LblNetLed = new System.Windows.Forms.ToolStripStatusLabel();
        this.LblSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
        this.LblNetStatus = new System.Windows.Forms.ToolStripStatusLabel();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
        this.deleteThisProjectsubrojectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.addAProjectsubrojectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
        this.CloseTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
        this.createANewPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newPackageUsingSpecFileWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.deleteThisPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editPrjMetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.repositoriesManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.deleteWipeAllBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.collaborationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.requestsToSubmitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.branchAPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
        this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.infosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.autoHideListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.serverStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
        this.iRCChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.officialPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.bugRepportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.featureRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
        this.showGlobalLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.chmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.BckGrdWorkerDll = new System.ComponentModel.BackgroundWorker();
        this.TimerNetAnim = new System.Windows.Forms.Timer(this.components);
        this.CtxMenuCloseTab = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.closeTabToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.deletePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.helpProvider1 = new System.Windows.Forms.HelpProvider();
        this.ContexMenuBookMarks = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.BookMarksAdd = new System.Windows.Forms.ToolStripMenuItem();
        this.BookMarksDel = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripContainer1.ContentPanel.SuspendLayout();
        this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
        this.toolStripContainer1.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.TabPgMain.SuspendLayout();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.splitContainer2.Panel1.SuspendLayout();
        this.splitContainer2.Panel2.SuspendLayout();
        this.splitContainer2.SuspendLayout();
        this.GrpBxPrjInf.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.contextMenuStripPkgList.SuspendLayout();
        this.toolStripContainerProjects.ContentPanel.SuspendLayout();
        this.toolStripContainerProjects.LeftToolStripPanel.SuspendLayout();
        this.toolStripContainerProjects.SuspendLayout();
        this.toolStrip2.SuspendLayout();
        this.toolStrip1.SuspendLayout();
        this.statusStrip1.SuspendLayout();
        this.menuStrip1.SuspendLayout();
        this.CtxMenuCloseTab.SuspendLayout();
        this.ContexMenuBookMarks.SuspendLayout();
        this.SuspendLayout();
        //
        // toolStripContainer1
        //
        //
        // toolStripContainer1.ContentPanel
        //
        this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
        this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(863, 393);
        this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.toolStripContainer1.Location = new System.Drawing.Point(0, 32);
        this.toolStripContainer1.Name = "toolStripContainer1";
        this.toolStripContainer1.Size = new System.Drawing.Size(863, 424);
        this.toolStripContainer1.TabIndex = 3;
        this.toolStripContainer1.Text = "toolStripContainer1";
        //
        // toolStripContainer1.TopToolStripPanel
        //
        this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
        //
        // tabControl1
        //
        this.tabControl1.Controls.Add(this.TabPgMain);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
        this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tabControl1.Location = new System.Drawing.Point(0, 0);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(863, 393);
        this.tabControl1.TabIndex = 0;
        this.tabControl1.TabPageClosing += new MonoOSC.PreRemoveTab(this.tabControl1_TabPageClosing);
        this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
        this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
        this.tabControl1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ControlRemoved);
        //
        // TabPgMain
        //
        this.TabPgMain.Controls.Add(this.splitContainer1);
        this.TabPgMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
        this.TabPgMain.Location = new System.Drawing.Point(4, 38);
        this.TabPgMain.Name = "TabPgMain";
        this.TabPgMain.Padding = new System.Windows.Forms.Padding(3);
        this.TabPgMain.Size = new System.Drawing.Size(855, 351);
        this.TabPgMain.TabIndex = 0;
        this.TabPgMain.Text = "Project";
        this.TabPgMain.UseVisualStyleBackColor = true;
        //
        // splitContainer1
        //
        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer1.Location = new System.Drawing.Point(3, 3);
        this.splitContainer1.Name = "splitContainer1";
        //
        // splitContainer1.Panel1
        //
        this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
        //
        // splitContainer1.Panel2
        //
        this.splitContainer1.Panel2.AutoScroll = true;
        this.splitContainer1.Panel2.Controls.Add(this.toolStripContainerProjects);
        this.splitContainer1.Size = new System.Drawing.Size(849, 345);
        this.splitContainer1.SplitterDistance = 281;
        this.splitContainer1.TabIndex = 1;
        this.splitContainer1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDoubleClick);
        //
        // splitContainer2
        //
        this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer2.Location = new System.Drawing.Point(0, 0);
        this.splitContainer2.Name = "splitContainer2";
        this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
        //
        // splitContainer2.Panel1
        //
        this.splitContainer2.Panel1.Controls.Add(this.GrpBxPrjInf);
        //
        // splitContainer2.Panel2
        //
        this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
        this.splitContainer2.Size = new System.Drawing.Size(281, 345);
        this.splitContainer2.SplitterDistance = 142;
        this.splitContainer2.TabIndex = 1;
        this.splitContainer2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDoubleClick);
        //
        // GrpBxPrjInf
        //
        this.GrpBxPrjInf.Controls.Add(this.listViewPrjInf);
        this.GrpBxPrjInf.Dock = System.Windows.Forms.DockStyle.Fill;
        this.GrpBxPrjInf.Location = new System.Drawing.Point(0, 0);
        this.GrpBxPrjInf.Name = "GrpBxPrjInf";
        this.GrpBxPrjInf.Size = new System.Drawing.Size(281, 142);
        this.GrpBxPrjInf.TabIndex = 0;
        this.GrpBxPrjInf.TabStop = false;
        this.GrpBxPrjInf.Text = "Project infos";
        this.GrpBxPrjInf.MouseHover += new System.EventHandler(this.GrpBxPrjInf_MouseHover);
        //
        // listViewPrjInf
        //
        this.listViewPrjInf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
        {
            this.columnHeader1,
            this.columnHeader2
        });
        this.listViewPrjInf.Dock = System.Windows.Forms.DockStyle.Fill;
        this.listViewPrjInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
        this.listViewPrjInf.GridLines = true;
        this.listViewPrjInf.Location = new System.Drawing.Point(3, 17);
        this.listViewPrjInf.Name = "listViewPrjInf";
        this.listViewPrjInf.Size = new System.Drawing.Size(275, 122);
        this.listViewPrjInf.TabIndex = 1;
        this.listViewPrjInf.UseCompatibleStateImageBehavior = false;
        this.listViewPrjInf.View = System.Windows.Forms.View.Details;
        this.listViewPrjInf.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewPrjInf_ColumnClick);
        //
        // columnHeader1
        //
        this.columnHeader1.Text = "";
        //
        // columnHeader2
        //
        this.columnHeader2.Text = "";
        //
        // groupBox1
        //
        this.groupBox1.Controls.Add(this.listViewPckg);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(281, 199);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "List of packages";
        this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
        //
        // listViewPckg
        //
        this.listViewPckg.Activation = System.Windows.Forms.ItemActivation.OneClick;
        this.listViewPckg.AllowDrop = true;
        this.listViewPckg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
        {
            this.ClmPkgName
        });
        this.listViewPckg.ContextMenuStrip = this.contextMenuStripPkgList;
        this.listViewPckg.Dock = System.Windows.Forms.DockStyle.Fill;
        this.listViewPckg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
        this.listViewPckg.ForeColor = System.Drawing.Color.Blue;
        this.listViewPckg.FullRowSelect = true;
        this.listViewPckg.GridLines = true;
        this.listViewPckg.HideSelection = false;
        this.listViewPckg.HotTracking = true;
        this.listViewPckg.HoverSelection = true;
        this.listViewPckg.Location = new System.Drawing.Point(3, 17);
        this.listViewPckg.Name = "listViewPckg";
        this.listViewPckg.Size = new System.Drawing.Size(275, 179);
        this.listViewPckg.TabIndex = 0;
        this.listViewPckg.UseCompatibleStateImageBehavior = false;
        this.listViewPckg.View = System.Windows.Forms.View.Details;
        this.listViewPckg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPckg_MouseClick);
        this.listViewPckg.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewPrjInf_ColumnClick);
        //
        // ClmPkgName
        //
        this.ClmPkgName.Text = "Name";
        this.ClmPkgName.Width = 277;
        //
        // contextMenuStripPkgList
        //
        this.contextMenuStripPkgList.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.toolStripMenuItemDelPkg,
            this.toolStripMenuItemEditMeta
        });
        this.contextMenuStripPkgList.Name = "contextMenuStripPkgList";
        this.contextMenuStripPkgList.Size = new System.Drawing.Size(174, 48);
        //
        // toolStripMenuItemDelPkg
        //
        this.toolStripMenuItemDelPkg.Name = "toolStripMenuItemDelPkg";
        this.toolStripMenuItemDelPkg.Size = new System.Drawing.Size(173, 22);
        this.toolStripMenuItemDelPkg.Text = "Delete";
        this.toolStripMenuItemDelPkg.Click += new System.EventHandler(this.toolStripMenuItemDelPkg_Click);
        //
        // toolStripMenuItemEditMeta
        //
        this.toolStripMenuItemEditMeta.Name = "toolStripMenuItemEditMeta";
        this.toolStripMenuItemEditMeta.Size = new System.Drawing.Size(173, 22);
        this.toolStripMenuItemEditMeta.Text = "Edit meta manualy";
        this.toolStripMenuItemEditMeta.Click += new System.EventHandler(this.toolStripMenuItemEditMeta_Click);
        //
        // toolStripContainerProjects
        //
        //
        // toolStripContainerProjects.ContentPanel
        //
        this.toolStripContainerProjects.ContentPanel.Controls.Add(this.panelProjects);
        this.toolStripContainerProjects.ContentPanel.Size = new System.Drawing.Size(537, 320);
        this.toolStripContainerProjects.Dock = System.Windows.Forms.DockStyle.Fill;
        //
        // toolStripContainerProjects.LeftToolStripPanel
        //
        this.toolStripContainerProjects.LeftToolStripPanel.Controls.Add(this.toolStrip2);
        this.toolStripContainerProjects.Location = new System.Drawing.Point(0, 0);
        this.toolStripContainerProjects.Name = "toolStripContainerProjects";
        this.toolStripContainerProjects.Size = new System.Drawing.Size(564, 345);
        this.toolStripContainerProjects.TabIndex = 4;
        this.toolStripContainerProjects.Text = "toolStripContainer2";
        //
        // panelProjects
        //
        this.panelProjects.AutoScroll = true;
        this.panelProjects.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelProjects.Location = new System.Drawing.Point(0, 0);
        this.panelProjects.Name = "panelProjects";
        this.panelProjects.Size = new System.Drawing.Size(537, 320);
        this.panelProjects.TabIndex = 0;
        //
        // toolStrip2
        //
        this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
        this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.BtnAddRepo
        });
        this.toolStrip2.Location = new System.Drawing.Point(0, 7);
        this.toolStrip2.Name = "toolStrip2";
        this.toolStrip2.Size = new System.Drawing.Size(27, 38);
        this.toolStrip2.TabIndex = 1;
        this.toolStrip2.Text = "toolStrip2";
        //
        // BtnAddRepo
        //
        this.BtnAddRepo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnAddRepo.Image = global::MonoOSC.Properties.Resources.Add;
        this.BtnAddRepo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnAddRepo.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnAddRepo.Name = "BtnAddRepo";
        this.BtnAddRepo.Size = new System.Drawing.Size(25, 26);
        this.BtnAddRepo.ToolTipText = "Add a new repository";
        this.BtnAddRepo.Click += new System.EventHandler(this.repositoriesManagerToolStripMenuItem_Click);
        //
        // toolStrip1
        //
        this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.BtnConnect,
            this.BtnDisConnect,
            this.toolStripSeparator5,
            this.nouveauToolStripButton,
            this.toolStripButton1,
            this.BtnWritePrjMeta,
            this.toolStripSeparator3,
            this.ouvrirToolStripButton,
            this.imprimerToolStripButton,
            this.toolStripSeparator,
            this.couperToolStripButton,
            this.copierToolStripButton,
            this.collerToolStripButton,
            this.toolStripSeparator1,
            this.BtnCloseTab,
            this.BtnDelPkg,
            this.toolStripSeparator2,
            this.ToolStripButton,
            this.toolStripSeparator4,
            this.LblProjectName,
            this.CmBxPrjName,
            this.BtnDelPrjSubPrj,
            this.BtnAddPrjSubPrj
        });
        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(863, 31);
        this.toolStrip1.Stretch = true;
        this.toolStrip1.TabIndex = 2;
        this.toolStrip1.Text = "toolStrip1";
        //
        // BtnConnect
        //
        this.BtnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnConnect.Image = global::MonoOSC.Properties.Resources.stock_connecttourl;
        this.BtnConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnConnect.Name = "BtnConnect";
        this.BtnConnect.Size = new System.Drawing.Size(28, 28);
        this.BtnConnect.Text = "Connect";
        this.BtnConnect.ToolTipText = "Connect";
        this.BtnConnect.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
        //
        // BtnDisConnect
        //
        this.BtnDisConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnDisConnect.Enabled = false;
        this.BtnDisConnect.Image = global::MonoOSC.Properties.Resources.stock_disconnect;
        this.BtnDisConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnDisConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnDisConnect.Name = "BtnDisConnect";
        this.BtnDisConnect.Size = new System.Drawing.Size(28, 28);
        this.BtnDisConnect.Text = "Disconnect";
        this.BtnDisConnect.Click += new System.EventHandler(this.BtnDisConnect_Click);
        //
        // toolStripSeparator5
        //
        this.toolStripSeparator5.Name = "toolStripSeparator5";
        this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
        //
        // nouveauToolStripButton
        //
        this.nouveauToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.nouveauToolStripButton.Enabled = false;
        this.nouveauToolStripButton.Image = global::MonoOSC.Properties.Resources.documentnew;
        this.nouveauToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.nouveauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.nouveauToolStripButton.Name = "nouveauToolStripButton";
        this.nouveauToolStripButton.Size = new System.Drawing.Size(28, 28);
        this.nouveauToolStripButton.Text = "&New package";
        this.nouveauToolStripButton.Click += new System.EventHandler(this.createANewPackageToolStripMenuItem_Click);
        //
        // toolStripButton1
        //
        this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.toolStripButton1.Enabled = false;
        this.toolStripButton1.Image = global::MonoOSC.Properties.Resources.insertobject;
        this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripButton1.Name = "toolStripButton1";
        this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
        this.toolStripButton1.Text = "Create a New package using spec file wizard";
        this.toolStripButton1.Click += new System.EventHandler(this.newPackageUsingSpecFileWizardToolStripMenuItem_Click);
        //
        // BtnWritePrjMeta
        //
        this.BtnWritePrjMeta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnWritePrjMeta.Image = global::MonoOSC.Properties.Resources.documentsave;
        this.BtnWritePrjMeta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnWritePrjMeta.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnWritePrjMeta.Name = "BtnWritePrjMeta";
        this.BtnWritePrjMeta.Size = new System.Drawing.Size(28, 28);
        this.BtnWritePrjMeta.Text = "&Save";
        this.BtnWritePrjMeta.ToolTipText = "Write meta data of the project";
        this.BtnWritePrjMeta.Click += new System.EventHandler(this.BtnWritePrjMeta_Click);
        //
        // toolStripSeparator3
        //
        this.toolStripSeparator3.Name = "toolStripSeparator3";
        this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
        //
        // ouvrirToolStripButton
        //
        this.ouvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.ouvrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripButton.Image")));
        this.ouvrirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.ouvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.ouvrirToolStripButton.Name = "ouvrirToolStripButton";
        this.ouvrirToolStripButton.Size = new System.Drawing.Size(23, 28);
        this.ouvrirToolStripButton.Text = "&Open";
        this.ouvrirToolStripButton.Visible = false;
        //
        // imprimerToolStripButton
        //
        this.imprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.imprimerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripButton.Image")));
        this.imprimerToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.imprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.imprimerToolStripButton.Name = "imprimerToolStripButton";
        this.imprimerToolStripButton.Size = new System.Drawing.Size(23, 28);
        this.imprimerToolStripButton.Text = "&Print";
        this.imprimerToolStripButton.Visible = false;
        //
        // toolStripSeparator
        //
        this.toolStripSeparator.Name = "toolStripSeparator";
        this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
        this.toolStripSeparator.Visible = false;
        //
        // couperToolStripButton
        //
        this.couperToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.couperToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripButton.Image")));
        this.couperToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.couperToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.couperToolStripButton.Name = "couperToolStripButton";
        this.couperToolStripButton.Size = new System.Drawing.Size(23, 28);
        this.couperToolStripButton.Text = "C&ut";
        this.couperToolStripButton.Visible = false;
        //
        // copierToolStripButton
        //
        this.copierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.copierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripButton.Image")));
        this.copierToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.copierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.copierToolStripButton.Name = "copierToolStripButton";
        this.copierToolStripButton.Size = new System.Drawing.Size(23, 28);
        this.copierToolStripButton.Text = "Co&y";
        this.copierToolStripButton.Visible = false;
        //
        // collerToolStripButton
        //
        this.collerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.collerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripButton.Image")));
        this.collerToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.collerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.collerToolStripButton.Name = "collerToolStripButton";
        this.collerToolStripButton.Size = new System.Drawing.Size(23, 28);
        this.collerToolStripButton.Text = "Pa&ste";
        this.collerToolStripButton.Visible = false;
        //
        // toolStripSeparator1
        //
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
        this.toolStripSeparator1.Visible = false;
        //
        // BtnCloseTab
        //
        this.BtnCloseTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnCloseTab.Image = global::MonoOSC.Properties.Resources.CloseTab;
        this.BtnCloseTab.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnCloseTab.Name = "BtnCloseTab";
        this.BtnCloseTab.Size = new System.Drawing.Size(26, 28);
        this.BtnCloseTab.Text = "toolStripButton1";
        this.BtnCloseTab.ToolTipText = "Close current package tab";
        this.BtnCloseTab.Visible = false;
        this.BtnCloseTab.Click += new System.EventHandler(this.CloseTabToolStripMenuItem_Click);
        //
        // BtnDelPkg
        //
        this.BtnDelPkg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnDelPkg.Image = global::MonoOSC.Properties.Resources.DelPkg;
        this.BtnDelPkg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnDelPkg.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnDelPkg.Name = "BtnDelPkg";
        this.BtnDelPkg.Size = new System.Drawing.Size(26, 28);
        this.BtnDelPkg.Text = "toolStripButton2";
        this.BtnDelPkg.ToolTipText = "Delete this package";
        this.BtnDelPkg.Visible = false;
        this.BtnDelPkg.Click += new System.EventHandler(this.deleteThisPackageToolStripMenuItem_Click);
        //
        // toolStripSeparator2
        //
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
        this.toolStripSeparator2.Visible = false;
        //
        // ToolStripButton
        //
        this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.ToolStripButton.Image = global::MonoOSC.Properties.Resources.helpabout;
        this.ToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.ToolStripButton.Name = "ToolStripButton";
        this.ToolStripButton.Size = new System.Drawing.Size(28, 28);
        this.ToolStripButton.Text = "&?";
        this.ToolStripButton.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
        //
        // toolStripSeparator4
        //
        this.toolStripSeparator4.Name = "toolStripSeparator4";
        this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
        //
        // LblProjectName
        //
        this.LblProjectName.Name = "LblProjectName";
        this.LblProjectName.Size = new System.Drawing.Size(46, 28);
        this.LblProjectName.Text = "Projects";
        this.LblProjectName.ToolTipText = "List all projects and subproject";
        //
        // CmBxPrjName
        //
        this.CmBxPrjName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.CmBxPrjName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
        this.CmBxPrjName.AutoToolTip = true;
        this.CmBxPrjName.MaxDropDownItems = 36;
        this.CmBxPrjName.Name = "CmBxPrjName";
        this.CmBxPrjName.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
        this.CmBxPrjName.Size = new System.Drawing.Size(280, 31);
        this.CmBxPrjName.Sorted = true;
        this.CmBxPrjName.SelectedIndexChanged += new System.EventHandler(this.CmBxPrjName_SelectedIndexChanged);
        this.CmBxPrjName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmBxPrjName_KeyUp);
        this.CmBxPrjName.Leave += new System.EventHandler(this.CmBxPrjName_Validated);
        this.CmBxPrjName.TextChanged += new System.EventHandler(this.CmBxPrjName_TextChanged);
        this.CmBxPrjName.Validated += new System.EventHandler(this.CmBxPrjName_Validated);
        //
        // BtnDelPrjSubPrj
        //
        this.BtnDelPrjSubPrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnDelPrjSubPrj.Image = global::MonoOSC.Properties.Resources.Del;
        this.BtnDelPrjSubPrj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnDelPrjSubPrj.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnDelPrjSubPrj.Name = "BtnDelPrjSubPrj";
        this.BtnDelPrjSubPrj.Size = new System.Drawing.Size(26, 28);
        this.BtnDelPrjSubPrj.Text = "Delete this Project/SubProject";
        this.BtnDelPrjSubPrj.Click += new System.EventHandler(this.deleteThisProjectsubrojectToolStripMenuItem_Click);
        //
        // BtnAddPrjSubPrj
        //
        this.BtnAddPrjSubPrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.BtnAddPrjSubPrj.Image = global::MonoOSC.Properties.Resources.Add;
        this.BtnAddPrjSubPrj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.BtnAddPrjSubPrj.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.BtnAddPrjSubPrj.Name = "BtnAddPrjSubPrj";
        this.BtnAddPrjSubPrj.Size = new System.Drawing.Size(26, 28);
        this.BtnAddPrjSubPrj.Text = "Add a Project/SubProject";
        this.BtnAddPrjSubPrj.Click += new System.EventHandler(this.addAProjectsubrojectToolStripMenuItem_Click);
        //
        // statusStrip1
        //
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.LblNetLed,
            this.LblSeparator1,
            this.LblNetStatus
        });
        this.statusStrip1.Location = new System.Drawing.Point(0, 456);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(863, 22);
        this.statusStrip1.TabIndex = 0;
        this.statusStrip1.Text = "statusStrip1";
        //
        // LblNetLed
        //
        this.LblNetLed.Image = global::MonoOSC.Properties.Resources.NetLedZz;
        this.LblNetLed.Name = "LblNetLed";
        this.LblNetLed.Size = new System.Drawing.Size(16, 17);
        //
        // LblSeparator1
        //
        this.LblSeparator1.Name = "LblSeparator1";
        this.LblSeparator1.Size = new System.Drawing.Size(28, 17);
        this.LblSeparator1.Text = "       ";
        //
        // LblNetStatus
        //
        this.LblNetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
        this.LblNetStatus.Name = "LblNetStatus";
        this.LblNetStatus.Size = new System.Drawing.Size(73, 17);
        this.LblNetStatus.Text = "Net Status";
        //
        // menuStrip1
        //
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.helpToolStripMenuItem
        });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(863, 32);
        this.menuStrip1.TabIndex = 1;
        this.menuStrip1.Text = "menuStrip1";
        //
        // menuToolStripMenuItem
        //
        this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator11,
            this.deleteThisProjectsubrojectToolStripMenuItem,
            this.addAProjectsubrojectToolStripMenuItem,
            this.toolStripSeparator8,
            this.CloseTabToolStripMenuItem,
            this.toolStripSeparator9,
            this.createANewPackageToolStripMenuItem,
            this.newPackageUsingSpecFileWizardToolStripMenuItem,
            this.deleteThisPackageToolStripMenuItem,
            this.toolStripSeparator10,
            this.exitToolStripMenuItem
        });
        this.menuToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.gnome_main_menu;
        this.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
        this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 28);
        this.menuToolStripMenuItem.Text = "Menu";
        //
        // connectToolStripMenuItem
        //
        this.connectToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_connecttourl;
        this.connectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
        this.connectToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
        this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        this.connectToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.connectToolStripMenuItem.Text = "Connect";
        this.connectToolStripMenuItem.ToolTipText = "Connect";
        this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
        //
        // disconnectToolStripMenuItem
        //
        this.disconnectToolStripMenuItem.Enabled = false;
        this.disconnectToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_disconnect;
        this.disconnectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
        this.disconnectToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
        this.disconnectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
        this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.disconnectToolStripMenuItem.Text = "Disconnect";
        this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.BtnDisConnect_Click);
        //
        // toolStripSeparator11
        //
        this.toolStripSeparator11.Name = "toolStripSeparator11";
        this.toolStripSeparator11.Size = new System.Drawing.Size(258, 6);
        //
        // deleteThisProjectsubrojectToolStripMenuItem
        //
        this.deleteThisProjectsubrojectToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.Del;
        this.deleteThisProjectsubrojectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.deleteThisProjectsubrojectToolStripMenuItem.Name = "deleteThisProjectsubrojectToolStripMenuItem";
        this.deleteThisProjectsubrojectToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.deleteThisProjectsubrojectToolStripMenuItem.Text = "Delete this project/subroject";
        this.deleteThisProjectsubrojectToolStripMenuItem.Click += new System.EventHandler(this.deleteThisProjectsubrojectToolStripMenuItem_Click);
        //
        // addAProjectsubrojectToolStripMenuItem
        //
        this.addAProjectsubrojectToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.Add;
        this.addAProjectsubrojectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.addAProjectsubrojectToolStripMenuItem.Name = "addAProjectsubrojectToolStripMenuItem";
        this.addAProjectsubrojectToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.addAProjectsubrojectToolStripMenuItem.Text = "Add a project/subroject";
        this.addAProjectsubrojectToolStripMenuItem.Click += new System.EventHandler(this.addAProjectsubrojectToolStripMenuItem_Click);
        //
        // toolStripSeparator8
        //
        this.toolStripSeparator8.Name = "toolStripSeparator8";
        this.toolStripSeparator8.Size = new System.Drawing.Size(258, 6);
        //
        // CloseTabToolStripMenuItem
        //
        this.CloseTabToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.CloseTab;
        this.CloseTabToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem";
        this.CloseTabToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+T";
        this.CloseTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
        this.CloseTabToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.CloseTabToolStripMenuItem.Text = "Close current tab.";
        this.CloseTabToolStripMenuItem.Visible = false;
        this.CloseTabToolStripMenuItem.Click += new System.EventHandler(this.CloseTabToolStripMenuItem_Click);
        //
        // toolStripSeparator9
        //
        this.toolStripSeparator9.Name = "toolStripSeparator9";
        this.toolStripSeparator9.Size = new System.Drawing.Size(258, 6);
        //
        // createANewPackageToolStripMenuItem
        //
        this.createANewPackageToolStripMenuItem.Enabled = false;
        this.createANewPackageToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.documentnew;
        this.createANewPackageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.createANewPackageToolStripMenuItem.Name = "createANewPackageToolStripMenuItem";
        this.createANewPackageToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.createANewPackageToolStripMenuItem.Text = "Create/edit a new package";
        this.createANewPackageToolStripMenuItem.Click += new System.EventHandler(this.createANewPackageToolStripMenuItem_Click);
        //
        // newPackageUsingSpecFileWizardToolStripMenuItem
        //
        this.newPackageUsingSpecFileWizardToolStripMenuItem.Enabled = false;
        this.newPackageUsingSpecFileWizardToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.insertobject;
        this.newPackageUsingSpecFileWizardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.newPackageUsingSpecFileWizardToolStripMenuItem.Name = "newPackageUsingSpecFileWizardToolStripMenuItem";
        this.newPackageUsingSpecFileWizardToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.newPackageUsingSpecFileWizardToolStripMenuItem.Text = "New package using spec file wizard";
        this.newPackageUsingSpecFileWizardToolStripMenuItem.ToolTipText = "Create a New package using spec file wizard";
        this.newPackageUsingSpecFileWizardToolStripMenuItem.Click += new System.EventHandler(this.newPackageUsingSpecFileWizardToolStripMenuItem_Click);
        //
        // deleteThisPackageToolStripMenuItem
        //
        this.deleteThisPackageToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.DelPkg;
        this.deleteThisPackageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.deleteThisPackageToolStripMenuItem.Name = "deleteThisPackageToolStripMenuItem";
        this.deleteThisPackageToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.deleteThisPackageToolStripMenuItem.Text = "Delete this package";
        this.deleteThisPackageToolStripMenuItem.Visible = false;
        this.deleteThisPackageToolStripMenuItem.Click += new System.EventHandler(this.deleteThisPackageToolStripMenuItem_Click);
        //
        // toolStripSeparator10
        //
        this.toolStripSeparator10.Name = "toolStripSeparator10";
        this.toolStripSeparator10.Size = new System.Drawing.Size(258, 6);
        //
        // exitToolStripMenuItem
        //
        this.exitToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.applicationexit;
        this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
        this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
        this.exitToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
        this.exitToolStripMenuItem.Text = "Exit";
        this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        //
        // editToolStripMenuItem
        //
        this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.SettingToolStripMenuItem,
            this.editPrjMetaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.repositoriesManagerToolStripMenuItem,
            this.deleteWipeAllBinaryToolStripMenuItem,
            this.collaborationToolStripMenuItem
        });
        this.editToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_allow_effects;
        this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
        this.editToolStripMenuItem.Text = "Edit";
        //
        // SettingToolStripMenuItem
        //
        this.SettingToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.gnomesettings;
        this.SettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
        this.SettingToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
        this.SettingToolStripMenuItem.Text = "Setting";
        this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
        //
        // editPrjMetaToolStripMenuItem
        //
        this.editPrjMetaToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.EditXml;
        this.editPrjMetaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.editPrjMetaToolStripMenuItem.Name = "editPrjMetaToolStripMenuItem";
        this.editPrjMetaToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
        this.editPrjMetaToolStripMenuItem.Text = "Edit project meta manualy";
        this.editPrjMetaToolStripMenuItem.Click += new System.EventHandler(this.editPrjMetaToolStripMenuItem_Click);
        //
        // toolStripMenuItem1
        //
        this.toolStripMenuItem1.Image = global::MonoOSC.Properties.Resources.configusers;
        this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 30);
        this.toolStripMenuItem1.Text = "Create an account";
        this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
        //
        // repositoriesManagerToolStripMenuItem
        //
        this.repositoriesManagerToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.key_bindings;
        this.repositoriesManagerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.repositoriesManagerToolStripMenuItem.Name = "repositoriesManagerToolStripMenuItem";
        this.repositoriesManagerToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
        this.repositoriesManagerToolStripMenuItem.Text = "Repositories manager";
        this.repositoriesManagerToolStripMenuItem.Click += new System.EventHandler(this.repositoriesManagerToolStripMenuItem_Click);
        //
        // deleteWipeAllBinaryToolStripMenuItem
        //
        this.deleteWipeAllBinaryToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.Wipe;
        this.deleteWipeAllBinaryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.deleteWipeAllBinaryToolStripMenuItem.Name = "deleteWipeAllBinaryToolStripMenuItem";
        this.deleteWipeAllBinaryToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
        this.deleteWipeAllBinaryToolStripMenuItem.Text = "Delete/Wipe all binary";
        this.deleteWipeAllBinaryToolStripMenuItem.Click += new System.EventHandler(this.deleteWipeAllBinaryToolStripMenuItem_Click);
        //
        // collaborationToolStripMenuItem
        //
        this.collaborationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.requestsToSubmitToolStripMenuItem,
            this.branchAPackageToolStripMenuItem,
            this.editPackageToolStripMenuItem
        });
        this.collaborationToolStripMenuItem.Enabled = false;
        this.collaborationToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.face_monkey;
        this.collaborationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.collaborationToolStripMenuItem.Name = "collaborationToolStripMenuItem";
        this.collaborationToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
        this.collaborationToolStripMenuItem.Text = "Collaboration";
        //
        // requestsToSubmitToolStripMenuItem
        //
        this.requestsToSubmitToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.gnome_fs_bookmark_missing;
        this.requestsToSubmitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.requestsToSubmitToolStripMenuItem.Name = "requestsToSubmitToolStripMenuItem";
        this.requestsToSubmitToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
        this.requestsToSubmitToolStripMenuItem.Text = "Requests to submit";
        this.requestsToSubmitToolStripMenuItem.Click += new System.EventHandler(this.requestsToSubmitToolStripMenuItem_Click);
        //
        // branchAPackageToolStripMenuItem
        //
        this.branchAPackageToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.gnome_fs_bookmark;
        this.branchAPackageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.branchAPackageToolStripMenuItem.Name = "branchAPackageToolStripMenuItem";
        this.branchAPackageToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
        this.branchAPackageToolStripMenuItem.Text = "Branch a package";
        this.branchAPackageToolStripMenuItem.Click += new System.EventHandler(this.branchAPackageToolStripMenuItem_Click);
        //
        // editPackageToolStripMenuItem
        //
        this.editPackageToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.gtk_edit;
        this.editPackageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.editPackageToolStripMenuItem.Name = "editPackageToolStripMenuItem";
        this.editPackageToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
        this.editPackageToolStripMenuItem.Text = "Edit package";
        this.editPackageToolStripMenuItem.Click += new System.EventHandler(this.editPackageToolStripMenuItem_Click);
        //
        // bookmarksToolStripMenuItem
        //
        this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.manageToolStripMenuItem,
            this.toolStripSeparator12
        });
        this.bookmarksToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_bookmark;
        this.bookmarksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
        this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
        this.bookmarksToolStripMenuItem.Text = "Bookmarks";
        //
        // manageToolStripMenuItem
        //
        this.manageToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_edit_bookmark;
        this.manageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
        this.manageToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
        this.manageToolStripMenuItem.Text = "Manage";
        this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
        //
        // toolStripSeparator12
        //
        this.toolStripSeparator12.Name = "toolStripSeparator12";
        this.toolStripSeparator12.Size = new System.Drawing.Size(128, 6);
        //
        // displayToolStripMenuItem
        //
        this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.infosToolStripMenuItem,
            this.autoHideListToolStripMenuItem,
            this.serverStatusToolStripMenuItem
        });
        this.displayToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.display;
        this.displayToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
        this.displayToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
        this.displayToolStripMenuItem.Text = "Display";
        //
        // infosToolStripMenuItem
        //
        this.infosToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.info;
        this.infosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.infosToolStripMenuItem.Name = "infosToolStripMenuItem";
        this.infosToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
        this.infosToolStripMenuItem.Text = "Infos";
        this.infosToolStripMenuItem.Click += new System.EventHandler(this.infosToolStripMenuItem_Click);
        //
        // autoHideListToolStripMenuItem
        //
        this.autoHideListToolStripMenuItem.CheckOnClick = true;
        this.autoHideListToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_effects_object_hide;
        this.autoHideListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.autoHideListToolStripMenuItem.Name = "autoHideListToolStripMenuItem";
        this.autoHideListToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
        this.autoHideListToolStripMenuItem.Text = "Auto hide list(mouse hover)";
        //
        // serverStatusToolStripMenuItem
        //
        this.serverStatusToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.connect_creating;
        this.serverStatusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.serverStatusToolStripMenuItem.Name = "serverStatusToolStripMenuItem";
        this.serverStatusToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
        this.serverStatusToolStripMenuItem.Text = "Server status";
        this.serverStatusToolStripMenuItem.Click += new System.EventHandler(this.serverStatusToolStripMenuItem_Click);
        //
        // helpToolStripMenuItem
        //
        this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator6,
            this.iRCChannelToolStripMenuItem,
            this.officialPageToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.bugRepportToolStripMenuItem,
            this.featureRequestToolStripMenuItem,
            this.toolStripSeparator7,
            this.showGlobalLogToolStripMenuItem,
            this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem,
            this.onlineHelpToolStripMenuItem,
            this.checkUpdateToolStripMenuItem
        });
        this.helpToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.gnome_help;
        this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 28);
        this.helpToolStripMenuItem.Text = "Help";
        //
        // aboutToolStripMenuItem
        //
        this.aboutToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.helpabout;
        this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        this.aboutToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.aboutToolStripMenuItem.Text = "About";
        this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
        //
        // toolStripSeparator6
        //
        this.toolStripSeparator6.Name = "toolStripSeparator6";
        this.toolStripSeparator6.Size = new System.Drawing.Size(276, 6);
        //
        // iRCChannelToolStripMenuItem
        //
        this.iRCChannelToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stop;
        this.iRCChannelToolStripMenuItem.Name = "iRCChannelToolStripMenuItem";
        this.iRCChannelToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.iRCChannelToolStripMenuItem.Text = "IRC #Channel";
        this.iRCChannelToolStripMenuItem.Click += new System.EventHandler(this.iRCChannelToolStripMenuItem_Click);
        //
        // officialPageToolStripMenuItem
        //
        this.officialPageToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.WWW;
        this.officialPageToolStripMenuItem.Name = "officialPageToolStripMenuItem";
        this.officialPageToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.officialPageToolStripMenuItem.Text = "Official page";
        this.officialPageToolStripMenuItem.Click += new System.EventHandler(this.officialPageToolStripMenuItem_Click);
        //
        // registerToolStripMenuItem
        //
        this.registerToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_hyperlink_toolbar;
        this.registerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
        this.registerToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.registerToolStripMenuItem.Text = "Become an MonoOSC User";
        this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
        //
        // donateToolStripMenuItem
        //
        this.donateToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.dollar;
        this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
        this.donateToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.donateToolStripMenuItem.Text = "Donate";
        this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
        //
        // bugRepportToolStripMenuItem
        //
        this.bugRepportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bugRepportToolStripMenuItem.Image")));
        this.bugRepportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.bugRepportToolStripMenuItem.Name = "bugRepportToolStripMenuItem";
        this.bugRepportToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.bugRepportToolStripMenuItem.Text = "Bug repport";
        this.bugRepportToolStripMenuItem.Click += new System.EventHandler(this.bugRepportToolStripMenuItem_Click);
        //
        // featureRequestToolStripMenuItem
        //
        this.featureRequestToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.Meffert_Pyraminx_32;
        this.featureRequestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.featureRequestToolStripMenuItem.Name = "featureRequestToolStripMenuItem";
        this.featureRequestToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.featureRequestToolStripMenuItem.Text = "Feature request";
        this.featureRequestToolStripMenuItem.Click += new System.EventHandler(this.featureRequestToolStripMenuItem_Click);
        //
        // toolStripSeparator7
        //
        this.toolStripSeparator7.Name = "toolStripSeparator7";
        this.toolStripSeparator7.Size = new System.Drawing.Size(276, 6);
        //
        // showGlobalLogToolStripMenuItem
        //
        this.showGlobalLogToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.logviewer;
        this.showGlobalLogToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.showGlobalLogToolStripMenuItem.Name = "showGlobalLogToolStripMenuItem";
        this.showGlobalLogToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.showGlobalLogToolStripMenuItem.Text = "Show global log";
        this.showGlobalLogToolStripMenuItem.Click += new System.EventHandler(this.showGlobalLogToolStripMenuItem_Click);
        //
        // MonoOBSFrameworkDevelopersHelpToolStripMenuItem
        //
        this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.htmlToolStripMenuItem,
            this.chmToolStripMenuItem
        });
        this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.systemhelp;
        this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem.Name = "MonoOBSFrameworkDevelopersHelpToolStripMenuItem";
        this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.MonoOBSFrameworkDevelopersHelpToolStripMenuItem.Text = "MonoOBSFramework developers help";
        //
        // htmlToolStripMenuItem
        //
        this.htmlToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.helpcontents;
        this.htmlToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
        this.htmlToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
        this.htmlToolStripMenuItem.Text = "Html";
        this.htmlToolStripMenuItem.Click += new System.EventHandler(this.htmlToolStripMenuItem_Click);
        //
        // chmToolStripMenuItem
        //
        this.chmToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_helpagent;
        this.chmToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.chmToolStripMenuItem.Name = "chmToolStripMenuItem";
        this.chmToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
        this.chmToolStripMenuItem.Text = "Chm";
        this.chmToolStripMenuItem.Click += new System.EventHandler(this.chmToolStripMenuItem_Click);
        //
        // onlineHelpToolStripMenuItem
        //
        this.onlineHelpToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.stock_online_layout;
        this.onlineHelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
        this.onlineHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
        this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.onlineHelpToolStripMenuItem.Text = "Online Help";
        this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
        //
        // checkUpdateToolStripMenuItem
        //
        this.checkUpdateToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.softwareupdateavailable;
        this.checkUpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
        this.checkUpdateToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
        this.checkUpdateToolStripMenuItem.Text = "Check update";
        this.checkUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkUpdateToolStripMenuItem_Click);
        //
        // BckGrdWorkerDll
        //
        this.BckGrdWorkerDll.WorkerReportsProgress = true;
        this.BckGrdWorkerDll.WorkerSupportsCancellation = true;
        this.BckGrdWorkerDll.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BckGrdWorkerDll_DoWork);
        this.BckGrdWorkerDll.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BckGrdWorkerDll_RunWorkerCompleted);
        this.BckGrdWorkerDll.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BckGrdWorkerDll_ProgressChanged);
        //
        // TimerNetAnim
        //
        this.TimerNetAnim.Enabled = true;
        this.TimerNetAnim.Interval = 600;
        this.TimerNetAnim.Tick += new System.EventHandler(this.TimerNetAnim_Tick);
        //
        // CtxMenuCloseTab
        //
        this.CtxMenuCloseTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.closeTabToolStripMenuItem1,
            this.deletePackageToolStripMenuItem
        });
        this.CtxMenuCloseTab.Name = "CtxMenuCloseTab";
        this.CtxMenuCloseTab.Size = new System.Drawing.Size(160, 48);
        //
        // closeTabToolStripMenuItem1
        //
        this.closeTabToolStripMenuItem1.Image = global::MonoOSC.Properties.Resources.CloseTab;
        this.closeTabToolStripMenuItem1.Name = "closeTabToolStripMenuItem1";
        this.closeTabToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
        this.closeTabToolStripMenuItem1.Text = "Close tab";
        this.closeTabToolStripMenuItem1.Click += new System.EventHandler(this.CloseTabToolStripMenuItem_Click);
        //
        // deletePackageToolStripMenuItem
        //
        this.deletePackageToolStripMenuItem.Image = global::MonoOSC.Properties.Resources.DelPkg;
        this.deletePackageToolStripMenuItem.Name = "deletePackageToolStripMenuItem";
        this.deletePackageToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
        this.deletePackageToolStripMenuItem.Text = "Delete package";
        this.deletePackageToolStripMenuItem.Click += new System.EventHandler(this.deleteThisPackageToolStripMenuItem_Click);
        //
        // helpProvider1
        //
        this.helpProvider1.HelpNamespace = "http://en.opensuse.org/MonoOSC/Guide";
        //
        // ContexMenuBookMarks
        //
        this.ContexMenuBookMarks.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.BookMarksAdd,
            this.BookMarksDel
        });
        this.ContexMenuBookMarks.Name = "ContexMenuBookMarks";
        this.ContexMenuBookMarks.Size = new System.Drawing.Size(185, 48);
        //
        // BookMarksAdd
        //
        this.BookMarksAdd.Name = "BookMarksAdd";
        this.BookMarksAdd.Size = new System.Drawing.Size(184, 22);
        this.BookMarksAdd.Text = "Add a bookmark";
        //
        // BookMarksDel
        //
        this.BookMarksDel.Name = "BookMarksDel";
        this.BookMarksDel.Size = new System.Drawing.Size(184, 22);
        this.BookMarksDel.Text = "Delete the bookmark";
        //
        // MainForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(863, 478);
        this.Controls.Add(this.toolStripContainer1);
        this.Controls.Add(this.statusStrip1);
        this.Controls.Add(this.menuStrip1);
        this.DoubleBuffered = true;
        this.HelpButton = true;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "MainForm";
        this.helpProvider1.SetShowHelp(this, true);
        this.Text = "Mono OSC";
        this.Shown += new System.EventHandler(this.MainForm_Shown);
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
        this.toolStripContainer1.ContentPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.PerformLayout();
        this.toolStripContainer1.ResumeLayout(false);
        this.toolStripContainer1.PerformLayout();
        this.tabControl1.ResumeLayout(false);
        this.TabPgMain.ResumeLayout(false);
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        this.splitContainer1.ResumeLayout(false);
        this.splitContainer2.Panel1.ResumeLayout(false);
        this.splitContainer2.Panel2.ResumeLayout(false);
        this.splitContainer2.ResumeLayout(false);
        this.GrpBxPrjInf.ResumeLayout(false);
        this.groupBox1.ResumeLayout(false);
        this.contextMenuStripPkgList.ResumeLayout(false);
        this.toolStripContainerProjects.ContentPanel.ResumeLayout(false);
        this.toolStripContainerProjects.LeftToolStripPanel.ResumeLayout(false);
        this.toolStripContainerProjects.LeftToolStripPanel.PerformLayout();
        this.toolStripContainerProjects.ResumeLayout(false);
        this.toolStripContainerProjects.PerformLayout();
        this.toolStrip2.ResumeLayout(false);
        this.toolStrip2.PerformLayout();
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.CtxMenuCloseTab.ResumeLayout(false);
        this.ContexMenuBookMarks.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editPrjMetaToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem CloseTabToolStripMenuItem;
    private System.Windows.Forms.TabPage TabPgMain;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListView listViewPckg;
    private System.Windows.Forms.ColumnHeader ClmPkgName;
    private System.ComponentModel.BackgroundWorker BckGrdWorkerDll;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.GroupBox GrpBxPrjInf;
    private System.Windows.Forms.ListView listViewPrjInf;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createANewPackageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteThisPackageToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton nouveauToolStripButton;
    private System.Windows.Forms.ToolStripButton ouvrirToolStripButton;
    private System.Windows.Forms.ToolStripButton imprimerToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripButton couperToolStripButton;
    private System.Windows.Forms.ToolStripButton copierToolStripButton;
    private System.Windows.Forms.ToolStripButton collerToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton ToolStripButton;
    private System.Windows.Forms.ToolStripButton BtnCloseTab;
    private System.Windows.Forms.ToolStripButton BtnDelPkg;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripPkgList;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelPkg;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditMeta;
    private System.Windows.Forms.ToolStripStatusLabel LblNetStatus;
    private System.Windows.Forms.ToolStripStatusLabel LblNetLed;
    private System.Windows.Forms.Timer TimerNetAnim;
    private System.Windows.Forms.ToolStripStatusLabel LblSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton BtnWritePrjMeta;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripLabel LblProjectName;
    private System.Windows.Forms.ToolStripComboBox CmBxPrjName;
    private System.Windows.Forms.ToolStripMenuItem repositoriesManagerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MonoOBSFrameworkDevelopersHelpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem chmToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton BtnConnect;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem showGlobalLogToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteWipeAllBinaryToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip CtxMenuCloseTab;
    private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem deletePackageToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton BtnDisConnect;
    private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newPackageUsingSpecFileWizardToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem infosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem autoHideListToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem iRCChannelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem officialPageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
    private TabControlEx tabControl1;
    private System.Windows.Forms.ToolStripMenuItem collaborationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem requestsToSubmitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem branchAPackageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editPackageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
    private System.Windows.Forms.HelpProvider helpProvider1;
    private System.Windows.Forms.ToolStripMenuItem serverStatusToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem bugRepportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem featureRequestToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip2;
    private System.Windows.Forms.ToolStripContainer toolStripContainerProjects;
    private System.Windows.Forms.ToolStripButton BtnAddRepo;
    private System.Windows.Forms.Panel panelProjects;
    private System.Windows.Forms.ToolStripButton BtnDelPrjSubPrj;
    private System.Windows.Forms.ToolStripButton BtnAddPrjSubPrj;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    private System.Windows.Forms.ToolStripMenuItem deleteThisProjectsubrojectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addAProjectsubrojectToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip ContexMenuBookMarks;
    private System.Windows.Forms.ToolStripMenuItem BookMarksAdd;
    private System.Windows.Forms.ToolStripMenuItem BookMarksDel;
    private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
}
}
