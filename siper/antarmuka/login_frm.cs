using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siper.antarmuka
{
    using layanan;
    public partial class login_frm : Form
    {
        pengguna_cls user = new pengguna_cls();
        public login_frm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin akan keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user.apakahAdaUser(username_txt.Text, password_txt.Text))
            {
                dashboard_frm dashboard = new dashboard_frm();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_txt.SelectAll();
                username_txt.Focus();
            }
        }
    }
}
