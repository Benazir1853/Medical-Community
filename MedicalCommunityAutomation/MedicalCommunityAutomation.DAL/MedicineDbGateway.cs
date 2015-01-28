using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.DAL
{
   public class MedicineDbGateway :DbGateway
    {
       public Medicine Find(int memberId)
       {
           string query = "SELECT *FROM tbl_medicine where id=" + memberId;
           ASqlConnection.Open();
           ASqlCommand = new SqlCommand(query, ASqlConnection);
           ASqlDataReader = ASqlCommand.ExecuteReader();

           Medicine aMedicine = new Medicine();

           if (ASqlDataReader.HasRows)
           {
               ASqlDataReader.Read();
               

               aMedicine.Name = ASqlDataReader["Name"].ToString();
               aMedicine.MgMl = ASqlDataReader["Mg/Ml"].ToString();

               
           }
           ASqlDataReader.Close();
           ASqlConnection.Close();
           return aMedicine;
       
       }
    
    }
}
