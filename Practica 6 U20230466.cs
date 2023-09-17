using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("\n*********************************************************************\n");
                Console.WriteLine("Menu de Opciones:");
                Console.WriteLine("1. Opcion 1: Suma de Numeros Pares e Impares en un Rango");
                Console.WriteLine("2. Opción 2: Adivina el número secreto (entre 1 y 10)");
                Console.WriteLine("3. Opción 3: Tablas de multiplicar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("\n*********************************************************************\n");

                Console.Write("Seleccione una opción: ");
                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n****** Suma de Numeros Pares e Impares en un Rango *******\n");
                        Console.Write("Ingrese un número entero positivo: ");

                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            int sumaPares = 0;
                            int sumaImpares = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    sumaPares += i; // Si es par, suma el acumulador de pares
                                }
                                else
                                {
                                    sumaImpares += i; // Si es impar, suma el acumulador de impares
                                }
                            }

                            Console.WriteLine("\n La suma de los números pares en el rango es: " + sumaPares);
                            Console.WriteLine("\n La suma de los números impares en el rango es: " + sumaImpares);
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un número entero positivo válido");
                        }
                        break;

                    case "2":
                        Random random = new Random();
                        int numeroSecreto = random.Next(1, 11);
                        int intentos = 0;
                        int intentoUsuario;

                        Console.WriteLine("\n******** Adivina el número secreto (entre el 1 y 10) *******");

                        while (true)
                        {
                            intentos++;

                            Console.Write("\nIngresa tu intento: ");
                            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                            {
                                if (intentoUsuario == numeroSecreto)
                                {
                                    Console.WriteLine("\nFelicitaciones, adivinaste el número secreto, que es " + numeroSecreto);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nIntenta de nuevo");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nIngresa un número válido");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("\n****************** Tablas de multiplicar ****************");
                        Console.Write("\nIngresa un número para ver su tabla de multiplicar: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nTabla de multiplicar del " + numero + " :");

                        // Utilizamos un bucle for para imprimir la tabla de multiplicar del número ingresado
                        for (int i = 1; i <= 10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine(numero + " x " + i + " = " + resultado);
                        }
                        break;

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

                Console.WriteLine(); // Salto de línea para separar las iteraciones del menú
            } while (!salir);

            Console.ReadKey();
        }
    }
}
