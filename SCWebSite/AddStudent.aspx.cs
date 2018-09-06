using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddStudent : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Sno = txtRSno.Text;
            stu.Sname = txtRSname.Text;
            stu.Spassword = txtRSpwd.Text;
            if (rdbMale.Checked == true)
            {
                stu.Ssex = "男";
            }
            else
            {
                stu.Ssex = "女";
            }
            stu.Sage = int.Parse(txtRSage.Text);
            stu.Sclass = ddlSclass.SelectedItem.Text;
            stu.Sdepartment = ddSdepartment.SelectedItem.Text;
            stu.Sphone = txtRSphone.Text;
            stu.Saddress = txtRSaddress.Text;
            StuBLL student = new StuBLL();
            bool flag = false;
            flag = student.Insert(stu);

            if (flag)
            {
                Response.Redirect("StudentInfo.aspx");
            }
            else Response.Write("<script language='javascript'>alert('注册失败！此用户已存在！');</script>");
        }
        protected void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void txtRSno_TextChanged(object sender, EventArgs e)
        {

        }
}