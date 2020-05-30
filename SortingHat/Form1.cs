using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ArrayList cesur = new ArrayList();
        public ArrayList mantik = new ArrayList();
        public ArrayList adalet = new ArrayList();
        public ArrayList kurnaz = new ArrayList();

        public void Doldur()
        {
            cesur.Add("Ben çok cesurum");
            cesur.Add("Cesur birisiyim");
            cesur.Add("Ben çok cesaretliyim");
            cesur.Add("Cesaret benim adım");

            mantik.Add("Mantık benim adım");
            mantik.Add("Mantıklı düşünerek hareket ederim");
            mantik.Add("Mantıklı davranmak çok akıllıca");
            mantik.Add("Akıllı birisiyim");

            adalet.Add("Adalet benim ismim");
            adalet.Add("Adalet heryerde olmalı");
            adalet.Add("Eşitlik ve adalet dengelenmeli");
            adalet.Add("Adaletli birisiyim");

            kurnaz.Add("Kurnazlık benim işim");
            kurnaz.Add("Çakal bir insanım");
            kurnaz.Add("Her kurnazlığı yaparım");
            kurnaz.Add("Kurnaz olmayı seviyorum");
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            ArrayList toplam = new ArrayList();
            toplam.AddRange(cesur);
            toplam.AddRange(mantik);
            toplam.AddRange(adalet);
            toplam.AddRange(kurnaz);
            string metin = txtMetin.Text;

            foreach(string liste in cesur)
            {
                if (metin == liste)
                {
                    pctResim.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "SortingHat\\gryffindor.jpg";
                    break;
                }
            }
            foreach (string liste in mantik)
            {
                if (metin == liste)
                {
                    pctResim.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "SortingHat\\ravenclaw.jpg";
                    break;
                }
            }
            foreach (string liste in adalet)
            {
                if (metin == liste)
                {
                    pctResim.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "SortingHat\\hufflepuff.jpg";
                    break;
                }
            }
            foreach (string liste in kurnaz)
            {
                if (metin == liste)
                {
                    pctResim.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "SortingHat\\Slytherin.jpg";
                    break;
                }
            }
            if (toplam.Contains(metin) != true)
                MessageBox.Show("Bu cümleyi bilmiyorum");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
