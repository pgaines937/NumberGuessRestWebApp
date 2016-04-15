<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RestWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome to Number Guessing Game</h1>
        <asp:Label ID="LabelLowerLimit" runat="server" Text="Lower Limit"></asp:Label>
        <asp:TextBox ID="TextBoxLower" runat="server"></asp:TextBox>
        <asp:Label ID="LabelUpperLimit" runat="server" Text="Upper Limit"></asp:Label>
        <asp:TextBox ID="TextBoxUpper" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSecretNumber" runat="server" Text="Generate a Secret Number" OnClick="ButtonSecretNumber_Click" />
        <asp:Label ID="LabelSecret" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />

        <asp:Label ID="LabelMakeGuess" runat="server" Text="Make a Guess"></asp:Label>
        <asp:TextBox ID="TextBoxMakeGuess" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonPlay" runat="server" Text="Play" OnClick="ButtonPlay_Click" />
        <asp:Label ID="LabelAttempts" runat="server" Text="Attempts"></asp:Label>
        <asp:Label ID="LabelAttemptsCount" runat="server" Text="0"></asp:Label>
        <asp:Label ID="LabelNumberIs" runat="server" Text="The number is "></asp:Label>
        <asp:Label ID="LabelNum" runat="server" Text="-"></asp:Label>
    </div>


</asp:Content>
