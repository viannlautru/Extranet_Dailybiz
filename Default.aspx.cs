using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Extranet_Dailybiz
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            com.dailybiz.exe.Idylisapi idev = new com.dailybiz.exe.Idylisapi();
            com.dailybiz.exe.SessionIDHeader sessionHeader = new com.dailybiz.exe.SessionIDHeader();

            //Authentification
            string codeAbonne = "IDYLI976";
            string identifiant = "m.hue@xefi.fr";
            string mdp = "Lenny27";
            string session = idev.authentification1(codeAbonne, identifiant, mdp);

            //Maintient la session ouverte
            sessionHeader.SessionID = session;


            
        }
              

    }
}