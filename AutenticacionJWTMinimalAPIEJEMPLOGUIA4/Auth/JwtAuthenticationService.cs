﻿using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;

using System.Text;


namespace AutenticacionJWTMinimalAPIEJEMPLOGUIA4.Auth
{
    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        private readonly string _key;

        public JwtAuthenticationService(string key)
        {
            _key = key;
        }

        public string Authenticate(string userName)
        {


            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenKey = Encoding.ASCII.GetBytes(_key);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim )

            };
            throw new NotImplementedException();
        }
    }
   
}
