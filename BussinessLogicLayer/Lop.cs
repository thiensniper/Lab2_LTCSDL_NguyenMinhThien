using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    class Lop : DataController
    {
        public Lop() : base("LOP") { }
        public Lop(string chuoiSQL) : base("LOP", chuoiSQL) { }
    }
}
