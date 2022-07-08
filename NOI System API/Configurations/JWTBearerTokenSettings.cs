#nullable disable

namespace NOI_System_API.Configurations
{
    public class JWTBearerTokenSettings
    {
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string ExpiryTimeInSeconds { get; set; }
    
    }
}
