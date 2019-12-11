using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class Customer
    {  private string ConnectionString;

        public Customer(string _conStr)
        {
            ConnectionString = _conStr;
        }
        public DataTable List_User()
        {

            var dt = new DbAccess(ConnectionString).FillDataTable("SELECT [Email],[UserName] FROM [dbo].[AspNetUsers]");
            return dt;

        }
    }
}