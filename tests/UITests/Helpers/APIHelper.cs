using RestSharp;

namespace UITests.Helpers
{
    public class APIHelper
    {
        private string _baseUrl;

        public APIHelper(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public RestClient APIClient => new RestClient(_baseUrl);

        public static APIHelper API => new APIHelper(Common.Settings.Url);

        public RestResponse GetResponse(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);

            return APIClient.GetAsync(request).Result;
        }
    }
}