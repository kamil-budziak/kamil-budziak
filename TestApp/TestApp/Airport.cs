using System;

public class Airport
{
	public Airport(string code, string name)
	{
		IataCode = code;
		Name = name;
	}

	public string IataCode { get; set; }
	public string Name { get; set; }
	public double TimeZone { get; set; }
}
