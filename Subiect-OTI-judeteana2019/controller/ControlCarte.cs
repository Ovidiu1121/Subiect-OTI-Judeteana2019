using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019
{
    public class ControlCarte
    {

        private List<Carte> lista=new List<Carte>();
        string path = Application.StartupPath+@"data\carti.txt";

        public ControlCarte()
        {
            load();
        }

        public void load()
        {
            StreamReader read = new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Carte carte = new Carte(line);
                this.lista.Add(carte);
            }

            read.Close();
        }

        public string afisare()
        {

            string text = "";

            for (int i = 0; i<lista.Count; i++)
            {
                text+=lista[i].description();
            }
            return text;
        }

        public void adaugare(Carte a)
        {
            this.lista.Add(a);
        }

        public string toSave()
        {
            string text = "";

            int i = 0;

            for (i = 0; i<lista.Count-1; i++)
            {
                text+=lista[i].save()+"\n";
            }
            text+=lista[i].save();

            return text;
        }

        public void salvareFisier()
        {
            StreamWriter write = new StreamWriter(path);

            write.WriteLine(toSave());

            write.Close();
        }

        public List<Carte> getList()
        {
            return this.lista;
        }

        public string getAutorByTitlu(string titlu)
        {

            for(int i=0; i<lista.Count; i++)
            {
                if (lista[i].Titlu.Equals(titlu))
                {
                    return lista[i].Autor;
                }
            }
            return null;
        }


    }
}
