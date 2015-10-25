<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="CurrencyConverter.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div class="jumbotron">
           <h4>
           <a href = "http://webstrar15.fulton.asu.edu/Index.html">Main Page URL </a> <br />
        </h4>
        <h1>Currency Converter </h1>
            <p class="lead">
                This service provides you with the USD equivalent of the input currency
            </p>
            <p>
                Method name : currencyconverter <br />
                Input : String currency e.g. INR and amount<br />
                Output : Currency in USD <br />
                TryIt URL : http://webstrar15.fulton.asu.edu/page7/TryIt.aspx
            </p>
    </div>

        <div class="row">
            <div class="col-md-6">    
                <asp:Label ID="Label1" runat="server" Text="Enter currency symbol :"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" />
                </div>    
        </div>

        <br />

        <div class="row">
            <div class="col-md-6">    
                <asp:Label ID="Label3" runat="server" Text="Enter amount :"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" />
                </div>    
        </div>

        <br />

        <div class="row">
            <div class="col-md-6">    
                <asp:Button ID ="Botton1" onclick ="Button1_Click" Text="Convert to USD" runat="server" /> 
            </div>
        </div>
         <br />

         <div class="row">
            <div class="col-md-6">
                <asp:Label ID="Label2" runat="server" />
            </div>
         </div>    

    </form>
</body>
</html>
