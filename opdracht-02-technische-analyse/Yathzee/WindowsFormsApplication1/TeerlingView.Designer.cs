namespace WindowsFormsApplication1
{
    partial class TeerlingView
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
            this.TeerlingLabel = new System.Windows.Forms.Label();
            this.Werpbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeerlingLabel
            // 
            this.TeerlingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TeerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeerlingLabel.Location = new System.Drawing.Point(16, 9);
            this.TeerlingLabel.Name = "TeerlingLabel";
            this.TeerlingLabel.Size = new System.Drawing.Size(144, 117);
            this.TeerlingLabel.TabIndex = 0;
            this.TeerlingLabel.Text = "label1";
            this.TeerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TeerlingLabel.Click += new System.EventHandler(this.TeerlingLabel_Click);
            // 
            // Werpbutton
            // 
            this.Werpbutton.Location = new System.Drawing.Point(46, 138);
            this.Werpbutton.Name = "Werpbutton";
            this.Werpbutton.Size = new System.Drawing.Size(75, 23);
            this.Werpbutton.TabIndex = 1;
            this.Werpbutton.Text = "Werp";
            this.Werpbutton.UseVisualStyleBackColor = true;
            this.Werpbutton.Click += new System.EventHandler(this.Werpbutton_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Werpbutton);
            this.Controls.Add(this.TeerlingLabel);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(178, 170);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TeerlingLabel;
        private System.Windows.Forms.Button Werpbutton;
    }
}
