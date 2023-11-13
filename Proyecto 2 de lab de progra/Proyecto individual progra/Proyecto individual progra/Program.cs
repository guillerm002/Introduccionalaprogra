class Program
{
    static Random rand = new Random();

    static int LanzarDado()
    {
        return rand.Next(1, 7);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de partidas: ");
        int partidas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de tiros por partida: ");
        int tirosPorPartida = int.Parse(Console.ReadLine());

        int puntajeJugadorTotal = 0;
        int puntajeCasaTotal = 0;
        int tirosGanadosTotal = 0;
        int tirosParesTotal = 0;
        int tirosImparesTotal = 0;
        int tirosIgualesTotal = 0;

        List<List<int>> resultadosPartidas = new List<List<int>>();

        for (int partida = 0; partida < partidas; partida++)
        {
            List<int> resultadosTiro = new List<int>();
            int puntajeJugador = 0;
            int puntajeCasa = 0;
            int tirosGanados = 0;
            int tirosPares = 0;
            int tirosImpares = 0;
            int tirosIguales = 0;

            for (int tiro = 0; tiro < tirosPorPartida; tiro++)
            {
                int dado1 = LanzarDado();
                int dado2 = LanzarDado();
                int suma = dado1 + dado2;

                resultadosTiro.Add(dado1);
                resultadosTiro.Add(dado2);

                if (puntajeJugador == 0)
                {
                    if (suma == 12 || suma == 6)
                    {
                        puntajeJugador += 12;
                    }
                    else if (suma == 4 || suma == 6 || suma == 10)
                    {
                        puntajeCasa += 12;
                    }
                    else if (suma == 11)
                    {
                        puntajeCasa += 6;
                    }
                    else if (suma >= 2 && suma <= 9)
                    {
                        puntajeJugador = suma;
                    }
                }

                if (puntajeJugador != 0)
                {
                    if (suma == puntajeJugador)
                    {
                        puntajeJugador += suma;
                        tirosGanados++;
                    }
                    else if (suma == 11)
                    {
                        puntajeCasa += 6;
                    }
                    else
                    {
                        puntajeCasa += suma;
                    }
                }

                if (suma % 2 == 0)
                {
                    tirosPares++;
                }
                else
                {
                    tirosImpares++;
                }

                if (dado1 == dado2)
                {
                    tirosIguales++;
                }
            }

            puntajeJugadorTotal += puntajeJugador;
            puntajeCasaTotal += puntajeCasa;
            tirosGanadosTotal += tirosGanados;
            tirosParesTotal += tirosPares;
            tirosImparesTotal += tirosImpares;
            tirosIgualesTotal += tirosIguales;

            string resultadoPartida = puntajeJugador > puntajeCasa ? "El jugador ganó" :
                (puntajeJugador < puntajeCasa ? "La casa ganó" : "Empate");

            Console.WriteLine($"\nPartida {partida + 1}: {resultadoPartida}");
            Console.WriteLine($"Resultados de los tiros:");

            for (int i = 0; i < resultadosTiro.Count; i += 2)
            {
                Console.WriteLine($"Tiro {i / 2 + 1}: Dado 1: {resultadosTiro[i]}, Dado 2: {resultadosTiro[i + 1]}");
            }

            Console.WriteLine($"Puntaje de la partida - Jugador: {puntajeJugador}, Casa: {puntajeCasa}");
            Console.WriteLine($"Tiros ganados por el jugador: {tirosGanados}");
        }

        Console.WriteLine("\nInformación final:");
        Console.WriteLine($"Puntaje total - Jugador: {puntajeJugadorTotal}, Casa: {puntajeCasaTotal}");
        Console.WriteLine($"Probabilidad de ganar: {(double)tirosGanadosTotal / (partidas * tirosPorPartida) * 100}%");
        Console.WriteLine($"Tiros totales con números pares: {tirosParesTotal}");
        Console.WriteLine($"Tiros totales con números impares: {tirosImparesTotal}");
        Console.WriteLine($"Tiros totales con números iguales: {tirosIgualesTotal}");
    }
}