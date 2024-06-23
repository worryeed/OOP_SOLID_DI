using OOP_SOLID_DI.Models;

namespace OOP_SOLID_DI.Services.Aerodromes;

public class Aerodrome : IAerodrome
{
    private readonly List<IPlane> _planes = new List<IPlane>();

    public int Count { get => _planes.Count; }
    public IReadOnlyList<IPlane> Planes => _planes.AsReadOnly();

    public void Add(IPlane? plane)
    {
        if (plane == null || _planes.Contains(plane))
        {
            return;
        }

        plane.Land();
        _planes.Add(plane);
    }

    public void Launch(int planeNumber)
    {
        IPlane? plane = _planes.SingleOrDefault(p => p.PlaneNumber == planeNumber);
        if (plane != null)
        {
            plane.Fly();
            _planes.Remove(plane);
        }
    }

    public void Remove(int planeNumber)
    {
        IPlane? plane = _planes.SingleOrDefault(p => p.PlaneNumber == planeNumber);
        if (plane != null)
        {
            _planes.Remove(plane);
        }
    }

    public IPlane? GetPlane(int planeNumber)
    {
        return _planes.SingleOrDefault(plane => plane.PlaneNumber == planeNumber);
    }

    public void Clear()
    {
        _planes.Clear();
    }
}