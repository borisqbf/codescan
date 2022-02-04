
using System;
using System.Net.Http;

namespace codescan
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "boris_qbf@hotmail.com";
            string password = "password";
            using (HttpClient client = new HttpClient())
            {
                var status=client.GetAsync("http://qbf.com.au" + "//?username="+ userName+"password="+password).Result.StatusCode;
            }
            double b = 12.082;
            int a = (int)b / 3;
            int[] ar = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Hello World! " + ar[a+7]);
        }
    }
}
