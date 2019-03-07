using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webcollection
{
    public partial class HttpWebRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("HttpWebRequest远程调用！");
        }

        //返回
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://baike.baidu.com/item/good/499438?fr=aladdin");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
            // Response.Write("Get Result"+wr.ToString());


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            string param = "city=apple";
            byte[] bs = Encoding.ASCII.GetBytes(param);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("Http://fanyi.baidu.com:80");
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = bs.Length;
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(bs, 0, bs.Length);

            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://192.168.0.178:8005/RemoteXiazuan.ashx");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
        }
    }
}