using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sections = { 10, 20, 15, 15, 30 };
            bool isOpen = true;


            while (isOpen)
            {
                Console.SetCursorPosition(0, 17);
                for (int i = 0; i < sections.Length; i++)
                {
                    Console.WriteLine($"В секторе номер {i + 1} свободно {sections[i]} мест.");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\tРегистарция рейса.\n\n ");
                Console.WriteLine("1 - забронировать места.\n2 - выход из программы.");
                Console.Write("Введите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlace;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sections.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует. ");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать? ");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (userPlace < 0)
                        {
                            Console.WriteLine("Вы ввели неверные значения. ");
                            break;
                        }
                        if (sections[userSector] < userPlace)
                        {
                            Console.WriteLine($"В секторе {userSector + 1} недостаточно мест. ");
                            break;
                        }
                        sections[userSector] -= userPlace;
                        Console.WriteLine("Успешно!");

                        break;
                    case 2:
                        isOpen = false;
                        break;

                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
