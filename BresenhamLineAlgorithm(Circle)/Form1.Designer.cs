namespace BresenhamLineAlgorithm_Circle_
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
            this.DrawCircle = new System.Windows.Forms.Button();
            this.CircleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Clear = new System.Windows.Forms.Button();
            this.DrawEllipse = new System.Windows.Forms.Button();
            this.ElipseNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ElipseNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CircleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElipseNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElipseNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCircle
            // 
            this.DrawCircle.Location = new System.Drawing.Point(620, 273);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(75, 23);
            this.DrawCircle.TabIndex = 0;
            this.DrawCircle.Text = "Draw circle";
            this.DrawCircle.UseVisualStyleBackColor = true;
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // CircleNumericUpDown
            // 
            this.CircleNumericUpDown.Location = new System.Drawing.Point(620, 302);
            this.CircleNumericUpDown.Name = "CircleNumericUpDown";
            this.CircleNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.CircleNumericUpDown.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(620, 446);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DrawEllipse
            // 
            this.DrawEllipse.Location = new System.Drawing.Point(620, 344);
            this.DrawEllipse.Name = "DrawEllipse";
            this.DrawEllipse.Size = new System.Drawing.Size(75, 23);
            this.DrawEllipse.TabIndex = 3;
            this.DrawEllipse.Text = "Draw Ellipse";
            this.DrawEllipse.UseVisualStyleBackColor = true;
            this.DrawEllipse.Click += new System.EventHandler(this.DrawEllipse_Click);
            // 
            // ElipseNumericUpDown1
            // 
            this.ElipseNumericUpDown1.Location = new System.Drawing.Point(620, 373);
            this.ElipseNumericUpDown1.Name = "ElipseNumericUpDown1";
            this.ElipseNumericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.ElipseNumericUpDown1.TabIndex = 4;
            // 
            // ElipseNumericUpDown2
            // 
            this.ElipseNumericUpDown2.Location = new System.Drawing.Point(620, 399);
            this.ElipseNumericUpDown2.Name = "ElipseNumericUpDown2";
            this.ElipseNumericUpDown2.Size = new System.Drawing.Size(75, 20);
            this.ElipseNumericUpDown2.TabIndex = 5;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 481);
            this.Controls.Add(this.ElipseNumericUpDown2);
            this.Controls.Add(this.ElipseNumericUpDown1);
            this.Controls.Add(this.DrawEllipse);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CircleNumericUpDown);
            this.Controls.Add(this.DrawCircle);
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "BresenhamLineAlgorithm(Circle)";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.CircleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElipseNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElipseNumericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawCircle;
        private System.Windows.Forms.NumericUpDown CircleNumericUpDown;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button DrawEllipse;
        private System.Windows.Forms.NumericUpDown ElipseNumericUpDown1;
        private System.Windows.Forms.NumericUpDown ElipseNumericUpDown2;
    }
}

