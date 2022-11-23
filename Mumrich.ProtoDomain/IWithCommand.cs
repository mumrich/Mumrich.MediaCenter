namespace Mumrich.ProtoDomain;

public interface IWithCommand<TCommand> where TCommand : ICommand
{
  void OnCommand(TCommand cmd);
}
