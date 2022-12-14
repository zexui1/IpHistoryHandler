namespace IpHandler
{
    partial class IpHistory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IpHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentIp = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.PrevIps = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimizeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current ip:";
            // 
            // CurrentIp
            // 
            this.CurrentIp.AutoSize = true;
            this.CurrentIp.Location = new System.Drawing.Point(81, 9);
            this.CurrentIp.Name = "CurrentIp";
            this.CurrentIp.Size = new System.Drawing.Size(13, 15);
            this.CurrentIp.TabIndex = 1;
            this.CurrentIp.Text = "0";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 144);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh Ip";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(12, 115);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(75, 23);
            this.InfoBtn.TabIndex = 3;
            this.InfoBtn.Text = "Info";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // PrevIps
            // 
            this.PrevIps.FormattingEnabled = true;
            this.PrevIps.ItemHeight = 15;
            this.PrevIps.Location = new System.Drawing.Point(164, 30);
            this.PrevIps.Name = "PrevIps";
            this.PrevIps.Size = new System.Drawing.Size(196, 154);
            this.PrevIps.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Previous Ips";
            // 
            // MinimizeIcon
            // 
            this.MinimizeIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizeIcon.Icon")));
            this.MinimizeIcon.Text = "Ip History Handler";
            this.MinimizeIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeIcon_MouseDoubleClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 30);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(114, 23);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear history of ips";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // IpHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 187);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrevIps);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.CurrentIp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IpHistory";
            this.Text = "Ip History Handler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IpHistory_FormClosing);
            this.Resize += new System.EventHandler(this.IpHistory_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label CurrentIp;
        private Button Refresh;
        private Button InfoBtn;
        private ListBox PrevIps;
        private Label label3;
        private NotifyIcon MinimizeIcon;
        private Button ClearBtn;
    }
}