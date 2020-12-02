using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto135graphicsBarras
{
    public partial class Form1 : Form
    {
        private bool estado = false;
        private int partido1, partido2, partido3;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                int mayor;

                if (partido1 > partido2 && partido1 > partido3)
                    mayor = partido1;
                else if (partido2 > partido3)
                    mayor = partido2;
                else
                    mayor = partido3;

                int largo1 = partido1 * 400 / mayor;
                int largo2 = partido2 * 400 / mayor;
                int largo3 = partido3 * 400 / mayor;

                Graphics lienzo = CreateGraphics();
                lienzo.FillRectangle(new SolidBrush(Color.Red), 10, 100, largo1, 100);
                lienzo.DrawString("Partido A: " + partido1, new Font("Arial", 20), new SolidBrush(Color.Brown), 20, 130);
                lienzo.FillRectangle(new SolidBrush(Color.Blue), 10, 220, largo2, 100);
                lienzo.DrawString("Partido B: " + partido2, new Font("Arial", 20), new SolidBrush(Color.Brown), 20, 250);
                lienzo.FillRectangle(new SolidBrush(Color.Green), 10, 340, largo3, 100);
                lienzo.DrawString("Partido C: " + partido3, new Font("Arial", 20), new SolidBrush(Color.Brown), 20, 370);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            partido1 = int.Parse(textBox1.Text);
            partido2 = int.Parse(textBox2.Text);
            partido3 = int.Parse(textBox3.Text);
            estado = true;
            Refresh();
        }
    }
}
