using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TrainglesLevel1();
            TrianglesPointingLevel2();
        }


        private static void TrainglesLevel1()
        {
            Console.Write("Write command, separate with dash: ");
            string numberList = Console.ReadLine();
            string[] sepNumbers = numberList.Split('-');

            Console.WriteLine();

            foreach (var numbers in sepNumbers)
            {
                int number = int.Parse(numbers);

                for (int i = 0; i < number; i++)
                {
                    int counter = number - i;

                    while (counter < number)
                    {
                        Console.Write("*");
                        counter++;
                    }
                   
                    Console.WriteLine("*");
                }


            }
        }


        private static void TrianglesPointingLevel2()
        {
            Console.Write("Write command: ");
            string numberList = Console.ReadLine();
            string[] sepNumbers = numberList.Split('-');

            Console.WriteLine();

            int y = 0;

            foreach (var item in sepNumbers)
            {

                if (sepNumbers[y].Contains("A"))
                {

                    string numbers = item.Replace("A", "");

                    int number = int.Parse(numbers);

                    for (int i = 0; i < number; i++)
                    {
                        int counterA = number - i;

                        while (counterA < number)
                        {
                            Console.Write("*");
                            counterA++;
                        }

                        Console.WriteLine("*");
                    }

                }

                else if(sepNumbers[y].Contains("B"))
                {
                    string numbers = item.Replace("B", "");

                    int number = int.Parse(numbers);

                    for (int i = 0; i < number; i++)
                    {
                        int counterB = i + 1;

                        while (counterB < number)
                        {
                            Console.Write("*");
                            counterB++;
                        }

                        Console.WriteLine("*");
                    }

                }

                y++;
                
            }
        }
    }
}
