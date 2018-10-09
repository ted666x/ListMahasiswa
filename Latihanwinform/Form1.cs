using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihanwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if  (!mskNPM.MaskFull)
            {
                MessageBox.Show("NPM harus diisi!!!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                mskNPM.Focus();
                return;
            }

            if (!(txtNama.Text.Length > 0))
            {
                MessageBox.Show("Nama harus diisi!!!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtNama.Focus();
                return;
            }

            if (!(txtTempatLahir.Text.Length > 0))
            {
                MessageBox.Show("Tempat Lahir diisi!!!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtTempatLahir.Focus();
                return;
            }

            
            {
                dtpTanggalLahir.Value = DateTime.Today;
                dtpTanggalLahir.Focus();
            }
            
            var jenisKelamin = rdoLakilaki.Checked ? "Laki-laki" : "Perempuan";

            var msg = string.Format("NPM : {0} \nNama: {1} \nJenis Kelamin: {2} \nTempat Lahir & Tanggal Lahir: {3} , {4}",
                mskNPM.Text, txtNama.Text, jenisKelamin, txtTempatLahir.Text , dtpTanggalLahir.Value);

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            var msg = "apakah anda yakin ?";
            var result = MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mskNPM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
