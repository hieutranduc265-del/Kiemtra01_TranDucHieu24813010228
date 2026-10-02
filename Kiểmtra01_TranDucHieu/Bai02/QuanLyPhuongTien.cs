using System;
using System.Collections.Generic;
using System.Linq;

namespace LogisticsAutoSpeed
{
    public class QuanLyPhuongTien
    {
        private List<PhuongTien> danhSach = new List<PhuongTien>();

        public void AddPhuongTien(PhuongTien pt)
        {
            danhSach.Add(pt);
        }

        public void DisplayAll()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách hiện tại đang trống!");
                return;
            }
            foreach (var pt in danhSach)
            {
                Console.WriteLine(pt.GetInfo());
            }
        }

        public PhuongTien FindMaxGiaLanBanh()
        {
            if (danhSach.Count == 0) return null;
            return danhSach.OrderByDescending(pt => pt.TinhGiaLanBanh()).FirstOrDefault();
        }
    }
}