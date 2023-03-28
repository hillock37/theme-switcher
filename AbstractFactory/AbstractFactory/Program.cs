using System.ComponentModel;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WebPage lightPage = new WebPage(new LightModeFactory());
            Console.WriteLine("Light page:\n" + lightPage.DescribeTheme());
            WebPage darkPage = new WebPage(new DarkModeFactory());
            Console.WriteLine("Dark page:\n" + darkPage.DescribeTheme());
        }
    }
}