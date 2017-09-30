namespace Task6
{
    partial class input
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
            this.ArrayA = new System.Windows.Forms.TextBox();
            this.ArrayB = new System.Windows.Forms.TextBox();
            this.Process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrayA
            // 
            this.ArrayA.Location = new System.Drawing.Point(12, 62);
            this.ArrayA.Name = "ArrayA";
            this.ArrayA.Size = new System.Drawing.Size(176, 20);
            this.ArrayA.TabIndex = 0;
            // 
            // ArrayB
            // 
            this.ArrayB.Location = new System.Drawing.Point(300, 62);
            this.ArrayB.Name = "ArrayB";
            this.ArrayB.Size = new System.Drawing.Size(176, 20);
            this.ArrayB.TabIndex = 1;
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(207, 59);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(75, 23);
            this.Process.TabIndex = 2;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Array B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Array A";
            // 
            // input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.ArrayB);
            this.Controls.Add(this.ArrayA);
            this.Name = "input";
            this.Text = "input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArrayA;
        private System.Windows.Forms.TextBox ArrayB;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

