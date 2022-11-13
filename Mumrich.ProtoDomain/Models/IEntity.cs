using System;

namespace Mumrich.ProtoDomain.Models
{
  public interface IEntity
  {
    Guid Id { get; set; }
  }
}
