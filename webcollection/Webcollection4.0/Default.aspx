<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webcollection.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="system trace log" />
             &nbsp; &nbsp; <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="异常try" />
        <p>
           <asp:Button ID="Button4" runat="server" Text="远程调用httpwebrequest" OnClick="Button4_Click" />
        </p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="数据库测试" />
      &nbsp; &nbsp;  
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="不同参数测试" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <p>
            <asp:Button ID="Button5" runat="server" Text="TestStore" OnClick="Button5_Click" />
        </p>
    </form>
    </form>
</body>
</html>
