using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gagan rules the IT universe"); Download();
        }

        static void Download()
        {
            Network.Download();
        }

    }
    class Network
    {
        static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}

