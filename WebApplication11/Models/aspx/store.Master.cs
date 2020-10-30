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
            if (Request.QueryString["vps-ssd"] != null)
            {
                Label6.Text = "SSD" + Request.QueryString["product"];
                Label20.Visible = false;
                Button2.Visible = false;
                Button3.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                RadioButtonList1.Visible = true;
            }
            else
            {

            }
            //Activation des label et textbox et changement de label vide en HDD = ?hdd=disque
            if (Request.QueryString["vps-sas"] != null)
            {
                Label20.Visible = false;
                Label6.Text = "HDD" + Request.QueryString["product"];
                Button2.Visible = false;
                Button3.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                RadioButtonList1.Visible = true;
            }
            else
            {

            }


            if (Request.QueryString["web"] != null)
            {
                Label20.Visible = false;
                Label6.Text = "" + Request.QueryString["product"];
                Button2.Visible = false;
                Button4.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label3.Text = "Nom de domaine";
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                RadioButtonList1.Visible = false;
                TextBox3.TextMode = TextBoxMode.SingleLine;
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

            // Variables pour l'envoi du mail
            string prenom = TextBox1.Text;
            string email = TextBox2.Text;
            string disque = Label6.Text;
            string rootpassword = TextBox3.Text;
            string os = RadioButtonList1.Text;
            var mailpro = Request["bastien@languedoc.ovh"];
            var errorMessage = "";
            try
            {
                // Paramétre SMTP pour l'envoi du mail
                WebMail.SmtpServer = "109.190.208.17";
                WebMail.SmtpPort = 25;
                WebMail.UserName = "bastien@languedoc.ovh";
                WebMail.Password = "Bas160698";
                WebMail.From = "bastien@languedoc.ovh";
                WebMail.EnableSsl = false;
                WebMail.Send(to: "bastien@languedoc.ovh",
                // Envoi du mail avec les variables
                subject: "Email de  - " + prenom,
                body: "email : " + email + " Mot de passe root : " + rootpassword + " Os : " + os + " Type disque : " + disque
               );

                // Paramétre SMTP pour l'envoi du mail vers client
                WebMail.SmtpServer = "109.190.208.17";
                WebMail.SmtpPort = 25;
                WebMail.UserName = "bastien@languedoc.ovh";
                WebMail.Password = "Bas160698";
                WebMail.From = "bastien@languedoc.ovh";
                WebMail.EnableSsl = false;
                WebMail.Send(to: "bastien@languedoc.ovh",
                // Envoi du mail avec les variables
                isBodyHtml: true,
                subject: "Commande en cours  - Languedoc-Network",
                body: "Bonjour " + prenom + "</br>" + "voici un récap </br> " + " Mot de passe root : " + rootpassword + " </br> Os : " + os + " Type disque : " + disque
               );

                Response.Redirect("/Successful");

            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            // Variables pour l'envoi du mail
            string prenom = TextBox1.Text;
            string email = TextBox2.Text;
            string ndd = TextBox3.Text;
            var mailpro = Request["bastien@languedoc.ovh"];
            var errorMessage = "";
            try
            {
                // Paramétre SMTP pour l'envoi du mail
                WebMail.SmtpServer = "109.190.208.17";
                WebMail.SmtpPort = 25;
                WebMail.UserName = "bastien@languedoc.ovh";
                WebMail.Password = "Bas160698";
                WebMail.From = "bastien@languedoc.ovh";
                WebMail.EnableSsl = false;
                WebMail.Send(to: "bastien@languedoc.ovh",
                // Envoi du mail avec les variables
                subject: "Email de  - " + prenom,
                body: "email : " + email + " Nom de domaine : " + ndd
               );
                Response.Redirect("/Successful");

            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

        }

        protected void TextBox3_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}