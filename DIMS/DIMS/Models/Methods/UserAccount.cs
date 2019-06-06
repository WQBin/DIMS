using DIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS.Models.Methods
{
    public class UserAccount
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
                var query = dbcontext.Student
                    .FirstOrDefault(s => s.Sno == id && s.Spassword == password);
                if (query != null)
                    return true;
                else
                    return false;
            }
            #endregion
        }
        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="id">学号</param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool NewPassword(string id,string oldPassword,string newPassword)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var student = dbcontext.Student
                    .FirstOrDefault(s=>s.Sno==id&&s.Spassword==oldPassword);
                if(student!=null)
                {
                    student.Spassword = newPassword;
                    dbcontext.SaveChanges();
                    return true;
                }
                return false;
            }
            #endregion
           
        }
        public Student GetStudentDetail(string sno)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Student
                    .FirstOrDefault(s => s.Sno == sno);
                if (query != null)
                    return query;
                else
                    return null;
            }
            #endregion
        }
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudent(Student student)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                dbcontext.Student.Add(student);
                dbcontext.SaveChanges();
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 根据学号查询学生信息
        /// </summary>
        /// <param name="sno"></param>
        /// <returns></returns>
        public Student GetStudents(string sno)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Student
                    .FirstOrDefault(s => s.Sno == sno);
                return query;
            }
            #endregion
        }
        //查询所有学生
        public List<Student> GetAllStudent()
        {
            #region
            using (var db = new dimsContext())
            {
                var query = db.Student
                    .FromSql("select * from dims.Student")
                    .ToList();
                return query;
            }
            #endregion
        }
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="student"></param>
        /// <param name="sno"></param>
        /// <returns></returns>
        public bool ModifyStudentInfor(Student student,string sno)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Student
                    .FirstOrDefault(s => s.Sno == sno);
                query = student;
                query.Sno = sno;
                dbcontext.SaveChanges();
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 获取学生宿舍号
        /// </summary>
        /// <param name="sno"></param>
        /// <returns></returns>
        public string GetBno(string sno)
        {
            #region
            using(var dbcontext=new dimsContext())
            {
                var query = dbcontext.Student
                    .FirstOrDefault(s => s.Sno == sno);
                return query.Bno;
            }
            #endregion
        }


    }
}
