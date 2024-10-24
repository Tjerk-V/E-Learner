using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ADR_Cursus
{
    public class QuestionsDataToJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(QuestionData).IsAssignableFrom(objectType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            if (jsonObject["type"] == null)
            {
                throw new InvalidOperationException("Missing 'type' property in JSON.");
            }
            string json = jsonObject.ToString();
            //jsonObject.ContainsKey("")
            string type = jsonObject["type"].ToString();
            switch (type)
            {
                case "MultipleChoiceQuestionData":
                    return JsonConvert.DeserializeObject<MultipleChoiceQuestionData>(json);
                case "OpenQuestionData":
                    return JsonConvert.DeserializeObject<OpenQuestionData>(json);
                case "LabelQuestionData":
                    return JsonConvert.DeserializeObject<LabelQuestionData>(json);
                case "ImageQuestionData":
                    return JsonConvert.DeserializeObject<ImageQuestionData>(json);
                default:
                    throw new InvalidOperationException($"Unknown type: {type}");
            }
        }
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
