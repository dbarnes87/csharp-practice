using System;
namespace PropertiesC
{
    public class Box
    {
        // member variable
        private int length;
        private int height;
        //private int width;
        private int volume;

        public int FrontSurface
        {
            get
            {
                return length * height;
            }
        }

        public int Width { get; set; }

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.height = height;
            this.Width = width; 
        }

        public int Volume {
            get
            {
                return Height * Width * Length;
            }
            set
            {
                volume = value;
            }
        }


        public int Height {
            get
            {
                return height;
            }
            /*
            set
            {
                if (value < 0)
                    value = -value;


                height = value;
            }
            */
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        public void displayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}.",
                length, height, Width, volume = Width * height * length); 
        }
    }
}
