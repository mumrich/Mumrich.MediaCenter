﻿using System.IO;

using Mumrich.ProtoDomain;

namespace Mumrich.MediaCenter.Domain.Entities
{
  public interface IMediaAsset : IEntity
  {
    Stream Data { get; }
    string Name { get; }
  }
}