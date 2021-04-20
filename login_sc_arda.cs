using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stok_programi
{
    public partial class login_sc_arda : Form
    {
        public login_sc_arda()
        {
            InitializeComponent();
        }

        private void giris_yap_Click(object sender, EventArgs e)
        {
            string k_adi;
            string sifre;

            k_adi = textBox1.Text;
            sifre = textBox2.Text;

            if (k_adi == "admin" && sifre == "123") {
                this.Hide();
                Form frm = new Form1();
                frm.Show();
            } else {
                MessageBox.Show("Şifre veya kullanıcı adı yanlış");
            }
        }

        private void login_sc_arda_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
