using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SupremeDiscordMessage
{
    public class EmptyToNullStringResolver : DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            return type.GetProperties()
                .Select(p => {
                    var jp = base.CreateProperty(p, memberSerialization);
                    jp.ValueProvider = new EmptyToNullStringValueProvider(p);
                    return jp;
                }).ToList();
        }
    }
}