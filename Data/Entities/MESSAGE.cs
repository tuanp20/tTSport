using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class MESSAGE
    {
        public string ID { get; set; }
        public string SUBJECT { get; set; }
        public string MESSAGE_BODY { get; set; }
        public List<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public string CREATE_BY { get; set; }
        public DateTime CREATE_DAY { get; set; }
        public string MODIFY { get; set; }
        public DateTime LASTUPDATE { get; set; }
    }
}
