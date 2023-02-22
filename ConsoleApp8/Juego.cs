using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    internal class Juego
    {
        //atributos

        private Palabra joga;
        private string saludo;
        private int vidas;

        //constructor
        public Juego() 
        {
            joga = new Palabra();
            saludo = "Bienvenido al juego de ahorcado \n\ntienes un total de 4 oportunidades para adivinar la palabra...   Suerte!";
            vidas = 4;

        }

        //metodo para jugar
        public void iniciarJuego() 
        {
            //parte que da la bienvenida al juego

            Console.WriteLine(saludo);

            //string para asignar valor de la palabra

            string bul;

            //usamos ramdom para tomar una palabra aleatoria de la clase Palabra

            Random rd = new Random();
            int rand_num = rd.Next(0, 11);
            bul = joga.getPalabras(rand_num);

            //print para decir la cantidad de letras que tiene la palabra

            Console.WriteLine("\n\nla palabra tiene " + joga.getLenght(rand_num) + " letras");

            //usamos un stringBuilder para poder tener un array de los caracteres del string de la palabra

            StringBuilder acertar = new StringBuilder(bul);
            for (int i = 0; i < bul.Length; i++)
            {
                if (i == bul.Length)
                {
                    acertar[i] = bul[i];
                }
                else
                {
                    acertar[i] = '_';
                }
            }
            
            //bucle principal en el que se toma en cuenta las vidad para jugar al juego

            while (vidas > 0)
            {

                //condicionales para dibujar un muñeco en base a la cantidad de vidas
                //se que el muñeco es feo, pero algo se intenta xD

                if (vidas == 4)
                {
                    Console.WriteLine("\n(I - I)");
                    Console.WriteLine("  II");
                    Console.WriteLine(" /II\"");
                    Console.WriteLine("/ II \"");
                    Console.WriteLine("  II");
                    Console.WriteLine(" ii ii");
                }
                else if(vidas == 3)
                {
                    Console.WriteLine("\n(I - I)");
                    Console.WriteLine("  II");
                    Console.WriteLine("  II\"");
                    Console.WriteLine("  II \"");
                    Console.WriteLine("  II");
                    Console.WriteLine(" ii ii");
                }
                else if (vidas == 2)
                {
                    Console.WriteLine("\n(I - I)");
                    Console.WriteLine("  II");
                    Console.WriteLine("  II\"");
                    Console.WriteLine("  II \"");
                    Console.WriteLine("  II");
                    Console.WriteLine("    ii");
                }
                else if (vidas == 1)
                {
                    Console.WriteLine("\n(I - I)");
                    Console.WriteLine("  II");
                    Console.WriteLine("  II");
                    Console.WriteLine("  II ");
                    Console.WriteLine("  II");
                    Console.WriteLine("    ii");
                }
               
                //parte en la que vamos a pedir los caracteres y limpiar la consola para que se vea mas bonito
                
                Console.WriteLine("dame una letra ");
                char caracter = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                bool go = false;
                for(int i = 0; i < bul.Length; i++)
                {
                    if( caracter == bul[i])
                    {
                        acertar[i] = caracter;
                        go = true;
                        
                    }
                  
                  
                }
                if (go)
                {
                    Console.WriteLine("acertaste");
                    

                }
                else
                {
                    Console.WriteLine("fallaste, piensa con mas cuidado");
                    vidas--;
                }
                bool ganar=true;
                for (int i = 0; i < bul.Length; i++)
                {
                    Console.Write(" {0}", acertar[i]);

                    if (acertar[i] == '_')
                    {
                        ganar = false;
                        
                    }
                }
                if (ganar == true)
                {
                    Console.WriteLine("\n(^ u ^)");
                    Console.WriteLine("  II");
                    Console.WriteLine(" /II\"");
                    Console.WriteLine("/ II \"");
                    Console.WriteLine("  II");
                    Console.WriteLine(" ii ii");
                    Console.WriteLine(" ");
                    Console.WriteLine("\nGanaste");
                    break;
                }
                
                
            }
            if (vidas == 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("\n(X - X)");
                Console.WriteLine("  II");
                Console.WriteLine("  II");
                Console.WriteLine("  II ");
                Console.WriteLine("  II");
                Console.WriteLine("  ");
                Console.WriteLine(" ");
                Console.WriteLine("has perdido, mejor suerte a la proxima");
                Console.WriteLine(" ");
                
            }
            
                
           
        }
    }
}
