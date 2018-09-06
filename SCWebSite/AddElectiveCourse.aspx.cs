using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddElectiveCourse : System.Web.UI.Page
{
    CourseBLL course = new CourseBLL();
    TeacherBLL teacher = new TeacherBLL();
    Course c = new Course();
    Teacher t = new Teacher();
    TC tc = new TC();

    public void Unique(DataTable dt)
    {
        var GetNews =
        from ne in dt.AsEnumerable()
        select ne;

        this.GridView1.DataSource = GetNews.CopyToDataTable<DataRow>();
        this.GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Unique(course.GetAllPointedCourse());
        if (!IsPostBack) 
        {
            DataTable dt=course.GetAllCno();
            foreach (DataRow dr in dt.Rows)
            {
                ddlCno.Items.Add(dr["Cno"].ToString());
            }
            dt = teacher.GetAllTno();
            foreach (DataRow dr in dt.Rows)
            {
                ddlTno.Items.Add(dr["Tno"].ToString());
            }
        }
    }

    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[8].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('您确定删除吗？')");

            }
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        Unique(course.GetAllPointedCourse());
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //执行数据库删除
        string cno = this.GridView1.DataKeys[e.RowIndex]["Cno"].ToString();
        string tno = this.GridView1.DataKeys[e.RowIndex]["Tno"].ToString();
        course.DeletePointedCourse(cno,tno);
        //刷新页面，显示数据
        Unique(course.GetAllPointedCourse());
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        tc.Cno = ddlCno.SelectedItem.Text;
        tc.Tno = ddlTno.SelectedItem.Text;
        int count = course.IsCnoTnoExist(tc);
        if (count > 0)
        {
            Response.Write("<script language='javascript'>alert('课程号和教师号已存在！');</script>");
        }
        else
        {
            tc.Tno = ddlTno.SelectedItem.Text;;
            tc.Time = txtTime.Text;
            txtTime.Text = "";
            tc.Place = txtPlace.Text;
            txtPlace.Text = "";
            bool flag = course.AddElectiveCourse(tc);
            if (flag)
                Response.Write("<script language='javascript'>alert('课程添加成功！');</script>");
            else
                Response.Write("<script language='javascript'>alert('课程添加失败！');</script>");
        }
    }
}