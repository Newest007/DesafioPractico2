using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioPractico2
{
    public partial class HeapMaximo : Form
    {
        public HeapMaximo()
        {
            InitializeComponent();
        }

        private void HeapMaximo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*
            int maxindex = arreglo_numeros.Length;
            arreglo_numeros[1] = arreglo_numeros[maxindex - 1]; //l primer numero es igual al ultimo numero

            Array.Resize<int>(ref arreglo_numeros, maxindex - 1); //Elimina el ultimo numero

            Arreglo[1] = Arreglo[maxindex - 1];
            Arreglo[1].Location = new Point(tabPage1.Width / 2, 20);
            Array.Resize<Button>(ref Arreglo, maxindex - 1);

            tabPage1.Controls.Clear();
            estado = true;

            Ordenar();
            tabPage1.Refresh();
            */
        }
    }
}
