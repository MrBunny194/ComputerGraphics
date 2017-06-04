namespace Fractals
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
            this.MyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MyComboBox
            // 
            this.MyComboBox.FormattingEnabled = true;
            this.MyComboBox.Items.AddRange(new object[] {
            "Sierpinski triangle",
            "Koch snowflake",
            "Cantor dust",
            "List fern",
            "Kam torus"});
            this.MyComboBox.Location = new System.Drawing.Point(963, 38);
            this.MyComboBox.Name = "MyComboBox";
            this.MyComboBox.Size = new System.Drawing.Size(121, 21);
            this.MyComboBox.TabIndex = 0;
            this.MyComboBox.SelectedIndexChanged += new System.EventHandler(this.MyComboBox_SelectedIndexChanged);
            // 
            // MyNumericUpDown
            // 
            this.MyNumericUpDown.Location = new System.Drawing.Point(963, 12);
            this.MyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MyNumericUpDown.Name = "MyNumericUpDown";
            this.MyNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MyNumericUpDown.TabIndex = 1;
            this.MyNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1095, 654);
            this.Controls.Add(this.MyNumericUpDown);
            this.Controls.Add(this.MyComboBox);
            this.Name = "MyForm";
            this.Text = "Fractals";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.MyNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MyComboBox;
        private System.Windows.Forms.NumericUpDown MyNumericUpDown;
    }
}

