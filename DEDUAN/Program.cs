using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEDUAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
       static void Menu()
        {
            int LuaChon;
          SinhVienService sinhVienService = new SinhVienService();
            do
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("1. Nhap 1 ds doi tuong");
                Console.WriteLine("2. Xuat ds doi tuong");
                Console.WriteLine("3. Xuat ds cac sv dc tang ve happy bee");
                Console.WriteLine("4. Xoa nhung sv ko dc tham gia neu k dc tang (tuoi>25)");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Moi ban lua chon chuc nang");
                Console.WriteLine("-------------------------------------------------------");
                LuaChon= int.Parse(Console.ReadLine());
                switch (LuaChon)
                {
                    case 1:
                        sinhVienService.ThemSinhVien();
                        break;
                    case 2:

                        sinhVienService.XuatDanhSach();
                        break;
                    case 3:
                        sinhVienService.XuatDSSinhVien();
                        break;
                    case 4:
                        ChucNang5();
                        break;
                }
            }while(LuaChon!=0);
        }

//5, Bổ sung vào menu chức năng tên 5.Kế thừa, khi chọn chức năng 5 yêu cầu
//nhập 1 đối tượng lớp SinhVienUD có giá trị ban đầu bằng Constructor có tham
//số sau đó in thông tin đối tượng đó ra màn hình bằng phương thức
//InThongTin(): void (1đ)
      static void ChucNang5()
        {
           

            Console.WriteLine("NHap ma sinh vien: ");
            string MaSinhVien = Console.ReadLine();
            Console.WriteLine("Nhap ten sinh vien la: ");
            string Ten = Console.ReadLine();
            Console.WriteLine("Moi nhap nam sinh: ");
            int NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem sinh vien la: ");
            double Diem = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ki hoc ");
            int KiHoc = int.Parse(Console.ReadLine());
            SinhVien sinhVien = new SinhVien(MaSinhVien, Ten, NamSinh, Diem, KiHoc);
            sinhVien.InThongTin();


        }
    }
}
