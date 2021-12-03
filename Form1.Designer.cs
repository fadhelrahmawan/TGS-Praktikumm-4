namespace P4_3_1184064
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
            this.components = new System.ComponentModel.Container();
            this.Huruf = new System.Windows.Forms.Label();
            this.Angka = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.textangka = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.texthuruf = new System.Windows.Forms.TextBox();
            this.merah = new System.Windows.Forms.Label();
            this.Angka1 = new System.Windows.Forms.Label();
            this.Angka2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // Huruf
            // 
            this.Huruf.AutoSize = true;
            this.Huruf.Location = new System.Drawing.Point(61, 36);
            this.Huruf.Name = "Huruf";
            this.Huruf.Size = new System.Drawing.Size(33, 13);
            this.Huruf.TabIndex = 0;
            this.Huruf.Text = "Huruf";
            // 
            // Angka
            // 
            this.Angka.AutoSize = true;
            this.Angka.Location = new System.Drawing.Point(61, 68);
            this.Angka.Name = "Angka";
            this.Angka.Size = new System.Drawing.Size(38, 13);
            this.Angka.TabIndex = 1;
            this.Angka.Text = "Angka";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(61, 103);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // textangka
            // 
            this.textangka.Location = new System.Drawing.Point(186, 68);
            this.textangka.Name = "textangka";
            this.textangka.Size = new System.Drawing.Size(100, 20);
            this.textangka.TabIndex = 3;
            this.textangka.Leave += new System.EventHandler(this.textangka_Leave);
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(186, 103);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 20);
            this.textemail.TabIndex = 4;
            this.textemail.Leave += new System.EventHandler(this.textemail_Leave);
            // 
            // texthuruf
            // 
            this.texthuruf.Location = new System.Drawing.Point(186, 42);
            this.texthuruf.Name = "texthuruf";
            this.texthuruf.Size = new System.Drawing.Size(100, 20);
            this.texthuruf.TabIndex = 5;
            this.texthuruf.Leave += new System.EventHandler(this.texthuruf_Leave);
            // 
            // merah
            // 
            this.merah.AutoSize = true;
            this.merah.ForeColor = System.Drawing.Color.Red;
            this.merah.Location = new System.Drawing.Point(64, 225);
            this.merah.Name = "merah";
            this.merah.Size = new System.Drawing.Size(93, 13);
            this.merah.TabIndex = 6;
            this.merah.Text = "*angka1 >Angka2";
            // 
            // Angka1
            // 
            this.Angka1.AutoSize = true;
            this.Angka1.Location = new System.Drawing.Point(64, 252);
            this.Angka1.Name = "Angka1";
            this.Angka1.Size = new System.Drawing.Size(47, 13);
            this.Angka1.TabIndex = 7;
            this.Angka1.Text = "Angka 1";
            // 
            // Angka2
            // 
            this.Angka2.AutoSize = true;
            this.Angka2.Location = new System.Drawing.Point(64, 278);
            this.Angka2.Name = "Angka2";
            this.Angka2.Size = new System.Drawing.Size(44, 13);
            this.Angka2.TabIndex = 8;
            this.Angka2.Text = "Angka2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Angka2);
            this.Controls.Add(this.Angka1);
            this.Controls.Add(this.merah);
            this.Controls.Add(this.texthuruf);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textangka);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Angka);
            this.Controls.Add(this.Huruf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Huruf;
        private System.Windows.Forms.Label Angka;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textangka;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox texthuruf;
        private System.Windows.Forms.Label merah;
        private System.Windows.Forms.Label Angka1;
        private System.Windows.Forms.Label Angka2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

