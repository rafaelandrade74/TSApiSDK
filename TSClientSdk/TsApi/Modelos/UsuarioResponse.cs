using Newtonsoft.Json;

namespace TSClientSdk.TsApi.Modelos
{
    public class UsuarioResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "apelido")]
        public string Apelido { get; set; }
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "admin")]
        public bool Admin { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Erro { get; set; } = string.Empty;
    }
}
