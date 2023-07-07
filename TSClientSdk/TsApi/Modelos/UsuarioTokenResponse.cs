using Newtonsoft.Json;

namespace TSClientSdk.TsApi.Modelos
{
    public class UsuarioTokenResponse
    {
        [JsonProperty(PropertyName = "error")]
        public string Erro { get; set; } = string.Empty;
        [JsonProperty(PropertyName = "token")]
        public string Token { get { return token; } set { token = value.Replace("Bearer", "").Trim(); } }
        private string token = string.Empty;
    }
}
