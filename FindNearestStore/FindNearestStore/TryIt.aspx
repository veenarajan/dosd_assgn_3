<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="FindNearestStore.TryIt1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Locate Your Nearest Store</h1>
            <p class="lead">
                This service provides you with the address when you provide the zip code and name of the store
            </p>
            <p>
                Method name : findneareststore <br />
                Input : Zip code and name of store<br />
                Output : Address of all the nearby locations of the store <br />
                TryIt URL : http://localhost:5970/TryIt.aspx
            </p>
    </div>
        <br />
      
        <div class="row">
            <div class="col-md-6">    
                <asp:Label ID="Label1" runat="server" Text="Enter name of store :"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" />
                </div>    
        </div>
        <br />
        <div class="row">
            <div class="col-md-6">    
                <asp:Label ID="Label2" runat="server" Text="Enter zip code :"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" />
                </div>    
        </div>
    
        <br />
        <div class="row">
            <div class="col-md-6">    
                <asp:Button ID ="Botton1" onclick ="Button1_Click" Text="Locate Store" runat="server" /> 
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
