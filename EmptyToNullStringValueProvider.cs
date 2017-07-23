using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace SupremeDiscordMessage
{
    public class EmptyToNullStringValueProvider : IValueProvider
    {
        PropertyInfo _MemberInfo;
        public EmptyToNullStringValueProvider(PropertyInfo memberInfo)
        {
            _MemberInfo = memberInfo;
        }

        public object GetValue(object target)
        {
            object result = _MemberInfo.GetValue(target);
            if (_MemberInfo.PropertyType == typeof(string) && result == "") result = null;
            return result;

        }

        public void SetValue(object target, object value)
        {
            _MemberInfo.SetValue(target, value);
        }
    }
}