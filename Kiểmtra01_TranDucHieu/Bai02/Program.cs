using System;

namespace LogisticsAutoSpeed
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            QuanLyPhuongTien ql = new QuanLyPhuongTien();

            while (true)
            {
                Console.WriteLine("\n================ QUẢN LÝ PHƯƠNG TIỆN ================");
                Console.WriteLine("1. Nhập Ô tô mới");
                Console.WriteLine("2. Nhập Xe máy mới");
                Console.WriteLine("3. Hiển thị danh sách phương tiện");
                Console.WriteLine("4. Tìm phương tiện có Giá Lăn Bánh cao nhất");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("=====================================================");
                Console.Write("Mời bạn chọn chức năng (0-4): ");

                string chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine("--- NHẬP THÔNG TIN Ô TÔ ---");
                        try
                        {
                            Console.Write("Mã phương tiện: ");
                            string maOto = Console.ReadLine();

                            Console.Write("Hãng xe: ");
                            string hangOto = Console.ReadLine();

                            Console.Write("Năm sản xuất (Thử nhập 1850 để test lỗi Validation): ");
                            int namOto = int.Parse(Console.ReadLine());

                            Console.Write("Giá gốc (VNĐ): ");
                            decimal giaOto = decimal.Parse(Console.ReadLine());

                            Console.Write("Số chỗ ngồi: ");
                            int soCho = int.Parse(Console.ReadLine());

                            Console.Write("Dung tích động cơ (L): ");
                            double dungTich = double.Parse(Console.ReadLine());

                            OTo oto = new OTo(maOto, hangOto, namOto, giaOto, soCho, dungTich);
                            ql.AddPhuongTien(oto);

                            Console.WriteLine("\n-> Thêm Ô tô thành công!");
                            Console.WriteLine($"-> Giá lăn bánh: {oto.TinhGiaLanBanh():N0} VNĐ");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("-> LỖI: Dữ liệu nhập vào phải là số!");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("-> LỖI BẮT ĐƯỢC: " + ex.Message);
                        }
                        break;

                    case "2":
                        Console.WriteLine("--- NHẬP THÔNG TIN XE MÁY ---");
                        try
                        {
                            Console.Write("Mã phương tiện: ");
                            string maXeMay = Console.ReadLine();

                            Console.Write("Hãng xe: ");
                            string hangXeMay = Console.ReadLine();

                            Console.Write("Năm sản xuất: ");
                            int namXeMay = int.Parse(Console.ReadLine());

                            Console.Write("Giá gốc (VNĐ): ");
                            decimal giaXeMay = decimal.Parse(Console.ReadLine());

                            Console.Write("Dung tích Xylanh (cc): ");
                            int dungTichXylanh = int.Parse(Console.ReadLine());

                            XeMay xemay = new XeMay(maXeMay, hangXeMay, namXeMay, giaXeMay, dungTichXylanh);
                            ql.AddPhuongTien(xemay);

                            Console.WriteLine("\n-> Thêm Xe máy thành công!");
                            Console.WriteLine($"-> Giá lăn bánh: {xemay.TinhGiaLanBanh():N0} VNĐ");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("-> LỖI: Dữ liệu nhập vào phải là số!");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("-> LỖI BẮT ĐƯỢC: " + ex.Message);
                        }
                        break;

                    case "3":
                        Console.WriteLine("--- DANH SÁCH PHƯƠNG TIỆN ---");
                        ql.DisplayAll();
                        break;

                    case "4":
                        Console.WriteLine("--- PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT ---");
                        PhuongTien maxPt = ql.FindMaxGiaLanBanh();
                        if (maxPt != null)
                        {
                            Console.WriteLine("-> " + maxPt.GetInfo());
                        }
                        else
                        {
                            Console.WriteLine("Chưa có phương tiện nào trong danh sách!");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Đã thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                        break;
                }
            }
        }
    }
}