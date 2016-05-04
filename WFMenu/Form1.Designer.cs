namespace WFMenu
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
            this.btnBeef = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSpag = new System.Windows.Forms.Button();
            this.btnTruite = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeef
            // 
            this.btnBeef.Location = new System.Drawing.Point(12, 12);
            this.btnBeef.Name = "btnBeef";
            this.btnBeef.Size = new System.Drawing.Size(148, 36);
            this.btnBeef.TabIndex = 0;
            this.btnBeef.Text = "Roti de boeuf";
            this.btnBeef.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 278);
            this.textBox1.TabIndex = 1;
            // 
            // btnSpag
            // 
            this.btnSpag.Location = new System.Drawing.Point(166, 12);
            this.btnSpag.Name = "btnSpag";
            this.btnSpag.Size = new System.Drawing.Size(148, 36);
            this.btnSpag.TabIndex = 2;
            this.btnSpag.Text = "Plat de spaghettis";
            this.btnSpag.UseVisualStyleBackColor = true;
            // 
            // btnTruite
            // 
            this.btnTruite.Location = new System.Drawing.Point(320, 12);
            this.btnTruite.Name = "btnTruite";
            this.btnTruite.Size = new System.Drawing.Size(148, 36);
            this.btnTruite.TabIndex = 3;
            this.btnTruite.Text = "Truite aux amendes";
            this.btnTruite.UseVisualStyleBackColor = true;
            // 
            // btnDessert
            // 
            this.btnDessert.Location = new System.Drawing.Point(166, 54);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(148, 36);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 96);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(458, 36);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Generer la facture";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 428);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnTruite);
            this.Controls.Add(this.btnSpag);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBeef);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeef;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSpag;
        private System.Windows.Forms.Button btnTruite;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnDone;
    }
}

