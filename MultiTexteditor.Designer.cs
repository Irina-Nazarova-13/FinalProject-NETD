
namespace FinalProjectForNETD
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuStripMultiEditor = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalWindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalWindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openCarListWindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openAverageUnitsWindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.youKnowWhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipMultiEditor = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripEditor = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStripMultiEditor.SuspendLayout();
            this.toolStripEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMultiEditor
            // 
            this.menuStripMultiEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.menuStripMultiEditor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMultiEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStripMultiEditor.Location = new System.Drawing.Point(0, 0);
            this.menuStripMultiEditor.Name = "menuStripMultiEditor";
            this.menuStripMultiEditor.ShowItemToolTips = true;
            this.menuStripMultiEditor.Size = new System.Drawing.Size(957, 31);
            this.menuStripMultiEditor.TabIndex = 1;
            this.menuStripMultiEditor.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.openFileMenu,
            this.saveFileMenu,
            this.saveAsFileMenu,
            this.closeFileMenu,
            this.exitFileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(50, 27);
            this.fileMenu.Text = "&File";
            this.fileMenu.ToolTipText = "File Manipulation";
            // 
            // newFileMenu
            // 
            this.newFileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.newFileMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.newFileMenu.Name = "newFileMenu";
            this.newFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenu.Size = new System.Drawing.Size(245, 28);
            this.newFileMenu.Text = "&New";
            this.newFileMenu.ToolTipText = "open New text Editor";
            this.newFileMenu.Click += new System.EventHandler(this.newFileMenuClick);
            // 
            // openFileMenu
            // 
            this.openFileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(245, 28);
            this.openFileMenu.Text = "&Open";
            this.openFileMenu.ToolTipText = "open Existing Text editor";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenuClick);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(245, 28);
            this.saveFileMenu.Text = "&Save";
            this.saveFileMenu.ToolTipText = "Save Text Editor";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenuClick);
            // 
            // saveAsFileMenu
            // 
            this.saveAsFileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.saveAsFileMenu.Name = "saveAsFileMenu";
            this.saveAsFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsFileMenu.Size = new System.Drawing.Size(245, 28);
            this.saveAsFileMenu.Text = "Save &As";
            this.saveAsFileMenu.ToolTipText = "Save text editor in the particular location";
            this.saveAsFileMenu.Click += new System.EventHandler(this.saveAsFileMenuClick);
            // 
            // closeFileMenu
            // 
            this.closeFileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.closeFileMenu.Name = "closeFileMenu";
            this.closeFileMenu.Size = new System.Drawing.Size(245, 28);
            this.closeFileMenu.Text = "&Close";
            this.closeFileMenu.ToolTipText = "Close the window";
            this.closeFileMenu.Click += new System.EventHandler(this.closeFileMenuClick);
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(245, 28);
            this.exitFileMenu.Text = "&Exit";
            this.exitFileMenu.ToolTipText = "Exit the application";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenuClick);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutEditMenu,
            this.copyEditMenu,
            this.pasteEditMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(53, 27);
            this.editMenu.Text = "&Edit";
            this.editMenu.ToolTipText = "Text Manipulation";
            // 
            // cutEditMenu
            // 
            this.cutEditMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cutEditMenu.Name = "cutEditMenu";
            this.cutEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutEditMenu.Size = new System.Drawing.Size(180, 28);
            this.cutEditMenu.Text = "Cu&t";
            this.cutEditMenu.ToolTipText = "Cut the selected text";
            this.cutEditMenu.Click += new System.EventHandler(this.cutEditMenuClick);
            // 
            // copyEditMenu
            // 
            this.copyEditMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.copyEditMenu.Name = "copyEditMenu";
            this.copyEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyEditMenu.Size = new System.Drawing.Size(180, 28);
            this.copyEditMenu.Text = "&Copy";
            this.copyEditMenu.ToolTipText = "Copy selected text";
            this.copyEditMenu.Click += new System.EventHandler(this.copyEditMenuClick);
            // 
            // pasteEditMenu
            // 
            this.pasteEditMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.pasteEditMenu.Name = "pasteEditMenu";
            this.pasteEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteEditMenu.Size = new System.Drawing.Size(180, 28);
            this.pasteEditMenu.Text = "&Paste";
            this.pasteEditMenu.ToolTipText = "Paste the text ";
            this.pasteEditMenu.Click += new System.EventHandler(this.pasteEditMenu_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeWindowsMenu,
            this.tileVerticalWindowsMenu,
            this.tileHorizontalWindowsMenu,
            this.openCarListWindowsMenu,
            this.openAverageUnitsWindowsMenu,
            this.youKnowWhatToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(87, 27);
            this.windowsMenu.Text = "&Windows";
            this.windowsMenu.ToolTipText = "Window manipulation";
            // 
            // cascadeWindowsMenu
            // 
            this.cascadeWindowsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cascadeWindowsMenu.Name = "cascadeWindowsMenu";
            this.cascadeWindowsMenu.Size = new System.Drawing.Size(227, 28);
            this.cascadeWindowsMenu.Text = "&Cascade";
            this.cascadeWindowsMenu.ToolTipText = "Cascade Layout of Windows";
            this.cascadeWindowsMenu.Click += new System.EventHandler(this.cascadeWindowMenuClick);
            // 
            // tileVerticalWindowsMenu
            // 
            this.tileVerticalWindowsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.tileVerticalWindowsMenu.Name = "tileVerticalWindowsMenu";
            this.tileVerticalWindowsMenu.Size = new System.Drawing.Size(227, 28);
            this.tileVerticalWindowsMenu.Text = "Tile &Vertical";
            this.tileVerticalWindowsMenu.ToolTipText = "Tile Verticle Layout of Windows";
            this.tileVerticalWindowsMenu.Click += new System.EventHandler(this.tileVerticalWindowsMenuClick);
            // 
            // tileHorizontalWindowsMenu
            // 
            this.tileHorizontalWindowsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.tileHorizontalWindowsMenu.Name = "tileHorizontalWindowsMenu";
            this.tileHorizontalWindowsMenu.Size = new System.Drawing.Size(227, 28);
            this.tileHorizontalWindowsMenu.Text = "Tile &Horizontal";
            this.tileHorizontalWindowsMenu.ToolTipText = "Title Horizontal Layout of Windows";
            this.tileHorizontalWindowsMenu.Click += new System.EventHandler(this.tileHorizontalWindowsMenuClick);
            // 
            // openCarListWindowsMenu
            // 
            this.openCarListWindowsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.openCarListWindowsMenu.Name = "openCarListWindowsMenu";
            this.openCarListWindowsMenu.Size = new System.Drawing.Size(227, 28);
            this.openCarListWindowsMenu.Text = "Open Car &List";
            this.openCarListWindowsMenu.ToolTipText = "Open Car List form";
            this.openCarListWindowsMenu.Click += new System.EventHandler(this.openCarListWindowsMenuClick);
            // 
            // openAverageUnitsWindowsMenu
            // 
            this.openAverageUnitsWindowsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.openAverageUnitsWindowsMenu.Name = "openAverageUnitsWindowsMenu";
            this.openAverageUnitsWindowsMenu.Size = new System.Drawing.Size(227, 28);
            this.openAverageUnitsWindowsMenu.Text = "Open &Average Units";
            this.openAverageUnitsWindowsMenu.ToolTipText = "Open Average Units Shipped form";
            this.openAverageUnitsWindowsMenu.Click += new System.EventHandler(this.openAverageUnitsWindowsMenuClick);
            // 
            // youKnowWhatToolStripMenuItem
            // 
            this.youKnowWhatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.youKnowWhatToolStripMenuItem.Name = "youKnowWhatToolStripMenuItem";
            this.youKnowWhatToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
            this.youKnowWhatToolStripMenuItem.Text = "You know &What?";
            this.youKnowWhatToolStripMenuItem.ToolTipText = "Click To Find Out";
            this.youKnowWhatToolStripMenuItem.Click += new System.EventHandler(this.youKnowWhatToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutHelpMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(56, 27);
            this.helpMenu.Text = "&Help";
            this.helpMenu.ToolTipText = "HELP";
            // 
            // aboutHelpMenu
            // 
            this.aboutHelpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.aboutHelpMenu.Name = "aboutHelpMenu";
            this.aboutHelpMenu.Size = new System.Drawing.Size(125, 28);
            this.aboutHelpMenu.Text = "&About";
            this.aboutHelpMenu.ToolTipText = "Info about application";
            this.aboutHelpMenu.Click += new System.EventHandler(this.aboutHelpMenuClick);
            // 
            // toolStripEditor
            // 
            this.toolStripEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.toolStripEditor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton});
            this.toolStripEditor.Location = new System.Drawing.Point(0, 31);
            this.toolStripEditor.Name = "toolStripEditor";
            this.toolStripEditor.Size = new System.Drawing.Size(957, 25);
            this.toolStripEditor.Stretch = true;
            this.toolStripEditor.TabIndex = 3;
            this.toolStripEditor.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButtonClick);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButtonClick);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButtonClick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(957, 569);
            this.Controls.Add(this.toolStripEditor);
            this.Controls.Add(this.menuStripMultiEditor);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMultiEditor;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Text Editor";
            this.menuStripMultiEditor.ResumeLayout(false);
            this.menuStripMultiEditor.PerformLayout();
            this.toolStripEditor.ResumeLayout(false);
            this.toolStripEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMultiEditor;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem closeFileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem cutEditMenu;
        private System.Windows.Forms.ToolStripMenuItem copyEditMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteEditMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowsMenu;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalWindowsMenu;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalWindowsMenu;
        private System.Windows.Forms.ToolStripMenuItem openCarListWindowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem openAverageUnitsWindowsMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutHelpMenu;
        private System.Windows.Forms.ToolTip toolTipMultiEditor;
        private System.Windows.Forms.ToolStripMenuItem youKnowWhatToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripEditor;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
    }
}

