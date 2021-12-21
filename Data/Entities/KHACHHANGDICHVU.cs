using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class KHACHHANGDICHVU
    {
        public string ID { get; set; }
        public DMLOAIBAIVIET DMLOAIBAIVIET { get; set; }
        public DMKHACHHANG DMKHACHHANG { get; set; }
        public string CREATE_BY { get; set; }
        public string CREATE_DAY { get; set; }
        public string MODIFY { get; set; }
        public string LASTUPDATE { get; set; }
    }
}
