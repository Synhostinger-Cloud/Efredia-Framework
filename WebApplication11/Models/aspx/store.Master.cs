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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)

        {

            //Activation des label et textbox et changement de label vide en HDD = ?hdd=disque
            if (Request.QueryString["vps"] != null)
            {
                Label20.Visible = false;
                Label21.Text = "Hébergement VPS";
                Button2.Visible = false;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
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
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                project_details.Visible = true;
            }
            else
            {

            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Prénom
        }

  


        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            //Password Root
        }



        protected void TextBox2_TextChanged(object sender, EventArgs e)
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

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

           

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Variables pour l'envoi du mail
            string prenom = TextBox1.Text;
            string email = TextBox2.Text;
            string project = project_details.Text;
            string bodyemail = "C:\\Users\\bastien.LANGUEDOC\\source\\repos\\Synhostinger_Website\\WebApplication11\\Views\\Home\\Processvps.cshtml";
            {
                // Paramétre SMTP pour l'envoi du mail
                WebMail.SmtpServer = "51.210.120.112";
                WebMail.SmtpPort = 25;
                WebMail.UserName = "no-reply@synhostinger.com";
                WebMail.Password = "MBJkt31Jao";
                WebMail.From = "no-reply@synhostinger.com";
                WebMail.EnableSsl = false;
                WebMail.Send(to: "contact@synhostinger.com",
                // Envoi du mail avec les variables
                subject: "Demande de projet -" + prenom,
                body: bodyemail
               );

                // Paramétre SMTP pour l'envoi du mail
                WebMail.SmtpServer = "51.210.120.112";
                WebMail.SmtpPort = 25;
                WebMail.UserName = "no-reply@synhostinger.com";
                WebMail.Password = "MBJkt31Jao";
                WebMail.From = "no-reply@synhostinger.com";
                WebMail.EnableSsl = false;
                WebMail.Send(to: "contact@synhostinger.com",
                // Envoi du mail avec les variables
                isBodyHtml: true,
                subject: "Vérification de votre projet  - Synhostinger",
                body: bodyemail
               );

                Label20.Visible = true;
                Response.Redirect("/Successful");
            }

        }
        protected void TextBox3_TextChanged1(object sender, EventArgs e)
        {

        }

        [Obsolete]
        protected void Button4_Click1(object sender, EventArgs e)
        {
            // Variables pour l'envoi du mail
            string prenom = TextBox1.Text;
            string email = TextBox2.Text;
            string project = project_details.Text;
            string product = Label21.Text;
            // Paramétre SMTP pour l'envoi du mail
            WebMail.SmtpServer = "51.210.120.112";
            WebMail.SmtpPort = 25;
            WebMail.UserName = "no-reply@synhostinger.com";
            WebMail.Password = "MBJkt31Jao";
            WebMail.From = "no-reply@synhostinger.com";
            WebMail.EnableSsl = false;
            WebMail.Send(to: "contact@synhostinger.com",
            // Envoi du mail avec les variables
            subject: "Demande de projet -" + prenom,
            body: "Hello " + "<br />" + "un nouveau projet est en attente :" + "<br />" + "Type : " + product + "<br /> <br />" + "Prénom :" + prenom + "<br />" + "Email :" + email +  "<br />" + " Description :" + project  + "<br /> <br />" + "Cordialement" + "<br />" + "l'équipe de Synhostinger"
           );

            Page.RegisterStartupScript("myAlert", "<script language=JavaScript>window.alert('Ok');</script>");

        }
    }
}