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
    <link href="/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="/css/simple-sidebar.css" rel="stylesheet">

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
                <h1>
                    <asp:Image ID="logoTest" runat="server" ImageUrl="~/media/dnd.png" Width="250px"  />
                    Monster Generator<asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </h1>               

                <p style="float:left">This page allows you to generate a random monster from the DnD monster manual.    
                <p>&nbsp;</p>
                <p>Search:
                    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                </p>
                <p>Challenge Rating (CR):&nbsp;
                    <asp:TextBox ID="txtChallengeRating" runat="server" onkeypress="return numberInputOnly(event);"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Monster Type:
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
                &nbsp; </p>
                <p>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate" Width="246px" />
                </p>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:left; margin-right: 30px;">
                        <asp:ListBox ID="lstBoxMonsters" runat="server" AutoPostBack="True" Height="185px" OnSelectedIndexChanged="lstBoxMonsters_SelectedIndexChanged" Width="386px"></asp:ListBox>
                        </div>
                            <div style="float:left;" width: 462px; height: 214px; margin-left: 30px">
                                &nbsp;<asp:Label ID="Label2" runat="server" Text="Monster Name:" Width="130px" style="text-align:right"></asp:Label>
                                <asp:TextBox ID="txtMonsterName" runat="server" ReadOnly="True" Enabled="False" style="margin-left: 10px" Width="150px"></asp:TextBox>
                            <br />
                                &nbsp;<asp:Label ID="Label3" runat="server" Text="Monster Type:" Width="130px" style="text-align:right"></asp:Label>
                                <asp:TextBox ID="txtMonsterType" runat="server" Width="150px" Enabled="False" OnTextChanged="txtMonsterType_TextChanged" style="margin-left: 10px"></asp:TextBox>
                            <br />
                                <asp:Label ID="Label4" runat="server" Text="Alignment:" Width="130px" style="text-align:right"></asp:Label>
                                <asp:TextBox ID="txtMonsterAlignment" runat="server" Width="150px" Enabled="False" style="margin-left: 10px"></asp:TextBox>
                            <br />
                                <asp:Label ID="Label5" runat="server" Text="Challenge Rating:" Width="130px" style="text-align:right"></asp:Label>
                                <asp:TextBox ID="txtMonsterChallengeRating" runat="server" Width="42px" Enabled="False" style="margin-left: 10px"></asp:TextBox>
                            <br />
                                <asp:Label ID="Label6" runat="server" Text="Hit Points:" Width="130px" style="text-align:right"></asp:Label>
                                <asp:TextBox ID="txtMonsterHitPoints" runat="server" Width="43px" Enabled="False" style="margin-left: 10px"></asp:TextBox>
                                <br />
                                <asp:Label ID="Label7" runat="server" Text="Hit Dice:" Width="130px" style="text-align:right"></asp:Label>
                                <asp:TextBox ID="txtMonsterHitDice" runat="server" Width="108px" Enabled="False" style="margin-left: 10px"></asp:TextBox>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                    
                    </div>
            <div><a href="#menu-toggle" class="btn btn-secondary" id="menu-toggle">Toggle Menu</a></div>


                </form>
        <script src="JavaScriptFunctions.js"></script>



</body>
</html>
