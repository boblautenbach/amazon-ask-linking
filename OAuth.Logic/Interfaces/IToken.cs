using OAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth.Logic.Interfaces
{
    public interface  IToken
    {
        Task<bool> AddRefreshToken(RefreshToken token);
        Task<bool> RemoveRefreshToken(string refreshTokenId);
        Task<bool> RemoveRefreshToken(RefreshToken refreshToken);
        List<RefreshToken> GetAllRefreshTokens();
        Task<RefreshToken> FindRefreshToken(string refreshTokenId);
   

    }
}
