using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectsMVCApplication.Models
{
    public class DataAccessLayer_model
    {
     public int CheckUserDetails(string UserName, string Password)
{
       SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectsMVCApplication;Integrated Security=True;");
                       
        con.Open();
        string query = "SELECT COUNT(*) FROM LoginTbl WHERE Username=@Username AND Password=@Password";
        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@Username", UserName); // ✅ @Username exactly same
        cmd.Parameters.AddWithValue("@Password", Password); // ✅ @Password exactly same

        int response = Convert.ToInt32(cmd.ExecuteScalar());
        return response;
    
}

    }
}