using System;
namespace BookMan.Views
{
    using Models;
    using Framework;
    class BookUpdateView
    {
        protected Book Model;
        public BookUpdateView(Book model)
        {
            Model = model;
        }

        public void Render()
        {
            ViewHelp.WriteLine("UPDATE BOOK INFORMATION", ConsoleColor.Green);
            

            var title = ViewHelp.InputString("Title", Model.Title);
            var authors = ViewHelp.InputString("Authors", Model.Authors);
            var publisher = ViewHelp.InputString("Publisher", Model.Publisher);
            var year = ViewHelp.InputInt("Year", Model.Year);
            var editon = ViewHelp.InputInt("Edition", Model.Edition);
            var tags = ViewHelp.InputString("Tags", Model.Tags);
            var description = ViewHelp.InputString("Description", Model.Description);
            var rate = ViewHelp.InputInt("Rate", Model.Rating);
            var reading = ViewHelp.InputBool("Reading", Model.Reading);
            var file  = ViewHelp.InputString("File", Model.File);
        }

    }
}