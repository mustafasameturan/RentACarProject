using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddedMessage = "Entity Added!";
        public static string DeletedMessage = "Entity Deleted!";
        public static string UpdatedMessage = "Entity Updated!";
        public static string EntityNameInvalid = "Entity Name Invalid!";
        public static string MaintenanceTime = "System In The Maintenance!";
        public static string EntitiesListed = "Entities Listed!";
        public static string ErrorMessage = "The data you have entered does not comply with the rules. Please try again!";
        public static string RentalAddedErrorMessage = "Please return the car you picked up before submitting a rental car request.";
        public static string RentalAddedMessage = "Car is successfuly rentaled!";
        public static string FailAddedImageLimit = "Image limit is full!";
        public static string CarModelAlreadyExist = "Car model is already exist!";
        public static string AuthorizationDenied = "Authoraziton denied!";
        public static string UserRegistered = "User is registered in the system!";
        public static string UserNotFound = "User is not found in the system!";
        public static string PasswordError = "The password is uncorrect!";
        public static string SuccessfulLogin = "User is successfully login!";
        public static string UserAlreadyExists = "User is already exist in the system!";
        public static string AccessTokenCreated = "Access Token Created!";
    }
}
