using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_guesses_untilitsright_näitab_mitu_korda_arvas
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ütleb mitu korda pidi kasutaja õige vastuse saamiseks arvama

            int magicNumber = new Random().Next(0, 101);
            int kasutajaNumber;
            int arvamisi = 1;

            Console.Write("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Sinu valitud number: ");
                if (int.TryParse(Console.ReadLine(), out kasutajaNumber))
                {
                    if (kasutajaNumber == magicNumber)
                    {
                        Console.WriteLine("Arvasid õige numbri!");
                        //siia tegin väikese täienduse Google abiga, et kirjutaks välja mitu korda pidi kasutaja numbrit arvama
                        Console.WriteLine("Sa arvasid ära õige numrbri {0}. {1}..\n", arvamisi, arvamisi == 1 ? "korral" : "korral");
                        

                    }
                    else
                    {
                        if (kasutajaNumber > magicNumber)
                        {
                            Console.WriteLine("Sinu number on liiga suur");
                            ++arvamisi;
                            continue;
                        }
                        if (kasutajaNumber < magicNumber)
                        {
                            Console.WriteLine("Sinu number on liiga väike");
                            ++arvamisi;
                            continue;
                        }
                    }
                }

            }

        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
