using System;

public class Flight
{
	public Flight(string fn, Plane p, DateTime dt, DateTime at, Airport da, Airport aa)
	{
		FlightNumber = fn;
		plane = p;
		DepartureTime = dt;
		ArrivalTime = at;
		DepartureAirport = da;
		ArrivalAirport = aa;
	}

	public string FlightNumber { get; set; }
	public Plane plane { get; set; }
	public DateTime DepartureTime { get; set; }
	public DateTime ArrivalTime { get; set; }
	public Airport DepartureAirport { get; set; }
	public Airport ArrivalAirport { get; set; }
}
