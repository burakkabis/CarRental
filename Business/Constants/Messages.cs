﻿using System;
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
        public static string CarAdded = "Car added";     
        public static string CarDeleted = "Car deleted.";
        public static string CarUpdated = "Car updated.";
        public static string CarsListed = "Cars listed";
        public static string CarNameInvalid = "Car name is invalid";
        public static string CarIsAlreadyRented = "Car is already rented";

        public static string CarImageAdded = "Car Image added";
        public static string CarImageDeleted = "Car Image deleted.";
        public static string CarImageUpdated = "Car Image updated.";
        public static string CarImagesListed = "CarImages listed";
        public static string CarImageNotFound = "Car Image not Found.";




        public static string BrandAdded = "Brand listed";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandUpdated = "Brand updated";
        public static string BrandsListed = "Brands listed";


        public static string ColorUpdated = "Color updated";
        public static string ColorDeleted = "Color deleted";
        public static string ColorAdded = "Color listed.";
        public static string ColorsListed = "Colors listed";

        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";
        public static string UserAdded = "User listed.";
        public static string UsersListed = "Users listed";


        public static string RentalUpdated = "Rental updated";
        public static string RentalDeleted = "Rental deleted";
        public static string RentalAdded = "Rental added";
        public static string RentalsListed = "Rentals listed";
        public static string RentalDetailsListed = "Rental Details listed";



        public static string CreditCardUpdated = "CreditCard updated";
        public static string CreditCardlDeleted = "CreditCard deleted";
        public static string CreditCardAdded = "CreditCard added";
        public static string CustomersCardsListed = "The customer's credit cards have been listed.";

        public static string PaymentAdded = "Payment added.";








        public static string AuthorizationDenied= "Authorization denied.";

        public static string MaintenanceTime = "The system is in maintenance.";
    }
}
