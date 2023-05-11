using Microsoft.Extensions.Configuration;
using Subiect_OTI_judeteana2019.data;
using Subiect_OTI_judeteana2019.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2019.repository
{
    public class UtilizatorRepository
    {

        private string connectionString;
        private DataAcces dataAcces;

        public UtilizatorRepository()
        {
            this.dataAcces = new DataAcces();

            this.connectionString =GetConnection();

        }

        public List<Utilizator> getAllUtilizatori()
        {

            string sql = "SELECT *FROM utilizatori";

            return this.dataAcces.LoadData<Utilizator, dynamic>(sql, new { }, connectionString);

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
