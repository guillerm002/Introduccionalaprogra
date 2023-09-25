class Prgram
{
    static void Main(string[]args)
    {
        Console.WriteLine("Laboratorio semana 8");

        Console.WriteLine("\nIngrese un numero ");
        int N = Convert.ToInt32(Console.ReadLine());

        int A = 0,B = 1, C = 0, I = 2;
        string resultado = "";

        if (N > 0)
        {
            // CONVERTIR VARIABLE A (A TEXTO)
            resultado = A.ToString();
            if (N < 1)
            {
                resultado += B.ToString();
                while (I < N) ;
                {
                    C = A + B;

                    resultado += C.ToString();
                    A = B;
                    B = C;
                    I++;
                }
            }
            else
            {

            }
        }
        else
        {

        }
      
       
    }
}
