using System;

using Mumrich.ProtoDomain.Aggregate;
using Mumrich.ProtoDomain.Events;

namespace Mumrich.MediaCenter.Domain.Aggregates;

public record class MediaFileAggregateState : AggregateStateBase<MediaFileAggregateState>
{
  protected MediaFileAggregateState(AggregateStateBase<MediaFileAggregateState> original)
    : base(original) { }

  public override IValueResponse<MediaFileAggregateState> Apply(IEvent @event)
  {
    throw new NotImplementedException();
  }
}
