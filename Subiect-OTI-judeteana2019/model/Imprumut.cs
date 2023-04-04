using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019
{
    public class Imprumut
    {
        private string titlu;
        private string email;
        private DateTime data;

        public Imprumut()
        {

        }

        public Imprumut(string titlu,string email,DateTime data)
        {
            this.titlu = titlu;
            this.email = email;
            this.data = data;
        }

        public Imprumut(string prop)
        {
            string[] a = prop.Split("*");

            this.titlu = a[0];
            this.email = a[1];
            this.data=DateTime.Parse(a[2]);

        }

        public string description()
        {
            string text = "";

            text+=this.titlu+",";
            text+=this.email+",";
            text+=this.data+"\n";

            return text;
        }

        public string save()
        {
            string text = "";

            text+=this.titlu+"*";
            text+=this.email+"*";
            text+=this.data;

            return text;
        }

        public string Titlu
        {
            get { return this.titlu; }
            set { this.titlu = value;}
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value;}
        }

        public DateTime Data
        {
            get { return this.data; }
            set { this.data = value;}
        }



    }
}
