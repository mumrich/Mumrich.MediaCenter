using Mumrich.ProtoDomain.Models;

namespace Mumrich.MediaCenter.Domain.Models
{
  public interface IMediaTag : IEntity
  {
    string Name { get; }
  }
}
