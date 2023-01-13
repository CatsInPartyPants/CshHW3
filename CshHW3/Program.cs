using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            /*
            void DrawSquare(int size, char simb)
            {
                for(int i = 1; i <= size; i++)
                {
                    for(int j = 1; j <= size; j++)
                    {
                        if (i == 1 || i == size)
                        {
                            Console.Write(simb);
                        }
                        else if (j == 1 || j == size)
                            Console.Write(simb);
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            DrawSquare(25, '(');
            Console.ReadKey();
            */

            // tasl 2
            /*
            int number2;
            Console.WriteLine("Enter 4 digit number");
            number2 = Int32.Parse(Console.ReadLine());

            int [] numArr = new int[4];

            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = number2 % 10;
                number2 /= 10;
            }

            if(((numArr[0] == numArr[3]) && numArr[1] == numArr[2]))
            {
                Console.WriteLine("Polindrom.");
            }
            else
                Console.WriteLine("Not polindrom");
            Console.ReadKey();
            */

            //task 3
            /*
            void ArrayFilter(ref int [] arr1, int [] arr2)
            {
                for(int i = 0; i < arr2.Length; i++)
                {
                    arr1 = arr1.Where(val => val != arr2[i]).ToArray();
                }
            }

            int [] arra1 = { 1,2,3,4,4,4,4,5,6};
            int[] arra2 = { 4, 3, 2};

            ArrayFilter(ref arra1 , arra2);

            foreach(int i in arra1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */

            //task 4, 5, 6

            WebSite site = new WebSite("GOHA", "www.goha.ru", "192.168.100.1");
            site.ShowSiteInfo();
            site.SetDiscription("This is a website about video games.");
            site.ShowSiteInfo();
    
            Journal myJournal = new Journal("Игромания");
            myJournal.SetDiscripion("Журнал про видеоигры.");
            myJournal.SetEmail("igromania@mail.ru");
            myJournal.SetYear(1995);
            myJournal.SetPhoneNumber(8945285808);
            myJournal.ShowJournalInfo();
            

            Shop myShop = new Shop("Магнит");
            myShop.SetDiscription("Магазин с продуктами");
            myShop.SetEmail("magnit@shop.ru");
            myShop.SetPhone("89005431254");
            myShop.SetAdress("Советская, 34, Архангельск");
            myShop.ShowShopInfo();
            Console.ReadKey();
        }
    }
}
