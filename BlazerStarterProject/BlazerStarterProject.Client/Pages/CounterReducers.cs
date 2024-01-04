using Fluxor;

namespace BlazerStarterProject.Client.Pages;

public static class CounterReducers
{
    [ReducerMethod(typeof(CounterActions.CounterIncrementAction))]
    public static CounterStore OnIncrement(CounterStore state)
    {
        return state with
        {
            CurrentCount = state.CurrentCount + 1
        };
    }

    [ReducerMethod(typeof(CounterActions.CounterResetAction))]
    public static CounterStore OnReset(CounterStore state)
    {
        return state with
        {
            CurrentCount = 0
        };
    }

    [ReducerMethod(typeof(CounterActions.CounterDecrementAction))]
    public static CounterStore OnDecrement(CounterStore state)
    {
        return state with
        {
            CurrentCount = state.CurrentCount - 1
        };
    }
}