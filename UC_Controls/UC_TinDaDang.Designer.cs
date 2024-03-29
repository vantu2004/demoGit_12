namespace Project_Windows_04
{
    partial class UC_TinDaDang
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
            this.components = new System.ComponentModel.Container();
            this.lbl_ngayDang = new System.Windows.Forms.Label();
            this.lbl_tenCongViec = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ngayDang
            // 
            this.lbl_ngayDang.AutoSize = true;
            this.lbl_ngayDang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_ngayDang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_ngayDang.Location = new System.Drawing.Point(68, 11);
            this.lbl_ngayDang.Name = "lbl_ngayDang";
            this.lbl_ngayDang.Size = new System.Drawing.Size(145, 31);
            this.lbl_ngayDang.TabIndex = 86;
            this.lbl_ngayDang.Text = "Update date";
            // 
            // lbl_tenCongViec
            // 
            this.lbl_tenCongViec.AutoSize = true;
            this.lbl_tenCongViec.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tenCongViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_tenCongViec.Location = new System.Drawing.Point(396, 11);
            this.lbl_tenCongViec.Name = "lbl_tenCongViec";
            this.lbl_tenCongViec.Size = new System.Drawing.Size(229, 31);
            this.lbl_tenCongViec.TabIndex = 87;
            this.lbl_tenCongViec.Text = "The name of the job";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImage = global::Project_Windows_04.Properties.Resources.pngegg__22_;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox2.Image = global::Project_Windows_04.Properties.Resources.job_942800;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(27, 11);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox2.TabIndex = 89;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::Project_Windows_04.Properties.Resources.job_942800;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.Image = global::Project_Windows_04.Properties.Resources.job_942800;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(355, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox1.TabIndex = 88;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // UC_TinDaDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lbl_tenCongViec);
            this.Controls.Add(this.lbl_ngayDang);
            this.Name = "UC_TinDaDang";
            this.Size = new System.Drawing.Size(1130, 53);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ngayDang;
        private System.Windows.Forms.Label lbl_tenCongViec;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}
