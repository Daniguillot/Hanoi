using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        public int Tam {
            get { return this.Tam; } 
            set { Tam = value; }
        }

        public Disco(int tam) { 
            
            this.Tam = tam; 
        }

    }
}

