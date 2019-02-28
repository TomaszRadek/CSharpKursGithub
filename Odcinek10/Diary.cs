using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
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
        private List<float> ratings;        // typ generyczny lista ocen

        public static float MinGrade = 0;
        public static float MaxGrade = 10;


        //Zachowania,  metody
        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating">nowa ocena</param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }





        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();

            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }




        

    }
}
