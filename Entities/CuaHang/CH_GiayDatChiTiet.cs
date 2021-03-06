﻿using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_GiayDatChiTiet
    {
        public int? ID { get; set; }
        public string HoaDonDatHang { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public int? SoLuong { get; set; }
        public string GhiChu { get; set; }
        public decimal? Gia { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
        ///////////////////////////////
        public string CuaHang { get; set; }
        public string DiaChiCuaHang { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public DateTime? NgayYeuCauGiao { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
        public string Label_KieuSize { get; set; }
        public decimal? Gia2 { get; set; } //Giá / 1000 dùng in phiếu
        public decimal? ThanhTien { get; set; }
        public decimal? ThanhTien2 { get; set; } //Thành tiền / 1000 dùng in phiếu
        public decimal? TienKhachDua { get; set; }
        public decimal? SoTienThua { get; set; }

    }
}
