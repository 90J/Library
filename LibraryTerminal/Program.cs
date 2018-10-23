using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //The books
            string[,] BookArray = new string[,]
        {
            { "Book Number 1", "IT", "Stephen King", "In" },
            { "Book Number 2", "C# for Jay", "Stephen Davis", "In" },
            { "Book Number 3", "To Kill a Mochingbird", "Harper Lee", "In" },
            { "Book Number 4", "1984", "George Orwell", "In" },
            { "Book Number 5", "Jane Eyre", "Charlotte Bronte", "In" },
            { "Book Number 6", "Gone with the Wind", "Margaret Mitchell", "In" },
            { "Book Number 7", "The Book Thief", "Markus Zusak", "In" },
            { "Book Number 8", "Night", "Elie Wiesel", "In" },
            { "Book Number 9", "Of Mice and Men", "John Steinbeck", "In" },
            { "Book Number 10", "A Tale of Two Cities", "Charles Dickens", "In" },
            { "Book Number 11", "Where the Sidewalk Ends", "Shel Silverstein", "In" },
            { "Book Number 12", "Sherlock Holmes", "Arthur Conan Doyle", "In" },
        };
            Start:
            //Main menu
            Console.WriteLine("Jay's Lackluster Boring Library");
            Console.WriteLine("What wouold you like to do?");
            Console.WriteLine("(1) List of books.");
            Console.WriteLine("(2) Search by Author.");
            Console.WriteLine("(3) Search by Keyword.");
            Console.WriteLine("(4) Select a book to check out.");
            Console.WriteLine("(5) Return a book.");
            Console.WriteLine("(q) to exit.");
            Console.Write("Please use the numbers to make your selection: ");
            string userChoice = Console.ReadLine();

            while (userChoice != "0")
            {

                //List all Books
                if (userChoice == "1")
                {
                    Console.WriteLine("List of books: ");
                    Console.WriteLine("User Chose 1");
                    foreach (var i in BookArray)
                    {
                        Console.WriteLine(string.Join("\n", i.ToString()));
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                }

                //Search by Author
                if (userChoice == "2")
                {
                    Console.Write("Enter the name of the Author you wish to search for: ");
                    string userAuthSearch = Console.ReadLine();

                    string value1 = Array.Find(BookArray, element => element.StartsWith(userAuthSearch, StringComparison.Ordinal));
                    if (value1 != null)
                    {
                        Console.WriteLine("Author Found");
                    }
                    else
                    {
                        Console.WriteLine("Does not exist.");
                        goto Start;
                    }

                }

                //Search with Keyword
                if (userChoice == "3")
                {
                    Console.Write("Enter a keyword to locate a book: ");
                    string userKWSearch = Console.ReadLine();


                }

                //Mark book as Checked Out
                if (userChoice == "4")
                {
                    Console.WriteLine("Select a book to check out: ");
                    string bookCheckOut = Console.ReadLine();
                }

                //Mark book as Checked In
                if (userChoice == "5")
                {
                    Console.WriteLine("Enter the book number you would like to return: ");
                    string userReturn = Console.ReadLine();
                }

                //Quit Program
                if (userChoice == "q")
                {
                    Console.WriteLine("Visit again soon!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("*Please enter a number from the below menu...*");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine();
                    goto Start;
                }
            }

        }


    }
}