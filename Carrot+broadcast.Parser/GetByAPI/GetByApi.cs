using Carrot_broadcast.Parser.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Carrot_broadcast.Parser.GetByAPI
{
    public class GetByApi
    {
        HttpClient _httpClient;

        public GetByApi()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<ModelResult>> GetDataAsync()
        {
            string apiUrl = "https://randomuser.me/api/";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);
                var resultsArray = json["results"].ToObject<JArray>();
                List<ModelResult> userDataList = resultsArray.Select(result => result.ToObject<ModelResult>()).ToList();
                return userDataList;
            }
            else
            {
                throw new HttpRequestException($"HTTP error: {response.StatusCode}");
            }
        }
    }
}