using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHat
{
    public partial class Train : Form
    {
        Form1 frm1 = new Form1();
        public Train()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtKelime.Text == null || txtKelime.Text == " " || cmbList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm seçenekleri doğru şekilde kodlayınız");
            }
            else
            {
                if (cmbList.SelectedItem.ToString() == "Gryffindor-Cesurlar")
                {
                    frm1.cesur.Add(txtKelime.Text);
                    txtKelime.Clear();
                    cmbList.SelectedIndex = -1;
                    MessageBox.Show("Ekleme başarılı.");
                }
                else if (cmbList.SelectedItem.ToString() == "Hufflepuff-Adaletliler")
                {
                    frm1.adalet.Add(txtKelime.Text);
                    txtKelime.Clear();
                    cmbList.SelectedIndex = -1;
                    MessageBox.Show("Ekleme başarılı.");
                }
                else if (cmbList.SelectedItem.ToString() == "Ravenclaw-Mantıklılar")
                {
                    frm1.mantik.Add(txtKelime.Text);
                    txtKelime.Clear();
                    cmbList.SelectedIndex = -1;
                    MessageBox.Show("Ekleme başarılı.");
                }
                else if (cmbList.SelectedItem.ToString() == "Slytherin-Kurnazlar")
                {
                    frm1.kurnaz.Add(txtKelime.Text);
                    txtKelime.Clear();
                    cmbList.SelectedIndex = -1;
                    MessageBox.Show("Ekleme başarılı.");
                }
                else
                    MessageBox.Show("Bir sorun var");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }
    }
}
