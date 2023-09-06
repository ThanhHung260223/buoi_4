using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace buoi_4
{
    class program
    {
        static void Main(string[] args)
        {
            ToaDo toaDo = new ToaDo();
            HinhTron hinhTron = new HinhTron();
            toaDo.nhap();
            hinhTron.nhap();
            toaDo.xuat();
            hinhTron.xuat();
            Console.ReadLine();
        }
    }

}

