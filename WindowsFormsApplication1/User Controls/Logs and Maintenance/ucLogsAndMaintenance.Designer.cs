namespace WindowsFormsApplication1
{
    partial class ucLogsAndMaintenance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLogsAndMaintenance));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 60);
            this.panel1.TabIndex = 58;
            // 
            // btnLogs
            // 
            this.btnLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogs.BackgroundImage")));
            this.btnLogs.Enabled = false;
            this.btnLogs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Location = new System.Drawing.Point(439, 177);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(213, 113);
            this.btnLogs.TabIndex = 130;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageEmp.BackgroundImage")));
            this.btnManageEmp.Enabled = false;
            this.btnManageEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmp.ForeColor = System.Drawing.Color.White;
            this.btnManageEmp.Location = new System.Drawing.Point(132, 15);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(213, 113);
            this.btnManageEmp.TabIndex = 129;
            this.btnManageEmp.Text = "Manage Employee Information";
            this.btnManageEmp.UseVisualStyleBackColor = true;
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.BackgroundImage")));
            this.btnCustomer.Enabled = false;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(132, 177);
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
            this.btnManageUsers.Location = new System.Drawing.Point(439, 15);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(213, 113);
            this.btnManageUsers.TabIndex = 127;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnManageEmp);
            this.panel2.Controls.Add(this.btnManageUsers);
            this.panel2.Controls.Add(this.btnLogs);
            this.panel2.Location = new System.Drawing.Point(17, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 333);
            this.panel2.TabIndex = 131;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 464);
            this.panel3.TabIndex = 132;
            // 
            // ucLogsAndMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ucLogsAndMaintenance";
            this.Size = new System.Drawing.Size(899, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
