using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class DMKHACHHANG
    {
        public string ID { get; set; }
        public string TENKHACH { get; set; }
        public string CREATE_BY { get; set; }
        public string CREATE_DAY { get; set; }
        public string MODIFY { get; set; }
        public string LASTUPDATE { get; set; }
        public List<KHACHHANGDICHVU> KHACHHANGDICHVUs { get; set; }
        public DMBAIVIET DMBAIVIET { get; set; }
    }
}
