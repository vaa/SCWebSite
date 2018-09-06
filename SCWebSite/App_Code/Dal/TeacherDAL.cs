using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TeacherDAL
{
    ProOperation pr = new ProOperation();
    DBOperation db = new DBOperation();//作为公共的实例化

    //查找教师编号
    public string SelectTno(Teacher teacher)
    {
        string tno = null;
        IDataParameter[] parameter = { 
                                                        new SqlParameter("@Tname",SqlDbType.VarChar,50)
                                    };
        parameter[0].Value = teacher.Tname;
        DataSet ds = pr.GetDataSet("SelectTno", parameter);
        if (ds.Tables[0].Rows.Count > 0)
            tno = ds.Tables[0].Rows[0]["Tno"].ToString();
        return tno;
    }
    //获得所有老师编号
    public DataTable GetAllTno()
    {
        string SQL = "select * from Teacher";
        DataTable dt = db.SQLGetDataTable(SQL);
        return dt;
    }
}