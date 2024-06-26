using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            // Configurar DataGridView
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Producto";
            dataGridView2.Columns[1].Name = "Cantidad";
            dataGridView2.Columns[2].Name = "Precio";
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            // Obtener valores de los TextBoxes
            string trabajador = txtTrabajador.Text;
            string codigoProducto = txtProducto.Text;
            string cantidad = txtCantidad.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(trabajador) ||
                string.IsNullOrWhiteSpace(codigoProducto) ||
                string.IsNullOrWhiteSpace(cantidad))
            {
                MessageBox.Show("Por favor, rellena todos los campos antes de realizar la venta.");
                return;
            }

            // Simulación de obtención de datos del producto y el precio (esto debería venir de una base de datos o similar)
            string nombreProducto = ObtenerNombreProducto(codigoProducto);
            string precioProducto = ObtenerPrecioProducto(codigoProducto);

            // Agregar datos al DataGridView
            string[] row = new string[] { nombreProducto, cantidad, precioProducto };
            dataGridView2.Rows.Add(row);

            // Limpiar TextBoxes
            txtProducto.Clear();
            txtCantidad.Clear();
        }

        private string ObtenerNombreProducto(string codigoProducto)
        {
            // Esta función debería obtener el nombre del producto según el código del producto
            // Aquí estamos simulando este proceso
            return "Producto " + codigoProducto;
        }

        private string ObtenerPrecioProducto(string codigoProducto)
        {
            // Esta función debería obtener el precio del producto según el código del producto
            // Aquí estamos simulando este proceso
            return "$10.00";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento del label1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento del label2
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento del label3
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Evento del textBox1
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento del dataGridView1
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento del dataGridView2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Evento del button1
        }
    }
}

