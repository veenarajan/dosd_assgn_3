<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="WeatherService.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Weather Service</h1>
            <p class="lead">
                This service provides you with the weather of the location for the next 5 days
            </p>
            <p>
                Method name : get5dayweather <br />
                Input : Zip code<br />
                Output : Weather of the location for 5 days <br />
                TryIt URL : http://localhost:51628/TryIt.aspx
            </p>
    </div>
        <br />
      
        <div class="row">
            <div class="col-md-6">    
                <asp:Label ID="Label1" runat="server" Text="Enter zip code :"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" />
                </div>    
        </div>
        <br />

        <div class="row">
            <div class="col-md-6">    
                <asp:Button ID ="Botton1" onclick ="Button1_Click" Text="Get Weather" runat="server" /> 
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
