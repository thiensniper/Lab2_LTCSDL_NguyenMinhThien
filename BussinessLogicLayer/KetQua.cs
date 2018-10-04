using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class KetQua : DataController
    {
        public KetQua() : base("KETQUA") { }
        public KetQua(string chuoiSQL) : base("KETQUA", chuoiSQL) { }
    }
}
