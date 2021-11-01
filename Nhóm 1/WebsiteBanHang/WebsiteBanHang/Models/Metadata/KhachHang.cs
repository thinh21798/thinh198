using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebsiteBanHang.Models
{
    [MetadataTypeAttribute(typeof(KhachhangMetadata))]
    public partial class Khachhang
    {
        internal sealed class KhachhangMetadata
        {
            public int MaKH { get; set; }
            [DisplayName("Tên Khách hàng")]
            [StringLength(100, ErrorMessage = "Tên người dùng không quá 100 kí tự.")]
            [Required(ErrorMessage = "Hãy nhập {0}.")]
            public string TenKH { get; set; }
            [DisplayName("Địa chỉ")]
            [StringLength(200, ErrorMessage = "Địa chỉ không quá 200 kí tự.")]
            [Required(ErrorMessage = "Hãy nhập {0}.")]
            public string DiaChi { get; set; }
            [DisplayName("Email")]
            [Required(ErrorMessage = " Hãy nhập địa chỉ {0}.")]
            [StringLength(200, ErrorMessage = "Email không quá 200 kí tự.")]
            [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "{0} không hợp lệ.")]
            public string Email { get; set; }
            [DisplayName("Số điện thoại")]
            [Required(ErrorMessage = "Hãy nhập {0}.")]
            [StringLength(10, ErrorMessage = "{0} không hợp lệ.")]
            [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                  ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
            public string SoDienThoai { get; set; }
        }
    }
}