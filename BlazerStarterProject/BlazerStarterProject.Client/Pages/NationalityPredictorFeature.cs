using BlazerStarterProject.Client.Models.NationalityPredictor;
using Fluxor;

namespace BlazerStarterProject.Client.Pages;

public class NationalityPredictorFeature : Feature<NationalityPredictorStore>
{
    public override string GetName()
    {
        return "NationaityPredictor";
    }

    protected override NationalityPredictorStore GetInitialState()
    {
        return new NationalityPredictorStore
        {
            User = new UserInfo()
        };
    }
}