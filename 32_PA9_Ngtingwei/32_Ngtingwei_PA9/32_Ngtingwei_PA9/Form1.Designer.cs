﻿namespace _32_Ngtingwei_PA9
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Converted = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_US = new System.Windows.Forms.RadioButton();
            this.rb_Yen = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(423, 90);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(100, 30);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(423, 258);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 30);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Converted Amount";
            // 
            // txt_Converted
            // 
            this.txt_Converted.Location = new System.Drawing.Point(207, 272);
            this.txt_Converted.Name = "txt_Converted";
            this.txt_Converted.Size = new System.Drawing.Size(100, 20);
            this.txt_Converted.TabIndex = 4;
            this.txt_Converted.TextChanged += new System.EventHandler(this.txt_Converted_TextChanged);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(207, 90);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 5;
            this.txt_Amount.TextChanged += new System.EventHandler(this.txt_Amount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Currency: ";
            // 
            // rb_US
            // 
            this.rb_US.AutoSize = true;
            this.rb_US.Location = new System.Drawing.Point(207, 149);
            this.rb_US.Name = "rb_US";
            this.rb_US.Size = new System.Drawing.Size(75, 17);
            this.rb_US.TabIndex = 7;
            this.rb_US.TabStop = true;
            this.rb_US.Text = "US Dollars";
            this.rb_US.UseVisualStyleBackColor = true;
            this.rb_US.CheckedChanged += new System.EventHandler(this.rb_US_CheckedChanged);
            // 
            // rb_Yen
            // 
            this.rb_Yen.AutoSize = true;
            this.rb_Yen.Location = new System.Drawing.Point(207, 208);
            this.rb_Yen.Name = "rb_Yen";
            this.rb_Yen.Size = new System.Drawing.Size(93, 17);
            this.rb_Yen.TabIndex = 8;
            this.rb_Yen.TabStop = true;
            this.rb_Yen.Text = "Japanese Yen";
            this.rb_Yen.UseVisualStyleBackColor = true;
            this.rb_Yen.CheckedChanged += new System.EventHandler(this.rb_Yen_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_Yen);
            this.Controls.Add(this.rb_US);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.txt_Converted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Converted;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_US;
        private System.Windows.Forms.RadioButton rb_Yen;
        private System.Windows.Forms.Label label4;
    }
}

