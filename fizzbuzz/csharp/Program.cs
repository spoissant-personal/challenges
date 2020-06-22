using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList().ForEach((int i) =>
            {
                var res = $"{(i % 3 == 0 ? "Fizz" : "")}{(i % 5 == 0 ? "Buzz" : "")}";
                res = String.IsNullOrEmpty(res) ? i.ToString() : res;
                Console.WriteLine(res);
            });

            //for(int i = 1; i <= 100; i++)
            //{
            //    var res = $"{(i % 3 == 0 ? "Buzz" : "")}{(i % 5 == 0 ? "Fizz" : "")}";
            //    res = String.IsNullOrEmpty(res) ? i.ToString() : res;
            //    Console.WriteLine(res);
            //}
        }
    }
}
