using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191114E2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            ///ÖSSZEFOGLALÁS
            /*
             * 0) változótípusok
             * 0) vezérlő szerkezetek
             * ----------------------
             * 1) string.Format()
             * 2) Random() + ConsoleColor + SetCursorePosition()
             * 3) programozási tételek I, II
             * 4) String-ek példány szintű metódusai
            */

            //string.Format példák
            int kor = 12;
            Console.WriteLine("Én " + kor + " éves vagyok");
            Console.WriteLine("Én {0} éves vagyok", kor);
            Console.WriteLine($"Én {kor} éves vagyok");

            int[] t = { 1, 123, 123456 };
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine("Ez az {0}. szám: {1, 6} és még utána szöveg", i + 1, t[i]);
            }

            int nagy = 1234567;
            Console.WriteLine("{0:N0}", nagy);

            double d = Math.PI;
            Console.WriteLine("Pi = {0:0.00}", d);

            int ft = 1234;
            Console.WriteLine("{0:C}", ft);

            //Random() példák

            int[] t3 = new int[10];
            for (int i = 0; i < t3.Length; i++)
            {
                //3al osztható 3 számjegyű
                t3[i] = rnd.Next(34, 334) * 3;
            }

            double[] d2 = new double[10];
            for (int i = 0; i < d2.Length; i++)
            {
                //40 és 80 2tj pontosságú
                d2[i] = rnd.Next(4000, 8001) / 100.0;
            }

            //prg tételek és feladatok:
            //elmélet és feladatok:
            //     http://info.nytta.hu/temak/prog/Programozasi_tetelek.pdf

            //órai gyakorlat:
            //pI:  https://github.com/JuhaszZoltan/CA191017E
            //pII: https://github.com/JuhaszZoltan/CA191024E

            //összefoglalva integer vektoron mind:
            //     https://github.com/JuhaszZoltan/CA191111/

            //String kezelés rövid jegyzet:
            //     https://my.pcloud.com/publink/show?code=XZkr3QkZuytf7MzejLQeSnHzPbhkD0mToAak

            Console.ReadKey();
        }
    }
}
