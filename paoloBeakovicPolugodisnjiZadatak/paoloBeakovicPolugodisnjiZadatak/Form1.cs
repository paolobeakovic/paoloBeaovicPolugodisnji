using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paoloBeakovicPolugodisnjiZadatak
{
    public partial class Form1 : Form
    {
        List<Ucenik> Ucenik = new List<Ucenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string godiste1 = textBox3.Text;
            string razred = textBox4.Text;

            if(string.IsNullOrWhiteSpace(ime) || string.IsNullOrWhiteSpace(prezime) || string.IsNullOrWhiteSpace(godiste1) || string.IsNullOrWhiteSpace(razred))
            {
                MessageBox.Show("Pogrešni podavi");
                return;
            }
            int godiste = Convert.ToInt32(godiste1);
            Ucenik.Add(new Ucenik(ime, prezime, godiste, razred));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Ime          Prezime          Godiste          Razred          Status");
            foreach(Ucenik ucenik in Ucenik)
            {
                listBox1.Items.Add(ucenik.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<Ucenik.Count; i++)
            {
                if (2020 - Ucenik[i].Godiste < 14)
                {
                    Ucenik[i].Status = "Junior";
                }else if(Ucenik[i].Godiste == 2002)
                {
                    Ucenik[i].Status = "OldTimer";
                }
                else
                {
                    Ucenik[i].Status = "Senior";
                }
            }
        }
    }
}
