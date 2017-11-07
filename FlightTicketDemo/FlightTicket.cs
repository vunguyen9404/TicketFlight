using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketDemo
{
    class Flight
    {
        public string Flight_id { get; set; }
        public string airline_id { get; set; }
        public string airline_name { get; set; }
        public string from_location { get; set; }
        public string to_location { get; set; }
        public DateTime depature_time { get; set; }
        public DateTime arrival_time { get; set; }
        public long duration { get; set; }
        public int total_seals { get; set; }
    }

    class FlightDetails
    {
        public Flight flight { get; set; }
        public DateTime flight_depature_time { get; set; }
        public double price { get; set; }
        public int available_seals { get; set; }
    }

    class CreditCardDetails
    {
        public PassengerProfile profile { get; set; }
        public string card_number { get; set; }
        public string card_type { get; set; }
        public int expiration_month {get; set;}
        public int expiration_year { get; set; }
    }
    class PassengerProfile
    {
        public string profile_id { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string tel_no { get; set; }
        public string email { get; set; }
    }

    class TicketInfo
    {
        public string ticket_id { get; set; }
        public PassengerProfile profile { get; set; }
        public FlightDetails flightDetails { get; set; }
        public string status { get; set; }
    }
}
