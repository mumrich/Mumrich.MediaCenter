using Mumrich.ProtoDomain.Primitives;

namespace Mumrich.ProtoDomain.Aggregate;

public interface IAggregate<TState> : IReferenceObject
{
  TState State { get; }
}
