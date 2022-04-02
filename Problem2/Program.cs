using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class AlbumTest
    {
        static void Main()
        {
            bool debug = false;

            //Create an album with its default constructor
            PhotoAlbum myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfPages());

            //Create an album with 24 pages
            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfPages());

            //Create an BigPhotoAlbum 
            BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberOfPages());

            if (debug)
                Console.ReadLine();
            Console.ReadKey();
        }
    }
}
