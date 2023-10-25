﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declarar una variable int para opciones

            {
                int opciones;

                do
                {
                    Console.WriteLine("\n<<<<<<Menu>>>>>>:");
                    Console.WriteLine("1- Programa que muestre los numeros de n al 1 de manera descendete:");
                    Console.WriteLine("2- Programa que muestre los numeros del 1 a 5 con while:");
                    Console.WriteLine("3- Programa que muestre el numero minimo de una lista:");
                    Console.WriteLine("4- <<<<<Salir>>>>>:");
                    Console.WriteLine("Seleccione una opcion (1-4):");

                    if (int.TryParse(Console.ReadLine(), out opciones))
                    {
                        switch (opciones)
                        {
                            case 1:

                                numerosDescendentes();

                                break;

                            case 2:

                                numerosWhile();

                                break;

                            case 3:

                                minimoLista();

                                break;

                            case 4:

                                break;

                            default:
                                Console.WriteLine("Opcion no valida. Por favor ingrese una opcion que sea valida");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no valida. Debe ingresar un numero  (1-4) ");

                    }

                } while (opciones != 4);


            }

            // Fin del main

            static void numerosDescendentes()
            {
                Console.WriteLine("\nIngrese un numero (n): ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n >= 1)
                {
                    for (int i = n; i >= 1; i--)
                    {
                        Console.WriteLine($"Numero > {i}");
                    }

                }
                else
                {
                    Console.WriteLine("Ingresar un numero mayor a 1");
                }
            }

            // Fin de numeros descendentes 


            static void numerosWhile()
            {
                int contador = 1;

                while (contador <= 5)
                {
                    Console.WriteLine($"Numero > {contador}");
                    contador++;
                }
            }

            // Fin de los numeros while 


            static void minimoLista()
            {

                List<int> numeros = new List<int> { 24, 10, 45, 35, 14, 10 };

                int minimo = numeros[0];

                // Inicializar con un valor del indice 0


                foreach (int numero in numeros)
                {
                    if (numero < minimo)
                    {
                        minimo = numero;

                        // Actualizando el valor 

                    }

                }

                Console.WriteLine("El numero minimo de la lista es > " + minimo);
            }

            // Fin de la lista

            // JUDITH ESPERANZA DEL CID DE LA O
            // AUTOEVALUACION: 8

        }
    }
}


