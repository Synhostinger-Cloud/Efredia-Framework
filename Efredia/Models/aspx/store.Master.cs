using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.UI;
using System.Web.UI.WebControls;
using Renci.SshNet;

namespace Efredia
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)

        {

            //Activation des label et textbox et changement de label vide en HDD = ?hdd=disque
            if (Request.QueryString["vps-perso"] != null)
            {
                Label20.Visible = false;
                Label21.Text = "VPS Personal";
                Button2.Visible = false;
                labelname.Visible = true;
                TelBox.Visible = true;
                labelemail.Visible = true;
                Label3.Visible = true;
                named.Visible = true;
                emailtextbox.Visible = true;
                project_details.Visible = true;
            }
            else
            {

            }

            if (Request.QueryString["vps-start"] != null)
            {
                Label20.Visible = false;
                Label21.Text = "VPS Startup";
                Button2.Visible = false;
                TelBox.Visible = true;
                labelname.Visible = true;
                labelemail.Visible = true;
                Label3.Visible = true;
                named.Visible = true;
                emailtextbox.Visible = true;
                project_details.Visible = true;
            }
            else
            {

            }
            if (Request.QueryString["vps-entreprise"] != null)
            {
                Label20.Visible = false;
                Label21.Text = "VPS Enterprise";
                Button2.Visible = false;
                labelname.Visible = true;
                TelBox.Visible = true;
                labelemail.Visible = true;
                Label3.Visible = true;
                named.Visible = true;
                emailtextbox.Visible = true;
                project_details.Visible = true;
            }
            else
            {

            }

            if (Request.QueryString["web"] != null)
            {
                Label20.Visible = false;
                Label21.Text = "Hébergement Web";
                Button2.Visible = false;
                labelname.Visible = true;
                TelBox.Visible = true;
                labelemail.Visible = true;
                Label3.Visible = true;
                named.Visible = true;
                emailtextbox.Visible = true;
                project_details.Visible = true;
            }
            else

            if (Request.QueryString["mail"] != null)
            {
                Label20.Visible = false;
                Label21.Text = "Hébergement E-mail";
                Button2.Visible = false;
                labelname.Visible = true;
                labelemail.Visible = true;
                Label3.Visible = true;
                TelBox.Visible = true;
                named.Visible = true;
                emailtextbox.Visible = true;
                project_details.Visible = true;
            }

        }

        protected void named_textchanged(object sender, EventArgs e)
        {
            //Prénom
        }

  


        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            //Password Root
        }



        protected void email_TextChanged(object sender, EventArgs e)
        {
            //Email
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Bouton Ok
            Response.Redirect("/");
        }

        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //Type d'OS
        }

        protected void details_textchanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

           

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TelBox_TextChanged(object sender, EventArgs e)
        {

        }

        [Obsolete]
        protected void validation_click(object sender, EventArgs e)
        {
            // Variables pour l'envoi du mail
            string prenom = named.Text;
            string email = emailtextbox.Text;
            string project = project_details.Text;
            string product = Label21.Text;
            // Paramétre SMTP pour l'envoi du mail
            WebMail.SmtpServer = "ssl0.ovh.net";
            WebMail.SmtpPort = 587;
            WebMail.UserName = "no-reply@synhostinger.fr";
            WebMail.Password = "MBJkt31Jao";
            WebMail.From = "Ne Pas Répondre - <no-reply@synhostinger.fr>";
            WebMail.EnableSsl = true;
            WebMail.Send(to: "contact@synhostinger.com",
            // Envoi du mail avec les variables
            subject: "Pré-commande de " + prenom,
            body: "Hello " + "<br />" + "une nouveau pré-commande est en attente :" + "<br />" + "Type : " + product + "<br /> <br />" + "Prénom : " + prenom + "<br />" + "Email : " + email +  "<br />" + "<br />" + " Description : " + project  + "<br /> <br />" + "Cordialement" + "<br />" + "l'équipe de Synhostinger"
           );

            // Paramétre SMTP pour l'envoi du mail
            WebMail.SmtpServer = "ssl0.ovh.net";
            WebMail.SmtpPort = 587;
            WebMail.UserName = "no-reply@synhostinger.fr";
            WebMail.Password = "MBJkt31Jao";
            WebMail.From = "Ne Pas Répondre - <no-reply@synhostinger.fr>";
            WebMail.EnableSsl = true;
            WebMail.Send(to: email,
            // Envoi du mail avec les variables
            subject: "Confirmation de votre pré-commande",
            body: "Bonjour " + prenom + "<br /><br />" + "Notre équipe à bien reçu votre demande de pré-commande" + "<br />" + "Voici le produit que vous avez sélectionné : " + product + "<br />" + "Nous vous remercions de la confiance que vous nous accordez. Une réponse vous sera apportée dans les prochains jours." + "<br /> <br />" + "Cordialement" + "<br />" + "l'équipe de Synhostinger"
           );

            Page.RegisterStartupScript("myAlert", "<script language=JavaScript>window.alert('Votre demande sera prise en compte dans les plus bref délai');</script>");
            Response.Redirect("/");
        }
    }
}
