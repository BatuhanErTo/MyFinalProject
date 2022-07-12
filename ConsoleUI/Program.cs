using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());//solid => open closed principle
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}