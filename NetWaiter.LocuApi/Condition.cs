using System;
using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class Condition
    {
        [JsonProperty(PropertyName = "$present")]
        public bool? Present { get; set; }
    }

    public class ConditionConverter<T> : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var wrapper = value as ConditionWrapper<T>;
            if (wrapper != null)
            {
                if (wrapper.Item != null)
                {
                    serializer.Serialize(writer, wrapper.Item);
                }
                else if (wrapper.Condition != null)
                {
                    serializer.Serialize(writer, wrapper.Condition);
                }
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new ConditionWrapper<T> {Item = serializer.Deserialize<T>(reader)};
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }

    public class ConditionWrapper<T>
    {
        public Condition Condition { get; set; }
        public T Item { get; set; }
    }
}