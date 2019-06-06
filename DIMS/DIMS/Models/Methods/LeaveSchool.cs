using DIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    /// <summary>
    /// 离校信息填写
    /// </summary>
    public class LeaveSchool
    {
        public bool RegistLeave(Livingschool livingschool)
        {
            #region
            using(var db=new dimsContext())
            {
                livingschool.Llivingdate = DateTime.Now;
                db.Livingschool.Add(livingschool);
                db.SaveChanges();
                return true;

            }
            #endregion
        }
        /// <summary>
        /// 查找并登记返校时间
        /// </summary>
        /// <param name="sno"></param>
        /// <param name="lno"></param>
        /// <returns></returns>
        public bool RegistReturn(string sno,int lno)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Latereturn
                    .FirstOrDefault(l => l.Sno == sno && l.Lno == lno);
                query.Lreturntime= DateTime.Now;
                dbcontext.SaveChanges();
                return true;
            }
            #endregion
        }
    }
}
