using DIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    public class LastManagement
    {
        /// <summary>
        /// 查询所有的晚归信息
        /// </summary>
        /// <returns></returns>
        public List<Latereturn> GetAllLaterReturn()
        {
            #region
            using(var db=new dimsContext())
            {
                var query = db.Latereturn
                    .FromSql("select * from dims.Latereturn")
                    .ToList();
                return query;

            }
            #endregion
        }
        /// <summary>
        /// 删除晚归信息
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool DeleteLateReturn(int i)
        {
            #region
            using(var db=new dimsContext())
            {
                var query = db.Latereturn
                    .FirstOrDefault(l => l.Lno == i);
                db.Remove(query);
                db.SaveChanges();
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 获取学生晚归信息
        /// </summary>
        /// <param name="lno"></param>
        /// <param name="sno"></param>
        /// <returns></returns>
        public Latereturn GetLatereturnDetail(int lno,string sno)
        {
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Latereturn
                    .FirstOrDefault(l => l.Lno == lno && l.Sno == sno);
                return query;
            }
        }
    }
}
