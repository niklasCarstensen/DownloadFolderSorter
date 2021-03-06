﻿namespace DownloadFolderSorter
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.OperationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNameMatching = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bApply = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.tFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBrowser = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.delayPicker = new System.Windows.Forms.TrackBar();
            this.lDelay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperationName,
            this.FileNameMatching,
            this.ToFolder});
            this.dataGrid.Enabled = false;
            this.dataGrid.Location = new System.Drawing.Point(13, 41);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(609, 195);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_CellMouseClick);
            // 
            // OperationName
            // 
            this.OperationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OperationName.HeaderText = "Name";
            this.OperationName.Name = "OperationName";
            this.OperationName.Width = 60;
            // 
            // FileNameMatching
            // 
            this.FileNameMatching.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileNameMatching.HeaderText = "File Name Matching";
            this.FileNameMatching.Name = "FileNameMatching";
            this.FileNameMatching.Width = 115;
            // 
            // ToFolder
            // 
            this.ToFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToFolder.HeaderText = "Target Folder";
            this.ToFolder.Name = "ToFolder";
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.Enabled = false;
            this.bApply.Location = new System.Drawing.Point(523, 242);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(99, 23);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply and Sort";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStatus.AutoSize = true;
            this.lStatus.Enabled = false;
            this.lStatus.Location = new System.Drawing.Point(12, 247);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(43, 13);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Status: ";
            // 
            // tFolder
            // 
            this.tFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFolder.Location = new System.Drawing.Point(108, 14);
            this.tFolder.Name = "tFolder";
            this.tFolder.Size = new System.Drawing.Size(409, 20);
            this.tFolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Download Folder:";
            // 
            // bBrowser
            // 
            this.bBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowser.Location = new System.Drawing.Point(523, 12);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(99, 23);
            this.bBrowser.TabIndex = 6;
            this.bBrowser.Text = "Browse Folders";
            this.bBrowser.UseVisualStyleBackColor = true;
            this.bBrowser.Click += new System.EventHandler(this.BBrowser_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Download Folder Sorter";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // delayPicker
            // 
            this.delayPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delayPicker.Location = new System.Drawing.Point(388, 242);
            this.delayPicker.Maximum = 15;
            this.delayPicker.Name = "delayPicker";
            this.delayPicker.Size = new System.Drawing.Size(129, 45);
            this.delayPicker.TabIndex = 7;
            this.delayPicker.Value = 3;
            this.delayPicker.Scroll += new System.EventHandler(this.DelayPicker_Scroll);
            this.delayPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DelayPicker_MouseUp);
            // 
            // lDelay
            // 
            this.lDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lDelay.AutoSize = true;
            this.lDelay.Location = new System.Drawing.Point(313, 247);
            this.lDelay.Name = "lDelay";
            this.lDelay.Size = new System.Drawing.Size(69, 13);
            this.lDelay.TabIndex = 8;
            this.lDelay.Text = "Delay: 3 sec.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 277);
            this.Controls.Add(this.lDelay);
            this.Controls.Add(this.delayPicker);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tFolder);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 250);
            this.Name = "MainForm";
            this.Text = "Download Folder Sorter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TextBox tFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameMatching;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToFolder;
        private System.Windows.Forms.Button bBrowser;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TrackBar delayPicker;
        private System.Windows.Forms.Label lDelay;
    }
}

