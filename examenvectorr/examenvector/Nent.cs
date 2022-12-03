using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenvector
{
    class Nent
    {
        private int n;
        public Nent()
        {
            n = 0;
        }
        public void cargar(int dato)
        {
            n = dato;
        }

        public void RamdomCARGAR(int a, int b)
        {
            Random r;
            r = new Random();

            n = r.Next(a, b);
        }

        public int descargar()
        {
            return n;
        }
        public bool veriffibo()
        {
            int a, b, c;
            a = -1;
            b = 1;
            c = 0;
            while (c < n)
            {
                c = a + b;
                a = b;
                b = c;
            }
            if (c == n)
            {
                return true;
            }
            return false;
        }
    }
}
