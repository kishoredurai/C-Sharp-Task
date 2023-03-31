using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    public class PhotoBook
    {
        private int numPages;
        public PhotoBook()
        {
            this.numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
        public int GetNumberPages()
        {
            return this.numPages;
        }
    }
    public class AddPhotoBook : PhotoBook
    {
        public AddPhotoBook() : base(64)
        {
        }
    }
    public class PhotoBookTest
    {
        public static void Main(string[] args)
        {
            // Create a default photo book and 
            PhotoBook book1 = new PhotoBook();
            Console.WriteLine("Number of pages in default photo book: " + book1.GetNumberPages());

            // photo book with 32 pages
            PhotoBook book2 = new PhotoBook(32);
            Console.WriteLine("Number of pages in photo book with 32 pages: " + book2.GetNumberPages());


            // Create a large photo book and show the number of pages
            AddPhotoBook book3 = new AddPhotoBook();
            Console.WriteLine("Number of pages in large photo book: " + book3.GetNumberPages());
        }
    }
}
