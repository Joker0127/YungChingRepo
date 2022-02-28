using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteSupport.SupportDB
{
    public partial class SupportDB
    {
        //Customers
        public const string table_Customers = "Customers";

        public const string CustomerID = "CustomerID";
        public const string CompanyName = "CompanyName";
        public const string ContactName = "ContactName";
        public const string ContactTitle = "ContactTitle";
        public const string Address = "Address";
        public const string City = "City";
        public const string Region = "Region";
        public const string PostalCode = "PostalCode";
        public const string Country = "Country";
        public const string Phone = "Phone";
        public const string Fax = "Fax";

        //Employees
        public const string table_Employees = "Employees";
        public const string EmployeeID = "EmployeeID";
        public const string LastName = "LastName";
        public const string FirstName = "FirstName";
        public const string Title = "Title";
        public const string TitleOfCourtesy = "TitleOfCourtesy";
        public const string BirthDate = "BirthDate";
        public const string HireDate = "HireDate";
        //public const string Address = "Address";
        //public const string City = "City";
        //public const string Region = "Region";
        //public const string PostalCode = "PostalCode";
        //public const string Country = "Country";
        public const string HomePhone = "HomePhone";
        public const string Extension = "Extension";
        public const string Photo = "Photo";
        public const string Notes = "Notes";
        public const string ReportsTo = "ReportsTo";
        public const string PhotoPath = "PhotoPath";

        //Order
        public const string table_Order = "Order";
        public const string OrderID = "OrderID";
        //public const string CustomerID = "CustomerID";
        //public const string EmployeeID = "EmployeeID";
        public const string OrderDate = "OrderDate";
        public const string RequiredDate = "RequiredDate";
        public const string ShippedDate = "ShippedDate";
        public const string ShipVia = "ShipVia";
        public const string Freight = "Freight";
        public const string ShipName = "ShipName";
        public const string ShipAddress = "ShipAddress";
        public const string ShipCity = "ShipCity";
        public const string ShipRegion = "ShipRegion";
        public const string ShipPostalCode = "ShipPostalCode";
        public const string ShipCountry = "ShipCountry";

        //Products
        public const string table_Products = "Products";
        public const string ProductID = "ProductID";
        public const string ProductName = "ProductName";
        public const string SupplierID = "SupplierID";
        public const string CategoryID = "CategoryID";
        public const string QuantityPerUnit = "QuantityPerUnit";
        public const string UnitPrice = "UnitPrice";
        public const string UnitsInStock = "UnitsInStock";
        public const string UnitsOnOrder = "UnitsOnOrder";
        public const string ReorderLevel = "ReorderLevel";
        public const string Discontinued = "Discontinued";
    }
}
