using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class TAOGIAI
    {
        public string ID { get; set; }
        public string TENGIAI { get; set; }
        public int SOLUONGGIAI { get; set; }
        public string LOAIGIAI { get; set; }
        public DateTime THOIGIAN { get; set; }
        public string DIADIEM { get; set; }
        public string CREATE_BY { get; set; }
        public DateTime CREATE_DAY { get; set; }
        public string MODIFY { get; set; }
        public DateTime LASTUPDATE { get; set; }
    }
}
