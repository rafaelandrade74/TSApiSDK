using Newtonsoft.Json;

namespace TSClientSdk.TsApi.Modelos
{
    public class ZonaResponse
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "subDominio")]
        public string? SubDominio { get; set; }
        [JsonProperty(PropertyName = "ipv4")]
        public string? Ipv4 { get; set; }
        [JsonProperty(PropertyName = "porta")]
        public int Porta { get; set; }
        [JsonProperty(PropertyName = "dono")]
        public string Dono { get; set; } = null!;
    }
}
