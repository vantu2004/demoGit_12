namespace Project_Windows_04
{
    partial class temp01
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
            this.pbx_temp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_temp
            // 
            this.pbx_temp.Location = new System.Drawing.Point(213, 72);
            this.pbx_temp.Name = "pbx_temp";
            this.pbx_temp.Size = new System.Drawing.Size(325, 199);
            this.pbx_temp.TabIndex = 0;
            this.pbx_temp.TabStop = false;
            // 
            // temp01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbx_temp);
            this.Name = "temp01";
            this.Text = "temp01";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_temp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbx_temp;
    }
}