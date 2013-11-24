namespace Forms
{
    partial class Schemes
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
            this.sea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sea
            // 
            this.sea.Location = new System.Drawing.Point(12, 12);
            this.sea.Name = "sea";
            this.sea.Size = new System.Drawing.Size(107, 23);
            this.sea.TabIndex = 0;
            this.sea.Text = "Under The Sea";
            this.sea.UseVisualStyleBackColor = true;
            this.sea.Click += new System.EventHandler(this.sea_Click);
            // 
            // Schemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sea);
            this.Name = "Schemes";
            this.Text = "Schemes";
            this.Load += new System.EventHandler(this.Schemes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sea;
    }
}