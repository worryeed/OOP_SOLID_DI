namespace OOP_SOLID_DI.Models;

public interface IPlane
{
    int PlaneNumber { get; }
    string? Name { get; }
    int NumberSeats { get; }
    PlaneState State { get; }
    void Fly();
    void Land();
}