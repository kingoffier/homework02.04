using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("pizza.json");
            var product = JsonConvert.DeserializeObject<List<Product>>(data);
            //var product1 = product.Where(x => x.category_id == 1).ToList();
            //if (product1.Count != 0)
            //{
            //    foreach (var item in product1)
            //    {
            //        Console.WriteLine($"id_product: {item.id_product}");
            //        Console.WriteLine($"name_product: {item.name_product}");
            //        Console.WriteLine($"category_id: {item.category_id}");
            //        Console.WriteLine($"description: {item.description}");
            //        Console.WriteLine($"price: {item.price}");
            //        Console.WriteLine($"image: {item.image}");

            //        Console.WriteLine("-----------------");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Такой категории нет");
            //}
            Console.WriteLine("----------------------------------");
            //var product2 = product.Select(x=>x.name_product).ToList();            
            //foreach(var item in product2)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("----------------------------------");
            //var product3 = product.Where(x => x.price > 500).ToList();
            //if (product3.Count != 0)
            //{
            //    foreach (var item in product3)
            //    {
            //        Console.WriteLine($"id_product: {item.id_product}");
            //        Console.WriteLine($"name_product: {item.name_product}");
            //        Console.WriteLine($"category_id: {item.category_id}");
            //        Console.WriteLine($"description: {item.description}");
            //        Console.WriteLine($"price: {item.price}");
            //        Console.WriteLine($"image: {item.image}");


            //        Console.WriteLine("-----------------");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Таких товаров за такую цену нет");
            //}
            Console.WriteLine("----------------------------------");
            //var product4 = product.Where(x => x.description.Contains("чеснок")).ToList();
            //if (product4.Count != 0)
            //{
            //    foreach (var item in product4)
            //    {
            //        Console.WriteLine($"id_product: {item.id_product}");
            //        Console.WriteLine($"name_product: {item.name_product}");
            //        Console.WriteLine($"category_id: {item.category_id}");
            //        Console.WriteLine($"description: {item.description}");
            //        Console.WriteLine($"price: {item.price}");
            //        Console.WriteLine($"image: {item.image}");


            //        Console.WriteLine("-----------------");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Таких товаров нет");
            //}
            Console.WriteLine("----------------------------------");
            //var product5 = product.Where(x=>x.id_product==1).Select(x=>x.image);
            //int count=product5.Count();
            //if (count>0)
            //{
            //    foreach (var item in product5)
            //    {
            //        Console.WriteLine(item);


            //        Console.WriteLine("-----------------");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Таких товаров нет");
            //}
            Console.WriteLine("----------------------------------");
            //bool proverka = product.Any(x => x.description.Contains("чеснок"));
            //if(proverka)
            //{
            //    var product6 = product.Where(x => x.description.Contains("чеснок")).First();
            //    Console.WriteLine(product6.id_product);
            //    Console.WriteLine(product6.name_product);
            //    Console.WriteLine(product6.category_id);
            //    Console.WriteLine(product6.description);
            //    Console.WriteLine(product6.price);
            //    Console.WriteLine(product6.image);
            //}
            //else
            //{
            //    Console.WriteLine("Такого товара нет");
            //}
            Console.WriteLine("----------------------------------");
            //Console.WriteLine("Введите идентификаторы продуктов");
            //string end = String.Empty;
            //int resultprice = 0;
            //while (end != "закончить выбор")
            //{
            //    end = Console.ReadLine();
            //    try
            //    {
            //        if (end == "закончить выбор")
            //        {
            //            break;
            //        }
            //        var product7 = product.Where(x => x.id_product == Convert.ToInt32(end));
            //        foreach (var item in product7)
            //        {
            //            resultprice += item.price;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Вы ввели не число");
            //    }
            //}

            //Console.WriteLine(resultprice);
            Console.WriteLine("----------------------------------");
            List<Product> product8 = product.Where(x => x.id_product == 1).ToList();
            List<string> ingridients=new List<string>();
            string proverka=String.Empty;
            foreach(var item in product8)
            {
                proverka += item.description;               
            }
            for (int i = 0; i < proverka.Split().Length; i++)
            {
                ingridients.Add(proverka.Split()[i]);
            }
            string[] result=ingridients.ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Product
    {
        public int id_product { get; set; }
        public string name_product { get; set; }
        public int category_id { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string image { get; set; }

    }

}

