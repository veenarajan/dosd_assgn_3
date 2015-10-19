<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="CreditCardService.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Credit Card Validation Service</h1>
            <p class="lead">
                This service is used to verify the card number and if it is valid then the order is processed
            </p>
            <p>
                Method name : creditcardvalidation <br />
                Input : Card type and number <br />
                Output : If valid or not <br />
                TryIt URL : http://localhost:40221/TryIt.aspx
            </p>
    </div>
        <br />
      
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="Label1" runat="server" Text="Select Card :"></asp:Label>
                <asp:DropDownList ID="ddlist" runat="server">
                    <asp:ListItem Text="AmericanExpress">AmericanExpress</asp:ListItem> 
                    <asp:ListItem Text="Discover" >Discover</asp:ListItem>
                    <asp:ListItem Text="MasterCard" >MasterCard</asp:ListItem>
                    <asp:ListItem Text="Visa" >Visa</asp:ListItem>
                </asp:DropDownList>
           </div>
         </div>
   
        <br />
        <div class="row">
            <div class="col-md-6">    
                <asp:Label ID="Label2" runat="server" Text="Enter Card Number :"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" />
                </div>    
        </div>
    
        <br />
        <div class="row">
            <div class="col-md-6">    
                <asp:Button ID ="Botton1" onclick ="Button1_Click" Text="Validate Card" runat="server" /> 
            </div>
        </div>

         <br />
         <div class="row">
            <div class="col-md-6">
                <asp:Label ID="Label3" runat="server" />
            </div>
         </div>    
       
    </form>
</body>
</html>
