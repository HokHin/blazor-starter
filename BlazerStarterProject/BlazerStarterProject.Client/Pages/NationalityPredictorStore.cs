using BlazerStarterProject.Client.Models.NationalityPredictor;

namespace BlazerStarterProject.Client.Pages;

public record NationalityPredictorStore
{
    public bool Initialized { get; init; }
    public UserInfo? User { get; init; }
}