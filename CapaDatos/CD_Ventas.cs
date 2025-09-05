using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Ventas
    {
        private static readonly string cadena =
           ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        // Registrar venta
        public void RegistrarVenta(int idFuncion, int cantidadBoletas, decimal valorTotal)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdFuncion", idFuncion);
                cmd.Parameters.AddWithValue("@CantidadBoletas", cantidadBoletas);
                cmd.Parameters.AddWithValue("@ValorTotal", valorTotal);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
