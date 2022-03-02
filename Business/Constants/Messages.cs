using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public static string RentalAdded = "Araç kiralandı";
        public static string RentalError = "Araç kiralanamadı";
        public static string BrandAdded = "Araç adı eklendi";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Şifre hatalı!";
        public static string SuccessfulLogin = "Sisteme giriş başarılı!";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok!";
    }
}
