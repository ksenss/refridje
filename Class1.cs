
 
namespace refridje

{

    partial class Freezer

    {


        public string Model { set; get; } = "bosh";

        public string Color { set; get; } = "pink";

        private int price;

        public int Price

        {

            get { return price; }

            set

            {

                if (value > 0)

                {

                    price = value;

                }

                else

                {

                    price = 0;

                }

            }

        }

        private int height;

        public int Height

        {

            get { return height; }

            set

            {

                if (value > 0)

                {

                    height = value;

                }

                else

                {

                    height = 0;

                }

            }

        }

        private int width;

        public int Width

        {

            get { return width; }

            set

            {

                if (value > 0)

                {

                    width = value;

                }

                else

                {

                    width = 0;

                }

            }

        }

        private static string type;

        private static string shop;

        static Freezer()

        {

            shop = "kyivska 16";

            type = "dry";

        }



    }

    internal class Program

    {

        static void Main(string[] args)

        {

            Freezer[] freezers = new Freezer[5];

            for (int i = 0; i < freezers.Length; i++)

            {

                freezers[i] = new Freezer(100 * (i + 1), 50 * (i + 1), 150 * (i + 1));

            }

            foreach (var freezer in freezers)

            {

                freezer.Print();

            }

        }

    }

}
