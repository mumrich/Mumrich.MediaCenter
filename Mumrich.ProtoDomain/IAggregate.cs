namespace Mumrich.ProtoDomain
{
  public interface IAggregate<TModel> : IEntity
  {
    TModel Model { get; }
  }
}
