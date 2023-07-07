using Flurl;
using Flurl.Http;
using TSClientSdk.TsApi.Extensoes;
using TSClientSdk.TsApi.Modelos;

namespace TSClientSdk.TsApi.Rotas
{
    public static class ZonaRota
    {
        public const string rota = "/Zonas";
        public async static Task<ZonaPaginadoResponse> ObterPaginado(int pagina, int qtdeLinhas)
        {
            try
            {
                if (!TSApiTools.Token.IsConnected()) throw new ApplicationException("Sessão invalida!");
                string? url = $"{TSApiTools.UrlBase}{rota}";
                IFlurlResponse resultado = await url
                    .SetQueryParams(new {pagina, qtdeLinhas})
                    .WithOAuthBearerToken(TSApiTools.Token.RawData)
                    .WithHeaders(new { Accept = "application/json", Content_Type = "application/json" })
                    .GetAsync();

                return await resultado.GetJsonAsync<ZonaPaginadoResponse>();
            }
            catch (FlurlHttpException ex)
            {
                return await ex.GetResponseJsonAsync<ZonaPaginadoResponse>();
            }
        }
    }
}
