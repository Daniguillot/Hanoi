using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        public int Size {

            get { return this.Elementos.Count; }
            set { Size = value; }
        }
        public int Top {
            get { return this.Elementos[this.Elementos.Count].Tam; }
            set { Top = value; }
        }       
        
        public List<Disco> Elementos {
            get { return this.Elementos; }
            set { Elementos = value; }
        }

        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Elementos = { };
        }

        public void push(Disco d)
        {
            this.Elementos.Add(d);
        }

        public Disco pop()
        {
            this.Elementos.RemoveAt(Size);
            return null;
        }                

        public bool isEmpty()
        {
            if(this.Elementos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
