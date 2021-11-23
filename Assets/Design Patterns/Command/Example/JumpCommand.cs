namespace DesignPatterns.Command.Example
{
    public class JumpCommand : Command
    {
        public override void Execute(IActor actor)
        {
            // example
            actor.Jump();
        }
    }

}
