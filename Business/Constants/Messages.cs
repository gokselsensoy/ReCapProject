using Core.Entities.Concrete;
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
        public static string CarAdded = "Car Added";
        public static string CarDeleted = "Car Deleted";
        public static string CarUpdated = "Car Updated";
        public static string CarNameInvalid = "Invalid Car Name";

        public static string ColorAdded = "Color Added";
        public static string ColorDeleted = "Color Deleted";
        public static string ColorUpdated = "Color Info Updated";
        public static string ColorNameInvalid = "Invalid Color Name";

        public static string BrandAdded = "Brand Added";
        public static string BrandDeleted = "Brand Deleted";
        public static string BrandUpdated = "Brand Info Updated";
        public static string BrandNameInvalid = "Invalid Brand Name";

        public static string AuthorizationDenied = "You are not authorized";
        public static string TokenCreated = "Token Created";

        public static string UserNotFound = "User not found";
        public static string UserExists = "User already exists";
        public static string LoginSuccess = "Login Success";
        public static string Registered = "Registered";
        public static string PasswordError = "Wrong password";




    }
}
