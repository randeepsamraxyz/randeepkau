using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peter Rules the IT Universe!");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://ibm.com");
            Console.WriteLine(data);
        }
        class Network
        {
            static public Task Download()
            {
                return Task.Run(() => Thread.Sleep(3000));
            }
        }
    }
}