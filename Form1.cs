using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_3_1184064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void texthuruf_Leave(object sender, EventArgs e)
        {
            if (texthuruf.Text == "")
            {
                epWarning.SetError(texthuruf, "Text Tidak Boleh Kosong!");
                epWrong.SetError(texthuruf, "");
                epCorrect.SetError(texthuruf, ""); 
            }
            else
            {
                if ((texthuruf.Text).All(char.IsLetter))
                {
                    epWarning.SetError(texthuruf, "");
                    epWrong.SetError(texthuruf, "");
                    epCorrect.SetError(texthuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(texthuruf, "Inputan hanya boleh huruf");
                    epWarning.SetError(texthuruf, "");
                    epCorrect.SetError(texthuruf, "");
                }
            }
        }

        private void textangka_Leave(object sender, EventArgs e)
        {
            if ((textangka.Text).All(char.IsNumber))
            {
                epCorrect.SetError(texthuruf, "Betul!");
                epWarning.SetError(textangka, "");
                epWrong.SetError(textangka, "");
            }
            else
            {
                epCorrect.SetError(textangka, "");
                epWarning.SetError(textangka, "");
                epWrong.SetError(textangka, "Inputan hanya boleh angka");
            }
        }

        private void textemail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textemail.Text, @"^^[@^\s]+@[@^\s]+(\.[@^\s]+)+$"))
            {
                epWarning.SetError(textemail, "");
                epWrong.SetError(textemail, "");
                epCorrect.SetError(textemail, "Betul!");
            }
            else
            {
                epWrong.SetError(textemail, "Format email salah!\ nContoh: a@b.c");
                epWarning.SetError(textemail, "");
                epCorrect.SetError(textemail, "");
            }
        }
    }
