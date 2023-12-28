using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;


namespace OkulApp.BLL//Bussiness Logic Layer
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@OgretmenAd",ogrt.Ad),
                                  new SqlParameter("@OgretmenSoyad",ogrt.Soyad),
                                  new SqlParameter("@OgretmenTc",ogrt.TC)
                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into Ogretmenler  values (@OgretmenAd,@OgretmenSoyad,@OgretmenTc)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
               
            }
        }


    }
}
