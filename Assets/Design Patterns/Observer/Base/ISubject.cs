namespace DesignPatterns.Observer
{
    using System;
    using System.Collections.Generic;

    public interface ISubject<T> where T : EventArgs
    {
        List<IObserver<T>> Observers { get; }
        void Register(IObserver<T> observer);
        void UnRegister(IObserver<T> observer);

        void Raise(object sender, T eventArgs);
    }
}