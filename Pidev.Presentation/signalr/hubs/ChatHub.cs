using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;


namespace Pidev.Presentation.signalr.hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message, string image)
        {
         //   utilisateur user = serviceUtilisateur.GetById(Int32.Parse(id));
            string dt = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

        

            Clients.All.addNewMessageToPage(name, message, dt, "/content/Uploads/" + image);
        }

    }
}