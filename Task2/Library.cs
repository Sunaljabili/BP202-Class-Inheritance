using System;
namespace Task2
{
    public class Library
    {
        public Library()
        {
        }
        public Book[] books;

        int j = 0;
        public void AddBook(Book book)
        {
            books[j++] = book;
        }

        public Book[] GetFiteredBooks(string genre)
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.genre==genre)
                {
                    count++;
                }
            }
            Book[] books2 = new Book[count];
            int j = 0;
            foreach (var item in books)
            {
                if (item.genre==genre)
                {
                    books2[j++] = item;
                }
            }
            return books2;
        }
        public Book[] GetFiteredBooks(double minPrice , double Maxprice)
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.price> minPrice && item.price < Maxprice)
                {
                    count++;
                }
            }
            Book[] books2 = new Book[count];
            int j = 0;
            foreach (var item in books)
            {
                if (item.price > minPrice && item.price < Maxprice)
                {
                    books2[j++] = item;
                }
            }
            return books2;
        }
        public void GetInfo(Book[] books3)
        {
            foreach (var item in books3)
            {
                Console.WriteLine($"Name ; {item.name} , " +
                $"Genre : {item.genre} , No : {item.no} Count : {item.count}  , Price : {item.price}");
            }

        }
    }
}
