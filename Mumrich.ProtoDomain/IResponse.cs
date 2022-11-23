using System;
using System.Collections;
using System.Collections.Generic;

namespace Mumrich.ProtoDomain;

public interface IResponse : ITimestamped
{
  IEnumerable<Exception> Exceptions { get; }
}
