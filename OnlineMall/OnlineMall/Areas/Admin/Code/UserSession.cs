using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMall.Areas.Admin.Code
{
    [Serializable]
    public class UserSession
    {
        public string UserName { set; get; }
    }
}