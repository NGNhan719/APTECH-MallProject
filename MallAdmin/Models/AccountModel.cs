using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MumbaiMallLibrary;
using System.Data.SqlClient;

namespace MallAdmin.Models
{
    public class AccountModel
    {
        private malldbEntities context = null;
        public AccountModel()
        {
            context = new malldbEntities();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password),
            };
            var res = context.Database.SqlQuery<bool>("@Sp_Account_Login @UserName, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}