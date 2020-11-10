using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.UI;
using System.Web.UI.WebControls;
using Renci.SshNet;

namespace WebApplication11
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            name.Visible = true;
            email.Visible = true;
            @object.Visible = true;
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            // Variables pour l'envoi du mail
            string prenom = name.Text;
            string email = this.email.Text;
            string contact = @object.Text;
            // Paramétre SMTP pour l'envoi du mail
            WebMail.SmtpServer = "51.210.120.112";
            WebMail.SmtpPort = 25;
            WebMail.UserName = "no-reply@synhostinger.com";
            WebMail.Password = "MBJkt31Jao";
            WebMail.From = "Ne Pas Répondre - <no-reply@synhostinger.com>";
            WebMail.EnableSsl = false;
            WebMail.Send(to: "contact@synhostinger.com",
            // Envoi du mail avec les variables
            subject: "Formulaire de contact" ,
            body: "Hello " + "<br />" + "une personne à rempli le formulaire de contact :" + "<br /> <br />" +  "Prénom : " + prenom + "<br />" + "Email : " + email + "<br />" + "<br />" + " Description : " + contact + "<br /> <br />" + "Cordialement" + "<br />" + "l'équipe de Synhostinger"
           );

            Response.Redirect("/");
        }

        protected void TextBox3_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}