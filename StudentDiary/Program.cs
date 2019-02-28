using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();  // deklaracja obiektu (zmiennej)
            // trzeba utworzyć obiekt

           //diary.AddRating(5);
           //diary.AddRating(8.5f);  // oznaczenie f, żeby kompilator wiedział, że chodzi o liczbę float a nie dobble które domyślnie przylmuje
           // diary.AddRating(4.7f);

           // float  avg = diary.CalculataAverage();
           // float max = diary.GiveMaxRating();
           // float min = diary.GiveMinRating();

            for (;;)
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);  // gdy parsowanie nie udaje się raiting jest ustawiany na 0
                
                

                if (rating==11)
                {
                    break;
                }

                if (result)
                {
                    if (rating>0 && rating <=10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbę z zakresu 1-10");
                    }
                    
                }

                

            }

            Console.WriteLine("Średnia twoich ocen to: " + diary.CalculataAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
            Console.ReadKey();

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();


        }
    }

}
