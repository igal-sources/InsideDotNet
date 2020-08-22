using System;

namespace InsideDotNet
{
    public class Shipment
    {
        private string trackingnumber;

        // The delegate procedure we are assigning to our object
        public delegate void ShipmentHandler(object myObject, ShipArgs myArgs);

        public event ShipmentHandler OnShipmentMade;

        public string TrackingNumber
        {
            set
            {
                trackingnumber = value;

                // We need to check whether a tracking number
                // was assigned to the field.
                if (trackingnumber.Length != 0)
                {
                    ShipArgs myArgs = new ShipArgs("Item has been shipped.");

                    // Tracking number is available, raise the event.
                    OnShipmentMade(this, myArgs);
                }
            }
        }

        public Shipment()
        {
        }
    }

    public class ShipArgs : EventArgs
    {
        private string message;

        public ShipArgs(string message)
        {
            this.message = message;
        }

        // This is a straightforward implementation for
        // declaring a public field
        public string Message
        {
            get { return message; }
        }
    }

    internal class EventsDemo
    {
        internal void EventsExample()
        {
            // we will create our instance
            Shipment myItem = new Shipment();

            // we need to add the delegate event to new object
            myItem.OnShipmentMade += new Shipment.ShipmentHandler(ShowUserMessage);

            // we assumed that the item has been just shipped and
            // we are assigning a tracking number to it.
            myItem.TrackingNumber = "1ZY444567";

            // The common procedure to see what is going on the
            // console screen
            Console.Read();
        }

        private static void ShowUserMessage(object a, ShipArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}