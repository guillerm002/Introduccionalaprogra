using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ejercicio no 2");
        int numero; // EnvironmentVariableTarget tipo entero
        string dia; //variable tipo cadena 

        Console.WriteLine("Ingrese un numero del uno al siete:  ");
        dia = Console.ReadLine();
        numero = Int32.Parse(dia);

        if (numero >= 1 && numero <= 7)
        {
            if (numero == 1)
            {
                Console.WriteLine("Lunes");
            }
        else if (numero == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Miercoles");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Sabado");
            }
            else if (numero == 7)
            {
                Console.WriteLine("Domingo");
            }
            else if (numero >= 8)
            {

                Console.WriteLine("Numero invalido");
            }
        }
    }
 
}