using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace SerializationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaYolu = "urunler.json";
                if (!File.Exists(dosyaYolu))
                {
                    MessageBox.Show("JSON dosyasý bulunamadý!");
                    return;
                }

                string jsonString = File.ReadAllText(dosyaYolu);
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                lstUrunler.Items.Clear();
                foreach (var urun in urunler)
                {
                    lstUrunler.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}