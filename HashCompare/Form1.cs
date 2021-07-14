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
using System.IO;

namespace HashCompare
{
    public partial class Form1 : Form
    {
        private MD5 Md5 = MD5.Create();
        private SHA1 Sha1 = SHA1.Create();
        private SHA256 Sha256 = SHA256.Create();
        private SHA512 Sha512 = SHA512.Create();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "File select";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txbPath.Text = openFileDialog.FileName;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbPath.Text))
            {
                MessageBox.Show("Select a file to proceed", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!cbMD5.Checked && !cbSHA1.Checked && !cbSHA256.Checked && !cbSHA512.Checked)
                {
                    MessageBox.Show("Select at least one hash type", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txbMD5.Clear();
                    txbSHA1.Clear();
                    txbSHA256.Clear();
                    txbSHA512.Clear();

                    if (cbMD5.Checked)
                    {
                        txbMD5.Text = BytesToString(GetHashMD5(txbPath.Text));
                    }
                    if (cbSHA1.Checked)
                    {
                        txbSHA1.Text = BytesToString(GetHashSHA1(txbPath.Text));
                    }
                    if (cbSHA256.Checked)
                    {
                        txbSHA256.Text = BytesToString(GetHashSHA256(txbPath.Text));
                    }
                    if (cbSHA512.Checked)
                    {
                        txbSHA512.Text = BytesToString(GetHashSHA512(txbPath.Text));
                    }
                }
            }
        }

        private byte[] GetHashSHA512(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                return Sha512.ComputeHash(stream);
            }
        }

        private byte[] GetHashSHA256(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                return Sha256.ComputeHash(stream);
            }
        }

        private byte[] GetHashSHA1(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                return Sha1.ComputeHash(stream);
            }
        }

        private byte[] GetHashMD5(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                return Md5.ComputeHash(stream);
            }
        }
        private string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
            {
                result += b.ToString("x2");
            }
            return result.ToUpper();
        }
    }
}
