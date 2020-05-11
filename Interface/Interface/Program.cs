using System;

namespace Interface
{
    

   

    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Geo", "what up?", "6/12/2018");
            Notification n2 = new Notification("Frank", "Blessed", "6/12/2018");
            n1.showNotifications();
            n2.showNotifications();

            Console.ReadKey();
        }
    }
}
