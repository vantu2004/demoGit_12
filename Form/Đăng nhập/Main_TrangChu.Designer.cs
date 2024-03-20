namespace Project_Windows_04
{
    partial class Main_TrangChu
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
            this.uC_BangTin1 = new Project_Windows_04.UC_BangTin();
            this.SuspendLayout();
            // 
            // uC_BangTin1
            // 
            this.uC_BangTin1.BackColor = System.Drawing.Color.White;
            this.uC_BangTin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_BangTin1.Location = new System.Drawing.Point(0, 0);
            this.uC_BangTin1.Name = "uC_BangTin1";
            this.uC_BangTin1.Size = new System.Drawing.Size(1332, 703);
            this.uC_BangTin1.TabIndex = 0;
            this.uC_BangTin1.Load += new System.EventHandler(this.uC_BangTin1_Load);
            // 
            // Main_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.uC_BangTin1);
            this.Name = "Main_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_BangTin uC_BangTin1;
    }
}

