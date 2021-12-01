using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace generatePassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = EncryptSHA512(textBox1.Text.Trim());
        }
        public static string EncryptSHA512(string Data)

        {

            SHA512 sha = new SHA512Managed();

            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {

                stringBuilder.AppendFormat("{0:x2}", b);

            }

            return stringBuilder.ToString();

        }

        public static string EncryptSHA1(string Data)
        {

            SHA1 sha = new SHA1Managed();

            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {

                stringBuilder.AppendFormat("{0:x2}", b);

            }

            return stringBuilder.ToString();

        }     


    }
}
