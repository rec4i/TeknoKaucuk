namespace TeknoKaucuk
{
    partial class DorduncuIslevsellikForm
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
            this.DosyaSeç = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DosyaSeç
            // 
            this.DosyaSeç.Location = new System.Drawing.Point(382, 39);
            this.DosyaSeç.Name = "DosyaSeç";
            this.DosyaSeç.Size = new System.Drawing.Size(132, 21);
            this.DosyaSeç.TabIndex = 0;
            this.DosyaSeç.Text = "Dosya Seç";
            this.DosyaSeç.UseVisualStyleBackColor = true;
            this.DosyaSeç.Click += new System.EventHandler(this.DosyaSeçBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 394);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya Yolu";
            // 
            // DorduncuIslevsellikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DosyaSeç);
            this.Name = "DorduncuIslevsellikForm";
            this.Text = "DorduncuIslevsellikForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DosyaSeç;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}