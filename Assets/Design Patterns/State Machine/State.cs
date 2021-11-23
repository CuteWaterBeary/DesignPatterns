using System.Collections;
using System.Collections.Generic;

public abstract class State
{
    protected readonly StateMachine _system;
    public State(StateMachine system)
    {
        _system = system;
    }

    public abstract void OnUpdate();
    public abstract void OnFixedUpdate();
    public abstract void OnDisable();
    public abstract void OnEnable();
}
