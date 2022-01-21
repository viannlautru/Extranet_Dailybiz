using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Extranet_Dailybiz.Models;
using System.Windows;
namespace Extranet_Dailybiz.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                com.dailybiz.exe.Idylisapi idev = new com.dailybiz.exe.Idylisapi();
                com.dailybiz.exe.SessionIDHeader sessionHeader = new com.dailybiz.exe.SessionIDHeader();

                //Authentification
                string codeAbonne = Request.Form["codeabonne"];
                string identifiant = Request.Form["identifiant"];
                string mdp = Request.Form["mdp"];
                string session = idev.authentification1(codeAbonne, identifiant, mdp);

                //Maintient la session ouverte
                sessionHeader.SessionID = session;


            }
        }

    }
}