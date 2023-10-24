

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SchetBanka;

namespace SchetBanka
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchetVBanke[] scheta = new SchetVBanke[2];

            for (int i = 0; i < scheta.Length; i++)
            {

                scheta[i] = new SchetVBanke();

            }

            int otvetSchet = 1;


            while (otvetSchet == 1 || otvetSchet == 2)
            {
                Console.WriteLine("Введите номер счета (1 или 2), чтобы перейти в его меню");

                otvetSchet = Convert.ToInt32(Console.ReadLine());
                string otvet1 = "да";
                if (otvetSchet != 1 && otvetSchet != 2)
                {
                    Console.WriteLine("Такого счета не может быть");
                    break;

                }
                else
                {
                    while (otvet1 == "да")
                    {

                        Console.WriteLine("Меню счета " + otvetSchet + ": \n 1 - открыть счет \n 2 - показать информацию о счете \n 3 - положить на счет \n 4 - снять со счета \n 5 - взять всю сумму \n 6 - перенести сумму с одного счета на другой");
                        int otvetMenu = Convert.ToInt32(Console.ReadLine());
                        switch (otvetMenu)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                scheta[otvetSchet - 1].choose(otvetMenu);
                                break;
                            case 6:
                                switch (otvetSchet - 1)
                                {
                                    case 0:
                                        scheta[0].choose(scheta[1], otvetMenu);
                                        break;
                                    case 1:
                                        scheta[1].choose(scheta[0], otvetMenu);
                                        break;
                                }
                                break;

                        }

                        Console.WriteLine("Хотите вернуться в меню счета №" + otvetSchet + "?");
                        otvet1 = Console.ReadLine();
                        if (otvet1 == "нет")
                        {
                            break;
                        }
                    }

                }
                


            }


            Console.ReadLine();

        }
    }
}