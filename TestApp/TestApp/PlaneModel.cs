using System;

public class PlaneModel
{
	public PlaneModel(string man, string mod, int e, int b, int f)
	{
		Manufacturer = man;
		Model = mod;
		economySeats = e;
		businessSeats = b;
		firstSeats = f;
	}

	public string Manufacturer { get; set; }
	public string Model { get; set; }
	public int economySeats { get; set; }
	public int businessSeats { get; set; }
	public int firstSeats { get; set; }
}
