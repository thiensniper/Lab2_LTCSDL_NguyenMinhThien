using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class ChuongTrinh : DataController
    {
        public ChuongTrinh() : base("CHUONGTRINH") { }
        public ChuongTrinh(string chuoiSQL) : base("CHUONGTRINH", chuoiSQL) { }
    }
}
