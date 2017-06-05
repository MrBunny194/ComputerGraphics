namespace Sets
{
    partial class MyForm
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
            this.MyComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MyComboBox
            // 
            this.MyComboBox.FormattingEnabled = true;
            this.MyComboBox.Items.AddRange(new object[] {
            "Mandelbrot set",
            "Julia set"});
            this.MyComboBox.Location = new System.Drawing.Point(714, 12);
            this.MyComboBox.Name = "MyComboBox";
            this.MyComboBox.Size = new System.Drawing.Size(121, 21);
            this.MyComboBox.TabIndex = 0;
            this.MyComboBox.SelectedIndexChanged += new System.EventHandler(this.MyComboBox_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(850, 519);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 520);
            this.Controls.Add(this.MyComboBox);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "Julia set and Mandelbrot set";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MyComboBox;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

