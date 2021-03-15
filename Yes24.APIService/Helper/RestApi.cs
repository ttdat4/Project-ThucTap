using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yes24.APIService.Helper
{
    public class RestApi
    {
        private RestClient _client;
        protected RestRequest request { get; set; }
        public Method Method { get; set; }

        public RestApi(string _baseUrl)
        {
            _client = new RestClient(_baseUrl);
        }

        public T ExecuteResponse<T>(string resource,
            List<string[]> headers,
            List<string[]> queryStrings,
            ICredentials credentials,
            params Parameter[] arrParam) where T : new()
        {
            request = new RestRequest()
            {
                Resource = resource,
                Credentials = credentials,
                Method = this.Method
            };


            if (headers != null && headers.Count > 0)
            {
                // add header to request

                foreach (var header in headers)
                {
                    request.AddHeader(header[0], header[1]);
                }
            }

            if (queryStrings != null && queryStrings.Count > 0)
            {
                foreach (var queryString in queryStrings)
                {
                    request.AddQueryParameter(queryString[0], queryString[1]);
                }
            }

            if (arrParam != null && arrParam.Length > 0)
            {
                // add parameter to request
                foreach (var param in arrParam)
                {
                    request.AddParameter(param);
                }
            }

            //IRestResponse<T> response = _client.Execute<T>(request);
            IRestResponse response = _client.Execute(request);
            var content = response.Content; // raw content as string
                                            //if (typeof(T).Name.Contains("Tuple"))
                                            //{

            //}
            //return JsonConvert.DeserializeObject<T>(content);
            return JsonConvert.DeserializeObject<T>(content.Replace("m_Item", "Item"));
            //return response;
        }


        public async Task<T> ExecuteResponseAsyn<T>(string resource,
            List<string[]> headers,
            List<string[]> queryStrings,
            ICredentials credentials,
            params Parameter[] arrParam) where T : new()
        {
            request = new RestRequest()
            {
                Resource = resource,
                Credentials = credentials,
                Method = this.Method
            };


            if (headers != null && headers.Count > 0)
            {
                // add header to request

                foreach (var header in headers)
                {
                    request.AddHeader(header[0], header[1]);
                }
            }

            if (queryStrings != null && queryStrings.Count > 0)
            {
                foreach (var queryString in queryStrings)
                {
                    request.AddQueryParameter(queryString[0], queryString[1]);
                }
            }

            if (arrParam != null && arrParam.Length > 0)
            {
                // add parameter to request
                foreach (var param in arrParam)
                {
                    request.AddParameter(param);
                }
            }

            IRestResponse<T> response = await _client.ExecuteTaskAsync<T>(request);
            return response.Data;
        }


        public void AddParameter<T>(T obj, ref List<Parameter> parameters)
        {
            if (parameters == null)
                parameters = new List<Parameter>();

            string json = JsonConvert.SerializeObject(obj);

            Parameter param = new Parameter()
            {
                Name = "application/json; charset=utf-8",
                Value = json,
                Type = ParameterType.RequestBody
            };

            parameters.Add(param);
        }
    }
}
