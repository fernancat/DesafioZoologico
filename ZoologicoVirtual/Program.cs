using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZoologicoVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool abandonar = false;

            do
            {

                Console.WriteLine("\r\n  ____ _____ ______ _   ___      ________ _   _ _____ _____   ____             _        __________   ____  _      ____   _____ _____ _____ ____  \r\n |  _ \\_   _|  ____| \\ | \\ \\    / /  ____| \\ | |_   _|  __ \\ / __ \\      /\\   | |      |___  / __ \\ / __ \\| |    / __ \\ / ____|_   _/ ____/ __ \\ \r\n | |_) || | | |__  |  \\| |\\ \\  / /| |__  |  \\| | | | | |  | | |  | |    /  \\  | |         / / |  | | |  | | |   | |  | | |  __  | || |   | |  | |\r\n |  _ < | | |  __| | . ` | \\ \\/ / |  __| | . ` | | | | |  | | |  | |   / /\\ \\ | |        / /| |  | | |  | | |   | |  | | | |_ | | || |   | |  | |\r\n | |_) || |_| |____| |\\  |  \\  /  | |____| |\\  |_| |_| |__| | |__| |  / ____ \\| |____   / /_| |__| | |__| | |___| |__| | |__| |_| || |___| |__| |\r\n |____/_____|______|_| \\_|   \\/   |______|_| \\_|_____|_____/ \\____/  /_/    \\_\\______| /_____\\____/ \\____/|______\\____/ \\_____|_____\\_____\\____/ \r\n                                                                                                                                                 \r\n                                                                                                                                                 \r\n");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("0. Abandonar");
                Console.WriteLine("1. Visitar al Leon");
                Console.WriteLine("2. Visitar al Elefante");
                Console.WriteLine("3. Visitar a la Jirafa");
                Console.WriteLine("4. Visitar al tigre");
                Console.WriteLine("5. Visitar al Mono");
                Console.WriteLine("6. Visitar al Oso");
                Console.WriteLine("7. Visitar al Cocodrilo");
                Console.WriteLine("8. Visitar a la Serpiente");
                Console.WriteLine("9. Visitar al Pinguino");
                Console.WriteLine("10. Visitar al Lobo");
                Console.WriteLine("11. Visitar a la Cebra");
                Console.WriteLine("12. Visitar al rinoceronte");
                Console.WriteLine("13. Visitar al Panda");
                Console.WriteLine("14. Visitar al Pavo Real");
                Console.WriteLine("15. Visitar a la Tortuga");
                Console.Write("Qué deseas hacer Guia?: ");
                int opcion = int.Parse(Console.ReadLine()); 

                Console.WriteLine("-----------------------------------------------------------");   
                

                switch (opcion)
                {
                   
                    case 0:abandonar = true;break;
                    case 1:VisitasAnimales.visitarLeon();break;
                    case 2: VisitasAnimales.visitarElefante(); break;
                    case 3: VisitasAnimales.visitarJirafa(); break;
                    case 4: VisitasAnimales.visitarTigre(); break;
                    case 5: VisitasAnimales.visitarMono(); break;
                    case 6: VisitasAnimales.visitarOso(); break;
                    case 7: VisitasAnimales.visitarCocodrilo(); break;
                    case 8: VisitasAnimales.visitarSerpiente(); break;
                    case 9: VisitasAnimales.visitarPinguino(); break;
                    case 10: VisitasAnimales.visitarLobo(); break;
                    case 11: VisitasAnimales.visitarCebra(); break;
                    case 12: VisitasAnimales.visitarRinoceronte(); break;
                    case 13: VisitasAnimales.visitarPanda(); break;
                    case 14: VisitasAnimales.visitarPavoReal(); break;
                    case 15: VisitasAnimales.visitarTortuga(); break;
                    default: Console.WriteLine("La opcion no está dentro de los parametros"); break;


                }

                Console.ReadKey();
                Console.Clear();


            } while (!abandonar);

            Console.ReadKey(true);



        }


       

    }



}