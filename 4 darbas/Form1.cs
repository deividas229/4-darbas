using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Security.Cryptography;

namespace _4_darbas
{
    public partial class Form1 : Form
    {

        private string key = "Raktelis";
        private static string path = "Prisijungimas.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void butPrisijungti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVardas.Text))
            {
                MessageBox.Show("Iveskite prisijungimo varda!");
                return;
            }

            if (string.IsNullOrEmpty(txtSlap.Text))
            {
                MessageBox.Show("Iveskite slaptazodi!");
                return;
            }
            {
                string vartotojoVardas = "", vartotojoSlaptazodis = "";
                Sifravimas AES = new Sifravimas();
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        try
                        {
                            var vart = new Vartotojas
                            {
                                Username = csv.GetField("Username"),
                                Password = AES.PasswordDecrypt(csv.GetField("Password"), key),
                            };

                            vartotojoVardas = vart.Username;
                            vartotojoSlaptazodis = vart.Password;
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }

                    }
                }
                if (txtSlap.Text != vartotojoSlaptazodis || txtVardas.Text != vartotojoVardas)
                {
                    MessageBox.Show("Neteisingai ivesti duomenys");

                    return;
                }
            }
            new Form2().Show();
            Hide();
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVardas.Text))
            {
                MessageBox.Show("Neivestas prisijungimo vardas");
                return;
            }

            if (string.IsNullOrEmpty(txtSlap.Text))
            {
                MessageBox.Show("Neivestas slaptazodis");
                return;
            }

            List<Vartotojas> VartotojoData = new List<Vartotojas>();
            Sifravimas AES = new Sifravimas();
            VartotojoData.Add(new Vartotojas() { Username = txtVardas.Text, Password = AES.PasswordCiphering(txtSlap.Text, "Raktelis") });

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) csv.WriteRecords(VartotojoData);

            string failas = File.ReadAllText(path);
            File.WriteAllText(path, failas);
            MessageBox.Show("Registracija sekminga");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Prisijungimas.csv"))
            {
                Sifravimas AES = new Sifravimas();
                string file = "Prisijungimas.csv";
                AES.DecryptCiphering(file, key);
            }
        }


         private void Form1_FormClosing(object sender, FormClosingEventArgs e)
         {
           if (File.Exists("Prisijungimas.csv"))
           {
               Sifravimas AES = new Sifravimas();
               string file = "Prisijungimas.csv";
               AES.EncryptCiphering(file, key);
           }

         }
    }
}
