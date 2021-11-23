using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Command
{
    public abstract class Command : ICommand
    {
        public abstract void Execute(IActor actor);

        public virtual void Undo(IActor actor)
        {

        }
    }

}
