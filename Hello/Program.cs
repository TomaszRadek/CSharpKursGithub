using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            valuwTypes();
            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void valuwTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxlong = long.MaxValue;
            long minlong = long.MinValue;

            Console.WriteLine("maxInt = "+maxInt);
            Console.WriteLine(" minInt = "+minInt);
            Console.WriteLine(" maxlong = "+ maxlong);
            Console.WriteLine(" minlong = " + minlong);


            


            
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey(); //czeka na naciśnięcie dowolnego klawisza
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);


            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo jesteś pełnoletni, możesz wypiś browara!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek");
            }

            else
            {
                Console.WriteLine("Możemy ci zaoferowaź mleko");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkownika  //komentarz, który będzie widoczny przy korzie wywołania metody po najechaniu myszką
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}
