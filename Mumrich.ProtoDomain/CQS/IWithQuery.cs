namespace Mumrich.ProtoDomain.CQS;

public interface IWithQuery<TQuery, TResponse> where TQuery : IQuery where TResponse : IResponse
{
  TResponse OnQuery(TQuery query);
}
