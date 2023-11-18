using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsFormsApp1
{
    class Vector
    {
        const int MAX = 100;
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void cargardato(int nele)
        {
            n = nele;//JCE
            int num = n;
            for (int i = 1; i <= num; i++)
            {//JCE
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }
        public void Cargar_rnd(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }

        }

        public string descargar()
        {
            string s;
            int i;
            s = "";
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }

     

        //EJERCICIO 1
        public void ejercicio1(int a, int b)
        {
            Vector vr = new Vector();
            for (int i = a; i <= b; i++)
            {
                vr.insertar(v[i]);
            }
            vr.ordenar();
            int x = 1;
            int y = vr.n;
            bool bandera = true;
            for (int i = a; i <= b; i++)
            {
                if (bandera)
                {
                    v[i] = vr.v[y];
                    y--;
                }
                else
                {
                    v[i] = vr.v[x];
                    x++;
                }
                bandera = !bandera;
            }

        }
        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void ordenar()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }

        //EJERCICIO 2
        public string Elem_MenosRep_Seg(int a, int b)
        {
            int i = a;
            int fr = frec_elem_segmento(v[i], a, b);
            int ele = v[i];
            for (i = a; i <= b; i++)
            {
                if (frec_elem_segmento(v[i], a, b) > fr)
                {
                    fr = frec_elem_segmento(v[i], a, b);
                    ele = v[i];
                    
                }
            }
            return "ele: "+ele+" , frac: "+fr;
        }

        public int Elem_MenosRep_Seg_frec(int a, int b)
        {
            int i = a;
            int frexMen;
            int c;
            c = 0;
            int fr = frec_elem_segmento(v[i], a, b);
            int ele = v[i];
            for (i = a; i <= b; i++)
            {
                frexMen = frec_elem_segmento(v[i], a, b);
                if (frexMen > fr)
                {
                    fr = frexMen;
                  
                    c = c + 1;
                }
            }
            return fr;
        }



        public int frec_elem_segmento(int elem, int a, int b)
        {
            int c = 0;
            int num = a;
            int num2 = b;
            checked
            {
                for (int i = num; i <= num2; i++)
                {

                    if (elem == v[i])
                    {
                        c++;
                    }
                }
                return c;
            }
        }



    }
}
