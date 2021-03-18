using System;
using System.Collections.Generic;
using System.Linq;

namespace Features.Linq
{
    public static class MyLinq 
    {
        public static int Cunt<T> (this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
             count ++;   
            return count;
        }
    }   
}