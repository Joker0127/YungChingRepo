using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteSupport.SupportDB
{
    public partial class SupportDB
    {
        DBManager.DBManager manager = new DBManager.DBManager();
        public List<Model.Customers> Customers_Get()
        {
            DataTable dt = manager.DB_GetDatatable(table_Customers, string.Empty);
            List<Model.Customers> list = new List<Model.Customers>();
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    Model.Customers customers = new Model.Customers();
                    customers.Address = row[Address].ToString();
                    customers.City = row[City].ToString();
                    customers.CompanyName = row[CompanyName].ToString();
                    customers.ContactName = row[ContactName].ToString();
                    customers.ContactTitle = row[ContactTitle].ToString();
                    customers.Country = row[Country].ToString();
                    customers.CustomerID = row[CustomerID].ToString();
                    customers.Fax = row[Fax].ToString();
                    customers.Phone = row[Phone].ToString();
                    customers.PostalCode = row[PostalCode].ToString();
                    customers.Region = row[Region].ToString();
                    list.Add(customers);
                }
            }
            return list;
        }
    }
}
