namespace easysetup
{
    partial class mainwindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Add the TextBox control declarations for Server Name and Server IP.
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtServerIP;

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
            this.servername = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.serverip = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.serverport = new System.Windows.Forms.GroupBox();
            this.txtmsgport = new System.Windows.Forms.TextBox();
            this.txtnpcport = new System.Windows.Forms.TextBox();
            this.txtloginport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdbname = new System.Windows.Forms.TextBox();
            this.txtdbuser = new System.Windows.Forms.TextBox();
            this.txtdbpass = new System.Windows.Forms.TextBox();
            this.btncrtoem = new System.Windows.Forms.Button();
            this.servername.SuspendLayout();
            this.serverip.SuspendLayout();
            this.serverport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servername
            // 
            this.servername.Controls.Add(this.label1);
            this.servername.Controls.Add(this.txtServerName);
            this.servername.Location = new System.Drawing.Point(12, 12);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(228, 54);
            this.servername.TabIndex = 0;
            this.servername.TabStop = false;
            this.servername.Text = "Server Name";
            this.servername.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name :";
            this.label1.UseWaitCursor = true;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(93, 19);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(115, 20);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.UseWaitCursor = true;
            // 
            // serverip
            // 
            this.serverip.Controls.Add(this.label2);
            this.serverip.Controls.Add(this.txtServerIP);
            this.serverip.Location = new System.Drawing.Point(12, 72);
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(228, 54);
            this.serverip.TabIndex = 1;
            this.serverip.TabStop = false;
            this.serverip.Text = "Server IP";
            this.serverip.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server IP :";
            this.label2.UseWaitCursor = true;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(93, 19);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(115, 20);
            this.txtServerIP.TabIndex = 0;
            this.txtServerIP.UseWaitCursor = true;
            // 
            // serverport
            // 
            this.serverport.Controls.Add(this.txtmsgport);
            this.serverport.Controls.Add(this.txtnpcport);
            this.serverport.Controls.Add(this.txtloginport);
            this.serverport.Controls.Add(this.label5);
            this.serverport.Controls.Add(this.label4);
            this.serverport.Controls.Add(this.label3);
            this.serverport.Location = new System.Drawing.Point(12, 132);
            this.serverport.Name = "serverport";
            this.serverport.Size = new System.Drawing.Size(228, 106);
            this.serverport.TabIndex = 2;
            this.serverport.TabStop = false;
            this.serverport.Text = "Server Port";
            this.serverport.UseWaitCursor = true;
            // 
            // txtmsgport
            // 
            this.txtmsgport.Location = new System.Drawing.Point(93, 45);
            this.txtmsgport.Name = "txtmsgport";
            this.txtmsgport.Size = new System.Drawing.Size(115, 20);
            this.txtmsgport.TabIndex = 5;
            this.txtmsgport.UseWaitCursor = true;
            // 
            // txtnpcport
            // 
            this.txtnpcport.Location = new System.Drawing.Point(93, 71);
            this.txtnpcport.Name = "txtnpcport";
            this.txtnpcport.Size = new System.Drawing.Size(115, 20);
            this.txtnpcport.TabIndex = 4;
            this.txtnpcport.UseWaitCursor = true;
            // 
            // txtloginport
            // 
            this.txtloginport.Location = new System.Drawing.Point(93, 19);
            this.txtloginport.Name = "txtloginport";
            this.txtloginport.Size = new System.Drawing.Size(115, 20);
            this.txtloginport.TabIndex = 3;
            this.txtloginport.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "NPC Port :";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "MSG Port :";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login Port :";
            this.label3.UseWaitCursor = true;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(128, 381);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(112, 49);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.UseWaitCursor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdbpass);
            this.groupBox1.Controls.Add(this.txtdbuser);
            this.groupBox1.Controls.Add(this.txtdbname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Database :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Username :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password :";
            // 
            // txtdbname
            // 
            this.txtdbname.Location = new System.Drawing.Point(93, 27);
            this.txtdbname.Name = "txtdbname";
            this.txtdbname.Size = new System.Drawing.Size(115, 20);
            this.txtdbname.TabIndex = 3;
            // 
            // txtdbuser
            // 
            this.txtdbuser.Location = new System.Drawing.Point(93, 55);
            this.txtdbuser.Name = "txtdbuser";
            this.txtdbuser.Size = new System.Drawing.Size(115, 20);
            this.txtdbuser.TabIndex = 4;
            // 
            // txtdbpass
            // 
            this.txtdbpass.Location = new System.Drawing.Point(93, 81);
            this.txtdbpass.Name = "txtdbpass";
            this.txtdbpass.Size = new System.Drawing.Size(115, 20);
            this.txtdbpass.TabIndex = 5;
            // 
            // btncrtoem
            // 
            this.btncrtoem.Location = new System.Drawing.Point(12, 381);
            this.btncrtoem.Name = "btncrtoem";
            this.btncrtoem.Size = new System.Drawing.Size(110, 49);
            this.btncrtoem.TabIndex = 5;
            this.btncrtoem.Text = "Create Oem.dat";
            this.btncrtoem.UseVisualStyleBackColor = true;
            this.btncrtoem.Click += new System.EventHandler(this.btncrtoem_Click);

            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 448);
            this.Controls.Add(this.btncrtoem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.serverport);
            this.Controls.Add(this.serverip);
            this.Controls.Add(this.servername);
            this.Name = "mainwindow";
            this.Text = "Easy Setup EO";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.mainwindow_Load);
            this.servername.ResumeLayout(false);
            this.servername.PerformLayout();
            this.serverip.ResumeLayout(false);
            this.serverip.PerformLayout();
            this.serverport.ResumeLayout(false);
            this.serverport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox servername;
        private System.Windows.Forms.GroupBox serverip;
        private System.Windows.Forms.GroupBox serverport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox txtmsgport;
        private System.Windows.Forms.TextBox txtnpcport;
        private System.Windows.Forms.TextBox txtloginport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdbpass;
        private System.Windows.Forms.TextBox txtdbuser;
        private System.Windows.Forms.TextBox txtdbname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncrtoem;
    }
}
