using System.Reflection;

namespace Mumrich.ProtoDomain
{
  public interface ITrySetValue<in TValue>
  {
    bool TrySetValue(PropertyInfo propertyInfo, TValue @value);
  }
}
