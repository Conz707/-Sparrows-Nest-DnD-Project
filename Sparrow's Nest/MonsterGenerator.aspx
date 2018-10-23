<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonsterGenerator.aspx.cs" Inherits="Sparrows_Nest.MonsterGen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Sparrow's Nest</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="css/simple-sidebar.css" rel="stylesheet">

</head>
<body>

    <form id="form1" runat="server">

    <div id="wrapper">

        <!-- Sidebar -->
        <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li class="sidebar-brand">
                    <a href="default.aspx">
                        Sparrow's Nest
                    </a>
                </li>
                <li>
                    <a href="#">Dashboard</a>
                </li>
                <li>
                    <a href="MonsterGenerator.aspx" >Monster Generator</a>
                    
                </li>
                <li>
                    <a href="#">Overview</a>
                </li>
                <li>
                    <a href="#">Events</a>
                </li>
                <li>
                    <a href="#">About</a>
                </li>
                <li>
                    <a href="#">Services</a>
                </li>
                <li>
                    <a href="#">Contact</a>
                </li>
            </ul>
        </div>
        <!-- /#sidebar-wrapper -->

        <!-- Page Content -->
        <div id="page-content-wrapper">
            <div class="container-fluid">
                <h1>Monster Generator</h1>
                <p>This page allows you to generate a random monster from the DnD monster manual.</p>
                <p>Fill in any of the text boxes below for monster generator parameters, or click generate for a fully random creature.</p>
                <p>Challenge Rating (CR):
                    <asp:TextBox ID="txtChallengeRating" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </p>
                <p>Monster Type:
                    <asp:DropDownList ID="txtType" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Aberration</asp:ListItem>
                        <asp:ListItem>Beast</asp:ListItem>
                        <asp:ListItem>Celestial</asp:ListItem>
                        <asp:ListItem>Construct</asp:ListItem>
                        <asp:ListItem>Dragon</asp:ListItem>
                        <asp:ListItem>Elemental</asp:ListItem>
                        <asp:ListItem>Fey</asp:ListItem>
                        <asp:ListItem>Fiend</asp:ListItem>
                        <asp:ListItem>Giant</asp:ListItem>
                        <asp:ListItem>Humanoid</asp:ListItem>
                        <asp:ListItem>Monstrosity</asp:ListItem>
                        <asp:ListItem>Ooze</asp:ListItem>
                        <asp:ListItem>Plant</asp:ListItem>
                        <asp:ListItem>Undead</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate" Width="246px" />
                </p>
                <p>
                    <asp:ListBox ID="ListBox1" runat="server" Height="204px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="402px"></asp:ListBox>
                </p>
                <a href="#menu-toggle" class="btn btn-secondary" id="menu-toggle">Toggle Menu</a>
            </div>
        </div>
        <!-- /#page-content-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Menu Toggle Script -->
    <script>
    $("#menu-toggle").click(function(e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
    });
    </script>

    </form>

</body>
</html>
