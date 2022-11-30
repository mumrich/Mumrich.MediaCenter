using System;
using System.Collections.Generic;

using Mumrich.ProtoDomain.Primitives;

namespace Mumrich.ProtoDomain.Events;

public interface IEvent : IReferenceObject, ITimestamped { }

public interface IResponse : IEvent
{
  IEnumerable<Exception> Exceptions { get; }
}

public interface IValueResponse<T> : IResponse, IValueObject<T> { }
