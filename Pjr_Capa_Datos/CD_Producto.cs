using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pjr_Capa_Entidad;
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;


namespace Pjr_Capa_Datos
{
    public class CD_Producto
    {
        SqlConnection cadenaconex = new SqlConnection("Data Source=LAPMASIEL;Initial Catalog=BDFarmacia;Integrated Security=true");

        public void CD_Resgistrar_Producto( CE_Producto pro)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_registrar_Producto", cadenaconex);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", pro.Idprod);
                cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                cmd.Parameters.AddWithValue("@Pre_compra", pro.PrecioCompra);
                cmd.Parameters.AddWithValue("@StockActual", pro.);
                cmd.Parameters.AddWithValue("@idCat", pro.Idprod);
                cmd.Parameters.AddWithValue("@Foto", pro.Idprod);
                cmd.Parameters.AddWithValue("@Pre_Venta", pro.Idprod);
                cmd.Parameters.AddWithValue("@Frmto_compra", pro.Idprod);
                cmd.Parameters.AddWithValue("@Utilidad", pro.Idprod);
                cmd.Parameters.AddWithValue("@ValorporProd", pro.Idprod);
                cmd.Parameters.AddWithValue("@Prin_Activo", pro.Idprod);
                cmd.Parameters.AddWithValue("@Laboratorio", pro.Idprod);
                cmd.Parameters.AddWithValue("@undMin", pro.Idprod);
                cmd.Parameters.AddWithValue("@undMax", pro.Idprod);
                cmd.Parameters.AddWithValue("@fechaVncmnto", pro.Idprod);
                cmd.Parameters.AddWithValue("@Ventaconreceta", pro.Idprod);


            }
            catch (Exception)
            {

                throw;
            }
        
        

        }

    }
}
