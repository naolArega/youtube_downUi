namespace youtube_downUi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.urlTbx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.playlistBx = new System.Windows.Forms.ListView();
            this.dlAllBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.clearCompBtn = new System.Windows.Forms.Button();
            this.expandCollapseBtn = new System.Windows.Forms.Button();
            this.playlistStr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playlistEnd = new System.Windows.Forms.NumericUpDown();
            this.noPlaylist = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FormatCbx = new System.Windows.Forms.ComboBox();
            this.titleMatchBx = new System.Windows.Forms.TextBox();
            this.matchRdo = new System.Windows.Forms.RadioButton();
            this.rjectRdo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downCntEnd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.downCntStr = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.downSzEnd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.downSzStr = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateStr = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.viewEnd = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.viewStr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.matchFilterTbx = new System.Windows.Forms.TextBox();
            this.addToQueueBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.debugLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playlistStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistEnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downCntEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downCntStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downSzEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downSzStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStr)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTbx
            // 
            this.urlTbx.Location = new System.Drawing.Point(58, 65);
            this.urlTbx.Name = "urlTbx";
            this.urlTbx.Size = new System.Drawing.Size(307, 20);
            this.urlTbx.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(466, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Queue list";
            // 
            // playlistBx
            // 
            this.playlistBx.Location = new System.Drawing.Point(454, 29);
            this.playlistBx.Name = "playlistBx";
            this.playlistBx.Size = new System.Drawing.Size(378, 335);
            this.playlistBx.TabIndex = 4;
            this.playlistBx.UseCompatibleStateImageBehavior = false;
            // 
            // dlAllBtn
            // 
            this.dlAllBtn.Location = new System.Drawing.Point(469, 370);
            this.dlAllBtn.Name = "dlAllBtn";
            this.dlAllBtn.Size = new System.Drawing.Size(93, 29);
            this.dlAllBtn.TabIndex = 5;
            this.dlAllBtn.Text = "Download all";
            this.dlAllBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(589, 370);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(68, 29);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // clearCompBtn
            // 
            this.clearCompBtn.Location = new System.Drawing.Point(681, 370);
            this.clearCompBtn.Name = "clearCompBtn";
            this.clearCompBtn.Size = new System.Drawing.Size(124, 29);
            this.clearCompBtn.TabIndex = 7;
            this.clearCompBtn.Text = "Clear completed";
            this.clearCompBtn.UseVisualStyleBackColor = true;
            // 
            // expandCollapseBtn
            // 
            this.expandCollapseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.expandCollapseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandCollapseBtn.Location = new System.Drawing.Point(838, 141);
            this.expandCollapseBtn.Name = "expandCollapseBtn";
            this.expandCollapseBtn.Size = new System.Drawing.Size(16, 76);
            this.expandCollapseBtn.TabIndex = 8;
            this.expandCollapseBtn.Text = "<";
            this.expandCollapseBtn.UseVisualStyleBackColor = false;
            this.expandCollapseBtn.Click += new System.EventHandler(this.expandCollapseBtn_Click);
            // 
            // playlistStr
            // 
            this.playlistStr.Location = new System.Drawing.Point(107, 106);
            this.playlistStr.Name = "playlistStr";
            this.playlistStr.Size = new System.Drawing.Size(53, 20);
            this.playlistStr.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Playlist range:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Up to";
            // 
            // playlistEnd
            // 
            this.playlistEnd.Location = new System.Drawing.Point(205, 104);
            this.playlistEnd.Name = "playlistEnd";
            this.playlistEnd.Size = new System.Drawing.Size(53, 20);
            this.playlistEnd.TabIndex = 12;
            // 
            // noPlaylist
            // 
            this.noPlaylist.AutoSize = true;
            this.noPlaylist.Location = new System.Drawing.Point(297, 105);
            this.noPlaylist.Name = "noPlaylist";
            this.noPlaylist.Size = new System.Drawing.Size(74, 17);
            this.noPlaylist.TabIndex = 13;
            this.noPlaylist.Text = "No playlist";
            this.noPlaylist.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Format:";
            // 
            // FormatCbx
            // 
            this.FormatCbx.FormattingEnabled = true;
            this.FormatCbx.Location = new System.Drawing.Point(80, 138);
            this.FormatCbx.Name = "FormatCbx";
            this.FormatCbx.Size = new System.Drawing.Size(121, 21);
            this.FormatCbx.TabIndex = 15;
            this.FormatCbx.Text = "n/a";
            // 
            // titleMatchBx
            // 
            this.titleMatchBx.Location = new System.Drawing.Point(6, 19);
            this.titleMatchBx.Name = "titleMatchBx";
            this.titleMatchBx.Size = new System.Drawing.Size(226, 20);
            this.titleMatchBx.TabIndex = 16;
            // 
            // matchRdo
            // 
            this.matchRdo.AutoSize = true;
            this.matchRdo.Location = new System.Drawing.Point(252, 12);
            this.matchRdo.Name = "matchRdo";
            this.matchRdo.Size = new System.Drawing.Size(74, 17);
            this.matchRdo.TabIndex = 17;
            this.matchRdo.TabStop = true;
            this.matchRdo.Text = "Match title";
            this.matchRdo.UseVisualStyleBackColor = true;
            // 
            // rjectRdo
            // 
            this.rjectRdo.AutoSize = true;
            this.rjectRdo.Location = new System.Drawing.Point(252, 35);
            this.rjectRdo.Name = "rjectRdo";
            this.rjectRdo.Size = new System.Drawing.Size(75, 17);
            this.rjectRdo.TabIndex = 18;
            this.rjectRdo.TabStop = true;
            this.rjectRdo.Text = "Reject title";
            this.rjectRdo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.titleMatchBx);
            this.groupBox1.Controls.Add(this.rjectRdo);
            this.groupBox1.Controls.Add(this.matchRdo);
            this.groupBox1.Location = new System.Drawing.Point(32, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 59);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title";
            // 
            // downCntEnd
            // 
            this.downCntEnd.Location = new System.Drawing.Point(167, 237);
            this.downCntEnd.Name = "downCntEnd";
            this.downCntEnd.Size = new System.Drawing.Size(38, 20);
            this.downCntEnd.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "to";
            // 
            // downCntStr
            // 
            this.downCntStr.Location = new System.Drawing.Point(103, 237);
            this.downCntStr.Name = "downCntStr";
            this.downCntStr.Size = new System.Drawing.Size(36, 20);
            this.downCntStr.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Down count:";
            // 
            // downSzEnd
            // 
            this.downSzEnd.Location = new System.Drawing.Point(356, 237);
            this.downSzEnd.Name = "downSzEnd";
            this.downSzEnd.Size = new System.Drawing.Size(38, 20);
            this.downSzEnd.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "to";
            // 
            // downSzStr
            // 
            this.downSzStr.Location = new System.Drawing.Point(292, 237);
            this.downSzStr.Name = "downSzStr";
            this.downSzStr.Size = new System.Drawing.Size(36, 20);
            this.downSzStr.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Down size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Date:";
            // 
            // dateStr
            // 
            this.dateStr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStr.Location = new System.Drawing.Point(62, 265);
            this.dateStr.Name = "dateStr";
            this.dateStr.Size = new System.Drawing.Size(99, 20);
            this.dateStr.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Views:";
            // 
            // viewEnd
            // 
            this.viewEnd.Location = new System.Drawing.Point(148, 298);
            this.viewEnd.Name = "viewEnd";
            this.viewEnd.Size = new System.Drawing.Size(53, 20);
            this.viewEnd.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "to";
            // 
            // viewStr
            // 
            this.viewStr.Location = new System.Drawing.Point(69, 298);
            this.viewStr.Name = "viewStr";
            this.viewStr.Size = new System.Drawing.Size(53, 20);
            this.viewStr.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Url:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Match filter:";
            // 
            // matchFilterTbx
            // 
            this.matchFilterTbx.Location = new System.Drawing.Point(107, 333);
            this.matchFilterTbx.Name = "matchFilterTbx";
            this.matchFilterTbx.Size = new System.Drawing.Size(258, 20);
            this.matchFilterTbx.TabIndex = 35;
            // 
            // addToQueueBtn
            // 
            this.addToQueueBtn.Image = global::youtube_downUi.Properties.Resources.add;
            this.addToQueueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToQueueBtn.Location = new System.Drawing.Point(148, 364);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(110, 40);
            this.addToQueueBtn.TabIndex = 37;
            this.addToQueueBtn.Text = "Add to queue";
            this.addToQueueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addToQueueBtn.UseVisualStyleBackColor = true;
            this.addToQueueBtn.Click += new System.EventHandler(this.addToQueueBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Image = global::youtube_downUi.Properties.Resources.about;
            this.aboutBtn.Location = new System.Drawing.Point(375, 2);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(42, 42);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Image = global::youtube_downUi.Properties.Resources.cog;
            this.settingBtn.Location = new System.Drawing.Point(3, 2);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(42, 42);
            this.settingBtn.TabIndex = 1;
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(189, 265);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(99, 20);
            this.dateEnd.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "to";
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(51, 17);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(19, 13);
            this.debugLbl.TabIndex = 40;
            this.debugLbl.Text = ">>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 421);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.addToQueueBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.matchFilterTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewEnd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.viewStr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateStr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.downSzEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.downSzStr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.downCntEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.downCntStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FormatCbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noPlaylist);
            this.Controls.Add(this.playlistEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playlistStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expandCollapseBtn);
            this.Controls.Add(this.clearCompBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dlAllBtn);
            this.Controls.Add(this.playlistBx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.urlTbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 460);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube down UI ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.playlistStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistEnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downCntEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downCntStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downSzEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downSzStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTbx;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView playlistBx;
        private System.Windows.Forms.Button dlAllBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button clearCompBtn;
        private System.Windows.Forms.Button expandCollapseBtn;
        private System.Windows.Forms.NumericUpDown playlistStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown playlistEnd;
        private System.Windows.Forms.CheckBox noPlaylist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FormatCbx;
        private System.Windows.Forms.TextBox titleMatchBx;
        private System.Windows.Forms.RadioButton matchRdo;
        private System.Windows.Forms.RadioButton rjectRdo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown downCntEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown downCntStr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown downSzEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown downSzStr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateStr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown viewEnd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown viewStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox matchFilterTbx;
        private System.Windows.Forms.Button addToQueueBtn;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label debugLbl;
    }
}

