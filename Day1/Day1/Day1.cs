using System;

namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] walkerInput = Resources.Resources.Day1Input.Split(new string[] { ", " }, StringSplitOptions.None);
            Walker walker = new Walker();
            walker.walk(walkerInput);
            Console.WriteLine("Walker finished traveling, distance of endpoint:\n" + walker.getDistance());
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}