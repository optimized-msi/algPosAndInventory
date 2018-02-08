namespace WindowsFormsApplication1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLogsAndMaintenance = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.myPanel = new System.Windows.Forms.Panel();
            this.maintenancePanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clerkPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.myPanel.SuspendLayout();
            this.maintenancePanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(1307, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.panel4);
            this.sidePanel.Controls.Add(this.panel7);
            this.sidePanel.Controls.Add(this.panel5);
            this.sidePanel.Controls.Add(this.panel2);
            this.sidePanel.Controls.Add(this.panel3);
            this.sidePanel.Location = new System.Drawing.Point(1, 113);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(208, 655);
            this.sidePanel.TabIndex = 25;
            this.sidePanel.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.btnPOS);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 111);
            this.panel4.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.btnLogsAndMaintenance);
            this.panel7.Location = new System.Drawing.Point(0, 444);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(209, 111);
            this.panel7.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.btnServices);
            this.panel5.Location = new System.Drawing.Point(0, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 111);
            this.panel5.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnInventory);
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 111);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnReports);
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 111);
            this.panel3.TabIndex = 12;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(345, 28);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(883, 46);
            this.bunifuCustomLabel4.TabIndex = 81;
            this.bunifuCustomLabel4.Text = "Point of Sale and Inventory Management System";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Snow;
            this.btnLogout.Location = new System.Drawing.Point(1234, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 46);
            this.btnLogout.TabIndex = 82;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Firebrick;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Snow;
            this.button8.Location = new System.Drawing.Point(1, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 37);
            this.button8.TabIndex = 3;
            this.button8.Text = "<--";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // btnPOS
            // 
            this.btnPOS.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pos_white;
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPOS.Location = new System.Drawing.Point(7, 16);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(194, 80);
            this.btnPOS.TabIndex = 12;
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.button6_Click_1);
            this.btnPOS.MouseEnter += new System.EventHandler(this.btnPos_MouseEnter);
            this.btnPOS.MouseLeave += new System.EventHandler(this.btnPos_MouseLeave);
            // 
            // btnLogsAndMaintenance
            // 
            this.btnLogsAndMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogsAndMaintenance.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._222222;
            this.btnLogsAndMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogsAndMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogsAndMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogsAndMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogsAndMaintenance.Location = new System.Drawing.Point(7, 13);
            this.btnLogsAndMaintenance.Name = "btnLogsAndMaintenance";
            this.btnLogsAndMaintenance.Size = new System.Drawing.Size(194, 80);
            this.btnLogsAndMaintenance.TabIndex = 20;
            this.btnLogsAndMaintenance.UseVisualStyleBackColor = false;
            this.btnLogsAndMaintenance.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnServices.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.services_white;
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnServices.Location = new System.Drawing.Point(7, 13);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(194, 80);
            this.btnServices.TabIndex = 19;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInventory.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1212;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInventory.Location = new System.Drawing.Point(7, 13);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(194, 80);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReports.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1231231;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReports.Location = new System.Drawing.Point(7, 19);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(194, 80);
            this.btnReports.TabIndex = 18;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // myPanel
            // 
            this.myPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myPanel.AutoScroll = true;
            this.myPanel.BackColor = System.Drawing.Color.Maroon;
            this.myPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myPanel.BackgroundImage")));
            this.myPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.myPanel.Controls.Add(this.maintenancePanel);
            this.myPanel.Location = new System.Drawing.Point(209, 114);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(1157, 651);
            this.myPanel.TabIndex = 24;
            // 
            // maintenancePanel
            // 
            this.maintenancePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maintenancePanel.Controls.Add(this.panel8);
            this.maintenancePanel.Controls.Add(this.panel9);
            this.maintenancePanel.Controls.Add(this.panel6);
            this.maintenancePanel.Location = new System.Drawing.Point(3, 0);
            this.maintenancePanel.Name = "maintenancePanel";
            this.maintenancePanel.Size = new System.Drawing.Size(816, 464);
            this.maintenancePanel.TabIndex = 135;
            this.maintenancePanel.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Firebrick;
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Location = new System.Drawing.Point(900, 116);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(189, 286);
            this.panel8.TabIndex = 134;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 131;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Firebrick;
            this.panel9.Controls.Add(this.btnManageEmp);
            this.panel9.Controls.Add(this.btnLogs);
            this.panel9.Controls.Add(this.btnCustomer);
            this.panel9.Controls.Add(this.btnManageUsers);
            this.panel9.Location = new System.Drawing.Point(9, 95);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(789, 354);
            this.panel9.TabIndex = 134;
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageEmp.BackgroundImage")));
            this.btnManageEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmp.ForeColor = System.Drawing.Color.White;
            this.btnManageEmp.Location = new System.Drawing.Point(451, 32);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(213, 113);
            this.btnManageEmp.TabIndex = 129;
            this.btnManageEmp.Text = "Manage Employee Information";
            this.btnManageEmp.UseVisualStyleBackColor = true;
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogs.BackgroundImage")));
            this.btnLogs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Location = new System.Drawing.Point(451, 192);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(213, 113);
            this.btnLogs.TabIndex = 130;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.BackgroundImage")));
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(143, 194);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(213, 113);
            this.btnCustomer.TabIndex = 128;
            this.btnCustomer.Text = "Customer Record";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.BackgroundImage")));
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(143, 32);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(213, 113);
            this.btnManageUsers.TabIndex = 127;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Firebrick;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(810, 60);
            this.panel6.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(240, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 39);
            this.label5.TabIndex = 30;
            this.label5.Text = "Logs and Maintenance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // clerkPanel
            // 
            this.clerkPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clerkPanel.AutoScroll = true;
            this.clerkPanel.BackColor = System.Drawing.Color.Maroon;
            this.clerkPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clerkPanel.BackgroundImage")));
            this.clerkPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clerkPanel.Location = new System.Drawing.Point(1, 103);
            this.clerkPanel.Name = "clerkPanel";
            this.clerkPanel.Size = new System.Drawing.Size(1366, 661);
            this.clerkPanel.TabIndex = 83;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.clerkPanel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sidePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.myPanel.ResumeLayout(false);
            this.maintenancePanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        //private UCFunctions ucFunctions1;
        public System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLogsAndMaintenance;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel clerkPanel;
        private System.Windows.Forms.Panel maintenancePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnPOS;
        public System.Windows.Forms.Button button8;
    }
}