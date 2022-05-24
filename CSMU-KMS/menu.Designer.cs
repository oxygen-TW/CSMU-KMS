namespace CSMU_KMS
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.Boffice2010 = new System.Windows.Forms.Button();
            this.CMD_Output = new System.Windows.Forms.TextBox();
            this.Boffice2016 = new System.Windows.Forms.Button();
            this.Boffice2013 = new System.Windows.Forms.Button();
            this.BatchStatus = new System.Windows.Forms.Label();
            this.Bwindows = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Boffice2019 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bWindowsDyu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BClearConsole = new System.Windows.Forms.Button();
            this.ProgramInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除目前OfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToNTHUMode = new System.Windows.Forms.ToolStripMenuItem();
            this.關於AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boffice2010
            // 
            this.Boffice2010.Location = new System.Drawing.Point(43, 275);
            this.Boffice2010.Margin = new System.Windows.Forms.Padding(4);
            this.Boffice2010.Name = "Boffice2010";
            this.Boffice2010.Size = new System.Drawing.Size(252, 58);
            this.Boffice2010.TabIndex = 0;
            this.Boffice2010.Text = "認證 Office2010";
            this.Boffice2010.UseVisualStyleBackColor = true;
            this.Boffice2010.Click += new System.EventHandler(this.Boffice2010_Click);
            // 
            // CMD_Output
            // 
            this.CMD_Output.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CMD_Output.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Output.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CMD_Output.Location = new System.Drawing.Point(467, 61);
            this.CMD_Output.Margin = new System.Windows.Forms.Padding(4);
            this.CMD_Output.Multiline = true;
            this.CMD_Output.Name = "CMD_Output";
            this.CMD_Output.ReadOnly = true;
            this.CMD_Output.Size = new System.Drawing.Size(569, 478);
            this.CMD_Output.TabIndex = 1;
            // 
            // Boffice2016
            // 
            this.Boffice2016.Location = new System.Drawing.Point(43, 110);
            this.Boffice2016.Margin = new System.Windows.Forms.Padding(4);
            this.Boffice2016.Name = "Boffice2016";
            this.Boffice2016.Size = new System.Drawing.Size(252, 58);
            this.Boffice2016.TabIndex = 2;
            this.Boffice2016.Text = "認證 Office2016";
            this.Boffice2016.UseVisualStyleBackColor = true;
            this.Boffice2016.Click += new System.EventHandler(this.Boffice2016_Click);
            // 
            // Boffice2013
            // 
            this.Boffice2013.Location = new System.Drawing.Point(43, 192);
            this.Boffice2013.Margin = new System.Windows.Forms.Padding(4);
            this.Boffice2013.Name = "Boffice2013";
            this.Boffice2013.Size = new System.Drawing.Size(252, 58);
            this.Boffice2013.TabIndex = 3;
            this.Boffice2013.Text = "認證 Office2013";
            this.Boffice2013.UseVisualStyleBackColor = true;
            this.Boffice2013.Click += new System.EventHandler(this.Boffice2013_Click);
            // 
            // BatchStatus
            // 
            this.BatchStatus.AutoSize = true;
            this.BatchStatus.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BatchStatus.Location = new System.Drawing.Point(464, 544);
            this.BatchStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BatchStatus.Name = "BatchStatus";
            this.BatchStatus.Size = new System.Drawing.Size(133, 30);
            this.BatchStatus.TabIndex = 4;
            this.BatchStatus.Text = "啟動狀態：";
            // 
            // Bwindows
            // 
            this.Bwindows.Location = new System.Drawing.Point(43, 52);
            this.Bwindows.Margin = new System.Windows.Forms.Padding(4);
            this.Bwindows.Name = "Bwindows";
            this.Bwindows.Size = new System.Drawing.Size(252, 54);
            this.Bwindows.TabIndex = 5;
            this.Bwindows.Text = "認證 Windows 7 含以上版本";
            this.Bwindows.UseVisualStyleBackColor = true;
            this.Bwindows.Click += new System.EventHandler(this.Bwindows_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Boffice2019);
            this.groupBox1.Controls.Add(this.Boffice2010);
            this.groupBox1.Controls.Add(this.Boffice2013);
            this.groupBox1.Controls.Add(this.Boffice2016);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(71, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 351);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Microsoft Office(CSMU)";
            // 
            // Boffice2019
            // 
            this.Boffice2019.Location = new System.Drawing.Point(43, 30);
            this.Boffice2019.Margin = new System.Windows.Forms.Padding(4);
            this.Boffice2019.Name = "Boffice2019";
            this.Boffice2019.Size = new System.Drawing.Size(252, 58);
            this.Boffice2019.TabIndex = 4;
            this.Boffice2019.Text = "認證 Office2019";
            this.Boffice2019.UseVisualStyleBackColor = true;
            this.Boffice2019.Click += new System.EventHandler(this.Boffice2019_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bWindowsDyu);
            this.groupBox2.Controls.Add(this.Bwindows);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(71, 394);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(333, 195);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Microsoft Windows OS(CSMU)";
            // 
            // bWindowsDyu
            // 
            this.bWindowsDyu.Location = new System.Drawing.Point(43, 126);
            this.bWindowsDyu.Margin = new System.Windows.Forms.Padding(4);
            this.bWindowsDyu.Name = "bWindowsDyu";
            this.bWindowsDyu.Size = new System.Drawing.Size(252, 54);
            this.bWindowsDyu.TabIndex = 6;
            this.bWindowsDyu.Text = "認證 Windows 7 含以上版本\r\n(備用腳本)";
            this.bWindowsDyu.UseVisualStyleBackColor = true;
            this.bWindowsDyu.Click += new System.EventHandler(this.BWindowsDyu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(464, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "CMD output";
            // 
            // BClearConsole
            // 
            this.BClearConsole.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClearConsole.Location = new System.Drawing.Point(937, 31);
            this.BClearConsole.Margin = new System.Windows.Forms.Padding(4);
            this.BClearConsole.Name = "BClearConsole";
            this.BClearConsole.Size = new System.Drawing.Size(100, 29);
            this.BClearConsole.TabIndex = 9;
            this.BClearConsole.Text = "Clear";
            this.BClearConsole.UseVisualStyleBackColor = true;
            this.BClearConsole.Click += new System.EventHandler(this.BClearConsole_Click);
            // 
            // ProgramInfo
            // 
            this.ProgramInfo.AutoSize = true;
            this.ProgramInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramInfo.Location = new System.Drawing.Point(665, 581);
            this.ProgramInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgramInfo.Name = "ProgramInfo";
            this.ProgramInfo.Size = new System.Drawing.Size(361, 17);
            this.ProgramInfo.TabIndex = 10;
            this.ProgramInfo.Text = "Program designed by Liu, Tzu-Hao. 2022 / 02 / 16 v1.3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具ToolsToolStripMenuItem,
            this.ChangeToNTHUMode,
            this.關於AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 工具ToolsToolStripMenuItem
            // 
            this.工具ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除目前OfficeToolStripMenuItem});
            this.工具ToolsToolStripMenuItem.Name = "工具ToolsToolStripMenuItem";
            this.工具ToolsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.工具ToolsToolStripMenuItem.Text = "工具 Tools";
            // 
            // 清除目前OfficeToolStripMenuItem
            // 
            this.清除目前OfficeToolStripMenuItem.Enabled = false;
            this.清除目前OfficeToolStripMenuItem.Name = "清除目前OfficeToolStripMenuItem";
            this.清除目前OfficeToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.清除目前OfficeToolStripMenuItem.Text = "清除目前 Office(目前不可用)";
            this.清除目前OfficeToolStripMenuItem.Click += new System.EventHandler(this.清除目前OfficeToolStripMenuItem_Click);
            // 
            // ChangeToNTHUMode
            // 
            this.ChangeToNTHUMode.Name = "ChangeToNTHUMode";
            this.ChangeToNTHUMode.Size = new System.Drawing.Size(128, 24);
            this.ChangeToNTHUMode.Tag = "0";
            this.ChangeToNTHUMode.Text = "切換到清華大學";
            this.ChangeToNTHUMode.Click += new System.EventHandler(this.切換到清華大學ToolStripMenuItem_Click);
            // 
            // 關於AboutToolStripMenuItem
            // 
            this.關於AboutToolStripMenuItem.Name = "關於AboutToolStripMenuItem";
            this.關於AboutToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.關於AboutToolStripMenuItem.Text = "關於 About";
            this.關於AboutToolStripMenuItem.Click += new System.EventHandler(this.關於AboutToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 602);
            this.Controls.Add(this.ProgramInfo);
            this.Controls.Add(this.BClearConsole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BatchStatus);
            this.Controls.Add(this.CMD_Output);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.Text = "中山醫學大學 Microsoft 校園授權軟體啟動程式 v1.4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boffice2010;
        private System.Windows.Forms.TextBox CMD_Output;
        private System.Windows.Forms.Button Boffice2016;
        private System.Windows.Forms.Button Boffice2013;
        private System.Windows.Forms.Label BatchStatus;
        private System.Windows.Forms.Button Bwindows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BClearConsole;
        private System.Windows.Forms.Label ProgramInfo;
        private System.Windows.Forms.Button bWindowsDyu;
        private System.Windows.Forms.Button Boffice2019;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除目前OfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeToNTHUMode;
    }
}