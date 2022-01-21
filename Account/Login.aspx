<%@ Page Title="Se connecter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Extranet_Dailybiz.Account.Login" Async="true" %>

<%--<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>--%>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %></h2>
    <form method="post" >
        <fieldset>
            <label for="codeabonne">Code abonné</label>
            <input type="text" id="codeabonne" name="codeabonne"  />

            <label for="identifiant">Identifiant</label>
            <input type="text" id="identifiant"  name="identifiant" value=""/>

            <label for="mdp">Mot de passe</label>
            <input type="text" id="mdp"  name="mdp"/> 

            <label>&nbsp;</label>
            <input type="submit" value="Submit" />
        </fieldset>
    </form>
</asp:Content>

