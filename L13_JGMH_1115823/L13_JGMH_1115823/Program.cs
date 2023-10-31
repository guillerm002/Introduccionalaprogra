internal class Program
{
    static void Main(string[] args)
    {
        double[] notas = new double[8];
        double promedio = 0;
        double suma = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Ingrese la nota para el índice " + i);
            notas[i] = double.Parse(Console.ReadLine());
            suma = suma + notas[i];
        }

        promedio = suma / 8;
        double notaMasAlta = notas[0];
        for (int i = 1; i < notas.Length; i++)
        {
            if (notas[i] > notaMasAlta)
            {
                notaMasAlta = notas[i];
            }
        }
        Console.WriteLine("La nota más alta es: " + notaMasAlta);
        Console.WriteLine("Promedio: " + promedio);



        Console.WriteLine("Ingrese una palabra");
        string palabra = Console.ReadLine();
        Console.WriteLine("Ingrese una letra: ");
        char letra = char.Parse(Console.ReadLine());
        int contador = 0;
        bool existe = false;

        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letra)
            {
                contador++;
            }
            if (i == 0 && palabra[i] == letra)
            {
                existe = true;
            }
        }
        if (existe)
        {
            Console.WriteLine("La letra ingresada existe al inicio de la palabra");
        }
        else
        {
            Console.WriteLine("La letra ingresada no existe al inicio de la palabra");
        }
        Console.WriteLine("La cantidad de veces que se encuentra la letra en la palabra es:" + contador);
        Console.ReadKey();

    }
}
