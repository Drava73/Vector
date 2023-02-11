using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        private int x;
        private int y;
        private int z;
        private double dlina;
        public void Skoliatplus() {
            int k;
            Console.Write("Введите скаляр:");
            k = Convert.ToInt32(Console.ReadLine());
            this.x *= k;
            this.y *= k;
            this.z *= k;
        }
        public void Skoliatminus()
        {
            int k;
            Console.Write("Введите скаляр:");
            k = Convert.ToInt32(Console.ReadLine());
            this.x /= k;
            this.y /= k;
            this.z /= k;
        }
        public void Vekplusvek(Vector ob1,Vector ob2)
        {
            ob1.x += ob2.x;
            ob1.y += ob2.y;
            ob1.z += ob2.z;
        }
        public void Vekminusvek(Vector ob1, Vector ob2)
        {
            ob1.x -= ob2.x;
            ob1.y -= ob2.y;
            ob1.z -= ob2.z;
        }
        public void Vekumnvek(Vector ob1, Vector ob2)
        {
            ob1.x *= ob2.x;
            ob1.y *= ob2.y;
            ob1.z *= ob2.z;
        }
        public void Vekprovvek(Vector ob1, Vector ob2)
        {
            if (ob1.x == ob2.x)
            {
                if (ob1.y == ob2.y)
                {
                    if(ob1.z == ob2.z) {
                        Console.Write("Вектора равны");
                    }
                }
            }
        }
        public int XYZlength
        {
            get {
                dlina = (x * x) + (y * y) + (z * z);
                double result = Math.Sqrt(Convert.ToDouble(dlina));
                return Convert.ToInt32(result); }
        }
        public int Xcoordinates
        {
            get { return x; }
        }
        public int Ycoordinates
        {
            get { return y; }
        }
        public int Zcoordinates
        {
            get { return z; }
        }
        public Vector() {
            x = 0;
            y = 0;
            z = 0;
        }
        public Vector(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Input() {
            Console.Write("Input x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input z:");
            z = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Vector({x},{y},{z})";
        }
    }
}
