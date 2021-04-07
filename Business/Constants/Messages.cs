using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Eklendi.";
   
        public static string Listed = "Listelendi.";

        public static string Deleted = "Silindi";

        public static string Updated = "Güncellendi.";
        public static string CarImageLimitExceeded="Resim Limiti Aşıldı.";
        public static string CarCheckImageLimited;
        public static string CarImageDeleted;
        public static string CarImageAdded="Eklendi";
        public static string Yes="evet";
        //internal static string ImageLimitExceeded;
        //internal static string CarImageUpdated;
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı girildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string CarImageUpdated = "Resim güncellendi";
        public static string ImageLimitExceeded = "Resim yükleme limiti aşıldı.";
    }

}
