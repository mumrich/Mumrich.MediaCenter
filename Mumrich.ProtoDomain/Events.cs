using System.Collections.Generic;

using Mumrich.ProtoDomain.Primitives;

namespace Mumrich.ProtoDomain.Events;

public interface IEvent : IReferenceObject, ITimestamped { }

public interface INotification
{
  string Message { get; }
}

public interface IResponse : IEvent
{
  bool Success { get; }
  IEnumerable<INotification> Notifications { get; }
}

public interface IValueResponse<T> : IResponse, IValueObject<T> { }
