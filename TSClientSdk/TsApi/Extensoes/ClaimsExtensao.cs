using System.IdentityModel.Tokens.Jwt;

namespace TSClientSdk.TsApi.Extensoes
{
    public static class ClaimsExtensao
    {
        public static bool IsAdmin(this JwtSecurityToken token)
        {
            if (token == null) throw new Exception("Token nulo");
            return token.Claims.Where(x => x.Type == "Admin").Select(x => x.Value == "True").FirstOrDefault();
        }
        public static string UserId(this JwtSecurityToken token)
        {
            if (token == null) throw new Exception("Token nulo");
            return token.Claims.Where(x => x.Type == "nameid").Select(x => x.Value).First();
        }
        public static string UserName(this JwtSecurityToken token)
        {
            if (token == null) throw new Exception("Token nulo");
            return token.Claims.Where(x => x.Type == "unique_name").Select(x => x.Value).First();
        }
        public static DateTime ExpirateDateToLocalTime(this JwtSecurityToken token)
        {
            return token.ExpirateDateUTC().ToLocalTime();
        }
        public static DateTime ExpirateDateUTC(this JwtSecurityToken token)
        {
            if (token == null) throw new Exception("Token nulo");
            var tempo = token.Claims.Where(x => x.Type == "exp").Select(x => int.Parse(x.Value)).First();
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(tempo);
        }
        public static bool IsConnected(this JwtSecurityToken token)
        {
            if (token == null) throw new Exception("Token nulo");

            return token.ExpirateDateUTC() > DateTime.UtcNow;
        }
    }
}
