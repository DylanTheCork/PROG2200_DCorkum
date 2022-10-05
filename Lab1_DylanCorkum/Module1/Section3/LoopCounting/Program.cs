using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                var k = 10;

                Console.WriteLine("Loop #{0}", (i+1));

                for (int j = 1; j <= 20; j++)
                {
                    if (j <= 10)
                    {
                        Console.WriteLine(j);
                    }
                    else
                    {
                        Console.WriteLine(k);
                        k--;
                    }
                    
                }
                
            }
            Console.ReadLine();
        }
    }
}