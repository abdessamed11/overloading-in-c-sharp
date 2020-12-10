using System;

namespace overloading_in_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Overloading over = new Overloading();
            int samm = over.add(10,20);
            Console.WriteLine(samm);

            int sam2 = over.add(10, 2, 5);
            Console.WriteLine(sam2);

            float sam3 = over.add(10.4f, 20.3f);
            Console.WriteLine(sam3);




            Console.ReadKey();
        }
    }
}
