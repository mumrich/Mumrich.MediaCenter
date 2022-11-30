namespace Mumrich.ProtoDomain.CQS;

public interface IWithCommand<TCommand> where TCommand : ICommand
{
  void OnCommand(TCommand cmd);
}
