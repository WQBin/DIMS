using DIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    public class AdminAccount
    {
        /// <summary>
        //管理员登录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string id,string password)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                foreach(var admin in dbcontext.Administer)
                {
                    if(admin.Ano==id&&admin.Apassword==password)
                    {
                        return true;
                    }
                }
            }
            #endregion
            return false;
        }

        public bool NewPassword(string id,string oldPassword,string newPassword)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var admin = dbcontext.Administer
                    .FirstOrDefault(a => a.Ano == id && a.Apassword == oldPassword);
                if(admin!=null)
                {
                    admin.Apassword = newPassword;
                    dbcontext.SaveChanges();
                    return true;
                }
                return false;
            }
            #endregion
           
        }

    }
}
