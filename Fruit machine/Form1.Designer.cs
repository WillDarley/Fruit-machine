namespace Fruit_machine
{
    partial class Form1
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
            this.lblresult1 = new System.Windows.Forms.Label();
            this.lblresult2 = new System.Windows.Forms.Label();
            this.lblresult3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblresult1
            // 
            this.lblresult1.AutoSize = true;
            this.lblresult1.Location = new System.Drawing.Point(77, 118);
            this.lblresult1.Name = "lblresult1";
            this.lblresult1.Size = new System.Drawing.Size(41, 13);
            this.lblresult1.TabIndex = 0;
            this.lblresult1.Text = "result 1";
            // 
            // lblresult2
            // 
            this.lblresult2.AutoSize = true;
            this.lblresult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult2.Location = new System.Drawing.Point(129, 118);
            this.lblresult2.Name = "lblresult2";
            this.lblresult2.Size = new System.Drawing.Size(181, 55);
            this.lblresult2.TabIndex = 1;
            this.lblresult2.Text = "result 2";
            // 
            // lblresult3
            // 
            this.lblresult3.AutoSize = true;
            this.lblresult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult3.Location = new System.Drawing.Point(189, 118);
            this.lblresult3.Name = "lblresult3";
            this.lblresult3.Size = new System.Drawing.Size(181, 55);
            this.lblresult3.TabIndex = 2;
            this.lblresult3.Text = "result 3";
            this.lblresult3.Click += new System.EventHandler(this.lblresult3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult3);
            this.Controls.Add(this.lblresult2);
            this.Controls.Add(this.lblresult1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresult1;
        private System.Windows.Forms.Label lblresult2;
        private System.Windows.Forms.Label lblresult3;
    }
}

