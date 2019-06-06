using DIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    public class FastMailManagement
    {
        /// <summary>
        /// 查看所有快件
        /// </summary>
        /// <returns></returns>
        public List<Fastmail> GetAllFastMail()
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Fastmail
                    .FromSql("select * from dims.Fastmail")
                    .ToList();
                return query;
            }
            #endregion
        }
        /// <summary>
        /// 通过快件号查询快件
        /// </summary>
        /// <param name="fno"></param>
        /// <returns></returns>
        public Fastmail GetOneFastmail(int fno)
        {
            #region
            using (var dbcontext = new dimsContext())
            {
                var query = dbcontext.Fastmail
                    .FirstOrDefault(f => f.Fno == fno);
                return query;
            }
            #endregion
        }
        /// <summary>
        /// 添加快件
        /// </summary>
        /// <param name="fastmail"></param>
        /// <returns></returns>
        public bool AddFastMail(Fastmail fastmail)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                dbcontext.Fastmail.Add(fastmail);
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 通过学号查询快件
        /// </summary>
        /// <param name="sno"></param>
        /// <returns></returns>
        public List<Fastmail> GetFastmailsThoughSno(string sno)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Fastmail
                    .FromSql("select * from dims.Fastmail")
                    .Where(f => f.Sno == sno)
                    .ToList();
                return query;       
            }
            #endregion
        }
        /// <summary>
        /// 签收快递
        /// </summary>
        /// <param name="sno"></param>
        /// <param name="fno"></param>
        /// <returns></returns>
        public bool SignFastMail(string sno,int fno)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Fastmail
                    .FirstOrDefault(f => f.Fno == fno && f.Sno == sno);
                if (query != null)
                {
                    query.Fstate = "已签收";
                    dbcontext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            #endregion
        }
    }
}
