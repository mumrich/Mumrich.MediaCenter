using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using Mumrich.ProtoDomain;

namespace Mumrich.MediaCenter.Domain.Entities;

public abstract record TimestampedBase : ITimestamped
{
  public DateTime Emission { get; } = DateTime.UtcNow;
}

public record AddMediaAssetCommand(IMediaAsset Asset) : TimestampedBase, ICommand;
public record GetMediaAssetQuery(Guid Id) : TimestampedBase, IQuery;
public record GetMediaAssetQueryResponse(IMediaAsset? Asset, IEnumerable<Exception> Exceptions) : TimestampedBase, IResponse;

public class MediaAssetsAggregate : IAggregate<IEnumerable<IMediaAsset>>, IWithCommand<AddMediaAssetCommand>, IWithQuery<GetMediaAssetQuery, GetMediaAssetQueryResponse>
{
  private readonly Dictionary<Guid, IMediaAsset> _model = new();
  public Guid Id { get; }
  public IEnumerable<IMediaAsset> Model => _model.Select(kvp => kvp.Value).ToList();

  public void OnCommand(AddMediaAssetCommand cmd)
  {
    _model.Add(cmd.Asset.Id, cmd.Asset);
  }

  public GetMediaAssetQueryResponse OnQuery(GetMediaAssetQuery query)
  {
    return _model.TryGetValue(query.Id, out IMediaAsset? mediaAsset)
      ? new GetMediaAssetQueryResponse(mediaAsset, Array.Empty<Exception>())
      : new GetMediaAssetQueryResponse(null, new[]
        {
          new InvalidConstraintException($"Unknown MediaAsset ID: {query.Id}")
        });
  }
}
