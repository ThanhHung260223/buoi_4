using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_4
{
    internal class HinhTron : ToaDo
    {
        private double _BanKinh;
        ToaDo tam = new ToaDo();

        public double GetBanKinh()
        {
            return _BanKinh;
        }

        public ToaDo GetTam()
        {
            return tam; 
        }
       

        public void SetBanKinh() { }
        public void SetTam() { }
        public double tinhChuVi()
        {
            return _BanKinh*2*3.14;
        }
        public double tinhDienTich() 
        {
            return _BanKinh*_BanKinh * 3.14;
        }

        
        public HinhTron()
        {
            
        }
        public HinhTron(double bankinh, ToaDo tam)
        {
            this._BanKinh = bankinh;
            this.tam = tam;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ban kinh: ");
            _BanKinh = double.Parse(Console.ReadLine());
        }
        public void xuat ()
        {
            Console.WriteLine("Hinh tron tam O voi ban kinh {0}", _BanKinh);
            Console.WriteLine("Chu vi hinh tron la: {0}", tinhChuVi());
            Console.WriteLine("Dien tich hinh tron la: {0}", tinhDienTich());
        }
    }
}
