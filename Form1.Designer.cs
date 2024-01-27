namespace MarthasBrowser
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
            this.button1 = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.GeneratedString = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1562, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(51, 55);
            this.textUrl.MinimumSize = new System.Drawing.Size(4, 15);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(1493, 26);
            this.textUrl.TabIndex = 3;
            this.textUrl.Text = "https://";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(43, 137);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1690, 465);
            this.webView21.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webView21.TabIndex = 4;
            this.webView21.ZoomFactor = 1D;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(372, 753);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 49);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Tag = "";
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(571, 764);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(148, 26);
            this.textResult.TabIndex = 6;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(49, 814);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 26);
            this.textNum2.TabIndex = 7;
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(49, 743);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 26);
            this.textNum1.TabIndex = 8;
            this.textNum1.TextChanged += new System.EventHandler(this.textNum1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 788);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 670);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "SIMPLE CALCULATOR";
            // 
            // comboOperation
            // 
            this.comboOperation.FormattingEnabled = true;
            this.comboOperation.Items.AddRange(new object[] {
            "Add",
            "Substract",
            "Multiply",
            "Divide"});
            this.comboOperation.Location = new System.Drawing.Point(166, 764);
            this.comboOperation.Name = "comboOperation";
            this.comboOperation.Size = new System.Drawing.Size(165, 28);
            this.comboOperation.TabIndex = 13;
            this.comboOperation.Tag = "";
            this.comboOperation.Text = "Select Operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 730);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 941);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "RANDOM STRING GENERATOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 966);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Enter desired string length :";
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(244, 963);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(71, 26);
            this.textLength.TabIndex = 21;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(352, 966);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(142, 37);
            this.btnGenerate.TabIndex = 22;
            this.btnGenerate.Text = "Generate String";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // GeneratedString
            // 
            this.GeneratedString.AutoSize = true;
            this.GeneratedString.Location = new System.Drawing.Point(522, 974);
            this.GeneratedString.Name = "GeneratedString";
            this.GeneratedString.Size = new System.Drawing.Size(132, 20);
            this.GeneratedString.TabIndex = 23;
            this.GeneratedString.Text = "Generated String";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(1148, 712);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(460, 26);
            this.text.TabIndex = 24;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(1614, 704);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(116, 42);
            this.btn.TabIndex = 25;
            this.btn.Text = "Submit";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1274, 846);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "[Decrypted String]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1274, 791);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "[Encrypted String]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1135, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "TEXT ENCRYPTION/DECRYPTION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(890, 715);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Please Entera string for encryption";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(932, 794);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "The encrypted string looks like:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(932, 846);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(282, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Check if the decrypted string is correct:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1100);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.text);
            this.Controls.Add(this.GeneratedString);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textUrl;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label GeneratedString;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

