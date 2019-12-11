using DataAccess;
using Microsoft.AspNet.Identity;
using POS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;

namespace POS.Models
{

    public static class CommonData
    {


        public static string ConStr()
        {
            var conS = "";
            try
            {
                conS = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
            catch (Exception e)
            {
                var tt = e;
                // ErrorHandler.Log("Common- getConStr", e.Message, e.Source);
#if DEBUG
                throw;
#endif
            }
            return conS;
        }


        //public static int GetCurrentUserLocaID()
        //{
        //    var manager = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
        //    var currUser = manager.FindById(HttpContext.Current.User.Identity.GetUserId());
        //    if (currUser != null)
        //    {
        //        return currUser;
        //    }
        //    return 0;
        //}

        //public static int GetBranchCode()
        //{
        //    var manager = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
        //    var currUser = manager.FindById(HttpContext.Current.User.Identity.GetUserId());
        //    if (currUser != null)
        //    {
        //        return currUser.BranchCode;
        //    }
        //    return 0;
        //}


        //public static DataTable LoadBanks()
        //{
        //    return new DbAccess(ConStr()).FillDataTable("SELECT  [BankID] i,[BankName] n  FROM [dbo].[Com_Banks]");
        //}

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }



    }



    public class Common2
    {
        public T ConvertDictionaryTo<T>(IDictionary<string, object> dictionary) where T : new()
        {
            Type type = typeof(T);
            T ret = new T();

            foreach (var keyValue in dictionary)
            {
                if (!keyValue.Value.GetType().Equals(typeof(DBNull)))
                {
                    type.GetProperty(keyValue.Key).SetValue(ret, keyValue.Value, null);
                };



            }

            return ret;
        }
    }

}