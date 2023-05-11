using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019.model
{
    public class Imprumut
    {
        private int id;
        private int id_carte;
        private string email;
        private DateTime data;

        public Imprumut()
        {

        }

        public Imprumut(int id, int id_carte, string email, DateTime data)
        {
            this.id = id;
            this.id_carte = id_carte;
            this.email = email;
            this.data = data;
        }

        public Imprumut(string prop)
        {
            string[] a = prop.Split("*");

            this.id_carte = int.Parse(a[0]);
            this.email = a[1];
            this.data=DateTime.Parse(a[2]);

        }

        public string description()
        {
            string text = "";

            text+=id+",";
            text+=this.id_carte+",";
            text+=email+",";
            text+=data+"\n";

            return text;
        }

        public string save()
        {
            string text = "";

            text+=id+"*";
            text+=id_carte+"*";
            text+=email+"*";
            text+=data;

            return text;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Id_carte
        {
            get { return this.id_carte;}
            set { this.id_carte = value;}
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }



    }
}
