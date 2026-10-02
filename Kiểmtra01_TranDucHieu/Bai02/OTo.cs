using System;

namespace LogisticsAutoSpeed
{
    public class OTo : PhuongTien
    {
        public int SoChongoi { get; set; }
        public double DungTichDongCo { get; set; }

        public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChongoi, double dungTichDongCo)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            if (soChongoi <= 0) throw new ArgumentException("Số chỗ ngồi phải > 0!");
            if (dungTichDongCo <= 0) throw new ArgumentException("Dung tích động cơ phải > 0!");

            SoChongoi = soChongoi;
            DungTichDongCo = dungTichDongCo;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (SoChongoi <= 9)
            {
                return GiaGoc + (GiaGoc * 0.12m) + (GiaGoc * 0.30m);
            }
            else
            {
                return GiaGoc + (GiaGoc * 0.10m);
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Loại: Ô tô ({SoChongoi} chỗ, {DungTichDongCo}L) | Giá lăn bánh: {TinhGiaLanBanh():N0} VNĐ";
        }
    }
}