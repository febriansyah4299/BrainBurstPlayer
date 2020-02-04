using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Brain_Burst_Player
{
    public partial class Form1 : Form
    {
        Aksi BBP = new Aksi();
        public Form1()
        {
            InitializeComponent();
        }

        private void TombolTambah_Click(object sender, EventArgs e)
        {
            BukaDonk.Filter = "MP3 (*.mp3)|*.mp3|Semua File(*.*)|*.*";
            if (BukaDonk.ShowDialog() == DialogResult.OK)
            {
                AjebAjeb.Text = BukaDonk.SafeFileName;
                BBP.BukaDikitJos(BukaDonk.FileName);
                BBP.TarikMang(AjebAjeb.Text);
            }
        }

        private void TombolPlay_Click(object sender, EventArgs e)
        {
            BBP.TarikMang(AjebAjeb.Text);
        }

        private void TombolPause_Click(object sender, EventArgs e)
        {
            BBP.TahanSebentar();
        }

        private void TombolStop_Click(object sender, EventArgs e)
        {
            BBP.SampunRampung();
        }

        private void TombolSayonara_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin?", "Konfirmasi Keluar aplikasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bukaBerkasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BukaDonk.Filter = "MP3 (*.mp3)|*.mp3|Semua File(*.*)|*.*";
            if (BukaDonk.ShowDialog()==DialogResult.OK)
            {
                AjebAjeb.Text = BukaDonk.SafeFileName;
                BBP.BukaDikitJos(BukaDonk.FileName);
                BBP.TarikMang(AjebAjeb.Text);
            }
        }

        private void tutupAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin?","Konfirmasi Keluar aplikasi",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Close();
            }
        }

        private void tentangBrainBurstPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brain Burst Player| Febriansyah : Programer, Jodi MT : Designer, Kevin R : Designer","Tentang");
        }

        private void lisensiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aplikasi ini memakai lisensi Public Domain, tetapi kami saat ini sedang mengerjakan proyek (media player) yang lebih kompleks dengan lisensi GNU General Public License V3.0","Lisensi");
        }
    }
}
