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
    public partial class Form3 : Form
    {
        Graphics area; //Area de trabajo
        public Form3()
        {
            InitializeComponent();
            area = areadibujo.CreateGraphics(); //Establezco area de dibujo
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black); //color por defecto

            switch (cmbColor.SelectedIndex) //colorear dependiendo de lo seleccione
            {
                case 0: lapicero = new Pen(Color.Yellow); break; //seleccion amarilla
                case 1: lapicero = new Pen(Color.Red); break;   //Seleccion roja
                case 2: lapicero = new Pen(Color.Blue); break;   //Seleccion azul     
                case 3: lapicero = new Pen(Color.Black); break;   //Seleccion negro
            }
            int iteraciones = int.Parse(txtCantidad.Text); // cantidad de lineas a dibujar
            int espacio = int.Parse(txtEspaciado.Text);//Espacio asignado (En pixeles)

            area.Clear(Color.White); //Limpia área a blanco , para que lineas no se vean una sobre otra

            int puntoincio = 50; //Inicio en un valor de y =  50

            for (int i = 0; i < iteraciones; i++)
            {
                area.DrawLine(lapicero, 20, puntoincio + (espacio * i), 300, puntoincio + (espacio * i));
                //dibuja linea por linea de acuerdo al color dado, en X van de 20 a 300 y en Y varia segun su iteracion
            }
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
