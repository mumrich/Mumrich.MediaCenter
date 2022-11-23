using System.Collections.Generic;
using System.IO;

using Mumrich.MediaCenter.Domain.Models;
using Mumrich.ProtoDomain;

namespace Mumrich.MediaCenter.Domain.Entities
{
  public interface IMediaAsset : IEntity
  {
    Stream Data { get; }
    string Name { get; }
    IEnumerable<IMediaTag> Tags { get; }
  }
}
