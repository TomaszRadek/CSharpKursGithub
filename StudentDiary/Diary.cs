using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {

        public Diary()  // konstruktor - po wpisaniu ctor i tab*2 pojawi się ten wpis domyślny
                        // konstruktor jest wywoływany gdy tworzony jest obiekt, konstruktor nic nie zwraca
                        // konstruktor wykorzystuje się najczęściej do inicjowania
        {
            ratings = new List<float>();
        }


        //Stan (zmienne - pola)
        List<float> ratings;        // typ generyczny lista ocen
        
        //Zachowania,  metody
        public void AddRating(float rating)
        {
            ratings.Add(rating);                 
        }

        public float CalculataAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();
            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        
        public float GiveMinRating()
        {
            return ratings.Min();
        }

    }
}
