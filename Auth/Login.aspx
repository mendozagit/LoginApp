<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginApp.Auth.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASAP-Login</title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="login-form">
                <div class="logo">
                    <img alt="Logo" src="https://sso.fed.prod.aws.swacorp.com/assets/images/swa_logo_dark.svg"/>
                </div>
            <h3>ASAP-FO</h3>
            <asp:TextBox ID="SwaIdTextBox" runat="server" placeholder="SWA ID"></asp:TextBox>
          <br/>
            <asp:TextBox ID="WsaPasswordTextBox" runat="server" placeholder="SWA Password" TextMode="Password"></asp:TextBox>
          <br/>
    
           <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="OnSubmitButtonClick" />
      
        </div>
    </form>
</body>
</html>
