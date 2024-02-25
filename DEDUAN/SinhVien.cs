using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEDUAN
{
    internal class SinhVien
    {
        private int kiHoc;

        private string MaSinhVien { get; set; }
        private string Ten {  get; set; }
        private int NamSinh { get; set; }
        private double Diem {  get; set; }
        public SinhVien()
        {
            
        }

        public SinhVien(string maSinhVien, string ten, int namSinh, double diem)
        {
            MaSinhVien = maSinhVien;
            Ten = ten;
            NamSinh = namSinh;
            Diem = diem;
        }

        public SinhVien(string maSinhVien, string ten, int namSinh, double diem, int kiHoc) : this(maSinhVien, ten, namSinh, diem)
        {
            this.kiHoc = kiHoc;
        }

        public  virtual void InThongTin()
        {
            Console.WriteLine($" Ma sinh vien la: {MaSinhVien}\t Ten la: {Ten}\t Nam sinh la: {NamSinh}\t Diem la: {Diem}");
        }
        public double  GetDiem()
        {
            return this.Diem;
        }
    }
}
