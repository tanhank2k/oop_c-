using System;

namespace BookMan
{
    using Controllers;
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BookController bookController = new BookController();

            while(true){
                Console.Write("Request>>");
                string request = Console.ReadLine();

                switch(request.ToLower()){
                    case "single":
                        bookController.Single(1);
                    break;

                    case "create":
                        bookController.Create();
                    break;

                    case "update":
                        bookController.Update(1);
                    break;
                    
                    default:
                        Console.WriteLine("Error Syntax!!!");
                    break;
                }
            }
        }
    }
}
