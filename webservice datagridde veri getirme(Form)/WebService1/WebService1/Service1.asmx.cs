using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
namespace WebService1
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        

[WebMethod]
        public DataTable getir()
        {
            SqlConnection cnn = new SqlConnection("server=.;Database=NORTHWND;trusted_connection=true");
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Products", cnn);
            DataTable dt = new DataTable("Products");
            adp.Fill(dt);
            return dt;
        }
    }
}