using Flurl;
using Flurl.Http;
using TSClientSdk.TsApi.Extensoes;
using TSClientSdk.TsApi.Modelos;

namespace TSClientSdk.TsApi.Rotas
{
    public static class UsuarioRota
    {
        public const string rota = "/Usuario";
        public async static Task<UsuarioTokenResponse> Token(string usuario, string senha)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario)) throw new ApplicationException("usuario vazio");
                if (string.IsNullOrEmpty(senha)) throw new ApplicationException("senha vazio");
                string? url = TSApiTools.UrlBase + rota;
                IFlurlResponse resultado = await url
                    .AppendPathSegment("Token")
                    .SetQueryParams(new { usuario, senha })
                    .WithHeaders(new { Accept = "application/json", Content_Type = "application/json" })
                    .PostAsync();
                return await resultado.GetJsonAsync<UsuarioTokenResponse>();
            }
            catch (FlurlHttpException ex)
            {
                return await ex.GetResponseJsonAsync<UsuarioTokenResponse>();
            }
        }
        public async static Task<UsuarioResponse> Visualizar(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id)) throw new ApplicationException("Id não pode ser nulo!");
                if (!TSApiTools.Token.IsConnected()) throw new ApplicationException("Sessão invalida!");
                string? url = $"{TSApiTools.UrlBase}{rota}";
                IFlurlResponse resultado = await url
                    .AppendPathSegment("Visualizar")
                    .AppendPathSegment(id)
                    .WithOAuthBearerToken(TSApiTools.Token.RawData)
                    .WithHeaders(new { Accept = "application/json", Content_Type = "application/json" })
                    .GetAsync();

                return await resultado.GetJsonAsync<UsuarioResponse>();
            }
            catch (FlurlHttpException ex)
            {
                return await ex.GetResponseJsonAsync<UsuarioResponse>();
            }
        }
        public async static Task<UsuarioResponse> AlterarSenha(string senhaAtual, string senhaNova)
        {
            try
            {
                if (string.IsNullOrEmpty(senhaAtual)) throw new ApplicationException("senhaAtual não pode ser nulo!");
                if (string.IsNullOrEmpty(senhaNova)) throw new ApplicationException("senhaNova não pode ser nulo!");
                if (!TSApiTools.Token.IsConnected()) throw new ApplicationException("Sessão invalida!");
                string? url = $"{TSApiTools.UrlBase}{rota}";
                IFlurlResponse resultado = await url
                    .AppendPathSegment("AlterarSenha")
                    .SetQueryParams(new { senhaAtual, senhaNova })
                    .WithOAuthBearerToken(TSApiTools.Token.RawData)
                    .WithHeaders(new { Accept = "application/json", Content_Type = "application/json" })
                    .PutAsync();

                return await resultado.GetJsonAsync<UsuarioResponse>();
            }
            catch (FlurlHttpException ex)
            {
                return await ex.GetResponseJsonAsync<UsuarioResponse>();
            }
        }
    }
}
