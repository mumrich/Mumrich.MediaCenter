namespace Mumrich.ProtoDomain
{
  public interface IAggregate<out TModel> where TModel : IEntity
  {
    TModel Model { get; }
  }
}
