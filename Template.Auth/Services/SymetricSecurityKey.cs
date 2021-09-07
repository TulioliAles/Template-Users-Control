using System.Security.Cryptography.X509Certificates;

namespace Template.Auth.Services
{
    internal class SymetricSecurityKey : X509Certificate2
    {
        public SymetricSecurityKey(byte[] rawData) : base(rawData)
        {
        }
    }
}