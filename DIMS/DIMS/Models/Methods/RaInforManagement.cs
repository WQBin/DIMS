using DIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    /// <summary>
    /// 宿管信息管理
    /// </summary>
    public class RaInforManagement
    {
        /// <summary>
        /// 增加宿管
        /// </summary>
        /// <param name="ra">代表宿管</param>
        /// <returns>成功返回true</returns>
        public bool AddRa(Administer ra)
        {
            #region
            try
            {
                using (var dbcontext = new dimsContext())
                {
                    dbcontext.Administer.Add(ra);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            #endregion
        }
        /// <summary>
        /// 删除一个宿管
        /// </summary>
        /// <param name="id">宿管id</param>
        /// <returns></returns>
        public bool DeleteRa(string id)
        {//有问题
            #region
            try
            {
                using (var dbcontext = new dimsContext())
                {
                    var ra = dbcontext.Administer
                        .FirstOrDefault(r => r.Ano == id);
                    dbcontext.Administer.Remove(ra);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            #endregion
        }
        /// <summary>
        //更改宿管信息
        /// </summary>
        /// <param name="id">宿管id</param>
        /// <param name="ra">宿管对象</param>
        /// <returns>成功返回true</returns>
        public bool ModifyRa(string id, Administer ra)
        {
            #region
            using (var dbcontext = new dimsContext())
            {
                var admin = dbcontext.Administer
                    .Single(r => r.Ano == id);
                if (admin != null)
                {
                    admin = ra;
                    dbcontext.SaveChanges();
                    return true;
                }
                else
                    return false;
                
            }
            #endregion
        }
        /// <summary>
        /// 通过id查找宿管
        /// </summary>
        /// <param name="id">宿管id</param>
        /// <returns>宿管</returns>
        public Administer CheckRaThoughID(string id)
        {
            #region
            using (var dbcontext = new dimsContext())
            {
                var ra = dbcontext.Administer
                    .FirstOrDefault(admin => admin.Ano == id);
                if (ra != null)
                    return ra;
                else
                    return null;
            }
            #endregion
        }
        /// <summary>
        /// 添加楼栋宿管
        /// </summary>
        /// <param name="aid">宿管id</param>
        /// <param name="Bno">楼栋号</param>
        /// <returns></returns>
        public bool AddBuildingRa(string aid,string Bno)
        {
            #region
            #endregion
            return false;
        }
        /// <summary>
        /// 通过id获取楼管
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Administer GetAdministerThoughID(string id)
        {
            #region
            #endregion
            return null;
        }
        public Administer GetAdministerThoughName(string name)
        {
            #region
            #endregion
            return null;
        }
    }
}
