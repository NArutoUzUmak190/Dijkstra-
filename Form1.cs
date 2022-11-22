using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kruskal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen Rojo = new Pen(Color.Red,3);
        Pen Negro = new Pen(Color.DarkBlue, 3);

        public void esqueleto()
        {
            Graphics grafica = Tabla.CreateGraphics();

            grafica.DrawLine(Negro, 50, 200, 152, 98);//S - B
            grafica.DrawLine(Negro, 50, 200, 152, 289);//S - C
            grafica.DrawLine(Negro, 152, 98, 308, 98);//B - D
            grafica.DrawLine(Negro,152, 98, 152,289);//B - C
            grafica.DrawLine(Negro, 152, 289, 308, 98);//C - D
            grafica.DrawLine(Negro, 152, 289, 308, 289);//C - E
            grafica.DrawLine(Negro, 308, 98, 420, 200);//D - T
            grafica.DrawLine(Negro, 308, 98, 308, 289);//D - E
            grafica.DrawLine(Negro,308,289,420,200);//E - T
        }

        private void Prueba_Click(object sender, EventArgs e)
        {
            esqueleto();
        }
    }
}
