using FinalProject.Business.Concrete;
using FinalProject.DataAccess.Concrete.InMemory;
using System;

namespace FinalProje.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
