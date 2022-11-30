using System;

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

public record ZonedDateTime(DateTime TimeStampUtc, TimeZoneInfo TimeZone)
{
  public static ZonedDateTime NewUtcNowZonedDateTime()
  {
    return new ZonedDateTime(DateTime.UtcNow, TimeZoneInfo.Utc);
  }
}

public interface ITimestamped
{
  ZonedDateTime TimeStamp { get; }
}
