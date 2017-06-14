using System;

namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] walkerInput = Resources.Resources.Day1Input.Split(new string[] { ", " }, StringSplitOptions.None);
            Walker walker = new Walker();
            walker.Walk(walkerInput);
            Console.WriteLine("Walker finished traveling, distance of endpoint:\n" + walker.GetDistance());
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}