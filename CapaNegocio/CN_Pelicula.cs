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
            if (codigo == 0 || codigo < 0)
            {
                throw new ArgumentException("El código no puede ser cero o negativo.");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                else
                {
                    if (duracion <= 0)
                    {
                        throw new ArgumentException("La duración debe ser mayor a cero.");
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(genero))
                        {
                            throw new ArgumentException("El género no puede estar vacío.");
                        }
                    }
                }
            }
            var existe = objetoCD.BuscarPelicula(codigo);
            if (existe != null)
            {
                throw new Exception("Ya existe una película con ese código.");
            }

            objetoCD.RegistrarPelicula(codigo, nombre, duracion, genero);
        }

        // Método para buscar película por código
        public DataRow BuscarPelicula(int codigo)
        {
            var datos = objetoCD.BuscarPelicula(codigo);

            if (datos == null)
            {
                throw new Exception("No se encontró la película con ese código.");
            }

            return datos;
        }
    }
}
