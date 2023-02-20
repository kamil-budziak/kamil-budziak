namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Airline> airlines = new List<Airline>();
            string[] airlines_str = null;
            if (File.Exists("airlines.txt"))
            {
                airlines_str = File.ReadAllLines("airlines.txt");
            }
            foreach(string s in airlines_str)
            {
                Airlines.Add(new Airline(s));
            }
            string[] airports_str = null;
            if (File.Exists("airports.txt"))
            {
                airports_str = File.ReadAllLines("airports.txt");
            }
            foreach (string s in airports_str)
            {
                string[] ap_arr = s.Split('\t');
                Airports.Add(new Airport(ap_arr[0], ap_arr[1]));
            }
            string[] planes_str = null;
            if (File.Exists("planes.txt"))
            {
                planes_str = File.ReadAllLines("planes.txt");
            }
            foreach (string s in planes_str)
            {
                string[] p_arr = s.Split("\t");
                Planes.Add(new Plane(p_arr[0], Airlines.Find(al => al.Name == p_arr[1])));
            }
            string[] flights_str = null;
            if (File.Exists("flights.txt"))
            {
                flights_str = File.ReadAllLines("flights.txt");
            }
            foreach(string f in flights_str)
            {
                try
                {
                    string[] f_arr = f.Split('\t');
                    string flightNumber = f_arr[0];
                    string plane_str = f_arr[1];
                    string depTime_str = f_arr[2];
                    string depAP_str = f_arr[3];
                    string arrTime_str = f_arr[4];
                    string arrAP_str = f_arr[5];
                    Plane plane = Planes.Find(p => p.registration == plane_str);
                    DateTime depTime = DateTime.Parse(depTime_str);
                    DateTime arrTime = DateTime.Parse(arrTime_str);
                    Airport depAP = Airports.Find(a => a.IataCode == depAP_str);
                    Airport arrAP = Airports.Find(a => a.IataCode == arrAP_str);
                    Flights.Add(new Flight(flightNumber, plane, depTime, arrTime, depAP, arrAP));
                }
                catch(Exception ex)
                {

                }
            }
            foreach(Flight f in Flights)
            {
                DataGridViewRow r = new DataGridViewRow();
                FlightsView.Rows.Add(r);
                int index = FlightsView.Rows.Count - 1;
                FlightsView.Rows[index].Cells[0].Value = f.FlightNumber;
                FlightsView.Rows[index].Cells[1].Value = f.plane.airline.Name;
                FlightsView.Rows[index].Cells[2].Value = f.DepartureAirport.Name;
                FlightsView.Rows[index].Cells[3].Value = f.DepartureTime.ToString();
                FlightsView.Rows[index].Cells[4].Value = f.ArrivalTime.ToString();
                FlightsView.Rows[index].Cells[5].Value = f.ArrivalAirport.Name;

            }
        }
        public List<Airline> Airlines = new List<Airline>();
        public List<Flight> Flights = new List<Flight>();
        public List<Plane> Planes = new List<Plane>();
        public List<Airport> Airports = new List<Airport>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}