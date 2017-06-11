using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ape_busquedaBinaria
{
    public partial class frmPrincipal : Form
    {
        Vector v;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTamaño_Click(object sender, EventArgs e)
        {
            v = new Vector(Convert.ToInt16(txtTamañoVector.Text));
            txtTamañoVector.Text = "";
        }

        private void btnLimite_Click(object sender, EventArgs e)
        {
            v.llenar(Convert.ToInt16(txtLimite.Text));
            txtLimite.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int busqueda = v.buscar(Convert.ToInt16(txtBuscar.Text));

            if (busqueda == -1)
                MessageBox.Show("No se encontró el número." + Environment.NewLine
                                + "Se hicieron " + v.comparaciones.ToString() + " comparaciones.");
            else
                MessageBox.Show("La posición del número encontrado es " + (busqueda + 1)  + "." + Environment.NewLine
                                + "Se hicieron " + v.comparaciones.ToString() + " comparaciones.");

            txtBuscar.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = v.mostrar();
        }
    }
}
