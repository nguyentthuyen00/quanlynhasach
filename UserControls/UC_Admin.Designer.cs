
namespace NSMoonLight.UserControls
{
    partial class UC_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnQD = new System.Windows.Forms.Button();
            this.btnKM = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCN);
            this.panel1.Controls.Add(this.btnQD);
            this.panel1.Controls.Add(this.btnKM);
            this.panel1.Controls.Add(this.btnNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 60);
            this.panel1.TabIndex = 1;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Location = new System.Drawing.Point(0, 59);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(941, 516);
            this.panelAdmin.TabIndex = 2;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdmin_Paint);
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnCN.Image = ((System.Drawing.Image)(resources.GetObject("btnCN.Image")));
            this.btnCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCN.Location = new System.Drawing.Point(722, 0);
            this.btnCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(218, 60);
            this.btnCN.TabIndex = 3;
            this.btnCN.Text = "   QL Công nợ";
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnQD
            // 
            this.btnQD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnQD.Image = ((System.Drawing.Image)(resources.GetObject("btnQD.Image")));
            this.btnQD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQD.Location = new System.Drawing.Point(492, 0);
            this.btnQD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQD.Name = "btnQD";
            this.btnQD.Size = new System.Drawing.Size(230, 60);
            this.btnQD.TabIndex = 2;
            this.btnQD.Text = "   QL Quy định";
            this.btnQD.UseVisualStyleBackColor = false;
            this.btnQD.Click += new System.EventHandler(this.btnQD_Click);
            // 
            // btnKM
            // 
            this.btnKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnKM.Image = ((System.Drawing.Image)(resources.GetObject("btnKM.Image")));
            this.btnKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKM.Location = new System.Drawing.Point(0, 0);
            this.btnKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKM.Name = "btnKM";
            this.btnKM.Size = new System.Drawing.Size(250, 60);
            this.btnKM.TabIndex = 0;
            this.btnKM.Text = "   QL Khuyến mãi";
            this.btnKM.UseVisualStyleBackColor = false;
            this.btnKM.Click += new System.EventHandler(this.btnKM_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnNV.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.Image")));
            this.btnNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNV.Location = new System.Drawing.Point(250, 0);
            this.btnNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(242, 60);
            this.btnNV.TabIndex = 1;
            this.btnNV.Text = "   QL Nhân viên";
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // UC_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Admin";
            this.Size = new System.Drawing.Size(941, 576);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKM;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnQD;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAdmin;
    }
}
