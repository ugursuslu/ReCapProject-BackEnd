using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string UsersListed = "Araçlar listelendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUptated = "Müşteri güncellendi";
        public static string RentalAdded = "Araç eklendi";
        public static string RentalUpdated = "Araç Güncellendi";
        public static string RentalDeleted = "Araç silindi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string CarCountOfBrandError = "Aynı üründen 10'dan fazla eklenemez";
        public static string CheckIfCarNameExists = "Aynı isimle araç eklenemez";
        public static string BrandLimitExceded = "Marka limiti aşıldığı için yeni araç eklenemiyor";
        public static string BrandsListed = "Marka listesi";
        public static string CarImageAdded = "Araç resimi eklendi";
        public static string NotCarImageAdded = "Araç resimi eklenemedi";
        public static string CapacityFulled = "Araç resimi 5'den fazla olamaz";
        public static string CarImageDeleted = "Araç resimi silindi";
        public static string CarImageListed = "Araç resimi güncellendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string PasswordError = "Şifre Hatalı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kayıt oldu";
    }
}
