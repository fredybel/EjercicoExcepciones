﻿using EjercicoExcepciones;

Operaciones operaciones = new Operaciones();
int opcion;
bool Ciclo = true;
double resultado = 0;



while (Ciclo)
{
    Console.WriteLine("********************************");
    Console.WriteLine("*             MENU             *");
    Console.WriteLine("* 1.      Sumar                *");
    Console.WriteLine("* 2.      Restar               *");
    Console.WriteLine("* 3.      Multiplicar          *");
    Console.WriteLine("* 4.      Dividir              *");
    Console.WriteLine("* 5.      Salir                *");
    Console.WriteLine("********************************");
    Console.WriteLine("Escoja la opción:");


    try
    {
        opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 5)
        {
            Ciclo = false;
            Console.WriteLine("fIN DEL PROGRAMA");
            break;
        }
        switch (opcion) {
            case 1:
                Console.WriteLine("ingrese el primer número");
                operaciones.N1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el segundo número");
                operaciones.N2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                operaciones.Imprimir();
                break;

            case 2:
                Console.WriteLine("ingrese el primer número");
                operaciones.N1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el segundo número");
                operaciones.N2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                operaciones.Imprimir();
                break;

            case 3:
                Console.WriteLine("ingrese el primer número");
                operaciones.N1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el segundo número");
                operaciones.N2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                operaciones.Imprimir();
                break;

            case 4:
                Console.WriteLine("ingrese el primer número");
                operaciones.N1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el segundo número");
                operaciones.N2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                operaciones.Imprimir();
                break;
        }

    }}