using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StuInfoUpdate : System.Web.UI.Page
{
    Boolean flag = true;
    StuBLL student = new StuBLL();//对业务逻辑层的实例化
    Student stu = new Student();

    //显示数据的函数
    public void BingGridView(DataTable dt)
    {
        txtSno.Text = dt.Rows[0]["Sno"].ToString();
        txtSname.Text = dt.Rows[0]["Sname"].ToString();
        txtPwd.TextMode = TextBoxMode.SingleLine;
        txtPwd.Text = dt.Rows[0]["spassword"].ToString();
        string sex = dt.Rows[0]["Ssex"].ToString();
        if (sex == "女")
        {
            rbFemale.Checked = true;
        }
        else if (sex == "男")
        {
            rbMale.Checked = true;
        }
        string sage = dt.Rows[0]["Sage"].ToString();
        txtSage.Text = sage;
        string sclass = dt.Rows[0]["Sclass"].ToString();
        ddlSclass.Text = sclass;
        string sgrade = dt.Rows[0]["Sdepartment"].ToString();
        ddSdepartment.Text = sgrade;
        txtSphone.Text = dt.Rows[0]["Sphone"].ToString();
        txtSaddress.Text = dt.Rows[0]["Saddress"].ToString();
    }

    //页面加载
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)//解决网页回传数据问题
        {
            if (flag == true)
            {
                string id = Request.QueryString["sno"].ToString();
                stu.Sno = id;
                DataTable dt = student.ShowInformation(stu);
                BingGridView(dt);
            }
            else if (flag == false)
            {
                string sno = txtSno.Text;
                stu.Sno = sno;
                DataTable dt = student.ShowInformation(stu);
                BingGridView(dt);
            }
        }
    }

    //单击"保存"按钮的事件
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["sno"].ToString();
        flag = false;
        String name = txtSname.Text;
        String password = txtPwd.Text;
        String sex = null;
        if (rbFemale.Checked == true)
        {
            sex = "女";
        }
        else if (rbMale.Checked == true)
        {
            sex = "男";
        }
        int sage = 0;
        bool b=int.TryParse(txtSage.Text, out sage);
        string sclass = ddlSclass.SelectedItem.Text;
        string sdepartment = ddSdepartment.SelectedItem.Text;
        string sphone = txtSphone.Text;
        string saddress = txtSaddress.Text;

        if (name == null || password == null)
        {
            Response.Write("<script language='javascript'>alert('用户名或密码不能为空！');</script>");
        }
        else
        {
            bool flagen = false;
            stu.Sno = id;
            stu.Sname = name;
            stu.Spassword = password;
            stu.Ssex = sex;
            stu.Sage = sage;
            stu.Sclass = sclass;
            stu.Sdepartment = sdepartment;
            stu.Sphone = sphone;
            stu.Saddress = saddress;
            flagen = student.UpdateInformation(stu);
            if (flagen)
            {
                Response.Redirect("StudentInfo.aspx");
            }

            stu.Sno = id;
            DataTable dt = student.ShowInformation(stu);
            BingGridView(dt);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentInfo.aspx");
    }
}