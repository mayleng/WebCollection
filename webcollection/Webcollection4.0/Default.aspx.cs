using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Webcollection
{
    public partial class Default : System.Web.UI.Page
    {

        public static string logPath = AppDomain.CurrentDomain.BaseDirectory + "logs\\systemTrace.log";

        //构造函数中初始化监听器
        public Default()
        {
            System.Diagnostics.Trace.Listeners.Clear();  //清除系统监听器 (就是输出到Console的那个)
            System.Diagnostics.Trace.Listeners.Add(new MyTraceListener(logPath));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //返回当前的请求
            string url = Request.Url.ToString();
            Response.Write("当前URL为：" + url);

            //设置服务器缓存
            Cache.Insert("key1", "cache abc", null, DateTime.Now.AddMinutes(20), TimeSpan.Zero);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);

            System.Diagnostics.Trace.TraceError("TRACE ERROR");
            System.Diagnostics.Trace.TraceWarning("trace warn");
            System.Diagnostics.Trace.TraceInformation("trace info");
            System.Diagnostics.Trace.WriteLine(" trace common");
            System.Diagnostics.Trace.Write("添加一个异常*******   ");
            //设置消息过滤
            System.Diagnostics.Trace.Write("test *********   ");
            System.Diagnostics.Trace.Write("test1 ********   ");
            System.Diagnostics.Trace.Write("test2******   ");
            Test();
        }

        //定义一个产生异常的方法
        private static void Test()
        {
            try
            {
                int i = 0;
                Console.WriteLine(5 / i); //出现除0异常
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(ex, "计算员工工资出现异常");
                System.Diagnostics.Trace.TraceError("记录日志 TRACE ERROR");
                System.Diagnostics.Trace.TraceWarning("记录日志 trace warn");
                System.Diagnostics.Trace.TraceInformation("记录日志 trace info");
                System.Diagnostics.Trace.Fail("trace ********Fail ");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Try.aspx?c=3");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Database.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HttpWebRequests.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TestStore.ashx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/URL.aspx");
        }
    }
}