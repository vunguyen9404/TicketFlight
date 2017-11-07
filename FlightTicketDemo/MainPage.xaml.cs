using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FlightTicketDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Flight> flights { get; set; }
        private ObservableCollection<FlightDetails> flightDetails { get; set; }
        private PassengerProfile passProfiles { get; set; }
        private ObservableCollection<CreditCardDetails> credits { get; set; }
        private ObservableCollection<TicketInfo> ticketInfo { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            passProfiles = new PassengerProfile
            {
                profile_id = "1",
                password = "123",
                first_name = "Nguyen",
                last_name = "Vu",
                address = "HaNoi, VN",
                tel_no = "01256655019",
                email = "vunvd00172@fpt.edu.vn"
            };
            txtPassName.Text = passProfiles.first_name + " " + passProfiles.last_name;
            txtPassAddress.Text = passProfiles.address;
            txtPassEMail.Text = passProfiles.email;

            flights = new ObservableCollection<Flight>();

            flights.Add(new Flight { Flight_id = "1", airline_id ="1", airline_name="VN Airline", arrival_time=new DateTime().AddDays(2), depature_time=new DateTime().AddDays(1), duration=10000, from_location="Hn, VN", to_location="HCM, Vn", total_seals=3 });
            flights.Add(new Flight { Flight_id = "2", airline_id = "3", airline_name = "VN Airline", arrival_time = new DateTime().AddDays(2), depature_time = new DateTime().AddDays(1), duration = 10000, from_location = "HN, VN", to_location = "LA, US", total_seals = 1 });

            flightDetails = new ObservableCollection<FlightDetails>();
            flightDetails.Add(new FlightDetails {
                flight=flights.ElementAt(0),
                flight_depature_time = new DateTime().AddDays(1),
                price = 1333,
                available_seals = 1000
            });

            flightDetails.Add(new FlightDetails
            {
                flight = flights.ElementAt(1),
                flight_depature_time = new DateTime().AddDays(2),
                price = 1333,
                available_seals = 1000
            });


            credits = new ObservableCollection<CreditCardDetails>();
            credits.Add(new CreditCardDetails
            {
                profile = passProfiles,
                card_number = "4421 44986 7876 9292",
                card_type = " Visa Debit",
                expiration_month = 10,
                expiration_year = 22
            });

            credits.Add(new CreditCardDetails
            {
                profile = passProfiles,
                card_number = "4421 44986 7876 9292",
                card_type = " Visa Credit",
                expiration_month = 10,
                expiration_year = 22
            });

            ticketInfo = new ObservableCollection<TicketInfo>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FlightDetails fd = cbFlight.SelectedValue as FlightDetails;
            CreditCardDetails credit = cbCredit.SelectedValue as CreditCardDetails;

            ticketInfo.Add(new TicketInfo
            {
                ticket_id = ticketInfo.Count + 1 + "",
                profile = passProfiles,
                flightDetails = fd,
                status = "OK"
            });
        }
    }
}
