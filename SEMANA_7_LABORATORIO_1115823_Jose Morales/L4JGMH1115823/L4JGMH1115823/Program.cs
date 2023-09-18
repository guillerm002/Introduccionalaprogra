class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio numero 1");
        Console.Write("Ingrese un numero: ");
        string numero1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numero1);

        Console.WriteLine("Ingrse otro numero: ");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        Console.WriteLine("Ingrse otro numero: ");
        string numero3 = Console.ReadLine();
        int num3 = Convert.ToInt32(numero3);
        // SUMA 
        int suma = num1 + num2;
        Console.WriteLine("resultado suma:" + num1 + " + " + num2 + " = " + suma);
        Console.ReadKey();
        // Resta 
        int resta = num1 - num2;
        Console.WriteLine("resultado resta:" + num1 + " - " + num2 + " = " + resta);
        Console.ReadKey();
        // Multiplicación
        int multiplicación = num1 * num2;
        Console.WriteLine("resultado multiplicación:" + num1 + " * " + num2 + " = " + multiplicación);
        Console.ReadKey();
        // Divsion 
        int división = num1 / num2;
        Console.WriteLine("resultado división:" + num1 + " / " + num2 + " = " + división );
        Console.ReadKey();
        // Residuo
        int residuo = num1 % num2 ;
        Console.WriteLine("resultado residuo:" + num1 + " % " + num2 + " = " + residuo);
        Console.ReadKey();
        
        //Mayor o igual que 
        Console.WriteLine("Ejercicio numero 2");
        
        if (num1> num2)
        {
            Console.WriteLine(num1 + " es mayor que: " + num2);
        }
        else if (num1 < num2)
        {
            Console.WriteLine(num1 + " es menor que: " + num2);
        }
        else if (num1 == num2)
        {
            Console.WriteLine(num1 + " es igual que: " + num2);
        }

        Console.WriteLine("Ejercicio numero 3");
        
         // Jerarquia de operaciones 
        int operacion1 = (num1 * num2) + num3 ;
        Console.WriteLine("resultado de la operacion 1:" + num1 + " * " + num2 + " + " + num3 + " = " + operacion1);
        Console.ReadKey();
        int operacion2 = num1 / (num2 * num3);
        Console.WriteLine("resultado de la operacion 2:" + num1 + " / " + num2 + " * " + num3 + " = " + operacion2);
        Console.ReadKey();
    }   
}
