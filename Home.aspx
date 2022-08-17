<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Server.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form2" runat="server">
         
           <asp:ListBox ID="ListBox1" runat="server" Height="0px" Width="0px" ></asp:ListBox>
         
 
        <div style="text-align: center">         
            HI<br/>
            Здесь вы сможите узнать, зарегестрирован ли ваш пользователь в операционной системе   
        </div>
            
        <br/><br/>
        <div style="text-align: center">       
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              </div> 
           
  <br/><br/>
         <div style="text-align: center">       
             <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Проверить"  />            
         </div>                      
         
        <div style="text-align: center">       
              </div> 


    </form>
</body>
</html>
