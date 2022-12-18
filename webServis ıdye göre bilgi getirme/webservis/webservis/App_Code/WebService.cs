using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data.Sql;          //SQL KUTUPHANESİ
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Configuration;

/// <summary>
/// WebService için özet açıklama
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    [WebMethod]

    public bilgiler BilgiGetir(int ıd)
    {
        bilgiler bilgilerimiz = new bilgiler();
        string cs = ConfigurationManager.ConnectionStrings["DBBaglan"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("sp_bilgigetir", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@ıd";
            parameter.Value = ıd;

            cmd.Parameters.Add(parameter);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                bilgilerimiz.ıd = Convert.ToInt32(dr["ıd"]);
                bilgilerimiz.kul_ad = dr["kul_ad"].ToString();
                bilgilerimiz.sifre = Convert.ToInt32(dr["sifre"]);

            }


        }

        return bilgilerimiz;

    }

}
