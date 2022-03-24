using System;

namespace homeworkBP202
{
    class Program
    {
        static void Main(string[] args)
        {

            Notebook notebook1 = new Notebook();
            Notebook notebook2 = new Notebook();
            Notebook notebook3 = new Notebook();
            Notebook notebook4 = new Notebook();

            notebook1.Name = "M1pro";
            notebook1.BrandName = "MacBook";
            notebook1.Price = 2000;


            notebook2.Name = "Toshiba";
            notebook2.BrandName = "Toshiba";
            notebook2.Price = 1000;


            notebook3.Name = "Legion";
            notebook3.BrandName = "Lenova";
            notebook3.Price = 1200;


            notebook4.Name = "ZenBook";
            notebook4.BrandName = "Asuse";
            notebook4.Price = 1450;

            double minPrice = 1300;
            double maxPrice = 2100;
           
            Notebook[] notebooks = new Notebook[] { notebook1, notebook2, notebook3, notebook4 };

            foreach (var item in FindPrice(notebooks,minPrice,maxPrice))
            {

                Console.WriteLine($" bu markali {item.Name} ve {item.BrandName} bu komputerler bu araliga daxildir:{item.Price}");
            }





        }

        static Notebook[]  FindPrice(Notebook[] notebooks,double minPrice,double maxPrice)
        {

            int count = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {

                if (notebooks[i].Price >minPrice && notebooks[i].Price<maxPrice)
                {
                    count++;
                }
            }

            Notebook[] filterNotbooks = new Notebook[count];

            int j = 0;
            for (int i = 0; i <notebooks.Length; i++)
            {
                if (notebooks[i].Price > minPrice && notebooks[i].Price < maxPrice)
                {

                    filterNotbooks[j] = notebooks[i];
                    j++;
                }

            }
            return filterNotbooks;
        }

    }

}
