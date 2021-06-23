using CapaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacionWF
{
    public partial class FrmProducto : Form
    {
        //Se crea un producto auxiliar para ocupar en el resto del formulario. Para generar la modificación
        // Este objeto "p" va a guardar el atributo Id para la modificación Update().
        Producto p;

        public FrmProducto()
        {
            InitializeComponent();
            p = new Producto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigoBarra.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoBarra.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            
            txtCodigoBarra.Focus();
            p = new Producto();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Producto p = new Producto();    ---- Esta línea se cambió a la 23 y 65. Para hacer el Update
            int numero = 0;
            if (Int32.TryParse(txtCodigoBarra.Text, out numero))
                p.CodigoBarra = numero;
            else
            {
                MessageBox.Show("El valor del codigo de barra no es numérico");
                txtCodigoBarra.Focus();
                return;
            }


            if(txtDescripcion.Text.Trim().Length < 1)
            {
                MessageBox.Show("La descripción no es válida, vuelva a intentar");
                txtDescripcion.Focus();
                return;
            }
            else
            {
                p.Descripcion = txtDescripcion.Text.ToUpper().Trim();

            }


            if (Int32.TryParse(txtPrecioCosto.Text, out numero))
                p.PrecioCosto = numero;
            else
            {
                MessageBox.Show("El valor del codigo de barra no es numérico");
                txtPrecioCosto.Focus();
                return;
            }

            if (Int32.TryParse(txtPrecioVenta.Text, out numero))
                p.PrecioVenta = numero;
            else
            {
                MessageBox.Show("El valor del codigo de barra no es numérico");
                txtPrecioVenta.Focus();
                return;
            }


            if (Int32.TryParse(txtStock.Text, out numero))
                p.Stock = numero;
            else
            {
                MessageBox.Show("El valor del codigo de barra no es numérico");
                txtStock.Focus();
                return;
            }

            
            //MODIFICAR - GUARDAR
            //Aquí se guardan o se actualizan los valores con el evento btnGuardar.
            int resultado = 0;
            if (p.Id == 0)
                resultado = p.Create();
            else
                resultado = p.Update();
            if (resultado == 1)
            {
                MessageBox.Show("Los datos han sido guardados C:");
                btnLimpiar_Click(null, null);
                btnListar_Click(null, null);
            }
            else
                MessageBox.Show("Los datos no han sido guardados :s");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            VentasColecciones vc = new VentasColecciones();
            dgvListado.DataSource = vc.ReadAll();
            dgvListado.Refresh();
        }

        //Seleccionar elemento del DATA GRID y listarlo en los campos de texto.
        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            p = (Producto)dgvListado.Rows[e.RowIndex].DataBoundItem;
            txtCodigoBarra.Text = p.CodigoBarra.ToString();
            txtDescripcion.Text = p.Descripcion.ToString();
            txtPrecioCosto.Text = p.PrecioCosto.ToString();
            txtPrecioVenta.Text = p.PrecioVenta.ToString();
            txtStock.Text = p.Stock.ToString();
        }
    }
}
