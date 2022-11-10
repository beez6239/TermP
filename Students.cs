using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BLL;


namespace DAL
{
    public class Students
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
         C:\Users\OSAS\source\repos\DAL\Studentsdb.mdf;Integrated Security=True");

        public void Add(Variables obj)
        {
            SqlCommand cmd = new SqlCommand();
        }
    }


   
}
