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
    public partial class Form2 : Form
    {

        bool matytiSlaptazodi = false;
        private static string path = "Slaptazodis.csv";
        private static string path2 = "Prisijungimas.csv";
        private string key = "Raktelis";

        public Form2()
        {
            InitializeComponent();
        }

        static void Naujas(List<Slaptazodis> slaptazodzioInfo) 
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                csv.WriteRecords(slaptazodzioInfo);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (File.Exists(path2)) 
            {
                Sifravimas AES = new Sifravimas();
                AES.EncryptCiphering(path2, key);
            }
            if (File.Exists(path))
            {
                Sifravimas AES = new Sifravimas();
                AES.EncryptCiphering(path, key);
            }
        }

        private void Form2_Load(object sender, EventArgs e) 
        {
            if (File.Exists(path))
            {
                Sifravimas AES = new Sifravimas();
                AES.DecryptCiphering(path, key);
                Prideti();
            }
        }

        public void Prideti() 
        {
            listDB.Items.Clear();

            int ID = 1;

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var irasas = new Slaptazodis
                    {
                        Vardas = csv.GetField("Vardas"),
                        _Slaptazodis = csv.GetField("_Slaptazodis"),
                        URL = csv.GetField("URL"),
                        Komentaras = csv.GetField("Komentaras")
                    };

                    Sifravimas AES = new Sifravimas();
                    listDB.Items.Add(new ListViewItem(new string[] { ID.ToString(), irasas.Vardas, AES.PasswordCiphering(irasas._Slaptazodis, "Raktelis"), irasas.URL, irasas.Komentaras }));

                    ID++;
                }
            }
        }
        private void butRslap_Click(object sender, EventArgs e)
        {
            if (matytiSlaptazodi == false)
            {
                listDB.Items.Clear();

                int ID = 1;

                var slaptazodziai = new List<Slaptazodis>();

                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        var irasas = new Slaptazodis
                        {
                            Vardas = csv.GetField("Vardas"),
                            _Slaptazodis = csv.GetField("_Slaptazodis"),
                            URL = csv.GetField("URL"),
                            Komentaras = csv.GetField("Komentaras")
                        };

                        if (irasas.Vardas.Contains(txtSbar.Text))
                        {
                            listDB.Items.Add(new ListViewItem(new string[] { ID.ToString(), irasas.Vardas, irasas._Slaptazodis, irasas.URL, irasas.Komentaras }));
                            slaptazodziai.Add(irasas);
                        }
                        ID++;
                    }
                }
                matytiSlaptazodi = true;
            }
            else
            {
                Prideti();
                matytiSlaptazodi = false;

            }
        }

        private void butKslap_Click(object sender, EventArgs e)
        {
            string Kopijuoti = listDB.SelectedItems[0].SubItems[2].Text;
            Clipboard.SetText(Kopijuoti);

            MessageBox.Show("Nukopijuotas vartotojo " + listDB.SelectedItems[0].SubItems[1].Text + " slaptazodis");
        
         }

        private void butAlanga_Click(object sender, EventArgs e)
        {
            Prideti();
        }

        private void butPnslap_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            int ID = 1;

            listDB.Items.Clear();

            var slaptazodziai = new List<Slaptazodis>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var irasas = new Slaptazodis
                    {
                        Vardas = csv.GetField("Vardas"),
                        _Slaptazodis = csv.GetField("_Slaptazodis"),
                        URL = csv.GetField("URL"),
                        Komentaras = csv.GetField("Komentaras")
                    };

                    if (irasas.Vardas == txtPslap.Text)
                        irasas._Slaptazodis = txtPvar.Text;

                    listDB.Items.Add(new ListViewItem(new string[] { ID.ToString(), irasas.Vardas, irasas._Slaptazodis, irasas.URL, irasas.Komentaras }));

                    slaptazodziai.Add(irasas);
                    ID++;
                }
            }
            Naujas(slaptazodziai);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            int ID = 1;

            listDB.Items.Clear();

            var slaptazodziai = new List<Slaptazodis>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var irasas = new Slaptazodis
                    {
                        Vardas = csv.GetField("Vardas"),
                        _Slaptazodis = csv.GetField("_Slaptazodis"),
                        URL = csv.GetField("URL"),
                        Komentaras = csv.GetField("Komentaras")
                    };

                    if (irasas.Vardas != txtTvard.Text)
                    {
                        slaptazodziai.Add(irasas);
                        listDB.Items.Add(new ListViewItem(new string[] { ID.ToString(), irasas.Vardas, irasas._Slaptazodis, irasas.URL, irasas.Komentaras }));
                        ID++;
                    }
                }
            }
            Naujas(slaptazodziai);
        }

        private void txtSbar_TextChanged(object sender, EventArgs e)
        {
            matytiSlaptazodi = false;
            listDB.Items.Clear();

            int ID = 1;

            var slaptazodziai = new List<Slaptazodis>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var irasas = new Slaptazodis
                    {
                        Vardas = csv.GetField("Vardas"),
                        _Slaptazodis = csv.GetField("_Slaptazodis"),
                        URL = csv.GetField("URL"),
                        Komentaras = csv.GetField("Komentaras")
                    };

                    if (irasas.Vardas.Contains(txtSbar.Text))
                    {
                        if (matytiSlaptazodi == true)
                        {
                            listDB.Items.Add(new ListViewItem(new string[] { ID.ToString(), irasas.Vardas, irasas._Slaptazodis, irasas.URL, irasas.Komentaras }));
                            slaptazodziai.Add(irasas);
                        }
                        else
                        {
                            Sifravimas AES = new Sifravimas();
                            listDB.Items.Add(new ListViewItem(new string[] { ID.ToString(), irasas.Vardas, AES.PasswordCiphering(irasas._Slaptazodis, "Tedis"), irasas.URL, irasas.Komentaras }));
                            slaptazodziai.Add(irasas);

                        }
                    }
                    ID++;
                }
            }
        }
    }
}
