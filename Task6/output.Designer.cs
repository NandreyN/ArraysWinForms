namespace Task6
{
    partial class output
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
            this.OutA = new System.Windows.Forms.TextBox();
            this.OutB = new System.Windows.Forms.TextBox();
            this.OutC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutA
            // 
            this.OutA.Location = new System.Drawing.Point(12, 44);
            this.OutA.Name = "OutA";
            this.OutA.Size = new System.Drawing.Size(144, 20);
            this.OutA.TabIndex = 0;
            // 
            // OutB
            // 
            this.OutB.Location = new System.Drawing.Point(252, 44);
            this.OutB.Name = "OutB";
            this.OutB.Size = new System.Drawing.Size(144, 20);
            this.OutB.TabIndex = 1;
            // 
            // OutC
            // 
            this.OutC.Location = new System.Drawing.Point(12, 100);
            this.OutC.Name = "OutC";
            this.OutC.Size = new System.Drawing.Size(384, 20);
            this.OutC.TabIndex = 0;
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 187);
            this.Controls.Add(this.OutC);
            this.Controls.Add(this.OutB);
            this.Controls.Add(this.OutA);
            this.Name = "output";
            this.Text = "output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutA;
        private System.Windows.Forms.TextBox OutB;
        private System.Windows.Forms.TextBox OutC;
    }
}