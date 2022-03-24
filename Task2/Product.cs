using System;
namespace Task2
{
    public class Product
    {
        public Product(string name , int no , double price)
        {
            this.price = price;
            this.name = name;
            this.no = no;
        }
        public Product(string name, int no, double price , int count)
        {
            this.price = price;
            this.name = name;
            this.no = no;
            this.count = count;
        }

        public string name;
        public int no;
        public double price;
        public int count;
    }
}
