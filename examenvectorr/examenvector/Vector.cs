using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenvector
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
        public void CargarRamdom(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
                v[i] = r.Next(a, b);
        }

        public string Descargar()
        {
            string s;
            int i;
            s = " ";
            for (i = 1; i <= n; i++)
                s = s + v[i] + " | ";
            return s;
        }
       
        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }
        public void ordenarAsc()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i+1; j <= n; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                            v[i]=v[j];
                            v[j]=aux;
                    }
                }
            }
        }
        public void ordenarDesc()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[i] < v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }
    
        public int frecuencia(int ele)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }

        
        public void examen1(Vector v2)
        {
            int aux = v2.n;
            v2.n = 0;
            for (int i = 1; i <= aux; i++)
            {
                int ele = v2.v[i];
                if (frecuencia(ele)==0)
                {
                    v2.insertar(ele);
                }

            }
        }

        public void examen2(int a, int b)
        {
            Vector fibos = new Vector();
            Vector nofibos = new Vector();
            Nent numero = new Nent(); 
            for (int i = a; i <= b; i++)
            {
                numero.cargar(v[i]);
                if (numero.veriffibo())
                {
                    fibos.insertar(v[i]);
                }
                else
                {
                    nofibos.insertar(v[i]);
                }
            }

            fibos.ordenarAsc();
            nofibos.ordenarDesc();

            int ipares = 1;
            int iimpares = 1;

            for (int i = a; i <= b; i++)
            {
                
                if (ipares <= fibos.n)
                {
                    v[i] = fibos.v[ipares];
                    ipares++;
                }
                else
                {
                    v[i] = nofibos.v[iimpares];
                    iimpares++;
                }
            }
        }
              
    }

    
}
