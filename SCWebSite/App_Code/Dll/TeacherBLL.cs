using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TeacherBLL
{
    TeacherDAL teacher = new TeacherDAL();

    public string SelectTno(Teacher t)
    {
        return teacher.SelectTno(t);
    }
    public DataTable GetAllTno()
    {
        return teacher.GetAllTno();
    }
}
