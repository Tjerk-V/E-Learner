using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADR_Cursus
{
    public static class PagesCollector
    {
        public static List<Page> GetPagesFromJson()
        {
            List<Page> Pages = new();
            JsonSerializerSettings settings = new()
            {
                Converters = new[] { new QuestionsDataToJsonConverter() },
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };
            string path = "Cursus/";
            string[] jsonFiles = Directory.GetFiles(path, "*.json");
            NumericComparer ns = new();
            Array.Sort(jsonFiles, ns);

            foreach (string jsonFile in jsonFiles)
            {
                string json = File.ReadAllText(jsonFile);
                Page new_page = new(JsonConvert.DeserializeObject<IEnumerable<QuestionData>>(json, settings));
                Pages.Add(new_page);
            }
            return Pages;
        }

    }
}
