using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Quanlybanhang
{
    public class SanPham
    {
        private string maSP;
        private int sl;

        public string MaSP { get => maSP; set => maSP = value; }
        public int Sl { get => sl; set => sl = value; }

        public SanPham(string _masp,int _sl)
        {
            this.maSP = _masp;
            this.sl = _sl;
        }
        public string xemsp()
        {
            return MaSP + sl;
        }
    }
}
