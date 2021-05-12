using System.Threading.Tasks;

namespace SocialMarket.Social.FbService
{
    public interface IFbAccessToken
    {
        Task FbAccToken(string redirect_uri = null, string clent_id = null, string client_secret = null, string grant_type = null);
    }
}