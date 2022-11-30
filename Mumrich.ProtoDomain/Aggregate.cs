using Mumrich.ProtoDomain.Events;
using Mumrich.ProtoDomain.Primitives;

namespace Mumrich.ProtoDomain.Aggregate;

public interface IAggregateState : IReferenceObject
{
  IValueResponse<IAggregateState> Apply(IEvent @event);
}
