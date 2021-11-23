using UnityEngine;

namespace DesignPatterns.Command.Example
{
    public delegate void CommandCallback(Command command);
    public class CommandManager : MonoBehaviour
    {
        public static event CommandCallback OnCommandRaise;

        private JumpCommand jumpCommand;
        private void Awake()
        {
            jumpCommand = new JumpCommand();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnCommandRaise?.Invoke(jumpCommand);
            }
        }
    }

}
