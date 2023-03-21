using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();

        private void Identidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientesPorIdentidad(Identidadtxt.Text);
                Nombreclientetxt.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                Nombreclientetxt.Clear();
            }
        }

        private void Buscarclientebt_Click(object sender, EventArgs e)
        {

        }
    }
}
