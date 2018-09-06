using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Teacher
{
    public Teacher() { }
    private string tno;
    private string tname;
    private string tsex;
    private string tage;
    private string tdepartment;
    private string tphone;
    private string tpassword;
    public string Tno
    {
        set { tno = value; }
        get { return tno; }
    }
    public string Tname
    {
        set { tname = value; }
        get { return tname; }
    }
    public string Tage
    {
        get { return tage; }
        set { tage = value; }
    }
    public string Tsex
    {
        get { return tsex; }
        set { tsex = value; }
    }
    public string Tdepartment
    {
        get { return tdepartment; }
        set { tdepartment = value; }
    }
    public string Tphone
    {
        get { return tphone; }
        set { tphone = value; }
    }
    public string Tpassword
    {
        set { tpassword = value; }
        get { return tpassword; }
    }
}

