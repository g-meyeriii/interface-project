using System;
using System.Collections.Generic;
using System.Text;

namespace Interface

    { public class Notification : INotifications
        {
            private string sender;
            private string message;
            private string date;

            //default constructor
            public Notification()
            {
                sender = "Admin";
                message = "What's up?";
                date = "";
            }
            public Notification(string mySender, string myMessage, string myDate)
            {
                this.sender = mySender;
                this.message = myMessage;
                this.date = myDate;
            }
            public void showNotifications()
            {
                Console.WriteLine("Message {0} was send by {1} at {2}", message, sender, date);
            }
            public string getDate()
            {
                return date;
            }
        }
    }

