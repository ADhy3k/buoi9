namespace buoi9
{
    partial class Form2
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
            this.lbMaK = new System.Windows.Forms.Label();
            this.lbTenK = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaK = new System.Windows.Forms.TextBox();
            this.txtTenK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMaK
            // 
            this.lbMaK.AutoSize = true;
            this.lbMaK.Location = new System.Drawing.Point(32, 30);
            this.lbMaK.Name = "lbMaK";
            this.lbMaK.Size = new System.Drawing.Size(53, 13);
            this.lbMaK.TabIndex = 0;
            this.lbMaK.Text = "Mã Khoa:";
            // 
            // lbTenK
            // 
            this.lbTenK.AutoSize = true;
            this.lbTenK.Location = new System.Drawing.Point(32, 64);
            this.lbTenK.Name = "lbTenK";
            this.lbTenK.Size = new System.Drawing.Size(57, 13);
            this.lbTenK.TabIndex = 1;
            this.lbTenK.Text = "Tên Khoa:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 102);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(105, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(197, 102);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // txtMaK
            // 
            this.txtMaK.Location = new System.Drawing.Point(88, 27);
            this.txtMaK.Name = "txtMaK";
            this.txtMaK.Size = new System.Drawing.Size(184, 20);
            this.txtMaK.TabIndex = 5;
            this.txtMaK.TextChanged += new System.EventHandler(this.txtMaK_TextChanged);
            // 
            // txtTenK
            // 
            this.txtTenK.Location = new System.Drawing.Point(88, 61);
            this.txtTenK.Name = "txtTenK";
            this.txtTenK.Size = new System.Drawing.Size(184, 20);
            this.txtTenK.TabIndex = 6;
            this.txtTenK.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.txtTenK);
            this.Controls.Add(this.txtMaK);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbTenK);
            this.Controls.Add(this.lbMaK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaK;
        private System.Windows.Forms.Label lbTenK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaK;
        private System.Windows.Forms.TextBox txtTenK;
    }
}