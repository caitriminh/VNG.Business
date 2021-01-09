﻿using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_Size
    {
        public int ID { get; set; }
        public string Size { get; set; }
        public bool? SuDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
