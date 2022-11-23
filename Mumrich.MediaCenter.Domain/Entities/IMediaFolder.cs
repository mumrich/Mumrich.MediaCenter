using System.Collections.Generic;

using Mumrich.ProtoDomain;

namespace Mumrich.MediaCenter.Domain.Entities;

public interface IMediaFolder : IEntity
{
  string Name { get; }
  IMediaFolder? Parent { get; }
  IEnumerable<IMediaAsset> Assets { get; }
  IEnumerable<IMediaFolder> Children { get; }
}
