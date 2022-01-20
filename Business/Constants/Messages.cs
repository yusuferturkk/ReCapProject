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
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarListed = "Araba listelendi";
        public static string CarNameInvalid = "Araba eklenemedi";
        public static string MaintenanceTime = "Sistem bakımda";
        internal static string RentalAdded = "Araç kiralandı";
        internal static string RentalError = "Araç kiralanamadı";
        internal static string BrandAdded = "Araç adı eklendi";
    }
}
