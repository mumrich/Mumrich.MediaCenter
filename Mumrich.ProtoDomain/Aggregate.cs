using Mumrich.ProtoDomain.Events;
using Mumrich.ProtoDomain.Primitives;

namespace Mumrich.ProtoDomain.Aggregate;

public interface IAggregateState<TState> : ITimestamped
{
  IValueResponse<TState> Apply(IEvent @event);
}

public abstract record class AggregateStateBase<TState> : IAggregateState<TState>
{
  private readonly TState _state;

  internal AggregateStateBase(TState newState, ZonedDateTime? timeStamp = null)
  {
    TimeStamp = timeStamp ?? ZonedDateTime.NewUtcNowZonedDateTime();
    _state = newState;
  }

  public ZonedDateTime TimeStamp { get; }

  public abstract IValueResponse<TState> Apply(IEvent @event);
}
