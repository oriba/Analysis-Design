<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PL.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/webStylesheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="top_banner">
        <img id="logo" src="images/Untitled-1 copy.png" />
        <table id="search">
            <tr>
               <td ><input id="searchText" runat="server" type="text" value="what are you looking for?" /></td>
               <td ><img id="searchButton" src="images/BlueOrbSearch.png" /></td>
            </tr>
        </table>
        <a id="login" href="Login.aspx"> login</a>>
    </div>
    <div id="nav">
        <ul>
            <li><a runat="server" onserverclick="Home_Click">Home</a></li>
            <li><a runat="server" onserverclick="Food_Click">Food</a></li>
            <li><a runat="server" onserverclick="Entertainment_Click">Entairtainment</a></li>
            <li><a runat="server" onserverclick="HealthAndBeauty_Click">Health And Beauty</a></li>
            <li><a runat="server" onserverclick="Apparel_Click">Apparel</a></li>
            <li><a runat="server" onserverclick="Electronics_Click">Electronics</a></li>
        </ul>
    </div>

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </form>

</body>
</html>
