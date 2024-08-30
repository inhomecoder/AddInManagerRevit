namespace AddInManager
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.DataGridViewAddIns = new System.Windows.Forms.DataGridView();
            this.AddinName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSpecific = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddinPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEnDis = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnInvert = new System.Windows.Forms.Button();
            this.BtnSelEnabled = new System.Windows.Forms.Button();
            this.BtnSelDis = new System.Windows.Forms.Button();
            this.lblChooseVersion = new System.Windows.Forms.Label();
            this.CboVersion = new System.Windows.Forms.ComboBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.ContextMenuStripDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemShowContent = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoToFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDelimiter1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemEnabledInRevit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUninstall = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.PictureBoxRevitIco = new System.Windows.Forms.PictureBox();
            this.ToolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.BtnEnDisGlobal = new System.Windows.Forms.Button();
            this.ButtonRevitVersions = new System.Windows.Forms.Button();
            this.cboScope = new System.Windows.Forms.ComboBox();
            this.lblChooseScope = new System.Windows.Forms.Label();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.ButtonAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddIns)).BeginInit();
            this.ContextMenuStripDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRevitIco)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewAddIns
            // 
            this.DataGridViewAddIns.AllowUserToAddRows = false;
            this.DataGridViewAddIns.AllowUserToDeleteRows = false;
            this.DataGridViewAddIns.AllowUserToResizeRows = false;
            this.DataGridViewAddIns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewAddIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAddIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAddIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddinName,
            this.UserSpecific,
            this.IsEnabled,
            this.Version,
            this.AddinPath});
            this.DataGridViewAddIns.Location = new System.Drawing.Point(22, 72);
            this.DataGridViewAddIns.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DataGridViewAddIns.Name = "DataGridViewAddIns";
            this.DataGridViewAddIns.RowHeadersVisible = false;
            this.DataGridViewAddIns.RowHeadersWidth = 72;
            this.DataGridViewAddIns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAddIns.Size = new System.Drawing.Size(1677, 354);
            this.DataGridViewAddIns.TabIndex = 11;
            this.DataGridViewAddIns.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewAddIns_CellMouseDown);
            this.DataGridViewAddIns.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewAddIns_CellMouseUp);
            this.DataGridViewAddIns.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewAddIns_ColumnHeaderMouseClick);
            // 
            // AddinName
            // 
            this.AddinName.FillWeight = 12.1988F;
            this.AddinName.HeaderText = "Name";
            this.AddinName.MinimumWidth = 9;
            this.AddinName.Name = "AddinName";
            this.AddinName.ReadOnly = true;
            this.AddinName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // UserSpecific
            // 
            this.UserSpecific.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserSpecific.FillWeight = 176.2048F;
            this.UserSpecific.HeaderText = "User Specific";
            this.UserSpecific.MinimumWidth = 9;
            this.UserSpecific.Name = "UserSpecific";
            this.UserSpecific.ReadOnly = true;
            this.UserSpecific.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserSpecific.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.UserSpecific.Width = 150;
            // 
            // IsEnabled
            // 
            this.IsEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsEnabled.FillWeight = 6.0994F;
            this.IsEnabled.HeaderText = "Enabled";
            this.IsEnabled.MinimumWidth = 9;
            this.IsEnabled.Name = "IsEnabled";
            this.IsEnabled.ReadOnly = true;
            this.IsEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IsEnabled.Width = 80;
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Version.FillWeight = 6.0994F;
            this.Version.HeaderText = "Version";
            this.Version.MinimumWidth = 9;
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Version.Width = 80;
            // 
            // AddinPath
            // 
            this.AddinPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddinPath.FillWeight = 24.3976F;
            this.AddinPath.HeaderText = ".ADDIN Path";
            this.AddinPath.MinimumWidth = 9;
            this.AddinPath.Name = "AddinPath";
            this.AddinPath.ReadOnly = true;
            this.AddinPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BtnEnDis
            // 
            this.BtnEnDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEnDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnDis.Location = new System.Drawing.Point(1485, 438);
            this.BtnEnDis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnEnDis.Name = "BtnEnDis";
            this.BtnEnDis.Size = new System.Drawing.Size(215, 42);
            this.BtnEnDis.TabIndex = 7;
            this.BtnEnDis.Text = "&Enable / Disable";
            this.ToolTipForm.SetToolTip(this.BtnEnDis, "Enable / disable highlighted add-ins");
            this.BtnEnDis.UseVisualStyleBackColor = true;
            this.BtnEnDis.Click += new System.EventHandler(this.BtnEnDis_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAll.Location = new System.Drawing.Point(22, 438);
            this.BtnAll.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(194, 42);
            this.BtnAll.TabIndex = 2;
            this.BtnAll.Text = "Select &all";
            this.ToolTipForm.SetToolTip(this.BtnAll, "Highlight all");
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnInvert
            // 
            this.BtnInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnInvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInvert.Location = new System.Drawing.Point(240, 438);
            this.BtnInvert.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnInvert.Name = "BtnInvert";
            this.BtnInvert.Size = new System.Drawing.Size(194, 42);
            this.BtnInvert.TabIndex = 3;
            this.BtnInvert.Text = "&Invert select";
            this.ToolTipForm.SetToolTip(this.BtnInvert, "Swap highlighting");
            this.BtnInvert.UseVisualStyleBackColor = true;
            this.BtnInvert.Click += new System.EventHandler(this.BtnInvert_Click);
            // 
            // BtnSelEnabled
            // 
            this.BtnSelEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSelEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelEnabled.Location = new System.Drawing.Point(504, 438);
            this.BtnSelEnabled.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSelEnabled.Name = "BtnSelEnabled";
            this.BtnSelEnabled.Size = new System.Drawing.Size(194, 42);
            this.BtnSelEnabled.TabIndex = 4;
            this.BtnSelEnabled.Text = "&Select Enabled";
            this.ToolTipForm.SetToolTip(this.BtnSelEnabled, "Highlight \"Enabled\" checked");
            this.BtnSelEnabled.UseVisualStyleBackColor = true;
            this.BtnSelEnabled.Click += new System.EventHandler(this.BtnSelEnabled_Click);
            // 
            // BtnSelDis
            // 
            this.BtnSelDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSelDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelDis.Location = new System.Drawing.Point(721, 438);
            this.BtnSelDis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSelDis.Name = "BtnSelDis";
            this.BtnSelDis.Size = new System.Drawing.Size(194, 42);
            this.BtnSelDis.TabIndex = 5;
            this.BtnSelDis.Text = "Select &Disabled";
            this.ToolTipForm.SetToolTip(this.BtnSelDis, "Highlight \"Enabled\" unchecked");
            this.BtnSelDis.UseVisualStyleBackColor = true;
            this.BtnSelDis.Click += new System.EventHandler(this.BtnSelDis_Click);
            // 
            // lblChooseVersion
            // 
            this.lblChooseVersion.AutoSize = true;
            this.lblChooseVersion.Location = new System.Drawing.Point(22, 21);
            this.lblChooseVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChooseVersion.Name = "lblChooseVersion";
            this.lblChooseVersion.Size = new System.Drawing.Size(159, 25);
            this.lblChooseVersion.TabIndex = 0;
            this.lblChooseVersion.Text = "Choose Version:";
            // 
            // CboVersion
            // 
            this.CboVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.CboVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVersion.FormattingEnabled = true;
            this.CboVersion.Location = new System.Drawing.Point(194, 17);
            this.CboVersion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CboVersion.Name = "CboVersion";
            this.CboVersion.Size = new System.Drawing.Size(219, 32);
            this.CboVersion.TabIndex = 0;
            this.CboVersion.SelectedIndexChanged += new System.EventHandler(this.Cbo_SelectedIndexChanged);
            this.CboVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cbo_MouseMove);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbout.Location = new System.Drawing.Point(1604, 17);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(95, 42);
            this.BtnAbout.TabIndex = 10;
            this.BtnAbout.Text = "About";
            this.ToolTipForm.SetToolTip(this.BtnAbout, "Information");
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // ContextMenuStripDGV
            // 
            this.ContextMenuStripDGV.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ContextMenuStripDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemShowContent,
            this.ToolStripMenuItemGoToFolder,
            this.ToolStripDelimiter1,
            this.ToolStripMenuItemEnabledInRevit,
            this.ToolStripMenuItemUninstall});
            this.ContextMenuStripDGV.Name = "ContextMenuStripDGV";
            this.ContextMenuStripDGV.Size = new System.Drawing.Size(495, 154);
            // 
            // ToolStripMenuItemShowContent
            // 
            this.ToolStripMenuItemShowContent.Name = "ToolStripMenuItemShowContent";
            this.ToolStripMenuItemShowContent.Size = new System.Drawing.Size(494, 36);
            this.ToolStripMenuItemShowContent.Text = "&Show .addin content";
            this.ToolStripMenuItemShowContent.Click += new System.EventHandler(this.ToolStripMenuItemShowContent_Click);
            // 
            // ToolStripMenuItemGoToFolder
            // 
            this.ToolStripMenuItemGoToFolder.Name = "ToolStripMenuItemGoToFolder";
            this.ToolStripMenuItemGoToFolder.Size = new System.Drawing.Size(494, 36);
            this.ToolStripMenuItemGoToFolder.Text = "&Go to .addin folder";
            this.ToolStripMenuItemGoToFolder.Click += new System.EventHandler(this.ToolStripMenuItemGoToFolder_Click);
            // 
            // ToolStripDelimiter1
            // 
            this.ToolStripDelimiter1.Name = "ToolStripDelimiter1";
            this.ToolStripDelimiter1.Size = new System.Drawing.Size(491, 6);
            // 
            // ToolStripMenuItemEnabledInRevit
            // 
            this.ToolStripMenuItemEnabledInRevit.Name = "ToolStripMenuItemEnabledInRevit";
            this.ToolStripMenuItemEnabledInRevit.Size = new System.Drawing.Size(494, 36);
            this.ToolStripMenuItemEnabledInRevit.Text = "Prompt add-in &security notion in Revit again";
            this.ToolStripMenuItemEnabledInRevit.Click += new System.EventHandler(this.ToolStripMenuItemEnabledInRevit_Click);
            // 
            // ToolStripMenuItemUninstall
            // 
            this.ToolStripMenuItemUninstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemUninstall.ForeColor = System.Drawing.Color.Maroon;
            this.ToolStripMenuItemUninstall.Name = "ToolStripMenuItemUninstall";
            this.ToolStripMenuItemUninstall.Size = new System.Drawing.Size(494, 36);
            this.ToolStripMenuItemUninstall.Text = "&Uninstall add-in";
            this.ToolStripMenuItemUninstall.Click += new System.EventHandler(this.ToolStripMenuItemUninstall_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdmin.Image = global::AddInManager.Properties.Resources.admin;
            this.BtnAdmin.Location = new System.Drawing.Point(1486, 17);
            this.BtnAdmin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(95, 42);
            this.BtnAdmin.TabIndex = 9;
            this.ToolTipForm.SetToolTip(this.BtnAdmin, "Restart as administrator");
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // PictureBoxRevitIco
            // 
            this.PictureBoxRevitIco.Location = new System.Drawing.Point(868, 4);
            this.PictureBoxRevitIco.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxRevitIco.Name = "PictureBoxRevitIco";
            this.PictureBoxRevitIco.Size = new System.Drawing.Size(61, 60);
            this.PictureBoxRevitIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxRevitIco.TabIndex = 9;
            this.PictureBoxRevitIco.TabStop = false;
            // 
            // BtnEnDisGlobal
            // 
            this.BtnEnDisGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEnDisGlobal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnDisGlobal.Location = new System.Drawing.Point(1248, 438);
            this.BtnEnDisGlobal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnEnDisGlobal.Name = "BtnEnDisGlobal";
            this.BtnEnDisGlobal.Size = new System.Drawing.Size(215, 42);
            this.BtnEnDisGlobal.TabIndex = 6;
            this.BtnEnDisGlobal.Text = "Enbl. / Dsbl. globally";
            this.ToolTipForm.SetToolTip(this.BtnEnDisGlobal, "Completely enable/disable add-ins in a version\'s ini file");
            this.BtnEnDisGlobal.UseVisualStyleBackColor = true;
            this.BtnEnDisGlobal.Click += new System.EventHandler(this.BtnEnDisGlobal_Click);
            // 
            // ButtonRevitVersions
            // 
            this.ButtonRevitVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRevitVersions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRevitVersions.Location = new System.Drawing.Point(1368, 17);
            this.ButtonRevitVersions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ButtonRevitVersions.Name = "ButtonRevitVersions";
            this.ButtonRevitVersions.Size = new System.Drawing.Size(95, 42);
            this.ButtonRevitVersions.TabIndex = 8;
            this.ButtonRevitVersions.Text = "Revit";
            this.ToolTipForm.SetToolTip(this.ButtonRevitVersions, "Check Revit versions installed");
            this.ButtonRevitVersions.UseVisualStyleBackColor = true;
            this.ButtonRevitVersions.Click += new System.EventHandler(this.ButtonRevitVersions_Click);
            // 
            // cboScope
            // 
            this.cboScope.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScope.FormattingEnabled = true;
            this.cboScope.Location = new System.Drawing.Point(633, 17);
            this.cboScope.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboScope.Name = "cboScope";
            this.cboScope.Size = new System.Drawing.Size(219, 32);
            this.cboScope.TabIndex = 12;
            this.cboScope.SelectedIndexChanged += new System.EventHandler(this.Cbo_SelectedIndexChanged);
            this.cboScope.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cbo_MouseMove);
            // 
            // lblChooseScope
            // 
            this.lblChooseScope.AutoSize = true;
            this.lblChooseScope.Location = new System.Drawing.Point(461, 21);
            this.lblChooseScope.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChooseScope.Name = "lblChooseScope";
            this.lblChooseScope.Size = new System.Drawing.Size(149, 25);
            this.lblChooseScope.TabIndex = 13;
            this.lblChooseScope.Text = "Choose Scope:";
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAbout.Location = new System.Drawing.Point(1604, 17);
            this.ButtonAbout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(95, 42);
            this.ButtonAbout.TabIndex = 10;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // ButtonAdmin
            // 
            this.ButtonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdmin.Image = global::AddInManager.Properties.Resources.admin;
            this.ButtonAdmin.Location = new System.Drawing.Point(1486, 17);
            this.ButtonAdmin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ButtonAdmin.Name = "ButtonAdmin";
            this.ButtonAdmin.Size = new System.Drawing.Size(95, 42);
            this.ButtonAdmin.TabIndex = 9;
            this.ButtonAdmin.UseVisualStyleBackColor = true;
            this.ButtonAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 502);
            this.Controls.Add(this.ButtonRevitVersions);
            this.Controls.Add(this.cboScope);
            this.Controls.Add(this.lblChooseScope);
            this.Controls.Add(this.ButtonAdmin);
            this.Controls.Add(this.BtnEnDisGlobal);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.PictureBoxRevitIco);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.CboVersion);
            this.Controls.Add(this.lblChooseVersion);
            this.Controls.Add(this.BtnSelDis);
            this.Controls.Add(this.BtnSelEnabled);
            this.Controls.Add(this.BtnInvert);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.BtnEnDis);
            this.Controls.Add(this.DataGridViewAddIns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stantec/DH Revit Add-In Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddIns)).EndInit();
            this.ContextMenuStripDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRevitIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewAddIns;
        private System.Windows.Forms.Button BtnEnDis;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnInvert;
        private System.Windows.Forms.Button BtnSelEnabled;
        private System.Windows.Forms.Button BtnSelDis;
        private System.Windows.Forms.Label lblChooseVersion;
        private System.Windows.Forms.ComboBox CboVersion;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripDGV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowContent;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGoToFolder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEnabledInRevit;
        private System.Windows.Forms.PictureBox PictureBoxRevitIco;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUninstall;
        private System.Windows.Forms.ToolStripSeparator ToolStripDelimiter1;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.ToolTip ToolTipForm;
        private System.Windows.Forms.Button BtnEnDisGlobal;
        private System.Windows.Forms.ComboBox cboScope;
        private System.Windows.Forms.Label lblChooseScope;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddinName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UserSpecific;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddinPath;
        private System.Windows.Forms.Button ButtonRevitVersions;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.Button ButtonAdmin;
    }
}

