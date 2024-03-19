using System;
using COMPUTADORA.BSS;
using COMPUTADORA.MODELOS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPUTADORA.VISTAS.ComputadoraVista
{
    public partial class ComputadoraListarVista : Form
    {
        public ComputadoraListarVista()
        {
            InitializeComponent();
        }
        CompuBss bss = new CompuBss();

        private void ComputadoraListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaComputadoraBss();
        }
    }
}
