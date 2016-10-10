using PostageCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string weight, height, width, depth;

            Console.WriteLine("Enter Weight in kg:");
            weight = Console.ReadLine();
            Console.WriteLine("Enter Height in cm:");
            height = Console.ReadLine();
            Console.WriteLine("Enter Width in cm:");
            width = Console.ReadLine();
            Console.WriteLine("Enter Depth in cm");
            depth = Console.ReadLine();

            try
            {
                Parcel parcel = new Parcel(Int32.Parse(weight), Int32.Parse(height), Int32.Parse(width), Int32.Parse(depth));

                Console.WriteLine(string.Format("Category: {0}", parcel.GetParcelCategory()));
                Console.WriteLine(string.Format("Cost: {0}", parcel.PrintPostageCost()));
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please make sure you enter valid parcel dimensions");
                Console.ReadLine();
            }

        }
    }
}
