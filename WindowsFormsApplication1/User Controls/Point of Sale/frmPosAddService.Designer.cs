﻿namespace WindowsFormsApplication1
{
    partial class frmPosAddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosAddService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFee = new System.Windows.Forms.Label();
            this.cboVehicleType = new System.Windows.Forms.ComboBox();
            this.cboServiceName = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPlateNo = new MyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.myTextBox1 = new MyTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myTextBox2 = new MyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 49);
            this.panel1.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(205, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 39);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select Service";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.myTextBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.myTextBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblFee);
            this.panel2.Controls.Add(this.cboVehicleType);
            this.panel2.Controls.Add(this.cboServiceName);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.txtPlateNo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkedListBox);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Location = new System.Drawing.Point(10, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 302);
            this.panel2.TabIndex = 85;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.ForeColor = System.Drawing.Color.White;
            this.lblFee.Location = new System.Drawing.Point(95, 221);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(0, 19);
            this.lblFee.TabIndex = 138;
            // 
            // cboVehicleType
            // 
            this.cboVehicleType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVehicleType.FormattingEnabled = true;
            this.cboVehicleType.Location = new System.Drawing.Point(145, 176);
            this.cboVehicleType.Name = "cboVehicleType";
            this.cboVehicleType.Size = new System.Drawing.Size(228, 28);
            this.cboVehicleType.TabIndex = 137;
            this.cboVehicleType.SelectedIndexChanged += new System.EventHandler(this.cboVehicleType_SelectedIndexChanged_1);
            // 
            // cboServiceName
            // 
            this.cboServiceName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServiceName.FormattingEnabled = true;
            this.cboServiceName.Location = new System.Drawing.Point(145, 142);
            this.cboServiceName.Name = "cboServiceName";
            this.cboServiceName.Size = new System.Drawing.Size(228, 28);
            this.cboServiceName.TabIndex = 136;
            this.cboServiceName.SelectedIndexChanged += new System.EventHandler(this.cboServiceName_SelectedIndexChanged_1);
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(350, 231);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(105, 52);
            this.btnSelect.TabIndex = 134;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(473, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 52);
            this.button3.TabIndex = 135;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.BackColor = System.Drawing.Color.Firebrick;
            this.txtPlateNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlateNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNo.ForeColor = System.Drawing.Color.White;
            this.txtPlateNo.Location = new System.Drawing.Point(87, 13);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(127, 25);
            this.txtPlateNo.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 132;
            this.label2.Text = "Fee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(395, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 131;
            this.label1.Text = "Serviced by:";
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.HorizontalScrollbar = true;
            this.checkedListBox.Location = new System.Drawing.Point(399, 46);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(181, 136);
            this.checkedListBox.TabIndex = 130;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(11, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 19);
            this.label21.TabIndex = 129;
            this.label21.Text = "Plate #:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 26);
            this.label15.TabIndex = 128;
            this.label15.Text = "Service Rendered:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(33, 180);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 19);
            this.label23.TabIndex = 127;
            this.label23.Text = "Vehicle Type:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(33, 146);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 19);
            this.label24.TabIndex = 126;
            this.label24.Text = "Service Name:";
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.Firebrick;
            this.myTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox1.ForeColor = System.Drawing.Color.White;
            this.myTextBox1.Location = new System.Drawing.Point(87, 46);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(127, 25);
            this.myTextBox1.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 139;
            this.label3.Text = "Model:";
            // 
            // myTextBox2
            // 
            this.myTextBox2.BackColor = System.Drawing.Color.Firebrick;
            this.myTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox2.ForeColor = System.Drawing.Color.White;
            this.myTextBox2.Location = new System.Drawing.Point(86, 83);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(127, 25);
            this.myTextBox2.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 141;
            this.label4.Text = "Car Color:";
            // 
            // frmPosAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(621, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPosAddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPosAddService";
            this.Load += new System.EventHandler(this.frmPosAddService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        public MyTextBox myTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.ComboBox cboVehicleType;
        private System.Windows.Forms.ComboBox cboServiceName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button button3;
        public MyTextBox txtPlateNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        public MyTextBox myTextBox2;
        private System.Windows.Forms.Label label4;
    }
}