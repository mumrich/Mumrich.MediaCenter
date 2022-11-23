namespace Mumrich.ProtoDomain;

public interface IWithQuery<TQuery, TResponse> where TQuery : IQuery where TResponse : IResponse
{
  TResponse OnQuery(TQuery query);
}
