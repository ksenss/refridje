using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refridje
{
    partial class Freezer
    {
        public Freezer()
        {
            price = 0;
            width = 0;
            height = 0;

        }
        public Freezer(int price, int width, int height)
        {
            Price = price;
            Height = height;
            width = Width;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Price: {Price}, Color: {Color}, Type: {type}, Shop: {shop}";
        }

    }
}