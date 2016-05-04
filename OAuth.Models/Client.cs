using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth.Models
{
    public class Client
    {
        public long ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string ClientName { get; set; }
        public string AllowedOrigin { get; set; }
        public bool Active { get; set; }
        public bool SecretRequired { get; set; }
        public long RefreshTokenLifetime { get; set; }
    }
}
