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
    public partial class dashboard_frm : Form
    {
        public dashboard_frm()
        {
            InitializeComponent();
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jurusan_frm jurusan = new Jurusan_frm();
            jurusan.Show();
        }

        private void programStudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodi_frm prodi = new prodi_frm();
            prodi.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin akan keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
