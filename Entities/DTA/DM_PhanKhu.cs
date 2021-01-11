using System;

namespace VNG.Business.Entities.DTA
{
    /// <summary>
    /// 
    /// </summary>
    public class DM_PhanKhu
    {
        public int ID { get; set; }
        public string MaPhanLoai { get; set; }
        public string MaChungLoai { get; set; }
        public string NhomGia { get; set; }
        public string Khu { get; set; }
        public string IsActive { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
