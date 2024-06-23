namespace OOP_SOLID_DI.Models;

public class Plane : IPlane
{
    public int PlaneNumber { get; private set; }
    public string? Name { get; private set; }
    public int NumberSeats { get; private set; }
    public PlaneState State { get; private set; } = PlaneState.OnGround;

    public Plane(int planeNumber, string? name, int numberSeats)
    {
        PlaneNumber = planeNumber;
        Name = name;
        NumberSeats = numberSeats;
    }

    public void Land()
    {
        State = PlaneState.OnGround;
    }

    public void Fly()
    {
        State = PlaneState.Flying;
    }
}