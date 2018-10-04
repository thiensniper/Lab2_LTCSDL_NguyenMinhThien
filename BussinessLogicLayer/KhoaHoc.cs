using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    class KhoaHoc : DataController
    {
        public KhoaHoc() : base("KHOAHOC") { }
        public KhoaHoc(string chuoiSQL) : base("KHOAHOC", chuoiSQL) { }
    }
}
