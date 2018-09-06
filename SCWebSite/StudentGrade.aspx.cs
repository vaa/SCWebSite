using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentGrade : System.Web.UI.Page
{
    CourseBLL course = new CourseBLL();
    TeacherBLL teacher = new TeacherBLL();
    Course c = new Course();
    Teacher t = new Teacher();
    SC sc = new SC();
    Student stu = new Student();

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
        Unique(course.ShowCourse(c));
    }

    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[7].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('您确定删除吗？')");

            }
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cno = this.GridView1.SelectedRow.Cells[0].Text;
        string sno = this.GridView1.SelectedRow.Cells[3].Text;
        Response.Redirect("UpdateSC.aspx?cno=" + cno+"&sno="+sno);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //执行数据库删除
        sc.Cno = this.GridView1.DataKeys[e.RowIndex]["Cno"].ToString();
        sc.Sno = this.GridView1.DataKeys[e.RowIndex]["Sno"].ToString();
        course.DeleteSC(sc);
        //刷新页面，显示数据
        Unique(course.ShowCourse(c));
    }

    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        Unique(course.ShowCourse(c));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string searchCondition = null;
        searchCondition = DropDownList1.SelectedItem.Text;
        sc.Sno = txtSearch.Text;
        stu.Sclass = txtSearch.Text;
        Unique(course.Search(sc, stu, searchCondition));
    }


}