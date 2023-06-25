using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WFA_Hashing {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            cbAlgorithm.SelectedIndex = 0;
            RefreshText();
        }

        private void TbPlain_TextChanged(object sender, EventArgs e) {
            RefreshText();
        }

        private void RefreshText() {
            if (cbAlgorithm.Text == "SHA-1") {
                tbHashed.Text = Utilty.GetHash(SHA1.Create(), tbPlain.Text);
            } else if (cbAlgorithm.Text == "SHA-256") {
                tbHashed.Text = Utilty.GetHash(SHA256.Create(), tbPlain.Text);
            } else if (cbAlgorithm.Text == "SHA-384") {
                tbHashed.Text = Utilty.GetHash(SHA384.Create(), tbPlain.Text);
            } else if (cbAlgorithm.Text == "SHA-512") {
                tbHashed.Text = Utilty.GetHash(SHA512.Create(), tbPlain.Text);
            } else if (cbAlgorithm.Text == "MD-5") {
                tbHashed.Text = Utilty.GetHash(MD5.Create(), tbPlain.Text);
            } else if (cbAlgorithm.Text == "RIPEMD-160") {
                tbHashed.Text = Utilty.GetHash(RIPEMD160.Create(), tbPlain.Text);
            }
        }

        private void CbAlgorithm_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshText();
        }
    }
}
