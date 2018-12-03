using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {

            //TrainglesLevel1();
            TrianglesPointingLevel2();//TODO: Lägg hela programmet (TriangelsPointingLevel2() anropet) i en loop, då behöver man inte starta programmet på nytt utan kan skriva in nya kommandon när programmet skrivit ut trianglarna

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
            string numberlist = GetUserInput(); //Lagt koden som hämtar input i en egen metod "GetUserInput"

            string[] sepNumbers = numberlist.Split('-',StringSplitOptions.RemoveEmptyEntries); //Lagt till en stringsplitoption som parameter till "Split" funktionen så den inte lägger in tomma rader i listan om användaren inte skriver något mellan två bindestreck

            Console.WriteLine();

            skrivUtTrianglar(sepNumbers); // Lagt koden som skriver ut en triangel i en egen metod "SkrivUtTrianglar"

        }

        private static string GetUserInput() //metod som hämtar input i form av en string från användaren och returnerar en string
        {
            Console.Write("Write command: ");
            string userInput = Console.ReadLine();
            return "LOL";
        }

        private static void skrivUtTrianglar(string[] sepNumbers) //metod som skriver ut trianglar enligt en string array med kommandon
        {
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

                        while (counterA < number) //TODO: Här kan det vara tydligare med en forloop, du använder dig ändå av en räknare (counterA) som du skapar vid sidan av. 
                        {
                            Console.Write("*");
                            counterA++;
                        }

                        Console.WriteLine("*");
                    }

                }

                else if (sepNumbers[y].Contains("B"))
                {
                    string numbers = item.Replace("B", "");

                    int number = int.Parse(numbers);

                    for (int i = 0; i < number; i++)
                    {
                        int counterB = i + 1;

                        while (counterB < number)//TODO: Här kan det vara tydligare med en forloop, du använder dig ändå av en räknare (counterB) som du skapar vid sidan av. 
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
