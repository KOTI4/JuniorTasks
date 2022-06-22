using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPicturesInRow = 3;
            int totalPicturesCountInAlbum = 52;

            int numberCompletedRows = totalPicturesCountInAlbum / numberPicturesInRow;
            int numberPicturesBeyondMeasure = totalPicturesCountInAlbum % numberPicturesInRow;

            Console.WriteLine("Количество заполненных рядов {0}, количество картинок сверх меры {1}",
                numberCompletedRows, numberPicturesBeyondMeasure);
            Console.ReadLine();
        }
    }
}
