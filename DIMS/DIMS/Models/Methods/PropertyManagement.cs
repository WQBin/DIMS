using DIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    public class PropertyManagement
    {
        /// <summary>
        /// 添加财产
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool AddProperty(Property property)
        {
            #region
            using(var db=new dimsContext())
            {
                db.Add(property);
                db.SaveChanges();
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 删除财物
        /// </summary>
        /// <param name="pno"></param>
        /// <returns></returns>
        public bool DeletePropery(int pno)
        {
            #region
            using(var db=new dimsContext())
            {
                var query = db.Property
                    .FirstOrDefault(r => r.Pno == pno);
                db.Remove(query);
                db.SaveChanges();
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 获取财产信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public Property GetProperty(int no)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Property
                    .FirstOrDefault(p => p.Pno == no);
                return query;
            }
            #endregion
        }
    }
}
