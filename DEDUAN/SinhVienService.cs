using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEDUAN
{
    internal class SinhVienService
    {
        public List<SinhVien> DanhSachSinhVien { get; set; }

        public SinhVienService()
        {
            DanhSachSinhVien = new List<SinhVien>();
        }
        public void ThemSinhVien()
        {
            int TiepTuc = -1;
            do
            {
                Console.WriteLine("NHap ma sinh vien: ");
                string MaSinhVien = Console.ReadLine();
                Console.WriteLine("Nhap ten sinh vien la: ");
                string Ten = Console.ReadLine();
                Console.WriteLine("Moi nhap nam sinh: ");
                int NamSinh = int.Parse(Console.ReadLine());
                Console.WriteLine("Diem sinh vien la: ");
                double Diem = double.Parse(Console.ReadLine());
                SinhVien sinhVien = new SinhVien(MaSinhVien, Ten, NamSinh, Diem);
                this.DanhSachSinhVien.Add(sinhVien);

                Console.Write("Ban co muon tiep tuc khong (1-co/2-khong): ");
                TiepTuc = int.Parse(Console.ReadLine());
            } while (TiepTuc == 1);
        }
        public void XuatDanhSach()
        {
            foreach (SinhVien sinhVien in DanhSachSinhVien)
            {
                sinhVien.InThongTin();
            }
        }

        public void XuatDSSinhVien()
        {
            Console.WriteLine("Nhap diem sinh vien");
            double diem = double.Parse(Console.ReadLine());
            foreach (SinhVien sinhVien in DanhSachSinhVien)
            {
                if (sinhVien.GetDiem() == diem)
                {
                    if (diem >= 8)
                    {
                        Console.WriteLine("sinh vien duoc tang ve happy bee");
                    }
                    sinhVien.InThongTin();
                }
            }
        }
    }

    
}
