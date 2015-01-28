using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace MedicalCommunityAutomation.DAL
{
    public class DbGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["connectionStringForMedicalCommunityDb"].ConnectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public SqlConnection ASqlConnection { set; get; }
        public SqlCommand ASqlCommand { set; get; }
        public SqlDataReader ASqlDataReader { set; get; }

        public DbGateway()
        {
            ASqlConnection = new SqlConnection(ConnectionString);
        }
    }
}
