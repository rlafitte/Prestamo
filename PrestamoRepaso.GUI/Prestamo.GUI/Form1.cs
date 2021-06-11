using Prestamo.Entidades;
using Prestamo.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamo.GUI
{
    public partial class Form1 : Form
    {
        private PrestamoNegocio _preNeg;
        private TipoPrestamoNegocio _tipNeg;
        public Form1()
        {
            try
            {
                InitializeComponent();
                _preNeg = new PrestamoNegocio();
                _tipNeg = new TipoPrestamoNegocio();
            }
            catch
            {
                MessageBox.Show("Error al cargar proyecto");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPrestamos();
                CargarTipoPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargarTipoPrestamos()
        {
            try
            {
                lstTipoPrestamo.DataSource = null;
                lstTipoPrestamo.DataSource = _tipNeg.TraerTipoPrestamos();
            }
            catch
            {
                throw new Exception("Error al cargar tipos de préstamos");
            }
        }

        private void CargarPrestamos()
        {
            try
            {
                lstPrestamos.DataSource = null;
                lstPrestamos.DataSource = _preNeg.TraerPrestamos();
            }
            catch
            {
                throw new Exception("Error al cargar lista de préstamos.");
            }
        }

        private void lstTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            TipoPrestamo tipoPre = new TipoPrestamo();
            tipoPre = (TipoPrestamo)lstTipoPrestamo.SelectedItem;
                tbLinea.Text = tipoPre.Linea;
                tbTNA.Text = tipoPre.Tna.ToString();

            }
            catch
            {
                MessageBox.Show("Error al seleccionar tipo de préstamo.");
            }
        }
    }
}
