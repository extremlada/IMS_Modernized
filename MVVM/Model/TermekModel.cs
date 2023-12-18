using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Modernized.MVVM.Model
{
    internal class TermekModel
    {
        public int TermekId { get; set; }
        public string Termeknev { get; set; }
        public int TermekDarabszam { get; set; }
        public string BevetEladas { get; set; }
        public DateTime Datum { get; set; }
    }
}
