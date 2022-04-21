using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added.";
        public static string ProductNameInvalid = "Product's name is invalid.";
        public static string MaintenanceTime = "System is under maintenance.";
        public static string ProductListed = "Products listed.";
        public static string ProductCountOfCategoryError = "Category can not hold any more products.";
        public static string ProductNameAlreadyExists = "Another item already exists with the same product name.";
        public static string CategoriesListed = "Categories listed.";
        public static string CategoryCountLimitExceeded = "Category count limit exceeded.";
    }
}
