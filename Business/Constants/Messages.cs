using Core.Entities.Concrete;
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
        public static string ProductAdded = "Ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime = "Sistem bakım saatleri içerisindedir.";

        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategory = "Bir kategoride en fazla 10 ürün olabilir.";

        public static string ProductNameAlreadyExist = "Bu isimde bir ürün hali hazırda mevcuttur.";

        public static string CotegoryLimitExceeded = "Kategori limiti aşıldığı için yeni bir ürün eklenemiyor.";

        public static string AuthorizationDenied = "Authorization Denied";

        public static string UserRegistered = "Kullanıcı eklendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre yanlış";

        public static string SuccessfulLogin = "Successful Login";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
