using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySystem
{
    /// <summary>
    /// Summary description for User
    /// </summary>

    public class User
    {
        #region Fields - Klassens indkapslede egenskaber
        private string usename;
        private string firstname;
        private string lastname;
        private int role;
        #endregion

        #region Constructors - Klassens konstruktør(er)
        public User()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion

        #region Properties - Klassens offentlige adgang til de indkapslede fields
        #endregion

        #region methods - Klassens offentlige metoder
        public static bool IsUser()
        {
            bool result = false;

            if (HttpContext.Current.Session["user"] != null)
            {
                result = true;
            }

            return result;
        }

        public static void CreateSession()
        {
            if (HttpContext.Current.Session["user"] == null)
            {
                HttpContext.Current.Session.Add("user", "noname");
            }

        }

        public static void RemoveSession()
        {
            if (HttpContext.Current.Session["user"] != null)
            {
                HttpContext.Current.Session.Remove("user");
            }

        }
        #endregion

    }
}