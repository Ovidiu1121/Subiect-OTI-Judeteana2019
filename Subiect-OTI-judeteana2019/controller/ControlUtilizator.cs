using Subiect_OTI_judeteana2019.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019.controller
{
    public class ControlUtilizator
    {
        private List<Utilizator> lista = new List<Utilizator>();
        string path = Application.StartupPath+@"data\utilizatori.txt";

        public ControlUtilizator()
        {
            load();
        }

        public void load()
        {
            StreamReader read = new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Utilizator utilizator = new Utilizator(line);
                lista.Add(utilizator);
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

        public void adaugare(Utilizator a)
        {
            lista.Add(a);
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

        public bool isUtilizator(string email, string parola)
        {
            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].Email.Equals(email)&&lista[i].Parola.Equals(parola))
                {
                    return true;
                }
            }
            return false;
        }

        public Utilizator getUtilizator(string email, string parola)
        {
            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].Email.Equals(email)&&lista[i].Parola.Equals(parola))
                {
                    return lista[i];
                }
            }
            return null;

        }

    }
}
