using System;
using System.ComponentModel.Design.Serialization;

public class Plane
{
	public Plane(string reg, Airline AL)
	{
		registration = reg;
		airline = AL;
	}


	public string registration { get; set; }
	//public PlaneModel airline {get; set; }
	public Airline airline { get; set; }
	public double totalFlightHours { get; set; }
	public double HoursToACheck { get; set; } = 160;
	public double HoursToBCheck { get; set; } = 750;
	public double HoursToCCheck { get; set; } = 2500;
	public double HoursToDCheck { get; set; } = 10000;


	public void PerformACheck()
	{
		HoursToACheck = 160;
	}
	public void PerformBCheck()
	{
		HoursToBCheck = 750;
		PerformACheck();
	}
	public void PerformCCheck()
	{
		HoursToCCheck = 2500;
		PerformBCheck();
	}
	public void PerformDCheck()
	{
		HoursToDCheck = 10000;
		PerformCCheck();
	}
}