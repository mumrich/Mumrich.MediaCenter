using Mumrich.ProtoDomain.Primitives;

namespace Mumrich.MediaCenter.Domain.Models
{
  public interface IMediaTag : IEntity
  {
    string Name { get; }
  }
}
