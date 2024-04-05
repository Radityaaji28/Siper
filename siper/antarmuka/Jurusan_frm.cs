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
    public partial class Jurusan_frm : Form
    {
        Jurusan_cls jurusan = new Jurusan_cls();
        public Jurusan_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(id_txt.Text))
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
            if (!jurusan.apakahAda(id_txt.Text))
            {

                jurusan.Id_Jurusan = id_txt.Text;
                jurusan.Nama_Jurusan = nama_txt.Text;
                if (jurusan.simpanData() > 0)
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
                if(MessageBox.Show("Apakah yakin mengubah data?",
                    "INFORMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jurusan.Nama_Jurusan = nama_txt.Text;
                    if(jurusan.ubahData(id_txt.Text) > 0)
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

        private void hapus_btn_Click(object sender, EventArgs e)
        {
             
            if (jurusan.apakahAda(id_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin menghapus data?",
                    "INFORMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (jurusan.hapusData(id_txt.Text) > 0)
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

        void tampilGrid()
        {
            if(cari_txt.Text.Length==0) 
            {
                jurusan_dgv.DataSource = jurusan.tampilkanData();
            }
            else
            {
                jurusan_dgv.DataSource = jurusan.tampilkanDgnama(cari_txt.Text);
            }
            belangBelang(jurusan_dgv);
        }
        void belangBelang (DataGridView grid)
        {
            foreach(DataGridViewRow row in grid.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(row.Index%2 == 0)
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
        private void Jurusan_frm_Load(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void jurusan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.jurusan_dgv.Rows[e.RowIndex];
                id_txt.Text = baris.Cells[0].Value.ToString();
                nama_txt.Text = baris.Cells[1].Value.ToString();
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
    }
}
