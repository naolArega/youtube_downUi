namespace youtube_downUi
{
    partial class Settings
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("General options");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Download");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("File system");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Thumbnail");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Verbosity");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Workaround");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Subtitle");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Authentication");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Adode pass");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Post processing");
            this.settingTreeView = new System.Windows.Forms.TreeView();
            this.generalOptionPn = new System.Windows.Forms.Panel();
            this.updateLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.ignoreCbx = new System.Windows.Forms.CheckBox();
            this.ignoreCfgCbx = new System.Windows.Forms.CheckBox();
            this.pathTxb = new System.Windows.Forms.TextBox();
            this.browseCfg = new System.Windows.Forms.Button();
            this.pathLbl = new System.Windows.Forms.Label();
            this.proxyLbl = new System.Windows.Forms.Label();
            this.proxyTxb = new System.Windows.Forms.TextBox();
            this.ipv4Rbtn = new System.Windows.Forms.RadioButton();
            this.ipv6Rbtn = new System.Windows.Forms.RadioButton();
            this.downloadPnl = new System.Windows.Forms.Panel();
            this.maxDownLbl = new System.Windows.Forms.Label();
            this.maxDownUd = new System.Windows.Forms.NumericUpDown();
            this.maxDownLbl2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maxRetryLbl = new System.Windows.Forms.Label();
            this.fragUd = new System.Windows.Forms.NumericUpDown();
            this.maxFragRetryLbl = new System.Windows.Forms.Label();
            this.skipFragcbx = new System.Windows.Forms.CheckBox();
            this.abortFragCbx = new System.Windows.Forms.CheckBox();
            this.bufferSzUd = new System.Windows.Forms.NumericUpDown();
            this.downBufferLbl = new System.Windows.Forms.Label();
            this.httpChUd = new System.Windows.Forms.NumericUpDown();
            this.httpChunkLb = new System.Windows.Forms.Label();
            this.downRevPlCbx = new System.Windows.Forms.CheckBox();
            this.downRandPlCbx = new System.Windows.Forms.CheckBox();
            this.ffmpegDownCbx = new System.Windows.Forms.CheckBox();
            this.generalOptionPn.SuspendLayout();
            this.downloadPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDownUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fragUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bufferSzUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpChUd)).BeginInit();
            this.SuspendLayout();
            // 
            // settingTreeView
            // 
            this.settingTreeView.Location = new System.Drawing.Point(12, 12);
            this.settingTreeView.Name = "settingTreeView";
            treeNode11.Name = "Node0";
            treeNode11.Tag = "0";
            treeNode11.Text = "General options";
            treeNode12.Name = "Node1";
            treeNode12.Tag = "1";
            treeNode12.Text = "Download";
            treeNode13.Name = "Node2";
            treeNode13.Tag = "2";
            treeNode13.Text = "File system";
            treeNode14.Name = "Node3";
            treeNode14.Tag = "3";
            treeNode14.Text = "Thumbnail";
            treeNode15.Name = "Node4";
            treeNode15.Tag = "4";
            treeNode15.Text = "Verbosity";
            treeNode16.Name = "Node5";
            treeNode16.Tag = "5";
            treeNode16.Text = "Workaround";
            treeNode17.Name = "Node6";
            treeNode17.Tag = "6";
            treeNode17.Text = "Subtitle";
            treeNode18.Name = "Node7";
            treeNode18.Tag = "7";
            treeNode18.Text = "Authentication";
            treeNode19.Name = "Node8";
            treeNode19.Tag = "8";
            treeNode19.Text = "Adode pass";
            treeNode20.Name = "Node9";
            treeNode20.Tag = "9";
            treeNode20.Text = "Post processing";
            this.settingTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.settingTreeView.Size = new System.Drawing.Size(129, 367);
            this.settingTreeView.TabIndex = 0;
            this.settingTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.settingTreeView_NodeMouseClick);
            // 
            // generalOptionPn
            // 
            this.generalOptionPn.Controls.Add(this.ipv6Rbtn);
            this.generalOptionPn.Controls.Add(this.ipv4Rbtn);
            this.generalOptionPn.Controls.Add(this.proxyLbl);
            this.generalOptionPn.Controls.Add(this.proxyTxb);
            this.generalOptionPn.Controls.Add(this.pathLbl);
            this.generalOptionPn.Controls.Add(this.browseCfg);
            this.generalOptionPn.Controls.Add(this.pathTxb);
            this.generalOptionPn.Controls.Add(this.ignoreCfgCbx);
            this.generalOptionPn.Controls.Add(this.ignoreCbx);
            this.generalOptionPn.Controls.Add(this.updateBtn);
            this.generalOptionPn.Controls.Add(this.updateLbl);
            this.generalOptionPn.Location = new System.Drawing.Point(148, 13);
            this.generalOptionPn.Name = "generalOptionPn";
            this.generalOptionPn.Size = new System.Drawing.Size(364, 366);
            this.generalOptionPn.TabIndex = 1;
            this.generalOptionPn.Tag = "0";
            // 
            // updateLbl
            // 
            this.updateLbl.AutoSize = true;
            this.updateLbl.Location = new System.Drawing.Point(17, 22);
            this.updateLbl.Name = "updateLbl";
            this.updateLbl.Size = new System.Drawing.Size(158, 13);
            this.updateLbl.TabIndex = 0;
            this.updateLbl.Text = "Update the youtube-dl software:";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(181, 17);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // ignoreCbx
            // 
            this.ignoreCbx.AutoSize = true;
            this.ignoreCbx.Location = new System.Drawing.Point(20, 59);
            this.ignoreCbx.Name = "ignoreCbx";
            this.ignoreCbx.Size = new System.Drawing.Size(80, 17);
            this.ignoreCbx.TabIndex = 3;
            this.ignoreCbx.Text = "Ignore error";
            this.ignoreCbx.UseVisualStyleBackColor = true;
            // 
            // ignoreCfgCbx
            // 
            this.ignoreCfgCbx.AutoSize = true;
            this.ignoreCfgCbx.Location = new System.Drawing.Point(20, 140);
            this.ignoreCfgCbx.Name = "ignoreCfgCbx";
            this.ignoreCfgCbx.Size = new System.Drawing.Size(88, 17);
            this.ignoreCfgCbx.TabIndex = 4;
            this.ignoreCfgCbx.Text = "Ignore config";
            this.ignoreCfgCbx.UseVisualStyleBackColor = true;
            // 
            // pathTxb
            // 
            this.pathTxb.Location = new System.Drawing.Point(20, 104);
            this.pathTxb.Name = "pathTxb";
            this.pathTxb.Size = new System.Drawing.Size(224, 20);
            this.pathTxb.TabIndex = 5;
            // 
            // browseCfg
            // 
            this.browseCfg.Location = new System.Drawing.Point(250, 102);
            this.browseCfg.Name = "browseCfg";
            this.browseCfg.Size = new System.Drawing.Size(75, 23);
            this.browseCfg.TabIndex = 6;
            this.browseCfg.Text = "Browse";
            this.browseCfg.UseVisualStyleBackColor = true;
            // 
            // pathLbl
            // 
            this.pathLbl.AutoSize = true;
            this.pathLbl.Location = new System.Drawing.Point(17, 88);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(64, 13);
            this.pathLbl.TabIndex = 7;
            this.pathLbl.Text = "Config path:";
            // 
            // proxyLbl
            // 
            this.proxyLbl.AutoSize = true;
            this.proxyLbl.Location = new System.Drawing.Point(17, 171);
            this.proxyLbl.Name = "proxyLbl";
            this.proxyLbl.Size = new System.Drawing.Size(33, 13);
            this.proxyLbl.TabIndex = 9;
            this.proxyLbl.Text = "Proxy";
            // 
            // proxyTxb
            // 
            this.proxyTxb.Location = new System.Drawing.Point(20, 187);
            this.proxyTxb.Name = "proxyTxb";
            this.proxyTxb.Size = new System.Drawing.Size(224, 20);
            this.proxyTxb.TabIndex = 8;
            // 
            // ipv4Rbtn
            // 
            this.ipv4Rbtn.AutoSize = true;
            this.ipv4Rbtn.Location = new System.Drawing.Point(20, 214);
            this.ipv4Rbtn.Name = "ipv4Rbtn";
            this.ipv4Rbtn.Size = new System.Drawing.Size(78, 17);
            this.ipv4Rbtn.TabIndex = 10;
            this.ipv4Rbtn.TabStop = true;
            this.ipv4Rbtn.Text = "Force IPV4";
            this.ipv4Rbtn.UseVisualStyleBackColor = true;
            // 
            // ipv6Rbtn
            // 
            this.ipv6Rbtn.AutoSize = true;
            this.ipv6Rbtn.Location = new System.Drawing.Point(20, 238);
            this.ipv6Rbtn.Name = "ipv6Rbtn";
            this.ipv6Rbtn.Size = new System.Drawing.Size(77, 17);
            this.ipv6Rbtn.TabIndex = 11;
            this.ipv6Rbtn.TabStop = true;
            this.ipv6Rbtn.Text = "Force IPv6";
            this.ipv6Rbtn.UseVisualStyleBackColor = true;
            // 
            // downloadPnl
            // 
            this.downloadPnl.Controls.Add(this.ffmpegDownCbx);
            this.downloadPnl.Controls.Add(this.downRandPlCbx);
            this.downloadPnl.Controls.Add(this.downRevPlCbx);
            this.downloadPnl.Controls.Add(this.httpChUd);
            this.downloadPnl.Controls.Add(this.httpChunkLb);
            this.downloadPnl.Controls.Add(this.bufferSzUd);
            this.downloadPnl.Controls.Add(this.downBufferLbl);
            this.downloadPnl.Controls.Add(this.abortFragCbx);
            this.downloadPnl.Controls.Add(this.skipFragcbx);
            this.downloadPnl.Controls.Add(this.fragUd);
            this.downloadPnl.Controls.Add(this.maxFragRetryLbl);
            this.downloadPnl.Controls.Add(this.numericUpDown1);
            this.downloadPnl.Controls.Add(this.maxRetryLbl);
            this.downloadPnl.Controls.Add(this.maxDownLbl2);
            this.downloadPnl.Controls.Add(this.maxDownUd);
            this.downloadPnl.Controls.Add(this.maxDownLbl);
            this.downloadPnl.Location = new System.Drawing.Point(148, 12);
            this.downloadPnl.Name = "downloadPnl";
            this.downloadPnl.Size = new System.Drawing.Size(364, 367);
            this.downloadPnl.TabIndex = 2;
            this.downloadPnl.Tag = "1";
            this.downloadPnl.Visible = false;
            // 
            // maxDownLbl
            // 
            this.maxDownLbl.AutoSize = true;
            this.maxDownLbl.Location = new System.Drawing.Point(22, 23);
            this.maxDownLbl.Name = "maxDownLbl";
            this.maxDownLbl.Size = new System.Drawing.Size(124, 13);
            this.maxDownLbl.TabIndex = 0;
            this.maxDownLbl.Text = "Maximum download rate:";
            // 
            // maxDownUd
            // 
            this.maxDownUd.Location = new System.Drawing.Point(150, 21);
            this.maxDownUd.Name = "maxDownUd";
            this.maxDownUd.Size = new System.Drawing.Size(106, 20);
            this.maxDownUd.TabIndex = 1;
            // 
            // maxDownLbl2
            // 
            this.maxDownLbl2.AutoSize = true;
            this.maxDownLbl2.Location = new System.Drawing.Point(262, 23);
            this.maxDownLbl2.Name = "maxDownLbl2";
            this.maxDownLbl2.Size = new System.Drawing.Size(56, 13);
            this.maxDownLbl2.TabIndex = 2;
            this.maxDownLbl2.Text = "Byte / sec";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(150, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // maxRetryLbl
            // 
            this.maxRetryLbl.AutoSize = true;
            this.maxRetryLbl.Location = new System.Drawing.Point(61, 49);
            this.maxRetryLbl.Name = "maxRetryLbl";
            this.maxRetryLbl.Size = new System.Drawing.Size(85, 13);
            this.maxRetryLbl.TabIndex = 3;
            this.maxRetryLbl.Text = "Maximum retries:";
            // 
            // fragUd
            // 
            this.fragUd.Location = new System.Drawing.Point(150, 73);
            this.fragUd.Name = "fragUd";
            this.fragUd.Size = new System.Drawing.Size(69, 20);
            this.fragUd.TabIndex = 6;
            // 
            // maxFragRetryLbl
            // 
            this.maxFragRetryLbl.AutoSize = true;
            this.maxFragRetryLbl.Location = new System.Drawing.Point(15, 75);
            this.maxFragRetryLbl.Name = "maxFragRetryLbl";
            this.maxFragRetryLbl.Size = new System.Drawing.Size(129, 13);
            this.maxFragRetryLbl.TabIndex = 5;
            this.maxFragRetryLbl.Text = "Maximum fragment retries:";
            // 
            // skipFragcbx
            // 
            this.skipFragcbx.AutoSize = true;
            this.skipFragcbx.Location = new System.Drawing.Point(76, 99);
            this.skipFragcbx.Name = "skipFragcbx";
            this.skipFragcbx.Size = new System.Drawing.Size(153, 17);
            this.skipFragcbx.TabIndex = 7;
            this.skipFragcbx.Text = "Skip unavailable fragments";
            this.skipFragcbx.UseVisualStyleBackColor = true;
            // 
            // abortFragCbx
            // 
            this.abortFragCbx.AutoSize = true;
            this.abortFragCbx.Location = new System.Drawing.Point(76, 122);
            this.abortFragCbx.Name = "abortFragCbx";
            this.abortFragCbx.Size = new System.Drawing.Size(157, 17);
            this.abortFragCbx.TabIndex = 8;
            this.abortFragCbx.Text = "Abort unavailable fragments";
            this.abortFragCbx.UseVisualStyleBackColor = true;
            // 
            // bufferSzUd
            // 
            this.bufferSzUd.Location = new System.Drawing.Point(150, 145);
            this.bufferSzUd.Name = "bufferSzUd";
            this.bufferSzUd.Size = new System.Drawing.Size(106, 20);
            this.bufferSzUd.TabIndex = 10;
            // 
            // downBufferLbl
            // 
            this.downBufferLbl.AutoSize = true;
            this.downBufferLbl.Location = new System.Drawing.Point(85, 147);
            this.downBufferLbl.Name = "downBufferLbl";
            this.downBufferLbl.Size = new System.Drawing.Size(59, 13);
            this.downBufferLbl.TabIndex = 9;
            this.downBufferLbl.Text = "Buffer size:";
            // 
            // httpChUd
            // 
            this.httpChUd.Location = new System.Drawing.Point(150, 171);
            this.httpChUd.Name = "httpChUd";
            this.httpChUd.Size = new System.Drawing.Size(106, 20);
            this.httpChUd.TabIndex = 12;
            // 
            // httpChunkLb
            // 
            this.httpChunkLb.AutoSize = true;
            this.httpChunkLb.Location = new System.Drawing.Point(60, 173);
            this.httpChunkLb.Name = "httpChunkLb";
            this.httpChunkLb.Size = new System.Drawing.Size(84, 13);
            this.httpChunkLb.TabIndex = 11;
            this.httpChunkLb.Text = "Http chunk size:";
            // 
            // downRevPlCbx
            // 
            this.downRevPlCbx.AutoSize = true;
            this.downRevPlCbx.Location = new System.Drawing.Point(76, 197);
            this.downRevPlCbx.Name = "downRevPlCbx";
            this.downRevPlCbx.Size = new System.Drawing.Size(157, 17);
            this.downRevPlCbx.TabIndex = 13;
            this.downRevPlCbx.Text = "Download playlist in reverse";
            this.downRevPlCbx.UseVisualStyleBackColor = true;
            // 
            // downRandPlCbx
            // 
            this.downRandPlCbx.AutoSize = true;
            this.downRandPlCbx.Location = new System.Drawing.Point(76, 220);
            this.downRandPlCbx.Name = "downRandPlCbx";
            this.downRandPlCbx.Size = new System.Drawing.Size(157, 17);
            this.downRandPlCbx.TabIndex = 14;
            this.downRandPlCbx.Text = "Download playlist in random";
            this.downRandPlCbx.UseVisualStyleBackColor = true;
            // 
            // ffmpegDownCbx
            // 
            this.ffmpegDownCbx.AutoSize = true;
            this.ffmpegDownCbx.Location = new System.Drawing.Point(76, 243);
            this.ffmpegDownCbx.Name = "ffmpegDownCbx";
            this.ffmpegDownCbx.Size = new System.Drawing.Size(141, 17);
            this.ffmpegDownCbx.TabIndex = 15;
            this.ffmpegDownCbx.Text = "Use ffmpeg to download";
            this.ffmpegDownCbx.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.downloadPnl);
            this.Controls.Add(this.generalOptionPn);
            this.Controls.Add(this.settingTreeView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 430);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.generalOptionPn.ResumeLayout(false);
            this.generalOptionPn.PerformLayout();
            this.downloadPnl.ResumeLayout(false);
            this.downloadPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDownUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fragUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bufferSzUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpChUd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView settingTreeView;
        private System.Windows.Forms.Panel generalOptionPn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label updateLbl;
        private System.Windows.Forms.RadioButton ipv6Rbtn;
        private System.Windows.Forms.RadioButton ipv4Rbtn;
        private System.Windows.Forms.Label proxyLbl;
        private System.Windows.Forms.TextBox proxyTxb;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.Button browseCfg;
        private System.Windows.Forms.TextBox pathTxb;
        private System.Windows.Forms.CheckBox ignoreCfgCbx;
        private System.Windows.Forms.CheckBox ignoreCbx;
        private System.Windows.Forms.Panel downloadPnl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label maxRetryLbl;
        private System.Windows.Forms.Label maxDownLbl2;
        private System.Windows.Forms.NumericUpDown maxDownUd;
        private System.Windows.Forms.Label maxDownLbl;
        private System.Windows.Forms.CheckBox ffmpegDownCbx;
        private System.Windows.Forms.CheckBox downRandPlCbx;
        private System.Windows.Forms.CheckBox downRevPlCbx;
        private System.Windows.Forms.NumericUpDown httpChUd;
        private System.Windows.Forms.Label httpChunkLb;
        private System.Windows.Forms.NumericUpDown bufferSzUd;
        private System.Windows.Forms.Label downBufferLbl;
        private System.Windows.Forms.CheckBox abortFragCbx;
        private System.Windows.Forms.CheckBox skipFragcbx;
        private System.Windows.Forms.NumericUpDown fragUd;
        private System.Windows.Forms.Label maxFragRetryLbl;
    }
}