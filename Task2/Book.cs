using System;
namespace Task2
{
    public class Book:Product
    {
        public Book(string genre, string name , int no , double price , int count ):base(name , no , price, count)
        {
            this.genre = genre;

        }
        public Book(string genre, string name, int no, double price ) : base(name, no, price)
        {
            this.genre = genre;

        }
        public string genre;
    }
}
