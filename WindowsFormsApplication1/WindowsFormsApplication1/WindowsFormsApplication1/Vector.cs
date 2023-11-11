using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Vector
    {
        
        int[] v;
        int n;
        
        public Vector()
        {
            v = new int[100];
        }
        
        public void Cargar(int dim)
        {
            n = dim;
            for (int i = 1; i <= n; i++)
            {
                v[i] = int.Parse(Interaction.InputBox("v[" + i.ToString() + "]", "Ingrese Elemento"));
            }
        }

        public void CargarRamdom(int x, int a, int b)
        {
            n = x;
            Random rand = new Random();
            for (int i = 1; i <= n; i++)
            {
                v[i] = rand.Next(a, b + 1);
            }
        }

        public String Descargar()
        {
            string r = "";
            for (int i = 1; i <= n; i++)
            {
                r = r + v[i].ToString();
                if (i < n)
                {
                    r = r + ", ";
                }
            }
            return r;
        }
        public void addElem(int x)
        {
            this.n++;
            v[n] = x;
        }
        public void elimPosMult(int m)
        {
            int dim = n;
            n = 0;
            for (int i = 1; i <= dim; i++)
            {
                if (i % m != 0)
                {
                    this.addElem(v[i]);
                }
            }
        }

        //pregunta 01

        public bool Pertenece(int a, int b, int x)
        {
            int r = 0;
            while (a <= b)
            {
                if (this.v[a] == x)
                    r++;
                a++;
            }
            return r > 0;
        }

        public int GetCantElemDif(int a, int b)
        {
            int c = 0;
            int p = a;
            while (p <= b)
            {
                if (!this.Pertenece(a, p - 1, v[p]))
                {
                    c++;
                }
                p++;
            }
            return c;
        }
    }
}
