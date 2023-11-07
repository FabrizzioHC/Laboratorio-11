using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_11
{
    class Program
    {
        static int[] notas = new int[100];
        static int contador = 0;

        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Casos con arreglos");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar notas");
                Console.WriteLine("2: Hallar la nota mayor");
                Console.WriteLine("3: Hallar la nota menor");
                Console.WriteLine("4: Encontrar una nota");
                Console.WriteLine("5: Modificar una nota");
                Console.WriteLine("6: Ver notas registradas");
                Console.WriteLine("7: Salir");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarNotas();
                        break;
                    case 2:
                        NotaMayor();
                        break;
                    case 3:
                        NotaMenor();
                        break;
                    case 4:
                        EncontrarNota();
                        break;
                    case 5:
                        ModificarNota();
                        break;
                    case 6:
                        NotasRegistradas();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Intente marcar denuevo solo con las opciones que estan ahi");
                        break;
                }
            } while (opcion != 7);
        }

        static void RegistrarNotas()
        {
            Console.Clear();
            Console.WriteLine("================================\n" +
                "Registrar una nota\n" +
                "================================");
            do
            {
                Console.Write("Ingresa la nota Nro " + (contador + 1) + ": ");
                notas[contador] = int.Parse(Console.ReadLine());
                contador++;
                Console.WriteLine("1: Registrar otra nota");
                Console.WriteLine("2: Regresar");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion != 1)
                    break;
            } while (contador < notas.Length);
        }

        static void NotaMayor()
        {
            Console.Clear();
            int mayor = -1;
            for (int i = 0; i < contador; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                }
            }
            Console.WriteLine("===============================\n" +
                "La nota mayor\n" +
                "================================");
            Console.WriteLine("La nota mayor es: " + mayor);
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void NotaMenor()
        {
            Console.Clear();
            int menor = int.MaxValue;
            for (int i = 0; i < contador; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }
            Console.WriteLine("===============================\n" +
                 "La nota menor\n" +
                 "================================");
            Console.WriteLine("La nota menor es: " + menor);
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void EncontrarNota()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                "Buscar Nota\n" +
                "================================");
            Console.Write("Ingrese la nota a buscar: ");
            int notaBuscada = int.Parse(Console.ReadLine());
            for (int i = 0; i < contador; i++)
            {
                if (notas[i] == notaBuscada)
                {
                    Console.WriteLine("La nota está en la posición " + i);
                }
            }
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void ModificarNota()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                "Modificar Nota\n" +
                "================================");
            Console.Write("Ingrese la posición: ");
            int posicion = int.Parse(Console.ReadLine()) - 1;
            if (posicion >= 0 && posicion < contador)
            {
                Console.Write("Ingrese el nuevo valor: ");
                notas[posicion] = int.Parse(Console.ReadLine());
                Console.WriteLine("===============================Antes:");
                ImprimirNotas();
                Console.WriteLine("Después:");
                ImprimirNotas(posicion);
            }
            else
            {
                Console.WriteLine("La Posición no válida.");
            }
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void NotasRegistradas()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                "notas registradas\n" +
                "================================");
            ImprimirNotas();
            Console.WriteLine("Siguiente posición será: " + (contador + 1));
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void ImprimirNotas(int resaltarPosicion = -1)
        {
            Console.Clear();
            for (int i = 0; i < contador; i++)
            {
                if (i == resaltarPosicion)
                {
                    Console.Write("[" + notas[i] + "] ");
                }
                else
                {
                    Console.Write(notas[i] + " ");
                }
            }
            Console.ReadLine(); 
        }
    }
}
