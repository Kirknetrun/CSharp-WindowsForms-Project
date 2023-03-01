using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        int newSize = 0;

        /// <summary>
        /// Oblicza
        /// </summary>
        private void buttonOblicz_Click(object sender, EventArgs e)
        {

            if (textBoxLitry.Text.Length != 0 && textBoxKilometry.Text.Length != 0)
            {
                newSize = 15;
                double iloscPaliwa = double.Parse(textBoxLitry.Text);
                double kilometry = double.Parse(textBoxKilometry.Text);
                double cenaZaCalaTrase = 0;

                double srednieSpalanie = SrednieSpalanie(iloscPaliwa, kilometry);
                double cenaZaStoKm;

                labelWynik.Text = "Srednie spalanie: " + (srednieSpalanie).ToString("#.00") + "\n L./100km";
                labelWynik.ForeColor = Color.Red;
                labelWynik.Font = new Font(labelWynik.Font.FontFamily, newSize, FontStyle.Bold);

                if (textBoxCenaZaLitr.Text.Length != 0)
                {
                    newSize = 12;
                    double cenaZaLitr = double.Parse(textBoxCenaZaLitr.Text);
                    cenaZaStoKm = srednieSpalanie * cenaZaLitr;
                    cenaZaCalaTrase = CenaZaCalaTrase(cenaZaStoKm, kilometry);

                    labelWynik2.Text = "Cena za 100km: " + (cenaZaStoKm).ToString("#.00") + " zl.";
                    labelWynik2.Font = new Font(labelWynik.Font.FontFamily, newSize, FontStyle.Bold);

                    labelWynik3.Text = "Cena za cala trase: " + (cenaZaCalaTrase).ToString("#.00") + " zl.";
                    labelWynik3.Font = new Font(labelWynik.Font.FontFamily, newSize, FontStyle.Bold);
                }
            }
            else
            {
                newSize = 15;
                labelWynik.Text = "Podaj ilosc paliwa oraz\n przejechana trase!!!";
                labelWynik.ForeColor = Color.Red;
                labelWynik.Font = new Font(labelWynik.Font.FontFamily, newSize, FontStyle.Bold);
            }
        }

        /// <summary>
        /// Zamyka aplikacje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Czysci wartosci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            newSize = 9;
            textBoxLitry.Clear();
            textBoxKilometry.Clear();
            textBoxCenaZaLitr.Clear();

            labelWynik.Text = "Wynik: ________";
            labelWynik.ForeColor = Color.Black;
            labelWynik.Font = new Font(labelWynik.Font.FontFamily, newSize, FontStyle.Bold);

            labelWynik2.Text = "Cena: __________";
            labelWynik2.ForeColor = Color.Black;
            labelWynik2.Font = new Font(labelWynik.Font.FontFamily, newSize, FontStyle.Bold);

            labelWynik3.Text = "Cała trasa: _____";
            labelWynik3.ForeColor = Color.Black;
            labelWynik3.Font = new Font(labelWynik.Font.FontFamily, newSize, FontStyle.Bold);
        }

        /// <summary>
        /// Oblicza srednie spalanie
        /// </summary>
        /// <param name="iloscPaliwa"></param>
        /// <param name="kilometry"></param>
        /// <returns>double</returns>
        public static double SrednieSpalanie(double iloscPaliwa, double kilometry)
        {
            return (iloscPaliwa / kilometry) * 100;
        }

        /// <summary>
        /// Oblicza cenę za cala trase
        /// </summary>
        /// <param name="cenaZaStoKm"></param>
        /// <param name="kilometry"></param>
        /// <returns>double</returns>
        public static double CenaZaCalaTrase(double cenaZaStoKm, double kilometry)
        {
            return (cenaZaStoKm * kilometry) / 100;
        }
    }
}
