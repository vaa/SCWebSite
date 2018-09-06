using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///TC 的摘要说明
/// </summary>
public class TC
{
	public TC(){}
    private string tno;
    private string cno;
    private string time;
    private string place;

    public string Tno
    {
        get { return tno; }
        set { tno = value; }
    }
    public string Cno
    {
        get { return cno; }
        set { cno = value; }
    }
    public string Time
    {
        get { return time; }
        set { time = value; }
    }
    public string Place
    {
        get { return place; }
        set { place = value; }
    }

}