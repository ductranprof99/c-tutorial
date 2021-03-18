using System;

namespace Carss
{
    class Car
    {
        public int Year {set;get;}
        public string Manufacturer {set;get;}
        public string Name {set;get;}
        public double Displacement {set;get;}
        public int Cylinder {set;get;}
        public int City {set;get;}
        public int HighWay {set;get;}
        public int Combined {set;get;}

        internal static Car ParseFromCsv(string line)
        {
            //Model Year,Division,Carline,Eng Displ,# Cyl,City FE,Hwy FE,Comb FE
            var column = line.Split(',');
            return new Car{
                Year = int.Parse(column[0]),
                Manufacturer = column[1],
                Name = column[2],
                Displacement = double.Parse(column[3]),
                Cylinder = int.Parse(column[4]),
                City = int.Parse(column[5]),
                HighWay = int.Parse(column[6]),
                Combined = int.Parse(column[7])
            };
        }
    }
}