using System;

namespace Sistema_de_votacion
{
    class Program
    {
        static void Votar()
        {
            float voto1 = 0;
            float voto2 = 0;
            float voto3 = 0;
            float voto4 = 0;
            Console.WriteLine("Sistema de votacion \n");
            Console.WriteLine("Ingrese su nombre completo \n");
            string Nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese su numero de cedula \n");
            int cedula = Convert.ToInt32(Console.ReadLine());
            string[] candidatos = { " ", "Juan Martinez", "Joanna Sanchez", "Ramon Lopez", "Dalmy Garcia" };
            Console.WriteLine("\nCandidatos electos: \n");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(i + ") " + candidatos[i]);
            }
            Console.WriteLine("Insertar el numero correspondiente a su votante electo: ");
            int electo = Convert.ToInt32(Console.ReadLine());
            switch (electo)
            {
                case 1:
                    if (electo == 1)
                    {
                        Console.WriteLine("Esta seguro de que desea realizar el voto? \n 1: Si \n 2: No");
                        int confirmar = Convert.ToInt32(Console.ReadLine());
                        if (confirmar == 1)
                        {
                            voto1++;
                            Console.Clear();
                            Console.WriteLine("Su voto ha sido realizado \n");
                        }
                        else if (confirmar == 2)
                        {
                            while (confirmar == 2)
                            {
                                Console.WriteLine("\nCandidatos electos: \n");
                                for (int i = 1; i <= 4; i++)
                                {
                                    Console.WriteLine(i + ") " + candidatos[i]);
                                }
                                Console.WriteLine("Insertar el numero correspondiente a su votante electo: ");
                                electo = Convert.ToInt32(Console.ReadLine());
                                if (electo == 1)
                                {
                                    voto1++;
                                    Console.Clear();
                                    Console.WriteLine("Su voto ha sido realizado");
                                    confirmar = 1;
                                }
                                else
                                {
                                    Console.WriteLine("Elija nuevamente su votante");
                                    Console.Clear();

                                }
                            }
                        }
                    }
                    break;
                case 2:
                    if (electo == 2)
                    {
                        Console.WriteLine("Esta seguro de que desea realizar el voto? \n 1: Si \n 2: No");
                        int confirmar = Convert.ToInt32(Console.ReadLine());
                        if (confirmar == 1)
                        {
                            voto2++;
                            Console.Clear();
                            Console.WriteLine("Su voto ha sido realizado");
                        }
                        else if (confirmar == 2)
                        {
                            while (confirmar == 2)
                            {
                                Console.WriteLine("\nCandidatos electos: \n");
                                for (int i = 1; i <= 4; i++)
                                {
                                    Console.WriteLine(i + ") " + candidatos[i]);
                                }
                                Console.WriteLine("Insertar el numero correspondiente a su votante electo: ");
                                electo = Convert.ToInt32(Console.ReadLine());
                                if (electo == 2)
                                {
                                    voto2++;
                                    Console.Clear();
                                    Console.WriteLine("Su voto ha sido realizado");
                                    confirmar = 1;
                                }
                                else
                                {
                                    Console.WriteLine("Elija nuevamente su votante");
                                    Console.Clear();

                                }
                            }
                        }
                    }
                    break;
                case 3:
                    if (electo == 3)
                    {
                        Console.WriteLine("Esta seguro de que desea realizar el voto? \n 1: Si \n 2: No");
                        int confirmar = Convert.ToInt32(Console.ReadLine());
                        if (confirmar == 1)
                        {
                            voto3++;
                            Console.Clear();
                            Console.WriteLine("Su voto ha sido realizado");
                        }
                        else if (confirmar == 2)
                        {
                            while (confirmar == 2)
                            {
                                Console.WriteLine("\nCandidatos electos: \n");
                                for (int i = 1; i <= 4; i++)
                                {
                                    Console.WriteLine(i + ") " + candidatos[i]);
                                }
                                Console.WriteLine("Insertar el numero correspondiente a su votante electo: ");
                                electo = Convert.ToInt32(Console.ReadLine());
                                if (electo == 3)
                                {
                                    voto3++;
                                    Console.Clear();
                                    Console.WriteLine("Su voto ha sido realizado");
                                    confirmar = 1;

                                }
                                else
                                {
                                    Console.WriteLine("Elija nuevamente su votante");
                                    Console.Clear();

                                }
                            }
                        }
                    }
                    break;
                case 4:
                    if (electo == 4)
                    {
                        Console.WriteLine("Esta seguro de que desea realizar el voto? \n 1: Si \n 2: No");
                        int confirmar = Convert.ToInt32(Console.ReadLine());
                        if (confirmar == 1)
                        {
                            voto4++;
                            Console.Clear();
                            Console.WriteLine("Su voto ha sido realizado \n");
                        }
                        else if (confirmar == 2)
                        {
                            while (confirmar == 2)
                            {
                                Console.WriteLine("\nCandidatos electos: \n");
                                for (int i = 1; i <= 4; i++)
                                {
                                    Console.WriteLine(i + ") " + candidatos[i]);
                                }
                                Console.WriteLine("Insertar el numero correspondiente a su votante electo: ");
                                electo = Convert.ToInt32(Console.ReadLine());
                                if (electo == 4)
                                {
                                    voto4++;
                                    Console.Clear();
                                    Console.WriteLine("Su voto ha sido realizado");
                                    confirmar = 1;
                                }
                                else
                                {
                                    Console.WriteLine("Elija nuevamente su votante");
                                    Console.Clear();

                                }
                            }
                        }
                    }
                    break;
            }
        }
        static void Resultados()
        {
            var Random = new Random();
            float voto1 = 0;
            float voto2 = 0;
            float voto3 = 0;
            float voto4 = 0;

            for (int i = 1; i <= 1000; i++)
            {
                int seleccion = Random.Next(1, 5);

                if (seleccion == 1)
                {
                    voto1 += 1;
                }
                else if (seleccion == 2)
                {
                    voto2 += 1;

                }
                else if (seleccion == 3)
                {
                    voto3 += 1;

                }
                else if (seleccion == 4)
                {
                    voto4 += 1;
                }
            }
            float[] votos = { 0, voto1, voto2, voto3, voto4 };
            float[] Rvotos = { 0, voto1, voto2, voto3, voto4 };
            Array.Sort(Rvotos);
            Console.WriteLine("Resultados de las votaciones \n");
            for (int e = 4; e >= 1; e--)
            {
                if (votos[1] == Rvotos[e])
                {
                    int Nposicion = Array.IndexOf(votos, votos[1]);
                    switch (Nposicion)
                    {
                        case 1:
                            Console.WriteLine("El candidato " + "Juan Martinez" + " ha concluido con la cantidad de " + Rvotos[e] + " votos y un porcentaje de " + Rvotos[e] / 1000 * 100 + "%");
                            break;
                    }

                }
                if (votos[2] == Rvotos[e])
                {
                    int Nposicion = Array.IndexOf(votos, votos[2]);
                    switch (Nposicion)
                    {
                        case 2:
                            Console.WriteLine("El candidato " + "Ramon Lopez" + " ha concluido con la cantidad de " + Rvotos[e] + " votos y un porcentaje de " + Rvotos[e] / 1000 * 100 + "%");
                            break;
                    }
                }
                if (votos[3] == Rvotos[e])
                {
                    int Nposicion = Array.IndexOf(votos, votos[3]);
                    switch (Nposicion)
                    {
                        case 3:
                            Console.WriteLine("El candidato " + "Joanna Sanchez" + " ha concluido con la cantidad de " + Rvotos[e] + " votos y un porcentaje de " + Rvotos[e] / 1000 * 100 + "%");

                            break;
                    }
                }
                if (votos[4] == Rvotos[e])
                {
                    int Nposicion = Array.IndexOf(votos, votos[4]);
                    switch (Nposicion)
                    {
                        case 4:
                            Console.WriteLine("El candidato " + "Dalmy Garcia" + " " + " ha concluido con la cantidad de " + Rvotos[e] + " votos y un porcentaje de " + Rvotos[e] / 1000 * 100 + "%");

                            break;
                    }
                }
            }

            if (voto1 == Rvotos[4])
            {
                Console.WriteLine("\nEl candidato ganador es Juan Martinez");
            }
            else if (voto2 == Rvotos[4])
            {
                Console.WriteLine("\nEl candidato ganador es Ramon Lopez");
            }
            else if (voto3 == Rvotos[4])
            {
                Console.WriteLine("\nEl candidato ganador es Joanna Sanchez");
            }
            else if (voto4 == Rvotos[4])
            {
                Console.WriteLine("\nEl candidato ganador es Dalmy Garcia");
            }
        }


        static void Main()
        {
            int Opcions = 0;
            while (Opcions != 3)
            {

                Console.WriteLine("Sistema de votaciones \n");
                Console.WriteLine("1) Votar");
                Console.WriteLine("2) Resultados");
                Console.WriteLine("3) Salir");
                Console.WriteLine("\nEscriba el numero de la opcion a utilizar");
                Opcions = Convert.ToInt32(Console.ReadLine());
                switch (Opcions)
                {
                    case 1:
                        Console.Clear();
                        Votar();
                        break;
                    case 2:
                        Console.Clear();
                        Resultados();
                        Console.WriteLine("\nDar enter para salir al menu principal");
                        Console.ReadLine();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }


        }
    }
}