using System;

namespace najmniejsza_najwieksza_liczba
{
    class Program
    {
        /*
         * Zadanie 1:
            -Stwórz metodę która przyjmuje stringa, a są nimi liczby oddzielone spacjami. Na podstawie tego argumentu zwróc najwyższą wartosc i najmniejszą jako string.
            
            Przykład:
            -Dla parametrów "1 2 3 4 5" zostanie zwrócone "5 1"
            -Dla parametrów "1 2 3 4 -5" zostanie zwrócone "4 -5"
            -Dla parametrów "14" zostanie zwrócone "14 14"
            
            Założenia:
            -Możesz założyć, że przekazany przez użytkownika parametr jest zawsze prawidłowy, nie musisz pisać walidacji.
            -Zawsze zostanie przekakazane przynajmniej jedna liczba.
            -Zwrócisz strina, którym będą 2 liczby oddzielone spacją. Wyższy numer będzie pierwszy.
        */


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
            var minNumber = int.Parse(numberList[0]);

            for (int i = 0; i < numberList.Length; i++)
            {
                
                if (int.Parse(numberList[i]) > maxNumber)
                {
                    maxNumber = int.Parse(numberList[i]);
                }

                if (int.Parse(numberList[i]) < minNumber)
                {
                    minNumber = int.Parse(numberList[i]);
                }
            }

            
            return $"{maxNumber} {minNumber}";

        }
    }   
}
