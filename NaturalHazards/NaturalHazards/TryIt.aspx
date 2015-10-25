<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="NaturalHazards.TryIt" %>

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
        <h1>Natural Hazard </h1>
            <p class="lead">
                This service provides you with the probability of earthquake of a location
            </p>
            <p>
                Method name : getearthquakeprob <br />
                Input : Zip code and radius of the region<br />
                Output : Probability of Eartquake <br />
                TryIt URL : http://webstrar15.fulton.asu.edu/page6/TryIt.aspx
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
                <asp:Label ID="Label3" runat="server" Text="Enter radius  :"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" />
                </div>    
        </div>
        <br />

        <div class="row">
            <div class="col-md-6">    
                <asp:Button ID ="Botton1" onclick ="Button1_Click" Text="Get probablitiy" runat="server" /> 
            </div>
        </div>
         <br />
         <div class="row">
            <div class="col-md-6">
                <asp:Label ID="Label2" runat="server" />
            </div>
         </div>    

    </form></body>
</html>
