using OAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth.Data
{
    public class MockRefreshToken
    {
        static  List<RefreshToken> _tokens = new List<RefreshToken>();

        public MockRefreshToken()
        {
            var expiresUTC = DateTime.UtcNow.AddDays(3);
            var issuedUTC = DateTime.UtcNow;
            //Refresh token mock data for future implementation
          //  _tokens.Add(new RefreshToken() { ClientId = "1212", ExpiresUtc = expiresUTC, Subject = "test@oauth.com", IssuedUtc = issuedUTC,  ProtectedTicket = "secret1",  Id = "qqweqwe"});
        }


        public async Task<bool> AddRefreshToken(RefreshToken token)
        {

            var existingToken = _tokens.Where(r => r.Subject == token.Subject && r.ClientId == token.ClientId).SingleOrDefault();

            if (existingToken != null)
            {
                var result = await RemoveRefreshToken(existingToken);
            }

            _tokens.Add(token);

            return true;
          //  return await _tokens.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken =  _tokens.Where(x => x.Id == refreshTokenId).SingleOrDefault() ;

            if (refreshToken != null)
            {
                _tokens.Remove(refreshToken);
                return true;
               // return await _ctx.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<bool> RemoveRefreshToken(RefreshToken refreshToken)
        {
            //_ctx.RefreshTokens.Remove(refreshToken);
            //return await _ctx.SaveChangesAsync() > 0;
            return true;
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = _tokens.Where(x => x.Id == refreshTokenId).SingleOrDefault();

            return refreshToken;
        }

        public List<RefreshToken> GetAllRefreshTokens()
        {
            return _tokens;
        }
    }
}
