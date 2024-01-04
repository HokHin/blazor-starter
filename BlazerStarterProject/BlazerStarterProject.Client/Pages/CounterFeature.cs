using Fluxor;

namespace BlazerStarterProject.Client.Pages;

public class CounterFeature : Feature<CounterStore>
{
    public override string GetName()
    {
        return "Counter";
    }

    protected override CounterStore GetInitialState()
    {
        return new CounterStore
        {
            CurrentCount = 0
        };
    }
}