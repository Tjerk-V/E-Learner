using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

class Mailer
{
    public static void Send(Stream pdfFile, string name, string date)
    {
        return;
        Attachment attachment = new(pdfFile, "Cursus.pdf");
        MailMessage mailMessage = new()
        {
            From = new MailAddress(""),
            Subject = "ADR-Cursus",
            Body = "ADR-Cursus gemaakt door: "+name,
        };
        mailMessage.To.Add("tjerk_veenstra@outlook.com");
        mailMessage.Attachments.Add(attachment);

        SmtpClient smtpClient = new()
        {
            Host = "smtp-relay.sendinblue.com",
            Port = 587,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("", ""),
            EnableSsl = true
        };

        try
        {
            smtpClient.Send(mailMessage);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Error: " + ex.Message);
        }
    }
}

