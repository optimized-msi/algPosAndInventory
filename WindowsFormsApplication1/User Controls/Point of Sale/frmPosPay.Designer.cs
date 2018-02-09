namespace WindowsFormsApplication1
{
    partial class frmPosPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosPay));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalService = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewOngoing = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.numCash = new System.Windows.Forms.NumericUpDown();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCash)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(150, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 19);
            this.lblTotal.TabIndex = 97;
            this.lblTotal.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(150, 133);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(17, 19);
            this.lblTotalAmount.TabIndex = 96;
            this.lblTotalAmount.Text = "0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(150, 101);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(17, 19);
            this.lblDiscount.TabIndex = 95;
            this.lblDiscount.Text = "0";
            // 
            // lblTotalService
            // 
            this.lblTotalService.AutoSize = true;
            this.lblTotalService.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalService.ForeColor = System.Drawing.Color.White;
            this.lblTotalService.Location = new System.Drawing.Point(150, 39);
            this.lblTotalService.Name = "lblTotalService";
            this.lblTotalService.Size = new System.Drawing.Size(17, 19);
            this.lblTotalService.TabIndex = 94;
            this.lblTotalService.Text = "0";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.White;
            this.lblTotalItems.Location = new System.Drawing.Point(150, 8);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(17, 19);
            this.lblTotalItems.TabIndex = 93;
            this.lblTotalItems.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Change:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(81, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 39);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pay Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 89;
            this.label3.Text = "Cash:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "Total:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(36, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 19);
            this.label17.TabIndex = 85;
            this.label17.Text = "Total Amount:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(36, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 19);
            this.label16.TabIndex = 83;
            this.label16.Text = "Discount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 81;
            this.label11.Text = "Total Service:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 79;
            this.label10.Text = "Total Items:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Firebrick;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Maroon;
            this.bunifuCards1.Controls.Add(this.numCash);
            this.bunifuCards1.Controls.Add(this.lblChange);
            this.bunifuCards1.Controls.Add(this.lblTotal);
            this.bunifuCards1.Controls.Add(this.lblTotalAmount);
            this.bunifuCards1.Controls.Add(this.lblDiscount);
            this.bunifuCards1.Controls.Add(this.lblTotalService);
            this.bunifuCards1.Controls.Add(this.lblTotalItems);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.label17);
            this.bunifuCards1.Controls.Add(this.label16);
            this.bunifuCards1.Controls.Add(this.label11);
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(4, 71);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(384, 252);
            this.bunifuCards1.TabIndex = 79;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 44);
            this.panel1.TabIndex = 78;
            // 
            // btnViewOngoing
            // 
            this.btnViewOngoing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewOngoing.BackgroundImage")));
            this.btnViewOngoing.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOngoing.ForeColor = System.Drawing.Color.White;
            this.btnViewOngoing.Location = new System.Drawing.Point(127, 329);
            this.btnViewOngoing.Name = "btnViewOngoing";
            this.btnViewOngoing.Size = new System.Drawing.Size(126, 49);
            this.btnViewOngoing.TabIndex = 113;
            this.btnViewOngoing.Text = "Pay Partial";
            this.btnViewOngoing.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(259, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 114;
            this.button1.Text = "Pay Full";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(150, 202);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(17, 19);
            this.lblChange.TabIndex = 114;
            this.lblChange.Text = "0";
            // 
            // numCash
            // 
            this.numCash.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCash.Location = new System.Drawing.Point(152, 168);
            this.numCash.Name = "numCash";
            this.numCash.Size = new System.Drawing.Size(147, 27);
            this.numCash.TabIndex = 115;
            this.numCash.ValueChanged += new System.EventHandler(this.numCash_ValueChanged);
            // 
            // frmPosPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(391, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewOngoing);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPosPay";
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.frmPosPay_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalService;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewOngoing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.NumericUpDown numCash;
    }
}