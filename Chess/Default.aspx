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

        <asp:DropDownList runat="server" id="PlayerWhiteAgentList" autopostback="true" Height="16px" style="margin-left: 17px" Width="145px" >
            <asp:ListItem value="TA">Terminal Agent</asp:ListItem>
            <asp:ListItem value="GA">Graphics Agent</asp:ListItem>
            <asp:ListItem value="AI">AI Agent</asp:ListItem>
        </asp:DropDownList>

        <asp:DropDownList runat="server" id="PlayerBlackAgentList" autopostback="true" Height="16px" style="margin-left: 16px" Width="135px" >
            <asp:ListItem value="TA">Terminal Agent</asp:ListItem>
            <asp:ListItem value="GA">Graphics Agent</asp:ListItem>
            <asp:ListItem value="AI">AI Agent</asp:ListItem>
        </asp:DropDownList>
        <asp:Button runat="server" id="StartButton" text="Start game" OnClick="StartButton_Click" Width="140px" style="margin-left: 14px" />

        <br />
        <asp:TextBox runat="server" id="TerminalInput" Height="23px" Width="479px" style="margin-top: 15px" /> 
        <asp:Button runat="server" id="GreetButton" text="Enter command" OnClick="TerminalButton_Click" Width="140px" style="margin-left: 9px" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
