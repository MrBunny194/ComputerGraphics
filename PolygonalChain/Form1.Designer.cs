namespace PolygonalChain
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.BezierCurve = new System.Windows.Forms.Button();
            this.DeCasteljausAlgorithm = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(828, 473);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // BezierCurve
            // 
            this.BezierCurve.Location = new System.Drawing.Point(539, 12);
            this.BezierCurve.Name = "BezierCurve";
            this.BezierCurve.Size = new System.Drawing.Size(75, 23);
            this.BezierCurve.TabIndex = 1;
            this.BezierCurve.Text = "Bezier curve";
            this.BezierCurve.UseVisualStyleBackColor = true;
            this.BezierCurve.Click += new System.EventHandler(this.BezierCurve_Click);
            // 
            // DeCasteljausAlgorithm
            // 
            this.DeCasteljausAlgorithm.Location = new System.Drawing.Point(620, 12);
            this.DeCasteljausAlgorithm.Name = "DeCasteljausAlgorithm";
            this.DeCasteljausAlgorithm.Size = new System.Drawing.Size(139, 23);
            this.DeCasteljausAlgorithm.TabIndex = 2;
            this.DeCasteljausAlgorithm.Text = "De Casteljau\'s algorithm";
            this.DeCasteljausAlgorithm.UseVisualStyleBackColor = true;
            this.DeCasteljausAlgorithm.Click += new System.EventHandler(this.DeCasteljausAlgorithm_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(765, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(852, 526);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DeCasteljausAlgorithm);
            this.Controls.Add(this.BezierCurve);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "Polygonal chain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button BezierCurve;
        private System.Windows.Forms.Button DeCasteljausAlgorithm;
        private System.Windows.Forms.Button Clear;
    }
}

