using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjerciciosArreglos_SLE
{
    internal class Arreglos2
    {
        public void PrimerEjercicio()
        {

            //LOS DOS PRIMEROS ARREGLOS SE DEBEN DE GUARDAR EN UN TERCER ARREGLO
            int[] primero = new int[3];
            int[] segundo = new int[3];
            int[] tercero = new int[3];


            //PARA INGRESAR LOS NUMEROS EN EL PRIMER ARREGLO
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Escribe los numeros para el primer arreglo");
                primero[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa los numeros para el segundo arreglo");
                segundo[i] = Convert.ToInt32(Console.ReadLine());




            }
            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Primer arreglo " + primero[i]);
                Console.WriteLine("Segundo arreglo " + segundo[i]);
            }
            */


            tercero[0] = primero[0] + segundo[0];
            tercero[1] = primero[1] + segundo[1];
            tercero[2] = primero[2] + segundo[2];


            Console.WriteLine("Posicion 1: " + tercero[0]);
            Console.WriteLine("Posicion 2: " + tercero[1]);
            Console.WriteLine("Posicion 3: " + tercero[2]);



        }




        public void SegundoEjercicio()
        {
            int numero = 0;
            int[] Adivina = { 1, 2, 1, 3, 4 };
            Console.WriteLine("Introducce el numero que quieres comprobar");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Adivina.Length; i++)
            {


                if (Adivina[i] == numero)
                {
                    Console.WriteLine("El numero esta en la posicion " + i);
                }
                else
                {
                    Console.WriteLine("No esta en esta posicion y/o no existe el numero ");
                }
            }
        }

        public void TercerEjercicio()
        {
            int[] algebra = new int[5];
            int[] analisis = new int[5];
            int[] tercero= new int[5];

            //´PARA ALUMNOS DE ALGEBRA
            for (int i = 0; i < algebra.Length; i++)
            {
                Console.WriteLine("Escribe el ID del alumno que quieras guardar (algebra)");
                algebra[i] = Convert.ToInt32(Console.ReadLine());
            }
            //PARA ANALISIS
            for (int i = 0; i < analisis.Length; i++)
            {
                Console.WriteLine("Escribe el ID del alumno que quieras guardar (analisis)");
                analisis[i] = Convert.ToInt32(Console.ReadLine());

            }
            int contador = 0;
            for (int i = 0; i < algebra.Length; i++)
            {
                for (int a = 0; a < analisis.Length; a++)
                {
                   
                       
                        if (algebra[i] == analisis[a])
                        {
                            tercero[contador] = algebra[i];
                            contador++;
                            Console.WriteLine("Las IDs que se repiten son " + algebra[i]);
                            
                        }
                    
                }
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("La cantidad de veces que se repite uno es " + tercero[i]);
            }


        }

        public void CuatroEjercicio()
        {
            Console.WriteLine("Escribe la longitud q quieres mi rei");
             int longitud = Convert.ToInt32(Console.ReadLine());
          
            int[] numeros = new  int [longitud];

            for (int i = 0; i < longitud; i++)
            {
                Console.WriteLine("Ingresa los valores");
                numeros[i]= Convert.ToInt32 (Console.ReadLine());

                
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                int aber = numeros[i];
                if (numeros[i] != aber)
                {
                    Console.WriteLine("aaaa " + numeros[i]);
                }
            }



            
        }


    }
}
