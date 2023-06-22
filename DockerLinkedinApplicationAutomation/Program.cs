using System;

namespace DockerLinkedinApplicationAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<1000)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(i+".Step");
                i++;
            }
        }
    }
}
