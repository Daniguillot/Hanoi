using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top > b.Top)
            {
                Disco disco = b.Elementos[b.Size];
                b.pop();

                a.push(disco);
            }
            else
            {
                Disco disco = a.Elementos[a.Size];
                a.pop();

                b.push(disco);
            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if (n%2 == 0)
            {
                while ( ini.isEmpty()==false &&  aux.isEmpty()==false )
                {
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);

                    m = m + 3;
                }
                
            }

            else
            {
                while ( ini.isEmpty() == false && aux.isEmpty() == false )
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);

                    m = m + 3;
                }
            }
            return m;
        }

    }
}
