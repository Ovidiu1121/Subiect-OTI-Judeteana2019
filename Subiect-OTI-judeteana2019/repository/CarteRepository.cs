using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Subiect_OTI_judeteana2019.data;
using Subiect_OTI_judeteana2019.model;

namespace Subiect_OTI_judeteana2019.repository
{
    public class CarteRepository
    {
        DataAcces dataAcces;
        private string connectionString;

        public CarteRepository()
        {

            this.dataAcces = new DataAcces();

            this.connectionString =GetConnection();

        }

        public List<Carte> getAllCarti()
        {

            string sql = "select * from carti";

            return this.dataAcces.LoadData<Carte, dynamic>(sql, new { }, connectionString);

        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }
    }
}
