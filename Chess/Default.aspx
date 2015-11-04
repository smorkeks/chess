<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chess.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" id="HelloWorldLabel"></asp:Label>
        <br />
        <br />
        <asp:TextBox runat="server" id="TextInput" Height="39px" Width="633px" /> 
        <br />
    <div>
    
        <asp:Button runat="server" id="GreetButton" text="Say Hello!" OnClick="GreetButton_Click" Width="148px" />
    
    </div>
    </form>
</body>
</html>
