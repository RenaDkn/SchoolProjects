<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebCovid19.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Type here:<asp:TextBox ID="TextBox2" runat="server" Height="22px" OnTextChanged="TextBox2_TextChanged" Width="284px"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" Height="153px" Width="456px" ReadOnly="True" style="margin-left: 550px; margin-top: 3px" TextMode="Search"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show the number of patiens per age" Height="21px" Width="340px" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Show the number of patiens per gender" Height="21px" Width="340px" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show the percentage of patiens per gender" Height="21px" Width="338px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Show the percentage of patiens per age" Height="21px" Width="340px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear" Height="22px" Width="66px" style="margin-top: 1px" />
        </p>
    </form>
</body>
</html>
