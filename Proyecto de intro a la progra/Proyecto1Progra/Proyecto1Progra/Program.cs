class Program
{

    static void Main(string[] args)
    {

        //Variables para el codigo y nombre de la estación Partida y Destino
        int EstacionPartida = 0;
        int EstacionDestino = 0;
        string NombreEstacionPartida = "";
        string NombreEstacionDestino = "";

        //Variables para los datos del viaje
        int DistanciaViaje = 0;
        string FechaServicio = "";
        int Edad = 0;
        bool Embarazada = false;
        bool Menor = false;

        //Variables para los datos del boleto
        string RutaViaje = "";
        double TiempoEstimadoViaje = 0;
        double PrecioBoleto = 0;

        //Variables para los datos acumulados del viaje
        double TiempoTotalViajado = 0;
        double TotalGastoBoletos = 0;
        int CantidadBoletos = 0;

        //Variables de control y menu
        int entradaMenu = 0;
        bool otroViaje = false;
        bool continuar = false;


        //El programa se va a estar ejecutando mientras no se seleccione la opcion de salida [2]
        do
        {
            Console.Write("\n");

            //Si no es otro viaje que muestre el menu principal (primer viaje)
            if (!otroViaje)
            {
                Console.WriteLine("-----VIAJES EN TRANSMETRO-----");

                Console.WriteLine("1. Iniciar Viaje");
                Console.WriteLine("2. Salir");

                Console.Write("\n");
                Console.Write("Opcion: ");

                entradaMenu = int.Parse(Console.ReadLine());
            }

            //Si la opcion seleccionada es [1] que solicite los datos del viaje
            if (entradaMenu == 1)
            {
                Console.Write("\n");

                //Si no es otro viaje (primer viaje) que solicite la estación de partida, sino unicamente se muestra los datos de la estacion de partida
                if (!otroViaje)
                {
                    Console.Write("Ingrese Codigo Estación de Partida: ");
                    EstacionPartida = int.Parse(Console.ReadLine());
                    //Se obtiene el nombre de la estación de partida
                    NombreEstacionPartida = obtenerNombreEstacion(EstacionPartida);
                }
                else
                {
                    //Si solicitó otro viaje se muestran los datos de la estación de partida
                    Console.WriteLine("Estación de Partida: [{0}] - {1}", EstacionPartida, NombreEstacionPartida);
                }


                //Se solicitan los datos de la estacion de destino
                Console.Write("Ingrese Codigo Estación de Destino: ");
                EstacionDestino = int.Parse(Console.ReadLine());

                //Se obtiene el nombre de la estación de destino 
                NombreEstacionDestino = obtenerNombreEstacion(EstacionDestino);

                //Se obtiene la distancia entre la estación de partida y destino
                DistanciaViaje = obtenerDistanciaRuta(EstacionPartida, EstacionDestino);

                //Si DistanciaViaje es mayor a cero quiere decir que existe una ruta valida, se procede a solicitar los datos para la compra del boleto
                if (DistanciaViaje > 0)
                {
                    //Si no es otro viaje se solicitan los datos para la compra del boleto, de lo contrario no se vuelven a solicitar
                    if (!otroViaje)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("-----COMPRA DE BOLETO-----");

                        //Se solicita la fecha de servicio
                        Console.Write("Fecha de Servicio (dd/mm/yyyy): ");
                        FechaServicio = Console.ReadLine();

                        //Se solicita la edad
                        Console.Write("Edad: ");
                        Edad = int.Parse(Console.ReadLine());

                        //Se solicita si está embarazada
                        Console.WriteLine("Está Embarazada? (1 = SI, 0 = NO)");
                        Embarazada = Convert.ToBoolean(int.Parse(Console.ReadLine()));

                        //Se solicita si viajará con menor de 3 años
                        Console.WriteLine("Viajará con un niño menor a 3 años? (1 = SI, 0 = NO)");
                        Menor = Convert.ToBoolean(int.Parse(Console.ReadLine()));
                    }

                    //Se concatena los datos de la estacion de partida y destino (Codigo y Nombre)
                    RutaViaje = String.Format(" Inicio: [{0}] - {1} \nDestino: [{2}] - {3}"
                                              , EstacionPartida, NombreEstacionPartida, EstacionDestino, NombreEstacionDestino);

                    //Se obtiene el tiempo del viaje el cual se calcula a partir de la distancia entre las estaciones seleccionadas
                    TiempoEstimadoViaje = obtenerTiempoViaje(DistanciaViaje);

                    //Se obtiene el precio del boleto en base a: distancia, la edad, si está embarazada, si viaja con un menor de 3 años
                    PrecioBoleto = obtenerPrecioBoleto(DistanciaViaje, Edad, Embarazada, Menor);

                    //Se muestran los datos de la compra del boleto
                    Console.WriteLine("\n");
                    Console.WriteLine("-----DATOS DEL BOLETO-----");

                    Console.WriteLine("Ruta del Viaje");
                    Console.WriteLine(RutaViaje);

                    Console.WriteLine(String.Format("Tiempo Estimado: {0} hrs", TiempoEstimadoViaje));
                    Console.WriteLine(String.Format("Precio del Boleto: {0} centavos", PrecioBoleto));

                    Console.WriteLine("\n");

                    //Se acumulan los datos del viaje en las variables para el resumen del viaje al finalizar.
                    CantidadBoletos = CantidadBoletos + 1;
                    TiempoTotalViajado = TiempoTotalViajado + TiempoEstimadoViaje;
                    TotalGastoBoletos = TotalGastoBoletos + PrecioBoleto;

                    //Se establece otroViaje en falso 
                    otroViaje = false;

                    //Se muestra si desea realizar otro viaje
                    Console.WriteLine("Desea realizar otro viaje? (1 = SI, 0 = NO)");
                    otroViaje = Convert.ToBoolean(int.Parse(Console.ReadLine()));

                    //Si es otro viaje
                    if (otroViaje)
                    {
                        //Se realiza el cambio de estación: La estación de Destino pasa a ser la estación de Partida
                        EstacionPartida = EstacionDestino;
                        NombreEstacionPartida = NombreEstacionDestino;
                    }
                    else
                    {
                        //Si no es otro viaje se etablece la opción de menu a [2 - Salir]
                        entradaMenu = 2;
                    }

                }
                else
                {
                    //Si no existe una ruta valida se muestra un mensaje de error
                    Console.WriteLine("\n");
                    Console.WriteLine("No existe la ruta del viaje requerido.");

                    //Se muestra si desea continuar, para pedir nuevamente los datos.
                    Console.Write("\n");
                    Console.WriteLine("Desea continuar? (1 = SI, 0 = NO)");
                    continuar = Convert.ToBoolean(int.Parse(Console.ReadLine()));

                    //Si no desea continuar 
                    if (!continuar)
                    {
                        //Se etablece la opción de menu a[2 - Salir]
                        entradaMenu = 2;
                    }

                }

            }


        } while (entradaMenu != 2);//Se estará ejecutando el ciclo mientras la entradaMenu sea diferente a [2 - Salir]


        //Si compró mas de un boleto se muestra el resumen del viaje
        if (CantidadBoletos >= 1)
        {
            Console.WriteLine("\n");
            Console.WriteLine("-----FIN DEL VIAJE-----");
            Console.WriteLine("Cantidad de Boletos: {0}", CantidadBoletos);
            Console.WriteLine("Tiempo total viajado: {0} hrs", TiempoTotalViajado);
            Console.WriteLine("Total gastado en boletos: {0} centavos", TotalGastoBoletos);
            Console.WriteLine("\n");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }


    }


    //Funcion que permite calcular el precio del boleto en base a: Distancia, Edad, si está Embarazada, si viaja con un Menor de 3 años
    static double obtenerPrecioBoleto(int Distancia, int EdadPasajero, bool ViajaEmbarazada, bool ViajaMenor)
    {
        double precio = 0;
        double descuento = 0;

        //Si viaja embarazada o viaja con un menor de 3 años el precio es cero
        if (ViajaEmbarazada || ViajaMenor)
        {
            precio = 0;
        }
        else //sino
        {
            //Si la edad del pasajero está entre los 15 y 25 años se aplica un descuento del 21%
            if (EdadPasajero >= 15 && EdadPasajero <= 25)
            {
                descuento = 0.21;
            }

            //Si la distancia del viaje es mayor a 10 
            if (Distancia > 10)
            {
                //El precio se calcula: los primeros 10 km son 7 centavos y despues los restantos km se cobran a 2 centavos por km.
                precio = (7 + ((Distancia - 10) * 2));
            }
            else
            {
                //Si la distancia no es mayor a 10km, unicamente se cobran 7 centavos
                precio = 7;
            }

            //El precio final es: el precio menos el descuento (si aplica)
            precio = precio - (precio * descuento);
        }


        return precio;
    }

    //funcion que permite obtener el tiempo del viaje requerido, se necesita la distancia para hacer el calculo
    static double obtenerTiempoViaje(int DistanciaRuta)
    {
        double tiempo;
        //Los buses viajan a una velocidad constante de 40km/h
        double velocidad = 40;
        //Se aplica la formula: tiempo = distancia / velocidad
        tiempo = (DistanciaRuta / velocidad);

        //Se redondea el tiempo a 2 decimales
        return Math.Round(tiempo, 2);
    }


    //Funcion que permite obtener el nombre de la estación en base a su codigo
    static string obtenerNombreEstacion(int CodigoEstacion)
    {
        string NombreEstacion;

        //Se realiza un case en base al CodigoEstación para obtener el Nombre de la Estación, sino existe se retorna una cadena vacia
        switch (CodigoEstacion)
        {
            case 51:
                NombreEstacion = "Estación Javier";
                break;

            case 61:
                NombreEstacion = "Estación Trébol";
                break;

            case 71:
                NombreEstacion = "Estación Don Bosco";
                break;

            case 82:
                NombreEstacion = "Estación Plaza Municipal";
                break;

            default:
                NombreEstacion = "";
                break;
        }


        return NombreEstacion;
    }

    //Funcion que permite obtener la Distancia en km de la Ruta en base al codigo de la estación de partida y destino
    static int obtenerDistanciaRuta(int CodigoEstacionPartida, int CodigoEstacionDestino)
    {
        int DistanciaRuta = 0;

        //Estación Javier -> Estación Trébol
        if (CodigoEstacionPartida == 51 && CodigoEstacionDestino == 61)
        {
            DistanciaRuta = 14;
        }
        //Estación Javier -> Estación Plaza Municipal
        else if (CodigoEstacionPartida == 51 && CodigoEstacionDestino == 82)
        {
            DistanciaRuta = 28;
        }
        //Estación Don Bosco -> Estación Plaza Municipal
        else if (CodigoEstacionPartida == 71 && CodigoEstacionDestino == 82)
        {
            DistanciaRuta = 13;
        }
        //Estación Trébol -> Estación Javier
        else if (CodigoEstacionPartida == 61 && CodigoEstacionDestino == 51)
        {
            DistanciaRuta = 7;
        }
        //Estación Plaza Municipal -> Estación Javier
        else if (CodigoEstacionPartida == 82 && CodigoEstacionDestino == 51)
        {
            DistanciaRuta = 21;
        }


        return DistanciaRuta;

    }


}

