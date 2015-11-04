<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chess.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 324px">
    <form id="form1" runat="server">
        
    <div>
        <asp:Label runat="server" id="HelloWorldLabel"></asp:Label>
        <br />
        <br />
        <asp:TextBox runat="server" id="TerminalOutput" Height="277px" Width="633px" Enabled="False" TextMode="MultiLine" /> 
        <br />
        <asp:TextBox runat="server" id="TerminalInput" Height="23px" Width="633px" style="margin-top: 15px" /> 
        <br />
        <asp:Button runat="server" id="GreetButton" text="Enter command" OnClick="TerminalButton_Click" Width="140px" />
        <br />
        <asp:Button runat="server" id="StartButton" text="Start game" OnClick="StartButton_Click" Width="140px" />
    </div>
    </form>
</body>
</html>
