using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Carss;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = ProcessFile("D:\\C#proj\\Tutorial\\L2.Linq\\cars\\fuel.csv");
            var quering = from car in cars 
                          orderby car.Combined ascending, car.Name descending
                          select car; 
            //dung cai nay hay hon
            var top = cars.OrderByDescending(c=>c.Name)
                          .ThenBy(c=>c.Combined)
                          .Select(c=>c)
                          .First(c=> c.Manufacturer == "BMW" && c.Year == 2016);
            // neu tim k thay thi bi fail -> bao loi
            // neu co xay ra truong hop top == null thi dung method FirstorDefault thay First
            foreach (var item in quering.Take(10))
            {
                Console.WriteLine($"{item.Name} : {item.Combined}");
            }
            Console.WriteLine($"{top.Name} : {top.Combined}");
        }
        private static List<Car> ProcessFile (string path)
        {
            var query =  
                from line in File.ReadAllLines(path).Skip(1)
                where line.Length>1 
                select Car.ParseFromCsv(line);
            return query.ToList();

        }
    }
}
