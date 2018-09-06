using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public Student() { }
    private string sno;
    private string sname;
    private string ssex;
    private int sage;
    private string sclass;
    private string sdepartment;
    private string sphone;
    private string saddress;
    private string spassword;

    public string Sno
    {
        set { sno = value; }
        get { return sno; }
    }
    public string Sname
    {
        set { sname = value; }
        get { return sname; }
    }
    public string Ssex
    {
        set { ssex = value; }
        get { return ssex; }
    }
    public int Sage
    {
        get { return sage; }
        set { sage = value; }
    }
    public string Sclass
    {
        set { sclass = value; }
        get { return sclass; }
    }
    public string Sdepartment
    {
        get { return sdepartment; }
        set { sdepartment = value; }
    }
    public string Sphone
    {
        get { return sphone; }
        set { sphone = value; }
    }
    public string Saddress
    {
        get { return saddress; }
        set { saddress = value; }
    }
    public string Spassword
    {
        get { return spassword; }
        set { spassword = value; }
    }
}

