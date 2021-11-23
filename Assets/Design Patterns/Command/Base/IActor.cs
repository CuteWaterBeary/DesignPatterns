using UnityEngine;

namespace DesignPatterns.Command
{
    public interface IActor
    {
        void Jump();
        Transform transform { get; }
    }
}