using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019
{
    public class Utilizator
    {
        private string email;
        private string parola;
        private string nume;
        private string prenume;

        public Utilizator()
        {

        }

        public Utilizator(string email, string parola, string nume, string prenume)
        {
            this.email = email;
            this.parola = parola;
            this.nume = nume;
            this.prenume = prenume;
        }

        public Utilizator(string prop)
        {
            string[] a = prop.Split(",");

            this.email=a[0];
            this.parola = a[1];
            this.nume = a[2];
            this.prenume = a[3];

        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Parola
        {
            get { return this.parola; }
            set { this.parola = value;}
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value;}
        }

        public string Prenume
        {
            get { return this.prenume;}
            set { this.prenume = value;}
        }

        public string description()
        {

            string text = "";

            text+=this.email+",";
            text+=this.parola+",";
            text+=this.nume+",";
            text+=this.prenume+"\n";

            return text;

        }

        public string save()
        {

            string text = "";

            text+=this.email+",";
            text+=this.parola+",";
            text+=this.nume+",";
            text+=this.prenume;

            return text;


        }



    }
}
