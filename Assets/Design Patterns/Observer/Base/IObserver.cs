namespace DesignPatterns.Observer
{
    using System;
    public interface IObserver<in T> where T : EventArgs
    {
        void OnNotify(object sender, T e);
    }
}