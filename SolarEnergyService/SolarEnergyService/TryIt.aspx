<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="SolarEnergyService.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div class="jumbotron">
        <h1>Solar Energy Service</h1>
            <p class="lead">
                This service returns the annual average sunshine index of a given position (latitude, longitude). 
            </p>
            <p>
                Method name: GetSolarIntersity<br />
                Input : Latitude and Longitude <br />
                Output : Annual Solar Intensity <br />

                Tryit URL : http://localhost:12182/TryIt.aspx 
            </p>
    </div>
        <br />

        <div class="row">
            <div class="col-md-6">   
                <p>Note: Enter latitude in range -90 and 90 and longitude -180 to 180</p> 
                
                <asp:Label ID="Label2" runat="server" Text="Enter Longitude :"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" />
            </div>    
        </div>
    
        <br />

        <div class="row">
            <div class="col-md-6">    
                <asp:Label ID="Label3" runat="server" Text="Enter Latitude :"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" />
            </div>    
        </div>

        <br />
        <div class="row">
            <div class="col-md-6">    
                <asp:Button ID ="Botton1" onclick ="Button1_Click" Text="Get Intensity" runat="server" />
            </div>    
        </div>

    <br />
        
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="Label4" runat="server" />
            </div>
         </div> 
        </form>
</body>
</html>
