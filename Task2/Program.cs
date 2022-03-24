using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kitablarin sayi : ");
            int countBook = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.books = new Book[countBook];
            for (int i = 0; i < countBook; i++)
            {

                string name = "";
                string genre = "";
                int count = 0, no = 0;
                double price = 0;
                bool check=true;

                while (name.Length < 1 || name.Length > 50)
                {
                    Console.WriteLine("Kitabin adi : ");
                    name = Console.ReadLine();
                }
                while (genre.Length < 3 || genre.Length > 20)
                {
                    Console.WriteLine("Kitabin janri : ");
                    genre = Console.ReadLine();
                }
                while (count <= 0)
                {
                    Console.WriteLine("Kitabin sayi :");
                    count = int.Parse(Console.ReadLine());
                }
                while (price <= 0)
                {
                    Console.WriteLine("Kitabin qiymeti");
                    price = double.Parse(Console.ReadLine());
                }
                
                while (check)
                {
                    check = false;
                    Console.WriteLine("Kitabin nomresi :");
                    no = int.Parse(Console.ReadLine());
                    for (int j = 0; j < i; j++)
                    {
                        if (library.books[j].no==no)
                        {
                            check = true;
                            break;
                        }
                    }
                }

                library.AddBook(new Book(genre, name, no, price, count));

            }
            while (true)
            {
                Console.WriteLine("Filet Olunsun ? : y/n");
                char answer = char.Parse(Console.ReadLine());
                if (answer=='y')
                {
                    Console.WriteLine("janra gore -1 ,, qiymete gore -2");
                    answer = char.Parse(Console.ReadLine());
                    if (answer=='1')
                    {
                        Console.WriteLine("Janri daxil et : ");
                        string genre = Console.ReadLine();
                        library.GetInfo(library.GetFiteredBooks(genre));
                        break;
                    }
                    else if (answer=='2')
                    {
                        Console.WriteLine("Max ve Min qiymetleri yazin");
                        double minprice = double.Parse(Console.ReadLine());
                        double maxprice = double.Parse(Console.ReadLine());
                        library.GetInfo(library.GetFiteredBooks(minprice , maxprice));
                        break;

                    }
                    else
                    {
                        Console.WriteLine("1 ve ya 2 daxil edile biler !!!");
                    }
                }
                else if (answer=='n')
                {
                    library.GetInfo(library.books);
                    break;
                }
                else
                {
                    Console.WriteLine("y ve ya n daxil edile biler ");
                }

            }

            
        }

    }
}

