using System;
using System.Collections.Generic;

public class Airline
{
	public Airline(string n)
	{
		Planes = new List<Plane>();
		Name = n;
	}
	public List<Plane> Planes { get; set; }
	public string Name { get; set; }
}
