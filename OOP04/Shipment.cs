using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
   

    //public abstract class Shipment
    //{
    //    public string TrackingCode { get; private set; }
    //    public string Description { get; private set; }
    //    public decimal Weight { get; private set; }
    //    public decimal DeliveryFee { get; private set; }
    //    public DeliveryAddress Destination { get; private set; }

    //    protected Shipment(string trackingCode, string description, decimal weight,
    //                        decimal deliveryFee, DeliveryAddress destination)
    //    {
    //        if (string.IsNullOrWhiteSpace(trackingCode))
    //            throw new ArgumentException("Tracking code cannot be empty.");
    //        if (string.IsNullOrWhiteSpace(description))
    //            throw new ArgumentException("Description cannot be empty.");
    //        if (weight <= 0)
    //            throw new ArgumentException("Weight must be greater than zero.");
    //        if (deliveryFee < 0)
    //            throw new ArgumentException("Delivery fee cannot be negative.");
    //        if (destination == null)
    //            throw new ArgumentNullException(nameof(destination));

    //        TrackingCode = trackingCode;
    //        Description = description;
    //        Weight = weight;
    //        DeliveryFee = deliveryFee;
    //        Destination = destination;
    //    }

    //    // Abstract members every shipment type must implement
    //    public abstract decimal EstimatedCost { get; }
    //    public abstract void PrintShipment();
    //}
}
