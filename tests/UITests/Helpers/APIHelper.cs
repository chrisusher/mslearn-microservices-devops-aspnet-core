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

        public RestClient RestClient => new RestClient(_baseUrl);

        public static APIHelper API => new APIHelper(Common.Settings.Url);
    }
}