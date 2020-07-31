namespace DemoWinFormCS
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(100, 192);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 30);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(76, 72);
            this.txtN1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(196, 30);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(76, 112);
            this.txtN2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(196, 30);
            this.txtN2.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(76, 152);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(196, 30);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 308);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.btnCalc);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtResult;
    }
}

