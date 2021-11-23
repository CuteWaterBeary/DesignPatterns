using DesignPatterns.Command;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command.Example
{
    public class CommandHandler : MonoBehaviour
    {
        [SerializeField] private Player actor;
        private void CommandManager_OnCommandRaise(Command command)
        {
            command.Execute(actor);
        }
        private void OnEnable()
        {
            CommandManager.OnCommandRaise += CommandManager_OnCommandRaise;
        }
        private void OnDisable()
        {
            CommandManager.OnCommandRaise -= CommandManager_OnCommandRaise;
        }
    }

}
