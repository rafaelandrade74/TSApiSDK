using System.IdentityModel.Tokens.Jwt;

namespace TSClientSdk.TsApi
{
    public static class TSApiTools
    {
        public static string UrlBase = "/api/";
        public static JwtSecurityToken Token
        {
            get;
            set; 
        }

       
    }
}
