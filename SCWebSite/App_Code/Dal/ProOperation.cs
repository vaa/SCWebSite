using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ProOperation
{
    string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
    public ProOperation()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 根据存储过程字符串，和参数，执行存储过程
    /// </summary>
    /// <param name="cmdText"></param>
    /// <param name="parameters"></param>
    public void ExcutePro(string cmdText, IDataParameter[] parameters)
    {
        SqlConnection conn = new SqlConnection(ConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter para in parameters)
        {
            cmd.Parameters.Add(para);
        }
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    /// <summary>
    /// 根据存储过程字符串，和参数，执行存储过程，
    /// </summary>
    /// <param name="cmdText"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public bool ExecuteProcedure(string cmdText, IDataParameter[] parameters)
    {
        bool flag = false;

        SqlConnection conn = new SqlConnection(ConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter para in parameters)
        {
            cmd.Parameters.Add(para);
        }
        conn.Open();
        int count = 0;
        count = cmd.ExecuteNonQuery();
        conn.Close();

        if (count > 0) flag = true;
        return flag;
    }
    /// <summary>
    /// 根据存储过程字符串，和参数，执行存储过程，并返回主键字段
    /// </summary>
    /// <param name="cmdText"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public int ExecuteProcedureRe(string cmdText, IDataParameter[] parameters)
    {
        int id = 0;

        SqlConnection conn = new SqlConnection(ConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter para in parameters)
        {
            cmd.Parameters.Add(para);
        }
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        id = int.Parse(parameters[0].Value.ToString());
        return id;
    }
    /// <summary>
    /// 根据存储过程字符串，执行存储过程，查询相关内容并返回到数据集中
    /// </summary>
    /// <param name="cmdText"></param>
    /// <returns></returns>
    public DataSet GetDataSet(string cmdText)
    {
        SqlConnection conn = new SqlConnection(ConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }
    /// <summary>
    /// 根据存储过程字符串，执行存储过程，查询相关内容并返回到数据适配器中
    /// </summary>
    /// <param name="cmdText"></param>
    /// <returns></returns>
    public SqlDataAdapter GetDataAdp(string cmdText)
    {
        SqlConnection conn = new SqlConnection(ConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        return adp;
    }
    /// <summary>
    /// 根据存储过程字符串，和参数，执行存储过程，查询相关内容并返回到数据适配器中
    /// </summary>
    /// <param name="cmdText"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public DataSet GetDataSet(string cmdText, IDataParameter[] parameters)
    {
        SqlConnection conn = new SqlConnection(ConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter para in parameters)
        {
            cmd.Parameters.Add(para);
        }
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }
}

