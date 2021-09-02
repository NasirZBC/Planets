using System;

public class Planet
{
	//Properties of a planet
	private string name;
	private int diameter;
	private float mass;
	private int density;
	private float gravity;
	private float rotationPeriod;
	private float lengthOfDay;
	private float distanceFromSun;
	private float orbitalPeriod;
	private float orbitalVelocity;
	private int meanTemp;
	private int numberOfMoons;
	private bool ringSystem;

	public Planet(){ }

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public int Diameter
    {
		get { return diameter; }
		set { diameter = value; }
	}
	public float Mass
	{
		get { return mass; }
		set { mass = value; }
	}
	public int Density
	{
		get { return density; }
		set { density = value; }
	}
	public float Gravity
	{
		get { return gravity; }
		set { gravity = value; }
	}
	public float RotationPeriod
	{
		get { return rotationPeriod; }
		set { rotationPeriod = value; }
	}
	public float LengthOfDay
	{
		get { return lengthOfDay; }
		set { lengthOfDay = value; }
	}
	public float DistanceFromSun
	{
		get { return distanceFromSun; }
		set { distanceFromSun = value; }
	}
	public float OrbitalPeriod
	{
		get { return orbitalPeriod; }
		set { orbitalPeriod = value; }
	}
	public float OrbitalVelocity
	{
		get { return orbitalVelocity; }
		set { orbitalVelocity = value; }
	}
	public int MeanTemp
	{
		get { return meanTemp; }
		set { meanTemp = value; }
	}
	public int NumberOfMoons
	{
		get { return numberOfMoons; }
		set { numberOfMoons = value; }
	}
	public bool RingSystem
	{
		get { return ringSystem; }
		set { ringSystem = value; }
	}

}
