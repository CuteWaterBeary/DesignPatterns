using UnityEngine;

public delegate void StateCallBack(State args);
public abstract class StateMachine : MonoBehaviour
{
    // Fields
    protected State _currentState;

    // Events
    public static event StateCallBack OnStateChanged;
    private void Start()
    {
        Initializing();
    }
    protected abstract void Initializing();

    private void Update()
    {
        if (_currentState != null)
            _currentState.OnUpdate();
    }

    private void FixedUpdate()
    {
        if (_currentState != null)
            _currentState.OnFixedUpdate();
    }

    public void SetState(State state)
    {
        if (_currentState != null)
            _currentState.OnDisable();

        _currentState = state;
        _currentState.OnEnable();

        OnStateChanged?.Invoke(state);
    }
}
