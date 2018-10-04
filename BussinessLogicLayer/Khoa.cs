using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    class Khoa : DataController
    {
        public Khoa() : base("KHOA") { }
        public Khoa(string chuoiSQL) : base("KHOA", chuoiSQL) { }
    }
}
