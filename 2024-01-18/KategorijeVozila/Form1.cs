using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KategorijeVozila
{
    struct Automobil
    {
        public enum Kategorija
        {
            Motocikl,
            Automobil,
            Kamion
        };
        public string model { get; set; }
        public int godina_proizvodnje { get; set; }
        public int broj_kotaca { get; set; }
        public Kategorija kategorija { get; set; }
    }

    public partial class Form1 : Form
    {

        List<Automobil> automobili = new List<Automobil>();
        public Form1()
        {
            InitializeComponent();
        }

        private void unos_b_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil();
            a.model = this.model.Text;

            int res;
            if (int.TryParse(this.godina_proizvodnje.Text, out res))
            {
                a.godina_proizvodnje = res;
            } else
            {
                MessageBox.Show("Godina proizvodnje nije broj!");
                return;
            }

            if (int.TryParse(this.broj_kotaca.Text, out res))
            {
                a.broj_kotaca = res;
                if (a.broj_kotaca % 2 == 1)
                {
                    MessageBox.Show("Neparan broj kotaca!!1");
                    return;
                }
            } else
            {
                MessageBox.Show("Broj kotača nije broj!");
                return;
            }

            if (this.kategorija.Text == "Motocikl")
            {
                a.kategorija = Automobil.Kategorija.Motocikl;
            }
            else if (this.kategorija.Text == "Automobil")
            {
                a.kategorija = Automobil.Kategorija.Automobil;
            }
            else if (this.kategorija.Text == "Kamion")
            {
                a.kategorija = Automobil.Kategorija.Kamion;
            }
            else
            {
                MessageBox.Show("Kategorija nije točna");
                return;
            }

            automobili.Add(a);
        }

        private void obrada_b_Click(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(this.broj_kotaca.Text, out res))
            {
                if (res % 2 == 1)
                {
                    MessageBox.Show("Neparan broj kotaca!!1");
                    return;
                } else if (res == 2)
                {
                    this.kategorija.Text = "Motocikl";
                }
                else if (res == 4)
                {
                    this.kategorija.Text = "Automobil";
                }
                else if (res > 4)
                {
                    this.kategorija.Text = "Kamion";
                }
                else
                {
                    MessageBox.Show("Ovo se nebi trebalo desit!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Broj kotača nije broj!");
                return;
            }
        }

        private void ispis_b_Click(object sender, EventArgs e)
        {
            string res = "";
            Dictionary<Automobil.Kategorija, int> kategorija_broj = new Dictionary<Automobil.Kategorija, int>();
            kategorija_broj[Automobil.Kategorija.Motocikl] = 0;
            kategorija_broj[Automobil.Kategorija.Automobil] = 0;
            kategorija_broj[Automobil.Kategorija.Kamion] = 0;

            foreach (Automobil auto in automobili)
            {
                res += "Model: " + auto.model + "\n";
                res += "Godina proizvodnje: " + auto.godina_proizvodnje.ToString() + "\n";
                res += "Broj kotača: " + auto.broj_kotaca.ToString() + "\n";
                res += "Kategorija: " + auto.godina_proizvodnje.ToString() + "\n";
                switch (auto.kategorija)
                {
                    case Automobil.Kategorija.Motocikl:
                        res += "Kategorija: " + "Motocikl" + "\n";
                        kategorija_broj[Automobil.Kategorija.Motocikl] += 1;
                        break;
                    case Automobil.Kategorija.Automobil:
                        res += "Kategorija: " + "Automobil" + "\n";
                        kategorija_broj[Automobil.Kategorija.Automobil] += 1;
                        break;
                    case Automobil.Kategorija.Kamion:
                        res += "Kategorija: " + "Kamion" + "\n";
                        kategorija_broj[Automobil.Kategorija.Kamion] += 1;
                        break;
                    default:
                        res += "Kategorija: " + "???" + "\n";
                        break;
                }
                res += "\n";
            }
            res += "Ukupan broj vozila po kategorijama:\n";
            res += "Motocikl: " + kategorija_broj[Automobil.Kategorija.Motocikl].ToString() + "\n";
            res += "Automobil: " + kategorija_broj[Automobil.Kategorija.Automobil].ToString() + "\n";
            res += "Kamion: " + kategorija_broj[Automobil.Kategorija.Kamion].ToString() + "\n";
            this.ispis.Text = res;
        }

    }
}
