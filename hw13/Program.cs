using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbersAsList = new List<int> { 1, 4, 2, 5, 9, 0, 3, 6 };
            var orderedNumbers = (from i in numbersAsList
                                 orderby i descending
                                 select i).Distinct().Skip(1).First();

            Console.WriteLine("Второе максимальное значение: " + orderedNumbers);

            int iteration = 0;
            foreach (int i in numbersAsList)
            {
                if (i == orderedNumbers)
                    Console.WriteLine("Позиция: " + iteration);

                iteration++;
            }

            iteration = 0;
            int sumOfEvenElements = 0;

            foreach (int i in numbersAsList)
            {
                if (iteration % 2 == 0)
                    sumOfEvenElements += i;

                iteration++;
            }

            Console.WriteLine("Сумма элементов на четных позициях: " + sumOfEvenElements);           
        }
    }
}
