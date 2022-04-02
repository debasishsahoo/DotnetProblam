using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class PhotoAlbum
    {
        private int numberOfPages;

        public  PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int a)
        {
            numberOfPages = a;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
