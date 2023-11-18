using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector v1, v2, v3;
        Nent n1, n2, n3;

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            n1 = new Nent();
            n2 = new Nent();
            n3 = new Nent();
        }


        //CARGAR 1

        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargardato(int.Parse(textBox1.Text));
            textBox5.Text = string.Concat(v1.descargar());
        }

        private void cARGARRNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar_rnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = string.Concat(v1.descargar());
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(v1.descargar());
        }

        //CARGAR 2
        private void cARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //v2.cargardato(int.Parse(textBox1.Text));
            //textBox5.Text = string.Concat(v2.descargar());
        }

        private void cARGARRBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //v2.Cargar_rnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            //textBox5.Text = string.Concat(v2.descargar());
        }


        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //textBox7.Text = string.Concat(v2.descargar());
        }


        //CARGAR 3
        private void cARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //v3.cargardato(int.Parse(textBox1.Text));
            //textBox5.Text = string.Concat(v3.descargar());
        }

        private void cARGARRNDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //v3.Cargar_rnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            //textBox5.Text = string.Concat(v3.descargar());
        }

        private void dESCARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //textBox8.Text = string.Concat(v3.descargar());
        }



        private void pREGUNTA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Int32.Parse(textBox2.Text);
            b = Int32.Parse(textBox3.Text);
            v1.ejercicio1(a, b);
            textBox7.Text = v1.descargar();
        }

        private void pREGUNTA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  textBox9.Text = String.Concat(v1.Elem_MenosRep_Seg_frec(int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
            textBox8.Text = String.Concat(v1.Elem_MenosRep_Seg(int.Parse(textBox2.Text), int.Parse(textBox3.Text)));

        }


    }
}
