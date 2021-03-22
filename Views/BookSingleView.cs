using System;
namespace BookMan.Views
{
    using Models;
    using Framework;
    internal class BookSingleView
    {
        protected Book Model; //Luu tru thong tin cuon sach can hien thi

        ///<summary>
        /// Ham tao
        ///</summary>
        ///<param name="model">Cuon sach cu the se duoc hien thi</param>
        public BookSingleView(Book model)
        {
            Model = model;
        }

        ///<summary>
        /// Thuc hien in thong tin cuon sach ra man hinh console
        /// </summary>
        public void Render()
        {
            if (Model == null)
            {
                ViewHelp.WriteLine("NO BOOK FOUND, SORRY!!", ConsoleColor.Red);
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            ViewHelp.WriteLine("BOOK DETAIL INFORMATION: ", ConsoleColor.Cyan);
            Console.ResetColor();

            Console.WriteLine($"Author: \t {Model.Authors}");
            Console.WriteLine($"Title: \t {Model.Title}");
            Console.WriteLine($"Publisher: \t {Model.Publisher}");
            Console.WriteLine($"Year: \t {Model.Year}");
            Console.WriteLine($"Edition: \t {Model.Edition}");
            Console.WriteLine($"Isbn: \t {Model.Isbn}");
            Console.WriteLine($"Tags: \t {Model.Tags}");
            Console.WriteLine($"Description: \t {Model.Description}");
            Console.WriteLine($"Rating: \t {Model.Rating}");
            Console.WriteLine($"Reading: \t {Model.Reading}");
            Console.WriteLine($"File: \t {Model.File}");
            Console.WriteLine($"FileName: \t {Model.FileName}");
        }

    }
}