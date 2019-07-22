using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientes1 = new Clientes();
            clientes1.Id = 1;
            clientes1.Nombre = "Angela";
            clientes1.Ciudad = "El progreso";

            Clientes clientes2 = new Clientes();
            clientes2.Id = 2;
            clientes2.Nombre = "Jose";
            clientes2.Ciudad = "San pedro sula";

            var listadeclientes = new List<Clientes>();
            listadeclientes.Add(clientes1);
            listadeclientes.Add(clientes2);

            foreach (var c in listadeclientes)
            {
                MessageBox.Show(c.Nombre);
                MessageBox.Show(c.Ciudad);




            }
            
        }
    }
}
