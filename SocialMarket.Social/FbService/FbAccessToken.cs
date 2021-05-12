using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace SocialMarket.Social.FbService
{
    public class FbAccessToken : IFbAccessToken
    {
        private readonly HttpClient httpClient;

        public FbAccessToken(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task FbAccToken(string redirect_uri = null, string clent_id = null, string client_secret = null, string grant_type = null)
        {
            var grantType = grant_type == null ? "client_credentials" : grant_type;

            var accUrl = $"{FbCommon.FbBaseUrl}/{FbCommon.FbAccTokUrl}?redirect_uri={redirect_uri}" +
                $"&client_id={FbCommon.FbClient}" +
                $"&client_secret={FbCommon.FbSecret}&grant_type={grantType}";

            var result = await httpClient.GetJsonAsync<object>(accUrl);
            var ss = result;
        }
    }
}
