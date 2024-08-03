using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trilha_C_.Models
{
    public class Pessoa
    {
        public string Nome  { get; set; }  // usa o atalho prop
        public int Idade { get; set; }

        public void Apresentar(){           //função
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
             
        }

        
    }
}