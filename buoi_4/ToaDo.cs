using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_4
{
    internal class ToaDo
    {
        private string _ten;
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private double x;
       
        private double y;
        public ToaDo()
        {
            x = 0;
            y = 0;
        }

        public ToaDo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX() { return x; }  
        public double GetY() { return y; }
        
        public void SetX(double x) { }
        public void SetY(double y) { }  

        public void nhap()
        {
            Console.WriteLine("Nhap tam toa do: ");
            x = double.Parse(Console.ReadLine());
            y= double.Parse(Console.ReadLine());
            
        }
    }
}
