using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class NGUOIDUNG
    {
        public string ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public int SEX { get; set; }
        public string DOB { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public List<THETHAONGUOIDUNG> THETHAONGUOIDUNGs { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string CREATE_BY { get; set; }
        public string CREATE_DAY { get; set; }
        public string MODIFY { get; set; }
        public string LASTUPDATE { get; set; }
    }
}
