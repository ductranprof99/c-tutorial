using System;
using System.Collections.Generic;
using System.Linq;
using Features;
using Features.Linq;
namespace L2.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            //a.LinqExample1();
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {id = 1,name = "Yasdb"},
                new Employee {id = 1,name = "Melur"},
                new Employee {id = 1,name = "Scoot"},
                new Employee {id = 1,name = "Cootsh"}
            };
            IEnumerable<Employee> sales = new List<Employee>(){
                new Employee {id = 3,name = "Alex"}
            };
            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            // while (enumerator.MoveNext())
            // {
            //    Console.WriteLine(enumerator.Current.name); 
            // }
            // int a2 = developers.Count();
            // Console.WriteLine(a2);
            foreach (var item in developers.Where(NameStartWithS));
            // cach 1
            foreach (var item in developers.Where(e => e.name.StartsWith("S")));
            // cach 2
            var query2 = from developer in developers 
                           where developer.name.Length == 5
                           orderby developer.name select developer;
            foreach (var item in query2)
            {
             Console.WriteLine(item);    
            }

        }
        private static bool NameStartWithS(Employee a){
            return a.name.StartsWith("S");
        }

        // public void LinqExample1(){
        //     int[] a = {1,2,3,4,5,6,9,7,8,10};
        //     IEnumerable<int> a1 = from i in a where i%2 == 0 select i;
        //     foreach (int i in a1) 
        //         Console.WriteLine(i);
        //     Console.ReadLine(); 
        // }
        public void LinqExample2(){
            // int[] a = {1,2,3,4,5,6,9,7,8,10};
            // IEnumerable<int> a1 = EnumerableExtensions.Where()
            // foreach (int i in a1) 
            //     Console.WriteLine(i);
            // Console.ReadLine(); 
        }
    }
}
