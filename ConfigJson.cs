using Newtonsoft.Json;

namespace BirdyBotv2
{
    //struct to store data from the Json
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
