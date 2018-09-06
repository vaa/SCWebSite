using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateSC : System.Web.UI.Page
{
    CourseBLL course = new CourseBLL();
    TeacherBLL teacher = new TeacherBLL();
    Course c = new Course();
    Teacher t = new Teacher();
    SC sc = new SC();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string cno = Request.QueryString["cno"].ToString();
            string sno = Request.QueryString["sno"].ToString();
            sc.Cno = cno;
            sc.Sno = sno;
            DataTable dt = new DataTable();
            dt = course.ShowDefultSC(sc);
            txtCno.Text = dt.Rows[0]["cno"].ToString();
            txtCname.Text = dt.Rows[0]["cname"].ToString();
            txtSno.Text = dt.Rows[0]["sno"].ToString();
            txtGrade.Text = dt.Rows[0]["grade"].ToString();

        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        bool flag = false;
        sc.Sno = txtSno.Text;
        sc.Cno = txtCno.Text;
        sc.Grade = float.Parse(txtGrade.Text);
        flag = course.SaveSC(sc);
        if (flag)
        {
            Response.Write("<script language='javascript'>alert('修改成功！');</script>");
            Response.Write("<script language=javascript>javascript:location.href='StudentGrade.aspx'</script>");
        }
        else
            Response.Write("<script language='javascript'>alert('修改失败！');</script>");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentGrade.aspx.aspx");
    }
}