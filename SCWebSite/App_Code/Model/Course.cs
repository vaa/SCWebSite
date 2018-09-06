using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Course
{
    public Course() { }
    private string cno;
    private string cname;
    private string tno;

    public string Cno
    {
        set { cno = value; }
        get { return cno; }
    }
    public string Cname
    {
        set { cname = value; }
        get { return cname; }
    }
    public string Tno
    {
        set { tno = value; }
        get { return tno; }
    }
}

