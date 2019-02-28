using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
             Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            DiaryStatistics stats = diary.ComputeStatistics();
            Console.WriteLine("Srednia ocen " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena" + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena" + stats.MinGrade);

               }
    }
}
