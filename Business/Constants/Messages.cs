using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi.";
        public static string CarNameInvalid = "Araç adı geçersiz";

        public static string ColorAdded = "Yeni renk eklendi.";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk bilgisi güncellendi.";
        public static string ColorNameInvalid = "Renk adı geçersiz";

        public static string BrandAdded = "Yeni marka eklendi";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka bilgisi güncellendi.";
        public static string BrandNameInvalid = "Marka adı geçersiz";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
