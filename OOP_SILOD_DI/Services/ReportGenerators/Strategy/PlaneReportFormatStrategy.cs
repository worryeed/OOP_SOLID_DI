using OOP_SOLID_DI.Models;
using System.Text;

namespace OOP_SOLID_DI.Services.ReportGenerators.Strategy;

public class PlaneReportFormatStrategy : IReportFormatStrategy<IPlane>
{
    public string? Format(List<IPlane> values)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("===============Report===============");
        foreach (IPlane value in values)
        {
            stringBuilder.AppendLine($"Number: {value.PlaneNumber}, Name: {value.Name}, NumberSeats: {value.NumberSeats} State: {value.State}");
        }
        stringBuilder.AppendLine("=================End================");
        return stringBuilder.ToString();
    }
}