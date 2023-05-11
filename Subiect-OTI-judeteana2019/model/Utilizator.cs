using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019.model
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

            email=a[0];
            parola = a[1];
            nume = a[2];
            prenume = a[3];

        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Parola
        {
            get { return parola; }
            set { parola = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string description()
        {

            string text = "";

            text+=email+",";
            text+=parola+",";
            text+=nume+",";
            text+=prenume+"\n";

            return text;

        }

        public string save()
        {

            string text = "";

            text+=email+",";
            text+=parola+",";
            text+=nume+",";
            text+=prenume;

            return text;


        }



    }
}
