using OAuth.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAuth.Models;
using OAuth.Data;

namespace OAuth.Logic.Services
{
    public class TokenService : IToken
    {
        public async Task<bool> AddRefreshToken(Models.RefreshToken token)
        {
            try
            {
                var dbService = new MockRefreshToken();

                return await dbService.AddRefreshToken(token);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Models.RefreshToken> GetAllRefreshTokens()
        {
            try
            {
                var dbService = new MockRefreshToken();

                return dbService.GetAllRefreshTokens();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool> RemoveRefreshToken(Models.RefreshToken refreshToken)
        {
            try
            {
                var dbService = new MockRefreshToken();

                return await dbService.RemoveRefreshToken(refreshToken);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            try
            {
                var dbService = new MockRefreshToken();

                return await dbService.RemoveRefreshToken(refreshTokenId);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            try
            {
                var dbService = new MockRefreshToken();

                return await dbService.FindRefreshToken(refreshTokenId);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
