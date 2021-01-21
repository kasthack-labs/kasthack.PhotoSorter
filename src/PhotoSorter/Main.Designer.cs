namespace PhotoSorter
{
    partial class Main
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetWD = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKeymapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKeymapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.Panel();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnAddMap = new System.Windows.Forms.Button();
            this.btnDelMap = new System.Windows.Forms.Button();
            this.lstMaps = new System.Windows.Forms.ListBox();
            this.lblMaps = new System.Windows.Forms.Label();
            this.pctView = new System.Windows.Forms.PictureBox();
            this.fbdWd = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdMap = new System.Windows.Forms.SaveFileDialog();
            this.ofdMap = new System.Windows.Forms.OpenFileDialog();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            this.menuMove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1754, 33);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetWD,
            this.saveKeymapToolStripMenuItem,
            this.loadKeymapToolStripMenuItem,
            this.loadCSVToolStripMenuItem,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 29);
            this.menuFile.Text = "File";
            // 
            // menuSetWD
            // 
            this.menuSetWD.Name = "menuSetWD";
            this.menuSetWD.Size = new System.Drawing.Size(283, 34);
            this.menuSetWD.Text = "Set working directory";
            this.menuSetWD.Click += new System.EventHandler(this.MenuSetWD_Click);
            // 
            // saveKeymapToolStripMenuItem
            // 
            this.saveKeymapToolStripMenuItem.Name = "saveKeymapToolStripMenuItem";
            this.saveKeymapToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.saveKeymapToolStripMenuItem.Text = "Save keymap";
            this.saveKeymapToolStripMenuItem.Click += new System.EventHandler(this.SaveKeymapToolStripMenuItem_Click);
            // 
            // loadKeymapToolStripMenuItem
            // 
            this.loadKeymapToolStripMenuItem.Name = "loadKeymapToolStripMenuItem";
            this.loadKeymapToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.loadKeymapToolStripMenuItem.Text = "Load keymap";
            this.loadKeymapToolStripMenuItem.Click += new System.EventHandler(this.LoadKeymapToolStripMenuItem_Click);
            // 
            // loadCSVToolStripMenuItem
            // 
            this.loadCSVToolStripMenuItem.Name = "loadCSVToolStripMenuItem";
            this.loadCSVToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.loadCSVToolStripMenuItem.Text = "Load CSV";
            this.loadCSVToolStripMenuItem.Click += new System.EventHandler(this.LoadCSVToolStripMenuItem_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(283, 34);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMove});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(58, 29);
            this.menuEdit.Text = "Edit";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 29);
            this.menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(164, 34);
            this.menuAbout.Text = "About";
            // 
            // Tools
            // 
            this.Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools.Controls.Add(this.lblFiles);
            this.Tools.Controls.Add(this.lstFiles);
            this.Tools.Controls.Add(this.btnAddMap);
            this.Tools.Controls.Add(this.btnDelMap);
            this.Tools.Controls.Add(this.lstMaps);
            this.Tools.Controls.Add(this.lblMaps);
            this.Tools.Location = new System.Drawing.Point(1438, 42);
            this.Tools.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(315, 962);
            this.Tools.TabIndex = 1;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(10, 485);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(42, 20);
            this.lblFiles.TabIndex = 5;
            this.lblFiles.Text = "Files";
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 20;
            this.lstFiles.Location = new System.Drawing.Point(10, 514);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(284, 424);
            this.lstFiles.TabIndex = 4;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.LstFiles_SelectedIndexChanged);
            this.lstFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstFiles_KeyDown);
            // 
            // btnAddMap
            // 
            this.btnAddMap.Location = new System.Drawing.Point(198, 428);
            this.btnAddMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMap.Name = "btnAddMap";
            this.btnAddMap.Size = new System.Drawing.Size(112, 35);
            this.btnAddMap.TabIndex = 3;
            this.btnAddMap.Text = "+";
            this.btnAddMap.UseVisualStyleBackColor = true;
            this.btnAddMap.Click += new System.EventHandler(this.BtnAddMap_Click);
            // 
            // btnDelMap
            // 
            this.btnDelMap.Location = new System.Drawing.Point(10, 428);
            this.btnDelMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelMap.Name = "btnDelMap";
            this.btnDelMap.Size = new System.Drawing.Size(112, 35);
            this.btnDelMap.TabIndex = 2;
            this.btnDelMap.Text = "-";
            this.btnDelMap.UseVisualStyleBackColor = true;
            this.btnDelMap.Click += new System.EventHandler(this.BtnDelMap_Click);
            // 
            // lstMaps
            // 
            this.lstMaps.Enabled = false;
            this.lstMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMaps.FormattingEnabled = true;
            this.lstMaps.ItemHeight = 29;
            this.lstMaps.Location = new System.Drawing.Point(10, 32);
            this.lstMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.Size = new System.Drawing.Size(298, 381);
            this.lstMaps.Sorted = true;
            this.lstMaps.TabIndex = 1;
            this.lstMaps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstMaps_KeyDown);
            // 
            // lblMaps
            // 
            this.lblMaps.AutoSize = true;
            this.lblMaps.Location = new System.Drawing.Point(6, 6);
            this.lblMaps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaps.Name = "lblMaps";
            this.lblMaps.Size = new System.Drawing.Size(78, 20);
            this.lblMaps.TabIndex = 0;
            this.lblMaps.Text = "Mappings";
            // 
            // pctView
            // 
            this.pctView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctView.Location = new System.Drawing.Point(20, 48);
            this.pctView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctView.Name = "pctView";
            this.pctView.Size = new System.Drawing.Size(1394, 955);
            this.pctView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctView.TabIndex = 2;
            this.pctView.TabStop = false;
            // 
            // ofdCsv
            // 
            this.ofdCsv.FileName = "ofdCsv";
            this.ofdCsv.Filter = "CSV files|*.csv";
            // 
            // menuMove
            // 
            this.menuMove.Name = "menuMove";
            this.menuMove.Size = new System.Drawing.Size(270, 34);
            this.menuMove.Text = "Move";
            this.menuMove.Click += new System.EventHandler(this.MenuMove_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 1022);
            this.Controls.Add(this.pctView);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.menuMain);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Photo sorter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlKeyDown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Panel Tools;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnAddMap;
        private System.Windows.Forms.Button btnDelMap;
        private System.Windows.Forms.ListBox lstMaps;
        private System.Windows.Forms.Label lblMaps;
        private System.Windows.Forms.PictureBox pctView;
        private System.Windows.Forms.ToolStripMenuItem menuSetWD;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.FolderBrowserDialog fbdWd;
        private System.Windows.Forms.ToolStripMenuItem saveKeymapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKeymapToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdMap;
        private System.Windows.Forms.OpenFileDialog ofdMap;
        private System.Windows.Forms.ToolStripMenuItem loadCSVToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
        private System.Windows.Forms.ToolStripMenuItem menuMove;
    }
}

