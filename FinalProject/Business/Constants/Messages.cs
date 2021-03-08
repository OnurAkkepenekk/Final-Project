using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductDeleted = "Ürün silindi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsListed = "Ürün listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoryde en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün vardır.";
        public static string CategoryLimitExceded = "Category sayısı aşımı yaşanmıştır yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        internal static string UserRegistered = "Kayıt başarılı.";
    }
}
