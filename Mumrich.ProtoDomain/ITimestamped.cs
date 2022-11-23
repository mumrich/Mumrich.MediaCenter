using System;

namespace Mumrich.ProtoDomain;

public interface ITimestamped
{
  DateTime Emission { get; }
}
