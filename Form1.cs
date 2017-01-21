using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RSA
{
    public partial class Form1 : Form
    {
        private RSA rsa;

        public Form1()
        {
            rsa = new RSA();
            InitializeComponent();
            text_priv_d.Text =  rsa.d.ToString();
            text_priv_n.Text = rsa.n.ToString();
            text_pub_n.Text = rsa.n.ToString();
            text_pub_e.Text = rsa.e.ToString();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = text.Text;
            byte[] dane = Encoding.ASCII.GetBytes(s);

            var zaszyfrowane = rsa.encrypt(dane);

            var stringBuilder = new StringBuilder();

            foreach (var bi in zaszyfrowane)
            {

                stringBuilder.Append(bi.ToString("X")+"\n");
                
            }
            text2.Text = " ";
            text2.Text = stringBuilder.ToString();
            text.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = text2.Text;
            var subStrings = s.Split('\n');
            var bigArray = new BigInteger[subStrings.Length];

            for (var index = 0; index < subStrings.Length -  1; index++)
            {
                var integer = Convert.ToUInt64(subStrings[index], 16);
                bigArray[index] = new BigInteger(integer);
            }


            var odszyfrowane = rsa.decrypt(bigArray);

            var stringB = new StringBuilder();

            foreach (var x in odszyfrowane)
            {
                stringB.Append((char) x);
            }
            text2.Text = " ";
            text.Text = stringB.ToString();
        }

        private void text_pub_e_TextChanged(object sender, EventArgs e)
        {
            rsa.e = Convert.ToInt32(text_pub_e.Text);
           

        }

        private void text_pub_n_TextChanged(object sender, EventArgs e)
        {
            rsa.n = Convert.ToInt32(text_pub_n.Text);
            text_priv_n.Text = text_pub_n.Text;
        }

        private void text_priv_d_TextChanged(object sender, EventArgs e)
        {
            rsa.d = Convert.ToInt32(text_priv_d.Text);
        }

        private void text_priv_n_TextChanged(object sender, EventArgs e)
        {
            rsa.n = Convert.ToInt32(text_priv_n.Text);
            text_pub_n.Text = text_priv_n.Text;
        }

        private void bReadFile_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream = null;

            var dlg = new OpenFileDialog();
            dlg.Filter = "Plik tekstowe (.txt)|*.txt";
            dlg.Multiselect = false;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((myStream = dlg.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            var myStreamReader = new System.IO.StreamReader(myStream);
                            String line = myStreamReader.ReadToEnd();
                            text.Text = line;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Błąd: Nie można odczytać pliku z dysku"+ex.ToString());
                }
            }

        }
    }
}
