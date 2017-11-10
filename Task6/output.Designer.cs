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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutA
            // 
            this.OutA.Location = new System.Drawing.Point(12, 101);
            this.OutA.Name = "OutA";
            this.OutA.Size = new System.Drawing.Size(947, 20);
            this.OutA.TabIndex = 0;
            // 
            // OutB
            // 
            this.OutB.Location = new System.Drawing.Point(12, 195);
            this.OutB.Name = "OutB";
            this.OutB.Size = new System.Drawing.Size(947, 20);
            this.OutB.TabIndex = 1;
            // 
            // OutC
            // 
            this.OutC.Location = new System.Drawing.Point(12, 283);
            this.OutC.Name = "OutC";
            this.OutC.Size = new System.Drawing.Size(947, 20);
            this.OutC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output C";
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}