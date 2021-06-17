using Newtonsoft.Json;
using System.Collections.Generic;

namespace XeniaPatchMaker.Util
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Title
    {
        [JsonProperty("ID")]
        public string ID;

        [JsonProperty("Name")]
        public string Name;
    }

    public class Xbox
    {
        [JsonProperty("Title")]
        public List<Title> Title;
    }

    public class Root
    {
        [JsonProperty("Xbox")]
        public Xbox Xbox;
    }
}
