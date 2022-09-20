using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC4
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_Age = 49; int i_Sex = 0;
            if (i_Sex == 1)
            {
                if (i_Age >= 50)
                {
                    Response.Write("壯年男人的程式執行程式碼區域");
                }
                else
                {
                    Response.Write("年輕男人的程式執行程式碼區域");
                }
            }
            else if (i_Sex == 0)
            {
                if (i_Age >= 50)
                {
                    Response.Write("壯年女人的程式執行程式碼區域");
                }
                else
                {
                    Response.Write("年輕女人的程式執行程式碼區域");
                }
            }
            else
            {
                Response.Write("其他");
            }
        }
    }
}