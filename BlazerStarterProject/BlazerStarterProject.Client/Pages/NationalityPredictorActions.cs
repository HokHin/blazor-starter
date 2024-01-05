using BlazerStarterProject.Client.Models.NationalityPredictor;

namespace BlazerStarterProject.Client.Pages;

public abstract class NationalityPredictorActions
{
    public class UserSetInitializedAction
    {
    }

    public class LoadUserAction(UserInfo userInfo)
    {
        public UserInfo UserInfo { get; } = userInfo;
    }

    public class GetUserAction
    {
    }
}