class program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[7];
        int mayor = int.MinValue;
        int menor = int.MaxValue;
        int cantidadNegativos = 0;
        int cantidadPositivos = 0;

        // Solicitamos el ingreso de los 7 números
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            // Actualizamos el mayor y el menor
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
            else if (numeros[i] < menor)
            {
                menor = numeros[i];
            }

            // Contamos los números negativos y positivos
            if (numeros[i] < 0)
            {
                cantidadNegativos++;
            }
            else
            {
                cantidadPositivos++;
            }
        }

        // Imprimimos los resultados
        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");
        Console.WriteLine($"La cantidad de números negativos es: {cantidadNegativos}");
        Console.WriteLine($"La cantidad de números positivos es: {cantidadPositivos}");

        // Imprimimos los 7 números ingresados
        Console.WriteLine($"Los números ingresados son: ");
        foreach (int numero in numeros)
        {
            Console.Write($"{numero} ");
        }
        Console.WriteLine();
    }
}