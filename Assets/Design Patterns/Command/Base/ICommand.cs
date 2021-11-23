namespace DesignPatterns.Command
{    public interface ICommand
    {
        void Execute(IActor actor);
        void Undo(IActor actor);
    }
}