using System;

namespace nt
{
    class Program
    {
        static void Main(string[] args)
        {
            var pid = System.Diagnostics.Process.GetCurrentProcess().Id;
            for (var i = 0; ; i++)
            {
                var l = Console.ReadLine();
                if (l == null)
                {
                    break;
                }
                Console.WriteLine($"pid={pid}, i={i}, {l}");
            }
        }
    }
}
