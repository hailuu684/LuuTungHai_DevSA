//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight_details_db
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public Nullable<System.DateTime> DepartureDateTime { get; set; }
        public Nullable<System.DateTime> ArrivalDateTime { get; set; }
        public Nullable<System.TimeSpan> FlightDuration { get; set; }
        public Nullable<double> StandardPrice { get; set; }
        public Nullable<int> TotalCapacity { get; set; }
    }
}