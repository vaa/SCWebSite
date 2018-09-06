using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class StudentDAL
{
    DBOperation db = new DBOperation();
    ProOperation pr = new ProOperation();

    //数据的插入
    public bool Insert(Student stu)
    {
        bool flag = false;
        //此处判断学号是否存在
        string SQL = "select * from student where sno='" + stu.Sno + "'";
        DataTable dt = db.SQLGetDataTable(SQL);
        if (dt.Rows.Count == 0)
        {
            IDataParameter[] parameter = { 
                                                        new SqlParameter("@Sno",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sname",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Ssex",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sage",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sclass",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sdepartment",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sphone",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Saddress",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Spassword",SqlDbType.VarChar,50)
                                    };
            parameter[0].Value = stu.Sno;
            parameter[1].Value = stu.Sname;
            parameter[2].Value = stu.Ssex;
            parameter[3].Value = stu.Sage;
            parameter[4].Value = stu.Sclass;
            parameter[5].Value = stu.Sdepartment;
            parameter[6].Value = stu.Sphone;
            parameter[7].Value = stu.Saddress;
            parameter[8].Value = stu.Spassword;
            flag = pr.ExecuteProcedure("InsertStudentInformation", parameter);
            return flag;
        }
        else
        {
            return flag;
        }
    }

    //数据的查询(看用户是否存在)
    public bool SearchSname(Student stu)
    {
        bool flag = false;
        IDataParameter[] parameter = { 
                                                        new SqlParameter("@Sno",SqlDbType.VarChar,50)
                                    };
        parameter[0].Value = stu.Sno;
        DataSet ds = pr.GetDataSet("SearchSname", parameter);
        if (ds.Tables[0].Rows.Count > 0)
            flag = true;
        return flag;
    }

    //学生信息
    public DataTable StudentInfo()
    {
        DataTable dt = new DataTable();
        String SQL = "select Sno,Sname,Ssex,Sage,Sclass,Sdepartment,Sphone,Saddress,Spassword from student order by sno asc ";
        return dt = db.SQLGetDataTable(SQL);
    }

    //所有学生学号
    public DataTable StudentSno()
    {
        string SQL = "select sno from student";
        DataTable dt = db.SQLGetDataTable(SQL);
        return dt;
    }

    //数据库里学生信息的删除
    public void DeleteInformation(int sno)
    {
        IDataParameter[] parameter = { 
                                                        new SqlParameter("@Sno",SqlDbType.Int,32)
                                    };
        parameter[0].Value = sno;
        pr.ExcutePro("DeleteInfomation", parameter);
    }

    //学生信息管理界面数据查询--学号
    public DataTable StudentInfoSearchSno(Student stu)
    {
        string SQL = "select Sno,Sname,Ssex,Sage,Sclass,Sdepartment,Sphone,Saddress,Spassword from student where sno='" + stu.Sno + "'";
        DataTable dt = db.SQLGetDataTable(SQL);
        return dt;
    }
    //学生信息管理界面数据查询--姓名
    public DataTable StudentInfoSearchSname(Student stu)
    {
        string SQL = "select Sno,Sname,Ssex,Sage,Sclass,Sdepartment,Sphone,Saddress,Spassword from student where sname='" + stu.Sname + "'";
        DataTable dt = db.SQLGetDataTable(SQL);
        return dt;
    }

    //用户修改界面数据的查询
    public DataTable ShowInformation(Student stu)
    {
        string SQL = "select * from student where sno='" + stu.Sno + "'";
        DataTable dt = db.SQLGetDataTable(SQL);
        return dt;
    }

    //用户修改界面的数据更新
    public bool UpdateInformation(Student stu)
    {
        bool flag = false;
        IDataParameter[] parameter = { 
                                                        new SqlParameter("@Sno",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sname",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Ssex",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sage",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sclass",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sdepartment",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Sphone",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Saddress",SqlDbType.VarChar,50),
                                                        new SqlParameter("@Spassword",SqlDbType.VarChar,50)
                                    };
        parameter[0].Value = stu.Sno;
        parameter[1].Value = stu.Sname;
        parameter[2].Value = stu.Ssex;
        parameter[3].Value = stu.Sage;
        parameter[4].Value = stu.Sclass;
        parameter[5].Value = stu.Sdepartment;
        parameter[6].Value = stu.Sphone;
        parameter[7].Value = stu.Saddress;
        parameter[8].Value = stu.Spassword;
        flag = pr.ExecuteProcedure("UpdateInfomation", parameter);
        return flag;
    }

}
