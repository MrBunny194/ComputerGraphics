namespace BresenhamLineAlgorithm
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
            this.MyPanel = new System.Windows.Forms.Panel();
            this.DrawLine = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.MyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyPanel
            // 
            this.MyPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MyPanel.Controls.Add(this.DrawLine);
            this.MyPanel.Controls.Add(this.Clear);
            this.MyPanel.Location = new System.Drawing.Point(12, 12);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(655, 440);
            this.MyPanel.TabIndex = 0;
            this.MyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPanel_Paint);
            this.MyPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyPanel_MouseClick);
            // 
            // DrawLine
            // 
            this.DrawLine.Location = new System.Drawing.Point(577, 385);
            this.DrawLine.Name = "DrawLine";
            this.DrawLine.Size = new System.Drawing.Size(75, 23);
            this.DrawLine.TabIndex = 1;
            this.DrawLine.Text = "Draw line";
            this.DrawLine.UseVisualStyleBackColor = true;
            this.DrawLine.Click += new System.EventHandler(this.DrawLine_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(577, 414);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 464);
            this.Controls.Add(this.MyPanel);
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "Bresenham\'s line algorithm";
            this.MyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MyPanel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button DrawLine;
    }
}

