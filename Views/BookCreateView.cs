using System;
namespace BookMan.Views
{
    using Models;
    using Framework;
    /// <summary>
    /// Class de them mot cuon sach moi
    /// </summary>
    public class BookCreateView
    {
        /// <summary>
        /// Ham khoi tao
        /// </summary>
        public BookCreateView()
        {

        }
        
        /// <summary>
        /// Yeu cau nguoi dung nhap thong tin va luu lai thong tin do
        /// </summary>
        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("CREATE A NEW BOOK");
            Console.ResetColor();

            var title = ViewHelp.InputString("Title");
            var authors = ViewHelp.InputString("Authors");
            var publisher = ViewHelp.InputString("Publisher");
            var year = ViewHelp.InputInt("Year");
            var editon = ViewHelp.InputInt("Edition");
            var tags = ViewHelp.InputString("Tags");
            var description = ViewHelp.InputString("Description");
            var rate = ViewHelp.InputInt("Rate");
            var reading = ViewHelp.InputBool("Reading");
            var file  = ViewHelp.InputString("File");

        }
    }
}