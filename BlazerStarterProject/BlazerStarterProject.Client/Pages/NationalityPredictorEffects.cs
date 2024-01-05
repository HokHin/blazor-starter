using System.Net.Http.Json;
using BlazerStarterProject.Client.Models.NationalityPredictor;
using Fluxor;

namespace BlazerStarterProject.Client.Pages;

public class NationalityPredictorEffects(HttpClient http)
{
    [EffectMethod(typeof(NationalityPredictorActions.GetUserAction))]
    public async Task GetUser(IDispatcher dispatcher)
    {
        var user = await http.GetFromJsonAsync<UserInfo>("https://api.nationalize.io/?name=nathaniel");
        dispatcher.Dispatch(new NationalityPredictorActions.LoadUserAction(user));
    }
}