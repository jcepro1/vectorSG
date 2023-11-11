using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Vector vector;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int dim = int.Parse(Interaction.InputBox("Ingrese Dimension del vector", "", ""));
            //    this.vector.Cargar(dim);
            //    this.textBox1.Text = this.vector.Descargar();
            //}
            //catch (Exception ex)
            //{
            //    Interaction.MsgBox(ex.Message);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.vector = new Vector();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int m = int.Parse(Interaction.InputBox("Ingrese valor para M", "", ""));
            //this.vector.elimPosMult(m);
            //this.textBox2.Text = this.vector.Descargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int dim = int.Parse(Interaction.InputBox("Ingrese dimension del vector ", "", ""));
            //    int a = int.Parse(Interaction.InputBox("Ingrese valor para A", "", ""));
            //    int b = int.Parse(Interaction.InputBox("Ingrese valor para B", "", ""));
            //    this.vector.CargarRamdom(dim, a, b);
            //    this.textBox1.Text = this.vector.Descargar();
            //}
            //catch (Exception ex)
            //{
            //    Interaction.MsgBox(ex.Message);
            //}
        }

        private void P1_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(Interaction.InputBox("Ingrese valor para A", "", ""));
            //int b = int.Parse(Interaction.InputBox("Ingrese valor para B", "", ""));
            //int r = this.vector.GetCantElemDif(a, b);
            //this.textBox2.Text = "Diferentes: " + r.ToString();
        }

        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int dim = int.Parse(Interaction.InputBox("Ingrese Dimension del vector", "", ""));
                this.vector.Cargar(dim);
                this.textBox1.Text = this.vector.Descargar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void cargarRamdonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int dim = int.Parse(Interaction.InputBox("Ingrese dimension del vector ", "", ""));
                int a = int.Parse(Interaction.InputBox("Ingrese valor para A", "", ""));
                int b = int.Parse(Interaction.InputBox("Ingrese valor para B", "", ""));
                this.vector.CargarRamdom(dim, a, b);
                this.textBox1.Text = this.vector.Descargar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Interaction.InputBox("Ingrese valor para A", "", ""));
            int b = int.Parse(Interaction.InputBox("Ingrese valor para B", "", ""));
            int r = this.vector.GetCantElemDif(a, b);
            this.textBox2.Text = "Diferentes: " + r.ToString();
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int m = int.Parse(Interaction.InputBox("Ingrese valor para M", "", ""));
            this.vector.elimPosMult(m);
            this.textBox2.Text = this.vector.Descargar();
        }
    }
}
