using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10VAUM1007322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            private double catetoA;
        private double anguloOpuestoA;


        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            this.catetoA = catetoA;
            this.anguloOpuestoA = anguloOpuestoA;
        }

        public double ObtenerCatetoA()
        {
            return catetoA;
        }

        public double ObtenerCatetoB()
        {

            return catetoA * Math.Tan(anguloOpuestoA * (Math.PI / 180));
        }

        public double ObtenerHipotenusa()
        {
            return catetoA / Math.Cos(anguloOpuestoA * (Math.PI / 180));
        }

        public double ObtenerAnguloOpuestoA()
        {
            return anguloOpuestoA;
        }

        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }

        public double ObtenerArea()
        {
            return catetoA * ObtenerCatetoB() / 2;
        }
    }

    class Triangulo
    {
        static void Main()
        {
            Console.Write("Ingrese la longitud del cateto A (en metros): ");
            double catetoA = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el ángulo opuesto al cateto A (en grados): ");
            double anguloOpuestoA = double.Parse(Console.ReadLine());

            TrianguloRectangulo objTriangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

            Console.WriteLine("Resultados:");
            Console.WriteLine("Cateto A:" + objTriangulo.ObtenerCatetoA() + " metros");
            Console.WriteLine("Cateto B:" + objTriangulo.ObtenerCatetoB() + "metros");
            Console.WriteLine("Hipotenusa:" + objTriangulo.ObtenerHipotenusa() + "metros");
            Console.WriteLine("Ángulo opuesto de A:" + objTriangulo.ObtenerAnguloOpuestoA() + "grados");
            Console.WriteLine("Ángulo opuesto de B: " + objTriangulo.ObtenerAnguloOpuestoB() + "grados");
            Console.WriteLine("Área" + objTriangulo.ObtenerArea() + "metros cuadrados");
        }
    }

}


