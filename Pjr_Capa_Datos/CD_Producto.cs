using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pjr_Capa_Entidad;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


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

                cmd.Parameters.AddWithValue("@StockActual", pro.StockActual);
                cmd.Parameters.AddWithValue("@idCat", pro.IdCat);

                cmd.Parameters.AddWithValue("@Foto", pro.Foto);
                cmd.Parameters.AddWithValue("@Pre_Venta", pro.Preventa);
                cmd.Parameters.AddWithValue("@Frmto_compra", pro.FormatoCompra);
                cmd.Parameters.AddWithValue("@Utilidad", pro.UtilidadUnint);
                cmd.Parameters.AddWithValue("@ValorporProd", pro.ValorxCant);
                cmd.Parameters.AddWithValue("@Prin_Activo", pro.PrincipioActivo);

                cmd.Parameters.AddWithValue("@Laboratorio", pro.Laboratorio);

                cmd.Parameters.AddWithValue("@undMin", pro.Und_min);
                cmd.Parameters.AddWithValue("@undMax", pro.Und_max);
                cmd.Parameters.AddWithValue("@fechaVncmnto", pro.FechaVence);
                cmd.Parameters.AddWithValue("@Ventaconreceta", pro.Venta_conReceta);

                cadenaconex.Open();
                cmd.ExecuteNonQuery();
                cadenaconex.Close();
            }
            catch (Exception ex)
            {
                if ( cadenaconex.State ==ConnectionState.Open )
                { 
                    cadenaconex.Close(); 
                
                }

                MessageBox.Show("wachau error: " + ex.Message, "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        
        

        }

    }
}
