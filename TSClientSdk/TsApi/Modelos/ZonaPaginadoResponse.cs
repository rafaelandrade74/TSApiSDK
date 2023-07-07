using Newtonsoft.Json;

namespace TSClientSdk.TsApi.Modelos
{
    public class ZonaPaginadoResponse
    {
        [JsonProperty(PropertyName = "erros")]
        public Dictionary<string, string> Erros { get; set; }
        [JsonProperty(PropertyName = "dados")]
        public IEnumerable<ZonaResponse> Dados { get; set; }
        [JsonProperty(PropertyName = "parametros")]
        public Dictionary<string, object> Parametros { get; set; }
    }
}
