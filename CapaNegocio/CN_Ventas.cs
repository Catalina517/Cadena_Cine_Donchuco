using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas objetoCD = new CD_Ventas();

        //precio de boletas
        private const decimal PrecioBoleta = 12000m;
        // Método para registrar venta
        public void RegistrarVenta(int idFuncion, int cantidadBoletas)
        {
            decimal valorTotal = cantidadBoletas * PrecioBoleta;
            objetoCD.RegistrarVenta(idFuncion, cantidadBoletas, valorTotal);
        }
    }
}
