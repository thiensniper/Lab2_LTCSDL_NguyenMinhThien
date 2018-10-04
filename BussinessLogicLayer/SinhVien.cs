using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class SinhVien : DataController
    {
        public SinhVien() : base("SINHVIEN") { }
        public SinhVien(string chuoiSQL) : base("SINHVIEN", chuoiSQL) { }
    }
}
