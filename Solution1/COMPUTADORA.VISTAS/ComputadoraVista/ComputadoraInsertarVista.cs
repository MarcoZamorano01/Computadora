using COMPUTADORA.BSS;
using COMPUTADORA.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COMPUTADORA.VISTAS.ComputadoraVista
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }
        CompuBss bss = new CompuBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Computadora com = new Computadora();
            com.Nombre = textBox1.Text;
            com.Descripcion = textBox2.Text;
            com.Precio = Convert.ToDecimal(textBox3.Text);
            com.FechaFabric = dateTimePicker1.Value;

            bss.InsertarComputadoraBss(com);
            MessageBox.Show("se guardo correctamente la computadora");
        }
    }
}
