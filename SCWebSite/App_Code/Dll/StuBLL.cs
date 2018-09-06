using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class StuBLL
{
    StudentDAL Stu = new StudentDAL();
    public bool Insert(Student st)
    {
        return Stu.Insert(st);
    }
    public bool SearchSname(Student st)
    {
        return Stu.SearchSname(st);
    }
    public DataTable StudentInfo()
    {
        return Stu.StudentInfo();
    }
    public DataTable StudentSno()
    {
        return Stu.StudentSno() ;
    }
    public void DeleteInformation(int ID)
    {
        Stu.DeleteInformation(ID);
    }
    public DataTable StudentInfoSearchSno(Student st)
    {
        return Stu.StudentInfoSearchSno(st);
    }
    public DataTable StudentInfoSearchSname(Student st)
    {
        return Stu.StudentInfoSearchSname(st);
    }
    public DataTable ShowInformation(Student st)
    {
        return Stu.ShowInformation(st);
    }

    public bool UpdateInformation(Student st)
    {
        return Stu.UpdateInformation(st);
    }
}

