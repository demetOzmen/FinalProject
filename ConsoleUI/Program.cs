﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

public class Program
{
    public static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        foreach (var product in productManager.GetAllByCategoryId(2))
        {
            Console.WriteLine(product.ProductName);
        }
    }
}