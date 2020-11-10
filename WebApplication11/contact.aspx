<%@ Page Title="Synhostinger - Contact" Language="C#" MasterPageFile="~/Models/aspx/Default.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="WebApplication11.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="web" runat="server">

     <!-- Header section end -->
    <!--Body-->
    <!-- Page Top section -->
    <section class="page-top-section set-bg" data-setbg="/Models/hosting2019/img/page-top-bg/1.jpg">
        <div class="container">
            <h2>Nous contacter</h2>
          
        </div>

    </section>
    <div id="body">
</head>
<body>


     <form id="form1" runat="server">
        <div>>
            <center>
            &nbsp;<br />
                <asp:Label ID="Label1" runat="server" Text="Nom Prénom" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="name" runat="server" required="required" OnTextChanged="TextBox1_TextChanged1" Visible="False"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="E-mail" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="email" runat="server" OnTextChanged="TextBox2_TextChanged1" TextMode="Email" required="required" Visible="False"></asp:TextBox>
            <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Objet" Visible="False"></asp:Label>
            <br />
                <asp:TextBox ID="object" runat="server" TextMode="MultiLine" required="required" OnTextChanged="TextBox3_TextChanged1" Height="139px" Visible="False" Width="441px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="Validation" />

                <br />

                <br />
</form>
     </div>
</asp:Content>
