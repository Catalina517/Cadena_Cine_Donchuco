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

        
        // Método para registrar venta
        public decimal RegistrarVenta(int idFuncion, int cantidadBoletas, decimal valorUnitario)
        {
            if (cantidadBoletas <= 0)
                throw new Exception("La cantidad de boletas debe ser mayor a cero.");

            if (valorUnitario <= 0)
                throw new Exception("El precio unitario debe ser mayor a cero.");

            decimal valorTotal = cantidadBoletas * valorUnitario;

            objetoCD.RegistrarVenta(idFuncion, cantidadBoletas, valorTotal);

            return valorTotal;
        }
    }
}
