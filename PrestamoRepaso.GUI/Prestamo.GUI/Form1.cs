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
        public Form1()
        {
            InitializeComponent();
            _preNeg = new PrestamoNegocio();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = _preNeg.TraerPrestamos();
        }
    }
}
