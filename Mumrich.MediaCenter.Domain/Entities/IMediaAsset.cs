using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Mumrich.MediaCenter.Domain.Models;
using Mumrich.ProtoDomain;

namespace Mumrich.MediaCenter.Domain.Entities
{
  public interface IMediaAssetInfo
  {
    string Name { get; }
    IEnumerable<IMediaTag> Tags { get; }
  }

  public interface IMediaAsset : IEntity
  {
    Task<Stream> GetDataAsync();
    Task<IMediaAssetInfo> GetInfoAsync();
  }
}
