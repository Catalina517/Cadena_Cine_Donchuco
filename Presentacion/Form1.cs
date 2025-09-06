using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        CN_Funcion funcion = new CN_Funcion();
        CN_Pelicula pelicula = new CN_Pelicula();
        CN_Ventas venta = new CN_Ventas();
        public Form1()
        {
            InitializeComponent();
            dtmFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void tbcRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtCod.Clear();
            txtNom.Clear();
            txtDuracion.Clear();
            txtGenero.Clear();
            txtCod.Focus();
        }
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                pelicula.RegistrarPelicula(int.Parse(txtCod.Text), txtNom.Text, int.Parse(txtDuracion.Text), txtGenero.Text);
                MessageBox.Show("Pelicula registrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Limpiar();
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCod.Text);
                DataRow datos = pelicula.BuscarPelicula(codigo);

                
                txtNom.Text = datos["Nombre"].ToString();
                txtDuracion.Text = datos["Duracion"].ToString();
                txtGenero.Text = datos["Genero"].ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void chkFuncion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFuncion.Checked)
            {
                btnRegistar.Enabled = false;
                txtNom.Enabled = false;
                txtDuracion.Enabled = false;
                txtGenero.Enabled = false;
                txtCod.Focus();
                txtCod.SelectAll();
            }
            else
            {
                btnRegistar.Enabled = true;
                txtNom.Enabled = true;
                txtDuracion.Enabled = true;
                txtGenero.Enabled = true;
                txtCod.Focus();
                txtCod.SelectAll();
            }
        }

        private void btnRegistrarF_Click(object sender, EventArgs e)
        {
            funcion.RegistarF(int.Parse(txtCod.Text), dtmFechaHora.Value, txtSala.Text);
            MessageBox.Show("Funcion registrada");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvListar.DataSource = null;
            dgvListar.Rows.Clear();
            dgvListar.DataSource = funcion.ListarF();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodA.Text); 
            dgvBuscarFuncion.DataSource = funcion.BuscarF(codigo);

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
           int idFuncion = int.Parse(txtNumFuncion.Text);
           int cantidadBoletas = int.Parse(txtCant.Text);
           decimal valorUnitario = decimal.Parse(txtUnidad.Text);

            decimal total = venta.RegistrarVenta(idFuncion, cantidadBoletas, valorUnitario);

            // Mostrar en el label o textbox
            lblTotal.Text = $"{total}";

            MessageBox.Show("Venta registrada con éxito");
        }
    }
}
