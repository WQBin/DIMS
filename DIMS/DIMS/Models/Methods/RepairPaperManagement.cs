using DIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    public class RepairPaperManagement
    {
        /// <summary>
        /// 增加保修单
        /// </summary>
        /// <param name="repairPaper"></param>
        /// <returns></returns>
        public bool AdddRepairPaper(Repairpaper repairPaper)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                dbcontext.Add(repairPaper);
                dbcontext.SaveChanges();
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 获取宿舍的所有保修单
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public List<Repairpaper> GetRepairpaperDetail(string department)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Repairpaper
                    .FromSql("select * from dims.Repairpaper")
                    .Where(r => r.Bno == department)
                    .ToList();
                return query;
            }
            #endregion
        }
    }
}
