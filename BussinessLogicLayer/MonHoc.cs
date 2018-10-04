using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class MonHoc : DataController
    {
        public MonHoc() : base("MONHOC") { }
        public MonHoc(string chuoiSQL) : base("MONHOC", chuoiSQL) { }
    }
}
