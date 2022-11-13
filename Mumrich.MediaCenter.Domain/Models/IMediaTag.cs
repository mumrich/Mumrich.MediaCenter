using Mumrich.ProtoDomain;

namespace Mumrich.MediaCenter.Domain.Models
{
  public interface IMediaTag : IEntity
  {
    string Name { get; }
  }
}
