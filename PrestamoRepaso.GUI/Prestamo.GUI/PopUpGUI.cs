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
    public partial class PopUpGUI : Form
    {
        private PrestamoNegocio _preNeg;
        public PopUpGUI()
        {
            InitializeComponent();
        }

        public PopUpGUI(Prestamos pre)
        {
            InitializeComponent();
            Pre = pre;
        }

        public Prestamos Pre { get; }

        private void btnSi_Click(object sender, EventArgs e)
        {
            Prestamos p = Pre;
            _preNeg = new PrestamoNegocio();
            _preNeg.AgregarPrestamo(p);
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
