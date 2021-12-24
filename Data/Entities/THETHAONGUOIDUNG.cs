using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class THETHAONGUOIDUNG
    {
        public string ID { get; set; }
        public NGUOIDUNG NGUOIDUNG { get; set; }
        public MONTHETHAO MONTHETHAO { get; set; }
        public int PRESTIGE_POINTS { get; set; }
        public string CREATE_BY { get; set; }
        public DateTime CREATE_DAY { get; set; }
        public string MODIFY { get; set; }
        public DateTime LASTUPDATE { get; set; }
    }
}
