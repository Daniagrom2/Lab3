using System;
using ClassLibrary1;
namespace KrossLab_3
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            Computer a = new Computer("Asus",16,"Nvidia GTX 1050Ti","Intel Core i5");
            Console.Write($"{a.Name} {a.GPU_Name} {a.CPU_Name} {a.RAM_Count}");
        }
    }
}
