using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace _4_darbas
{
    public partial class Form3 : Form
    {

        private static string path = "Slaptazodis.csv";

        public Form3()
        {
            InitializeComponent();
        }

        List<Slaptazodis> GautiSlaptazodi() 
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var slaptazodziai = new List<Slaptazodis>();
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var record = new Slaptazodis
                    {
                        Vardas = csv.GetField("Vardas"),
                        _Slaptazodis = csv.GetField("_Slaptazodis"),
                        URL = csv.GetField("URL"),
                        Komentaras = csv.GetField("Komentaras")
                    };

                    slaptazodziai.Add(record);
                }
                return slaptazodziai;
            }
        }

        private void butPri_Click(object sender, EventArgs e)
        {
            try
            {
                bool contains = false;

                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var slaptazdodziai = new List<Slaptazodis>();
                    csv.Read();
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        var irasas = new Slaptazodis { Vardas = csv.GetField("Vardas") };

                        if (irasas.Vardas == txtVard.Text)
                        {
                            contains = true;
                            MessageBox.Show("Iraso pavadinimas jau egzistuoja!");
                            return;
                        }
                    }
                }
                if (string.IsNullOrEmpty(txtSlap.Text))
                {
                    MessageBox.Show("Neivestas pavadinimas!");
                    return;
                }
                if (string.IsNullOrEmpty(txtURL.Text))
                {
                    MessageBox.Show("Neivestas slaptazodis!");
                    return;
                }
                if (string.IsNullOrEmpty(txtKom.Text))
                {
                    MessageBox.Show("Iveskite URL (arba jo pavadinima)!");
                    return;
                }

                List<Slaptazodis> gSlapt = GautiSlaptazodi();

                gSlapt.Add(new Slaptazodis { Vardas = txtVard.Text, _Slaptazodis = txtSlap.Text, URL = txtURL.Text, Komentaras = txtKom.Text });

                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    csv.WriteRecords(gSlapt);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida: " + ex.Message);
            }
        }

        private void butGslap_Click(object sender, EventArgs e)
        {
            int ilgis = 10;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < ilgis--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            string password = res.ToString();
            txtSlap.Text = password;
        }
    }
}
