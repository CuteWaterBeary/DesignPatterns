using UnityEngine;

namespace DesignPatterns.Command.Example
{
    public class Player : MonoBehaviour, IActor
    {
        public void Jump()
        {
            Debug.Log("Player jumped.");
        }
    }

}
