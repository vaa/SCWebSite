using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CourseBLL
{
    CourseDAL course = new CourseDAL();

    public DataTable GetAllCno()
    {
        return course.GetAllCno();
    }
    public DataTable GetSelect(SC sc)
    {
        return course.GetSelect(sc);
    }

    public DataTable GetSelectedCourseName(SC sc)
    {
        return course.GetSelectedCourseName(sc);
    }

    public DataTable GetAllCourse()
    {
        return course.GetAllCourse();
    }

    public DataTable GetAllPointedCourse()
    {
        return course.GetAllPointedCourse();
    }

    public void DeleteCourse(SC sc)
    {
        course.DeleteCourse(sc);
    }

    public DataTable GetSelectedCourseCno(Course c)
    {
        return course.GetSelectedCourseCno(c);
    }

    public bool IsSelected(SC sc)
    {
        return course.IsSelected(sc);
    }

    public void InsertCourse(SC sc)
    {
        course.InsertCourse(sc);
    }

    public void DeletePointedCourse(string cno,string tno)
    {
        course.DeletePointedCourse(cno,tno);
    }
    public bool AddElectiveCourse(TC tc)
    {
        return course.AddElectiveCourse(tc);
    }
    public int IsCnoExist(Course c)
    {
        return course.IsCnoExist(c);
    }
    public int IsCnoTnoExist(TC tc)
    {
        return course.IsCnoTnoExist(tc);
    }
    public DataTable ShowCourse(Course c)
    {
        return course.ShowCourse(c);
    }
    public void DeleteSC(SC sc)
    {
        course.DeleteSC(sc);
    }
    public DataTable ShowDefultSC(SC s)
    {
        return course.ShowDefultSC(s);
    }
    public bool SaveSC(SC sc)
    {
        return course.SaveSC(sc);
    }
    public DataTable Search(SC sc, Student stu, string condition)
    {
        return course.Search(sc,stu,condition);
    }
}

