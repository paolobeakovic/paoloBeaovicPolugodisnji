using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paoloBeakovicPolugodisnjiZadatak
{
    class Ucenik
    {
        string ime;
        string prezime;
        int godiste;
        string razred;
        string status;
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public string Razred { get => razred; set => razred = value; }
        public string Status { get => status; set => status = value; }

        public Ucenik(string ime, string prezime, int godiste, string razred)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godiste = godiste;
            this.razred = razred;
        }

        public override string ToString()
        {
            string ispis = this.ime + "          " + this.prezime + "          " + this.godiste + "          " + this.razred + "          " + this.status;
            return ispis;
        }
    }
}
