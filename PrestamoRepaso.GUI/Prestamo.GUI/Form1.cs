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
        private Operador _op;
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
                _op = new Operador();
                _op.Prestamos1 = _preNeg.TraerPrestamos();
                lstPrestamos.DataSource = null;
                //lstPrestamos.DataSource = _preNeg.TraerPrestamos();
                lstPrestamos.DataSource = _op.Prestamos1;

                tbComisionTotal.Text = _op.PorcentajeComsion(_op.Prestamos1, _op.Comision);
                lbContadorPrestamos.Text = _op.ContadorPrestamos().ToString();
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

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Prestamos pre = new Prestamos(Convert.ToDouble(tbTNA.Text), Convert.ToDouble(tbMonto.Text), Convert.ToInt32(tbPlazo.Text));
            
            tbCuotaCap.Text = pre.CuotaCapital().ToString("0.00");
            tbCuotaInt.Text = pre.CuotaInteres().ToString("0.00");
            tbCuotaTotal.Text = pre.CuotaTotal().ToString("0.00");
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {

                TipoPrestamo tip = (TipoPrestamo)lstTipoPrestamo.SelectedItem;
                int _tna = Convert.ToInt32(tip.Tna);
                Prestamos pre = new Prestamos(Convert.ToDouble(tbCuotaTotal.Text),
                    Convert.ToDouble(tbMonto.Text),
                    Convert.ToInt32(tbPlazo.Text),
                    tip.Id,
                    Convert.ToInt32("877071"),
                    tip.Id,
                    _tna,
                    tip.Linea);


                PopUpGUI p = new PopUpGUI(pre);

                p.Show();
            }
            catch
            {
                MessageBox.Show("Error al dar de alta préstamo.");
            }

            CargarPrestamos();
            _op.PorcentajeComsion(_op.Prestamos1, _op.Comision);
            lbContadorPrestamos.Text = _op.ContadorPrestamos().ToString();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            tbMonto.Clear();
            tbCuotaCap.Clear();
            tbCuotaInt.Clear();
            tbCuotaTotal.Clear();
            tbPlazo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarPrestamos();
            lbContadorPrestamos.Text = _op.ContadorPrestamos().ToString();
        }
    }
}
