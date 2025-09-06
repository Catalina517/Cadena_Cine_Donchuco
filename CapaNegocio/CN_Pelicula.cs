using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Pelicula
    {
        private CD_Pelicula objetoCD = new CD_Pelicula();

        // Método para registrar película
        public void RegistrarPelicula(int codigo, string nombre, int duracion, string genero)
        {
            objetoCD.RegistrarPelicula(codigo, nombre, duracion, genero);
        }

        // Método para buscar película por código
        public DataRow BuscarPelicula(int codigo)
        {
            return objetoCD.BuscarPelicula(codigo);
        }
    }
}
