namespace BlazerStarterProject.Client.Models.NationalityPredictor;

public record UserInfo
{
    public int Count { get; init; }
    public string? Name { get; init; }
    public CountryInfo[] Country { get; init; }
}