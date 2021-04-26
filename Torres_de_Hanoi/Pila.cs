using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        public int Size { get; set; }
        public int Top { get; set; }       
        
        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
           
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
