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
    public partial class prodi_frm : Form
    {
        prodi_cls prodi = new prodi_cls();
        public prodi_frm()
        {
            InitializeComponent();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(id_txt.Text))
            {
                MessageBox.Show("Sudah ada");
            }
            else
            {
                MessageBox.Show("Belum ada");
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!prodi.apakahAda(id_txt.Text))
            {
                prodi.Id_Prodi = id_txt.Text;
                prodi.Nama_Prodi = nama_txt.Text;

                string idJurusan = jurusan_cmb.SelectedValue.ToString();
                prodi.Id_Jurusan = idJurusan;
                if (prodi.simpanData() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    id_txt.Focus();
                    id_txt.Clear();
                    nama_txt.Clear();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Maaf data input tidak valid",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    id_txt.Focus();
                }
            }
            else
            {
                if (MessageBox.Show("Apakah yakin mengubah data?",
                    "INFORMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prodi.Nama_Prodi = nama_txt.Text;
                    string idJurusan = jurusan_cmb.SelectedValue.ToString();
                    prodi.Id_Jurusan = idJurusan;
                    if (prodi.ubahData(id_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil diubah",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        id_txt.Focus();
                        id_txt.Clear();
                        nama_txt.Clear();
                        tampilGrid();
                    }
                }
            }
        }

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                prodi_dgv.DataSource = prodi.tampilkanData();
            }
            else
            {
                prodi_dgv.DataSource = prodi.tampilkanDgnama(cari_txt.Text);
            }
            belangBelang(prodi_dgv);
        }

        void belangBelang(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Index % 2 == 0)
                    {
                        cell.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(id_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin menghapus data?",
                    "INFORMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (prodi.hapusData(id_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        id_txt.Focus();
                        id_txt.Clear();
                        nama_txt.Clear();
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dihapus",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        id_txt.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data Tidak ditemukan",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                id_txt.Focus();
            }
        }

        private void prodi_frm_Load(object sender, EventArgs e)
        {
            jurusan_cmb.DataSource = prodi.getComboJurusan();
            jurusan_cmb.DisplayMember = "nama_jurusan";
            jurusan_cmb.ValueMember = "id_jurusan";
            tampilGrid();
        }

        private void prodi_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.prodi_dgv.Rows[e.RowIndex];
                id_txt.Text = baris.Cells[0].Value.ToString();
                nama_txt.Text = baris.Cells[1].Value.ToString();
                string idJurusan = baris.Cells[2].Value?.ToString();
                int index = jurusan_cmb.FindStringExact(idJurusan);

                // Pilih item di ComboBox berdasarkan indeks
                if (index != -1)
                {
                    jurusan_cmb.SelectedIndex = index;
                }
                else
                {
                    // Jika nilai idJurusan tidak ditemukan di ComboBox
                    MessageBox.Show("Nilai id jurusan tidak ditemukan di ComboBox.");
                }

                // Set nilai id_jurusan_text
                jurusan_cmb.Text = baris.Cells[2].Value?.ToString();

            }
        }

        private void cari_btn_Click(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin akan keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nama_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
