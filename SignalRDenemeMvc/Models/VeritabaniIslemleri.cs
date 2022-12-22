using SignalRDenemeMvc.Context;
using SignalRDenemeMvc.SignalHub;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SignalRDenemeMvc.Models
{
    public class VeritabaniIslemleri
    {
        public IEnumerable<BesinList> PersonelleriGetir()
        {
            using (SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["DiyetisyenDBEntities"].ConnectionString))
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                using (SqlCommand cmd = new SqlCommand(@"SELECT [BesinID]  ,[Yemek] ,[Miktar],[OlcuBirimi] ,[Kalori],[Protein] ,[Karbonhidrat] ,[Yağ],[CategoriesID] from [dbo].[Besinlers]", baglanti))
                {
                   
                    SqlDependency dependency = new SqlDependency(cmd);
                    SqlDependency.Start(baglanti.ConnectionString);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        List<BesinList> Personeller = new List<BesinList>();
                        while (dr.Read())
                        {
                            Personeller.Add(new BesinList
                            {
                                Yemek = dr["Yemek"].ToString(),
                                BesinID = Convert.ToInt32(dr["BesinID"].ToString()),
                                Miktar = dr["Miktar"].ToString(),
                                Karbonhidrat = dr["Karbonhidrat"].ToString()
                            });
                        }
                        return Personeller;
                    }
                }
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            besinlerHub.Show();
        }
    }
}