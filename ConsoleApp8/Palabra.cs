using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    internal class Palabra
    {
        private string[] palabras;

        public Palabra() 
        {
            palabras = new string[11] { "hola", "pato", "jugar", "pelota", "goma", "salado", "fuera", "ocho", "palabra", "descanso", "esternocleidomastoideo" };
        }
        public string getPalabras(int numero) 
        { 
            return palabras[numero];
        }
        public int getLenght(int numero) 
        {
            return palabras[numero].Length;
        }
        
        
    }
}
