namespace TurtleGraphics
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
            this.MynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MynumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MyComboBox
            // 
            this.MyComboBox.FormattingEnabled = true;
            this.MyComboBox.Items.AddRange(new object[] {
            "Koch snowflake",
            "Sierpinski triangle",
            "Rosetta",
            "Hilbert curve"});
            this.MyComboBox.Location = new System.Drawing.Point(719, 38);
            this.MyComboBox.Name = "MyComboBox";
            this.MyComboBox.Size = new System.Drawing.Size(121, 21);
            this.MyComboBox.TabIndex = 0;
            this.MyComboBox.SelectedIndexChanged += new System.EventHandler(this.MyComboBox_SelectedIndexChanged);
            // 
            // MynumericUpDown
            // 
            this.MynumericUpDown.Location = new System.Drawing.Point(719, 12);
            this.MynumericUpDown.Name = "MynumericUpDown";
            this.MynumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MynumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Глубина рекурсии:";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MynumericUpDown);
            this.Controls.Add(this.MyComboBox);
            this.DoubleBuffered = true;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turtle graphics";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.MynumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MyComboBox;
        private System.Windows.Forms.NumericUpDown MynumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}

