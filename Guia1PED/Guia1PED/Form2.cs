using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1PED
{
    public partial class Form2 : Form
    {
       
        int x, y; //Permite determinar la ubicacion del click
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics(); //Establecemos zona para dibujo
            Pen lapiz = new Pen(Color.Black); //Declaramos colo del PEN a utilizar

            if (listBox1.SelectedIndex == 0) //Si seleciona circulo
            {
                SolidBrush sb = new SolidBrush(Color.Red); //Brush Roja
                g.DrawEllipse(lapiz, x - 50, y - 50, 100, 100); /*Dibujara ELLIPSE usando S PEN   con la posicion en X y Y - 50 y dimensiones 100 */
                g.FillEllipse(sb, x - 50, y - 50, 100, 100); //Rellena de color la elipse dada
            }
            if (listBox1.SelectedIndex == 1)// Si selecciona rectangulo
            {
                SolidBrush sb = new SolidBrush(Color.Green); //Brush Verde
                g.DrawRectangle(lapiz, x - 50, y - 50, 100, 100); /*Dibujara Rectangulo usando S PEN   con la posicion en X y Y - 50 y dimensiones 100 */
                g.FillRectangle(sb, x - 50, y - 50, 100, 100); //Rellena de color el rectangulo dado
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;

            panel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual
            this.Hide();

            // Muestra el segundo formulario
           Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
