using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019
{
    public class ControlImprumut
    {

        private List<Imprumut>lista=new List<Imprumut>();
        private string path = Application.StartupPath+@"\data\imprumuturi.txt";

        public ControlImprumut()
        {
            load();
        }

        public void load()
        {

            StreamReader read=new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Imprumut a=new Imprumut(line);
                lista.Add(a);
            }
            read.Close();
        }

        public string afisare()
        {

            string text = "";

            for(int i = 0; i<lista.Count; i++)
            {
                text+=lista[i].description()+"\n";
            }
            return text;
        }

        public string toSave()
        {

            string text = "";
            int i = 0;

            for(i=0; i<lista.Count-1; i++)
            {
                text+=lista[i].save();
            }
            text+=lista[i].save();

            return text;
        }

        public void salvareFisier()
        {
            StreamWriter writer=new StreamWriter(path);

            writer.WriteLine(toSave());

            writer.Close();

        }

        public List<string> getTitluByeEmail(string email)
        {
            List<string> titluri = new List<string>();

            for(int i=0; i<lista.Count; i++)
            {
                if (this.lista[i].Email.Equals(email))
                {
                    titluri.Add(lista[i].Email);
                }
            }
            return titluri;
        }

        public List<Imprumut> getList()
        {
            return this.lista;
        }

    }
}
