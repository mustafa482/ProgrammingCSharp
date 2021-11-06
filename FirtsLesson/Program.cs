using System;
using System.Text;

namespace FirtsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            int var1;
            Console.Write("İlk ədədi daxil edin:");
            while (true)
            {

                try
                {
                    var1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception exc)
                {

                    Console.WriteLine("You can only enter int number");
                    Console.Write("Xais olunur ilk ededi tekrar daxil edin:");
                }
            }
            


            Console.Write("İkinci ədədi daxil edin:");
            int var2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Verilən ədədlərin cəmi:{0}", Sum(var1,var2));

            
            Console.ReadLine();
            
        }
        static int Sum(int var1,int var2)
        {
            return var1 + var2;
        }
    }
}
