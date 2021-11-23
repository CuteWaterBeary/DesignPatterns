using DesignPatterns.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IObserver = DesignPatterns.Observer.IObserver<Coin>;

public class Coin : EventArgs, ISubject<Coin>
{
    public int amount = 5;

    public void SetAmount(object from, int value)
    {
        if (amount == value)
            return;

        amount = value;
        Raise(from, this);
    }

    #region Observer Pattern
    private List<IObserver> observers;
    public List<IObserver> Observers { get => observers; set => observers = value; }
    public void Raise(object sender, Coin eventArgs)
    {
        observers.ForEach((x) => x.OnNotify(sender, eventArgs));
    }

    public void Register(DesignPatterns.Observer.IObserver<Coin> observer)
    {
        if (observers.Contains(observer))
            return;

        observers.Add(observer);
    }

    public void UnRegister(DesignPatterns.Observer.IObserver<Coin> observer)
    {
        if (!observers.Contains(observer))
            return;

        observers.Remove(observer);
    }
    #endregion
}

public class ObserverExample : MonoBehaviour, IObserver
{
    private Coin coin;

    private void Start()
    {
        Coin _coin = new Coin();
        _coin.Register(this);
        _coin.SetAmount(this, 5);
    }

    public void OnNotify(object sender, Coin e)
    {
        // we can get update event also we can make dependency inject
        coin = e;

        Debug.Log("Coin injected.");
        Debug.Log("Coin updated.");
    }
}
