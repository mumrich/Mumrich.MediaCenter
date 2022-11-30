using System;
using System.Collections.Generic;

namespace Mumrich.ProtoDomain.Primitives;

/// <summary>
/// https://de.wikipedia.org/wiki/Value_Object
/// </summary>
public interface IValueObject<T>
{
  T Value { get; }
}

/// <summary>
/// https://de.wikipedia.org/wiki/Entit%C3%A4t_(Informatik)
/// </summary>
public interface IReferenceObject
{
  Guid Id { get; }
}

public interface ITimestamped
{
  DateTime TimestampUTC { get; }
  TimeZoneInfo TimeZone { get; }
}

public interface IEvent : IReferenceObject, ITimestamped
{
}

public interface IResponse : IEvent
{
  IEnumerable<Exception> Exceptions { get; }
}
