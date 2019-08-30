﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica4MC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Escoja una opcion");
                Console.WriteLine("1 - Ejercicio 1");
                Console.WriteLine("2 - Ejercicio 2");
                Console.WriteLine("3 - Ejercicio 3");
                Console.WriteLine("4 - Ejercicio 4");
                Console.WriteLine("5 - Ejercicio 5");
                Console.WriteLine("6 - Ejercicio 6");
                Console.WriteLine("7 - Ejercicio 7");
                Console.WriteLine("8 - Ejercicio 8");
                Console.WriteLine("0 - Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Ejercicio6();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        static void Ejercicio1()
        {
            double total = 0.0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Ingrese el sueldo del empleado " + i);
                total += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Total: {0}, Promedio: {1:N2}", total, total / 20);
        }

        private static void Ejercicio2()
        {
            int aprobados = 0, reprobados = 0;
            Console.WriteLine("Ingrese la cantidad de estudiantes");
            int numEstudiantes = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numEstudiantes; i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante " + i);
                double nota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la asistencia del estudiante " + i);
                int asistencia = Convert.ToInt32(Console.ReadLine());
                if (nota >= 7.0 && asistencia >= 75)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            Console.WriteLine("Aprobados: {0} Reprobados: {1}", aprobados, reprobados);
        }

        private static void Ejercicio3()
        {
            int vocales = 0;
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            char[] array = nombre.ToCharArray();

            for (int i = 0; i < nombre.Length; i++)
            {
                if (array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'o' || array[i] == 'u')
                {
                    vocales++;
                }
                if (array[i] == 'A' || array[i] == 'E' || array[i] == 'I' || array[i] == 'O' || array[i] == 'U')
                {
                    vocales++;
                }
                if (array[i] == 'á' || array[i] == 'é' || array[i] == 'í' || array[i] == 'ó' || array[i] == 'ú')
                {
                    vocales++;
                }
                if (array[i] == 'Á' || array[i] == 'É' || array[i] == 'Í' || array[i] == 'Ó' || array[i] == 'Ú')
                {
                    vocales++;
                }
            }
            Console.WriteLine("Cantidad de vocales: {0}", vocales);
        }

        private static void Ejercicio4()
        {
            double total = 0.0, cantidad = 0.0;
            do
            {
                Console.WriteLine("Ingrese el total de ventas");
                cantidad = Convert.ToDouble(Console.ReadLine());
                if(cantidad != -1) total += cantidad;

            } while (cantidad != -1);
            Console.WriteLine("Total de ventas: {0} Bonificacion del 5%: {1}", total, total * 1.05);
        }

        private static void Ejercicio5()
        {
            string clave = "carranza", escondida = "********";
            int intentos = 1;

            do
            {
                Console.WriteLine("Ingrese la clave para entrar: Pista {0}", clave.Substring(0, intentos));
                string contrasena = Console.ReadLine();

                if (contrasena == clave)
                {
                    Console.WriteLine("Entraste");
                    break;
                }
                intentos++;
            } while (intentos <= 3);
            if (intentos == 3)
            {
                Console.WriteLine("Perdiste");
            }
        }

        private static void Ejercicio6()
        {
            int i = 0;
            double totalSucursal = 0.0, totalGlobal = 0.0;
            string mensaje = "";

            do
            {
                Console.WriteLine("Ingrese el total de ventas de la sucursal {0}", i + 1);
                totalSucursal = Convert.ToDouble(Console.ReadLine());
                mensaje += "Cantidad sucursal " + i + ":" + totalSucursal + "\n";
                totalGlobal += totalSucursal;
                i++;
            } while (totalSucursal != 0);
            Console.WriteLine(mensaje);
            Console.WriteLine("Cantidad global: {0:N2} Promedio: {1:N2}", totalGlobal, totalGlobal/i);
        }
    }
}
