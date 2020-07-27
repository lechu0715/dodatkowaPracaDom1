using System;

namespace najmniejsza_najwieksza_liczba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby a program wskaże największą i najmniejszą");
            var name = Console.ReadLine();
            Console.WriteLine(MaxMin(name));

            Console.ReadLine();
        }

        public static string MaxMin(string value)
        {

            string[] numberList = value.Split(new string[] { " " }, StringSplitOptions.None); //to z neta :)


            var maxNumber = int.Parse(numberList[0]);
            for (int i = 0; i < numberList.Length; i++)
            {
                
                if (int.Parse(numberList[i]) > maxNumber)
                {
                    maxNumber = int.Parse(numberList[i]);
                }

            }

            var minNumber = int.Parse(numberList[0]);
            for (int i = 0; i < numberList.Length; i++)
            {
                
                if (int.Parse(numberList[i]) < minNumber)
                {
                    minNumber = int.Parse(numberList[i]);
                }
            }

            return $"{maxNumber} {minNumber}";

        }
    }   
}
