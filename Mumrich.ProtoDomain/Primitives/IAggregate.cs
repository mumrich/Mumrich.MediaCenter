namespace Mumrich.ProtoDomain.Primitives
{
  public interface IAggregate<TModel> : IEntity
  {
    TModel Model { get; }
  }
}
