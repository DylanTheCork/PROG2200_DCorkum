using System;
using Humanizer;

namespace NugetExample
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(TimeSpan.FromMilliseconds(1299630020).Humanize(3));
            Console.WriteLine(TimeSpan.FromMilliseconds(3603001).Humanize(3));
            Console.WriteLine(TimeSpan.FromMilliseconds(8157019263).Humanize(3));
        }
    }
}