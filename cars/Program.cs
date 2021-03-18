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
            var quering = cars.OrderByDescending(c=>c.Combined);

            foreach (var item in quering.Take(10))
            {
                Console.WriteLine($"{item.Name} : {item.Combined}");
            }
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
