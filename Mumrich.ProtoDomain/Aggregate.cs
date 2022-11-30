using Mumrich.ProtoDomain.Events;
using Mumrich.ProtoDomain.Primitives;

namespace Mumrich.ProtoDomain.Aggregate;

public interface IAggregate<TState> : IReferenceObject
{
  TState State { get; }

  void On(IEvent @event);
}
