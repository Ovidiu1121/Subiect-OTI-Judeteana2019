using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019
{
    public  class Carte
    {

        private int id;
        private string titlu;
        private string autor;
        private string gen;

        public Carte()
        {

        }

        public Carte(int id,string titlu,string autor,string gen)
        {
            this.id=id;
            this.titlu=titlu;
            this.autor=autor;
            this.gen=gen;
        }

        public Carte(string prop)
        {
            string[] a = prop.Split(",");

            this.id=int.Parse(a[0]);
            this.titlu = a[1];
            this.autor=a[2];
            this.gen=a[3];


        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Titlu
        {
            get { return this.titlu; }
            set { this.titlu = value;}
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value;}
        }

        public string Gen
        {
            get { return this.gen; }
            set { this.gen = value;}
        }

        public string description()
        {
            string text = "";

            text+=this.id+",";
            text+=this.titlu+",";
            text+=this.autor+",";
            text+=this.gen+"\n";

            return text;

        }

        public string save()
        {

            string text = "";

            text+=this.id+",";
            text+=this.titlu+",";
            text+=this.autor+",";
            text+=this.gen;

            return text;

        }


    }
}
