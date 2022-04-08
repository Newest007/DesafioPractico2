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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HeapMínimo heapMínimo = new HeapMínimo();

            this.Hide();
            heapMínimo.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeapMaximo heapMaximo = new HeapMaximo();

            this.Hide();
            heapMaximo.Show();

        }
    }
}
