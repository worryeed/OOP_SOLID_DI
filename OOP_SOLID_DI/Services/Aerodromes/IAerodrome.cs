using OOP_SOLID_DI.Models;

namespace OOP_SOLID_DI.Services.Aerodromes;

public interface IAerodrome
{
    int Count { get; }
    IReadOnlyList<IPlane> Planes { get; }
    void Add(IPlane plane);
    void Remove(int planeNumber);
    void Launch(int planeNumber);
    void Clear();
    IPlane? GetPlane(int planeNumber);
}