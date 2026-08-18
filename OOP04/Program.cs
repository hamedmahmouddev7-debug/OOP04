using System.Diagnostics.Contracts;

namespace OOP04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Question01
            // a) Abstraction means hiding complex implementation details and showing only the important information.

            // b) Because it reduces complexity and helps organize the code by focusing on what an object does rather than how it does it.
            #endregion

            #region Question02
            /*a) Difference:

            Abstract Class: Can contain abstract methods, normal methods, fields, and constructors.
            Interface: Defines a contract that a class must follow.

            b) Choose an Interface when different classes need to share the same behavior, even if they are not related by inheritance.

            c)  A class cannot inherit from multiple abstract classes.
                A class can implement multiple interfaces.
            */
            #endregion

            #endregion


            #region Part02
            /*
            var addr1 = new DeliveryAddress("12 Nile St", "Cairo", "Egypt");
            var addr2 = new DeliveryAddress("5 Tahrir Sq", "Cairo", "Egypt");
            var addr3 = new DeliveryAddress("22 Berliner Str", "Berlin", "Germany");

            
            var standard = new StandardShipment("SH001", "Laptop", 15, 50, addr1);
            var express = new ExpressShipment("SH002", "Documents", 10, 40, addr2, 30);
            var international = new InternationalShipment("SH003", "Electronics", 20, 60, addr3);

            
            var center = new DeliveryCenter();
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            
            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine();

           
            center.PrintTrackingStatuses();
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine();

            
            PrintInsuranceReport(center.GetShipments());

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

        
            ITrackable[] trackables = { standard, express, international };
            foreach (var t in trackables)
                DeliveryReport.PrintShipment(t);

            
            IInsurable[] insurables = { standard, express, international };
            foreach (var ins in insurables)
                DeliveryReport.PrintInsurance(ins);
            
        }

        static void PrintInsuranceReport(System.Collections.Generic.List<Shipment> shipments)
        {
            foreach (var s in shipments)
            {
                string label = s switch
                {
                    StandardShipment => "Standard Shipment",
                    ExpressShipment => "Express Shipment",
                    InternationalShipment => "International Shipment",
                    _ => "Shipment"
                };
                decimal insurance = ((IInsurable)s).CalculateInsurance();
                Console.WriteLine($"{label} Insurance : {insurance:0.00} EGP");
            }
             */
            #endregion
        }


    }

       
    }