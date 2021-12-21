using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class DMLOAIDICHVU
    {
        public string ID { get; set; }
        public string TENDICHVU { get; set; }
        public string CREATE_BY { get; set; }
        public string CREATE_DAY { get; set; }
        public string MODIFY { get; set; }
        public string LASTUPDATE { get; set; }
        public List<KHACHHANGDICHVU> KHACHHANGDICHVUs { get; set; }
    }
}
