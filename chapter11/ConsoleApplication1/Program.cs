using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://www.bing.com";
            var firstRequest = MeasureRequest(uri);
            var secondRequest = MeasureRequest(uri);
            if (firstRequest.Item1 != HttpStatusCode.OK &&
            secondRequest.Item1 != HttpStatusCode.OK)
            {
                Console.WriteLine("Unexpected status code");
            }
            else
            {
                Console.WriteLine($"First request took {firstRequest.Item2}ms");
                Console.WriteLine($"Second request took {secondRequest.Item2}ms");
            }
            Console.ReadLine();
        }

        static HttpClient client = new HttpClient();

        static Tuple<HttpStatusCode, long> MeasureRequest(string uri)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var response = client.GetAsync(uri).Result;
            response.Content.ReadAsStringAsync().Wait();
            stopwatch.Stop();

            return new Tuple<HttpStatusCode, long>(
                response.StatusCode,
                stopwatch.ElapsedMilliseconds);
        }
    }
}
