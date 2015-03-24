using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppeveliEmailTask
{
    class AppeveliEmailTasks
    {
        //Create a method to open the EmailComposeTask
        //Pass five parameters: Subject, Body, Email Recepitant, CC, and Bcc
        public void sendEmailMessage(string subject, string body, string emailRecepitant, string Cc, string Bcc) 
        {
            EmailComposeTask appeveliComposeTask = new EmailComposeTask();

            appeveliComposeTask.Subject = subject;
            appeveliComposeTask.Body = body;
            appeveliComposeTask.To = emailRecepitant;
            appeveliComposeTask.Cc = Cc;
            appeveliComposeTask.Bcc = Bcc;

            appeveliComposeTask.Show();
        }

        //Create method for only one recepitant
        //Only pass three parameters: Subject, Body, Recepitant
        public void sendToOneReceiptant(string subject, string body, string recepitant)
        {
            EmailComposeTask appeveliComposeTask = new EmailComposeTask();

            appeveliComposeTask.Subject = subject;
            appeveliComposeTask.Body = body;
            appeveliComposeTask.To = recepitant;
        }

        
    }
}
