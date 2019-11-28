using System;

namespace Practicas_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine( "--BIENVENIDO A SU CONVERTIDOR DE DIVIISAS ");
           System.Console.WriteLine(    );
           System.Console.WriteLine("SELECCIONE LA OPCION QUE DESEA REAIZAR");
           System.Console.WriteLine("1) PESOS A DOLARES");
           System.Console.WriteLine( "2) DOLARES A PESOS");
           System.Console.WriteLine("3) SALIR");
         int  r = Convert.ToInt32(Console.ReadLine());
           switch (r)
           {
            case 1:
            System.Console.WriteLine("INGRESE LA CANTIDAD QUE DESEA CONVERTIR");
            double PESOS = Convert.ToDouble(Console.ReadLine());
            var res = PESOS/20;
            System.Console.WriteLine("Usted cuenta con: "+res+" dlls"); 
            break; 

            case 2: 
             System.Console.WriteLine("INGRESE LA CANTIDAD QUE DESEA CONVERTIR");
            double DOLARES = Convert.ToDouble(Console.ReadLine());
            var res1 = DOLARES*20;
            System.Console.WriteLine("Usted cuenta con: "+res1+" mxn"); 
            break; 
            
            case 3:
               break;
               default:
               break;
           }

        }
    }
}
