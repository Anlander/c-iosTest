using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person(FirstName: "Philip", LastName: "Anlander");
            // person.Age = 30;
            // person.GetFullName();
            // person.GetPersonInfo();
            Book book = new Book(
                Pages: 5,
                Title: "Life",
                Author: "King"
                );
            book.GetBookInfo();
        }
    }
}