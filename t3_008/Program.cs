using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3_008
{
    class Program
    {
        static int Delivery(int quant)
        {
            if (quant == 0)
                return 1;
            else
                return quant * Delivery (quant - 1);
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количество клиентов: ");
            string q = Console.ReadLine();
            int quant = Convert.ToInt32(q);

            int factorial = Delivery(quant);

            Console.Write("Количество возможных вариантов доставки: {0}", factorial);

            Console.ReadKey();
        }
    }
}
