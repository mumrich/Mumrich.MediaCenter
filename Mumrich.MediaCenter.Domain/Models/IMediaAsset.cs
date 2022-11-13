using System.IO;

using Mumrich.ProtoDomain.Models;

namespace Mumrich.MediaCenter.Domain.Models
{
  public interface IMediaAsset : IEntity
  {
    Stream Data { get; set; }
    string Name { get; set; }
  }
}
