using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEDUAN
{
    internal class SinhVienUD:SinhVien
    {
        private int KiHoc { get; set; }
        public SinhVienUD()
        {
            
        }

        public SinhVienUD(int kiHoc, string Ma, string Ten, int NamSinh, double Diem): base (Ma, Ten, NamSinh, Diem) 
        {
            KiHoc = kiHoc;
        }
        public override void InThongTin()
        {
            base.InThongTin();
        }
    }
}
