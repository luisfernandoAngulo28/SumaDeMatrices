using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] A = { 1, 3, 4, 5, 6 };///[1][3][4][5][6]  //inicializar un Vector






            ///Matriz Original
            int[,] A = { { 1, 0, 0, 0, 0, 0 },
                         { 3, 2, 0, 0, 3, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0,-4 },
                         { 1,-2, 0, 0, 0, 1 },
                         { 0, 0, 0, 0, 1, 0 }
                        };

            int[,] B = { { 1, 0, 0, 0, 0, 0 },
                         { 3, 2, 0, 0, 3, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0,-4 },
                         { 1,-2, 0, 0, 0, 1 },
                         { 0, 0, 0, 0, 1, 0 }
                        };

            int[,] C = { { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 }
                        };




            clsSpar m = new clsSpar();
            clsSpar n = new clsSpar();
            clsSpar r = new clsSpar();

            Console.WriteLine("--------Matriz Original-----------------");
            Console.WriteLine(m.MostrarMatriz(A));
            Console.WriteLine(n.MostrarMatriz(B));
            Console.WriteLine("-------------------------");
            m.Cargar(A);
            n.Cargar(B);
            r.Cargar(C);
            Console.WriteLine("-------Matriz Sparce------------------");

            System.Console.WriteLine(m.MostrarMatrizSparce());
            System.Console.WriteLine(n.MostrarMatrizSparce());

            Console.WriteLine("-------Suma------------------");
            //Console.WriteLine(m.SumaAB(A,B));
            Console.WriteLine(r.sumaDeMatrices(m, n));
            Console.WriteLine(r.MostrarMatrizSparce());
            //-----------------------------------------------------------



            //System.Console.WriteLine(p.SumarMatricesDispersas(m,n));
           

            Console.ReadKey();


        }
    }
}
