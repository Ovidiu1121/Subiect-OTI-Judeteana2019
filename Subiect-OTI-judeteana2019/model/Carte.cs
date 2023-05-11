using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019.model
{
    public class Carte
    {

        private int id;
        private string titlu;
        private string autor;
        private string gen;

        public Carte()
        {

        }

        public Carte(int id, string titlu, string autor, string gen)
        {
            this.id=id;
            this.titlu=titlu;
            this.autor=autor;
            this.gen=gen;
        }

        public Carte(string prop)
        {
            string[] a = prop.Split(",");

            id=int.Parse(a[0]);
            titlu = a[1];
            autor=a[2];
            gen=a[3];


        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Gen
        {
            get { return gen; }
            set { gen = value; }
        }

        public string description()
        {
            string text = "";

            text+=id+",";
            text+=titlu+",";
            text+=autor+",";
            text+=gen+"\n";

            return text;

        }

        public string save()
        {

            string text = "";

            text+=id+",";
            text+=titlu+",";
            text+=autor+",";
            text+=gen;

            return text;

        }


    }
}
