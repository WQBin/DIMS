using DIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    public class DormitoryManagement
    {
        /// <summary>
        /// 设定宿舍人数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool SetDormitoryNum(int num)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Studentbuilding
                    .FromSql("select * from dims.Studentbuilding")
                    .ToList();
                foreach(var q in query)
                {
                    q.Bdsnum = num;
                }
                dbcontext.SaveChanges();
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 修改宿舍楼性别
        /// </summary>
        /// <param name="sex"></param>
        /// <returns></returns>
        public bool SetDormitorySex(string sex)
        {
            #region
            using (var dbcontext = new dimsContext())
            {
                var query = dbcontext.Studentbuilding
                    .FromSql("select * from dims.Studentbuilding")
                    .ToList();
                foreach (var q in query)
                {
                    q.Bsex = sex;
                }
                dbcontext.SaveChanges();
                return true;
            }
            #endregion
        }
    }
}
