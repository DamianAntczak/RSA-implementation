namespace RSA
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
            this.text = new System.Windows.Forms.RichTextBox();
            this.text2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.text_pub_n = new System.Windows.Forms.TextBox();
            this.text_pub_e = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.text_priv_n = new System.Windows.Forms.TextBox();
            this.text_priv_d = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Location = new System.Drawing.Point(1, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(454, 150);
            this.text.TabIndex = 0;
            this.text.Text = "";
            // 
            // text2
            // 
            this.text2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text2.Location = new System.Drawing.Point(1, 197);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(454, 95);
            this.text2.TabIndex = 1;
            this.text2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Szyfruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Deszyfruj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 300);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(455, 100);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.text_pub_n);
            this.tabPage1.Controls.Add(this.text_pub_e);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klucz publiczny:";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // text_pub_n
            // 
            this.text_pub_n.Location = new System.Drawing.Point(29, 32);
            this.text_pub_n.Name = "text_pub_n";
            this.text_pub_n.Size = new System.Drawing.Size(100, 20);
            this.text_pub_n.TabIndex = 3;
            this.text_pub_n.TextChanged += new System.EventHandler(this.text_pub_n_TextChanged);
            // 
            // text_pub_e
            // 
            this.text_pub_e.Location = new System.Drawing.Point(29, 3);
            this.text_pub_e.Name = "text_pub_e";
            this.text_pub_e.Size = new System.Drawing.Size(100, 20);
            this.text_pub_e.TabIndex = 2;
            this.text_pub_e.TextChanged += new System.EventHandler(this.text_pub_e_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "e";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.text_priv_n);
            this.tabPage2.Controls.Add(this.text_priv_d);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(447, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "klucz prywatny:";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // text_priv_n
            // 
            this.text_priv_n.Location = new System.Drawing.Point(29, 32);
            this.text_priv_n.Name = "text_priv_n";
            this.text_priv_n.Size = new System.Drawing.Size(100, 20);
            this.text_priv_n.TabIndex = 3;
            this.text_priv_n.TextChanged += new System.EventHandler(this.text_priv_n_TextChanged);
            // 
            // text_priv_d
            // 
            this.text_priv_d.Location = new System.Drawing.Point(29, 3);
            this.text_priv_d.Name = "text_priv_d";
            this.text_priv_d.Size = new System.Drawing.Size(100, 20);
            this.text_priv_d.TabIndex = 2;
            this.text_priv_d.TextChanged += new System.EventHandler(this.text_priv_d_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "RSA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.RichTextBox text2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_pub_n;
        private System.Windows.Forms.TextBox text_pub_e;
        private System.Windows.Forms.TextBox text_priv_n;
        private System.Windows.Forms.TextBox text_priv_d;
    }
}

