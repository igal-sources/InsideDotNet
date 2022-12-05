using System;

namespace InsideDotNet.InsideDemos
{
    // interface declaration
    internal interface IVehicle
    {
        void changeGear(int newGear);
        void speedUp(int increment);
        void applyBrakes(int decrement);
        void doSomthing();
        int SomeValue { get; set; }
    }

    // class implements interface
    internal class Bicycle : IVehicle
    {
        private int speed;
        private int gear;

        public int SomeValue 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public void doSomthing()
        {
            throw new NotImplementedException();
        }

        // to change gear
        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        // to increase speed
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        // to decrease speed
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +
                              " gear: " + gear);
        }
    }

    // class implements interface
    internal class Bike : IVehicle
    {
        private int speed;
        private int gear;

        // to change gear
        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        // to increase speed
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        // to decrease speed
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +
                              " gear: " + gear);
        }

        public int SomeValue
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void doSomthing()
        {
            throw new NotImplementedException();
        }
    }

    public class InterfaceDemo
    {
        public void PopulateVehicles()
        {
            // creating an instance of Bicycle  
            // doing some operations  
            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBrakes(1);

            Console.WriteLine("Bicycle present state :");
            bicycle.printStates();

            // creating instance of bike. 
            Bike bike = new Bike();
            bike.changeGear(1);
            bike.speedUp(4);
            bike.applyBrakes(3);

            Console.WriteLine("Bike present state :");
            bike.printStates();
        }
    }
}