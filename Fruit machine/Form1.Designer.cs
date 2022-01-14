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
            this.btnGo = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblresult1
            // 
            this.lblresult1.AutoSize = true;
            this.lblresult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult1.Location = new System.Drawing.Point(93, 118);
            this.lblresult1.Name = "lblresult1";
            this.lblresult1.Size = new System.Drawing.Size(181, 55);
            this.lblresult1.TabIndex = 0;
            this.lblresult1.Text = "result 1";
            this.lblresult1.Click += new System.EventHandler(this.lblresult1_Click);
            // 
            // lblresult2
            // 
            this.lblresult2.AutoSize = true;
            this.lblresult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult2.Location = new System.Drawing.Point(334, 118);
            this.lblresult2.Name = "lblresult2";
            this.lblresult2.Size = new System.Drawing.Size(181, 55);
            this.lblresult2.TabIndex = 1;
            this.lblresult2.Text = "result 2";
            // 
            // lblresult3
            // 
            this.lblresult3.AutoSize = true;
            this.lblresult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult3.Location = new System.Drawing.Point(563, 118);
            this.lblresult3.Name = "lblresult3";
            this.lblresult3.Size = new System.Drawing.Size(181, 55);
            this.lblresult3.TabIndex = 2;
            this.lblresult3.Text = "result 3";
            this.lblresult3.Click += new System.EventHandler(this.lblresult3_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(27, 294);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(259, 91);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Press to Play!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(460, 294);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(328, 110);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Press to withdraw winnings!";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(12, 19);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(132, 37);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnGo);
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
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblBalance;
    }
}

