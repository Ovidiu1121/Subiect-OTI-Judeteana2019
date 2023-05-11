using Subiect_OTI_judeteana2019.model;
using Subiect_OTI_judeteana2019.repository;
using System.Diagnostics;

namespace Subiect_OTI_judeteana2019
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Utilizator a = new Utilizator("dana@gmail.com", " dana", " Mandache", "Dana");
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MeniuFreeBook(a));

            ImprumutRepository a = new ImprumutRepository();
            List<Imprumut> list = a.getAllImprumuturi();

            foreach (Imprumut item in list)
            {
                Debug.WriteLine(item.description());
            }

        }

    }
}