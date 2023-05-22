using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //Static:Surekli newlemememizi sagliyor.
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarAlreadyRented ="Araba zaten kiralandi";
        public static string CarDeleted = "Arac silindi.";
        public static string CarUpdated = "Arac guncellendi.";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted ="Marka silindi";
        public static string BrandUpdated ="Marka guncellendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorUpdated = "Renk guncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorsListed = "Renkler listelendi";
        public static string AuthorizationDenied="Yetkiniz yok.";
    }
}
