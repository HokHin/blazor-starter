using Fluxor;

namespace BlazerStarterProject.Client.Pages;

public class NationalityPredictorReducers
{
    [ReducerMethod]
    public static NationalityPredictorStore OnGetUsers(NationalityPredictorStore state,
        NationalityPredictorActions.LoadUserAction action)
    {
        return state with
        {
            User = action.UserInfo
        };
    }

    [ReducerMethod]
    public static NationalityPredictorStore OnLoadUsers(NationalityPredictorStore state,
        NationalityPredictorActions.UserSetInitializedAction action)
    {
        return state with
        {
            Initialized = true
        };
    }
}