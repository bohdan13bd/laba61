using System;
using System.Collections.Generic;

// Абстрактний клас Транспортний засіб
public abstract class Vehicle
{
    public double Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

// Клас Людина
public class Human
{
    public double Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is moving.");
    }
}

// Спадкоємці від Транспортного засобу
public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving.");
    }
}

public class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bus is moving.");
    }
}

public class Train : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Train is moving.");
    }
}

// Клас Маршрут
public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public Route(string startPoint, string endPoint)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
    }
}

// Клас Транспортна мережа
public class TransportNetwork
{
    private List<Vehicle> vehicles;
    private Route currentRoute;

    public TransportNetwork()
    {
        vehicles = new List<Vehicle>();
        currentRoute = null;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void SetRoute(Route route)
    {
        currentRoute = route;
    }

    public void MoveAllVehicles()
    {
        if (currentRoute == null)
        {
            Console.WriteLine("No route set.");
            return;
        }

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();

        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        Route route = new Route("City A", "City B");
        network.SetRoute(route);

        network.MoveAllVehicles();
    }
}
