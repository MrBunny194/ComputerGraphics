namespace ConvexPolygonFillAlgorithm
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
            this.ToClose = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToClose
            // 
            this.ToClose.Location = new System.Drawing.Point(600, 351);
            this.ToClose.Name = "ToClose";
            this.ToClose.Size = new System.Drawing.Size(75, 23);
            this.ToClose.TabIndex = 0;
            this.ToClose.Text = "To close";
            this.ToClose.UseVisualStyleBackColor = true;
            this.ToClose.Click += new System.EventHandler(this.ToClose_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(600, 432);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(600, 380);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(75, 23);
            this.Fill.TabIndex = 2;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 467);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ToClose);
            this.Name = "MyForm";
            this.Text = "Convex Polygon Fill Algorithm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToClose;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Fill;
    }
}

