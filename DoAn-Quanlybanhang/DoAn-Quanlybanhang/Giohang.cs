using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Quanlybanhang
{
    class Giohang
    {
        private SanPham[] arr;
        private int maVoucher;
        internal SanPham[] Arr { get => arr; set => arr = value; }
        public int MaVoucher { get => maVoucher; set => maVoucher = value; }

        public Giohang()
        {
            this.arr = new SanPham[0];
            this.MaVoucher = 0;
        }
        public void themsp(SanPham sp)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (string.Compare(arr[i].MaSP.Trim().ToLower(), sp.MaSP.Trim().ToLower()) == 0)
                {
                    suasl(sp);
                    return;
                }
            }

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = sp;

        }
        public void them(SanPham sp)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = sp;
        }
        public void xoasp(string masp)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (string.Compare(arr[i].MaSP, masp) == 0)
                {
                    if (i == arr.Length - 1)
                    {
                        Array.Resize(ref arr, arr.Length - 1);
                        return;
                    }
                    else
                    {
                        for (int j = i; j < arr.Length; j++)
                        {
                            arr[j] = arr[j + 1];
                        }
                        Array.Resize(ref arr, arr.Length - 1);
                        return;
                    }
                }
            }
        }
        public void suatt(SanPham newsp)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (string.Compare(arr[i].MaSP, newsp.MaSP) == 0)
                {
                    arr[i].Sl = newsp.Sl;
                    break;
                }
            }
        }
        public string xemgio()
        {
            string x = maVoucher.ToString();
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i].xemsp() + "\n";
            }
            return x;
        }
        public void suasl(SanPham sp)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (string.Compare(arr[i].MaSP, sp.MaSP) == 0)
                {
                    arr[i].Sl += sp.Sl;
                    return;
                }
            }
        }
    }
}
