using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Yes24.Utilities;

namespace Yes24.APIService.Helper
{
    public class BaseOrderAPI
    {
        public string BaseURL { get; set; }

        #region Constructor
        public BaseOrderAPI()
        {
            BaseURL = ConfigurationManager.AppSettings["URLOrderAPI"];
        }
        #endregion

        #region Methods
        protected T GetDataFromApiOut<T, TParam>(
            string resources, 
            Method methodApi = Method.POST, 
            List<string[]> headers = null, 
            List<string[]> queryStrings = null, 
            params TParam[] arrParam) where T : new()
        {
            RestApi api = new RestApi(BaseURL);
            api.Method = methodApi;

            List<Parameter> parameters = null;

            if (arrParam != null && arrParam.Length > 0)
            {
                // add list param to rest api
                foreach (TParam param in arrParam)
                {
                    api.AddParameter<TParam>(param, ref parameters);
                }
            }
            if (headers == null)
            {
                headers = new List<string[]>();
            }

            headers.Add(new []{ "UserName", ConfigurationManager.AppSettings["UserNameOrderAPI"] });
            headers.Add(new []{ "Password", ConfigurationManager.AppSettings["PasswordOrderAPI"] });

            return api.ExecuteResponse<T>(resources, headers, queryStrings, null, (parameters != null ? parameters.ToArray() : null));
        }

        protected T GetDataFromApiOut<T>(
            string resources,
            Method methodApi = Method.POST,
            List<string[]> headers = null,
            List<string[]> queryStrings = null) where T : new()
        {
            RestApi api = new RestApi(BaseURL);
            api.Method = methodApi;

            if (headers == null)
            {
                headers = new List<string[]>();
            }

            headers.Add(new[] { "UserName", ConfigurationManager.AppSettings["UserNameOrderAPI"] });
            headers.Add(new[] { "Password", ConfigurationManager.AppSettings["PasswordOrderAPI"] });

            return api.ExecuteResponse<T>(resources, headers, queryStrings, null, null);
        }

        protected async Task<T> GetDataFromApiOutAsyn<T, TParam>(
            string resources,
            Method methodApi = Method.POST,
            List<string[]> headers = null,
            List<string[]> queryStrings = null,
            params TParam[] arrParam) where T : new()
        {
            RestApi api = new RestApi(BaseURL);
            api.Method = methodApi;

            if (headers == null)
            {
                headers = new List<string[]>();
            }

            headers.Add(new[] { "UserName", ConfigurationManager.AppSettings["UserNameOrderAPI"] });
            headers.Add(new[] { "Password", ConfigurationManager.AppSettings["PasswordOrderAPI"] });

            List<Parameter> parameters = null;
            if (arrParam != null && arrParam.Length > 0)
            {
                // add list param to rest api
                foreach (TParam param in arrParam)
                {
                    api.AddParameter<TParam>(param, ref parameters);
                }
            }

            var response = await api.ExecuteResponseAsyn<T>(resources, headers, queryStrings, null, (parameters != null ? parameters.ToArray() : null));
            return response;
        }

        protected async Task<T> GetDataFromApiOutAsyn<T>(
            string resources,
            Method methodApi = Method.POST,
            List<string[]> headers = null,
            List<string[]> queryStrings = null) where T : new()
        {
            RestApi api = new RestApi(BaseURL);
            api.Method = methodApi;

            if (headers == null)
            {
                headers = new List<string[]>();
            }

            headers.Add(new[] { "UserName", ConfigurationManager.AppSettings["UserNameOrderAPI"] });
            headers.Add(new[] { "Password", ConfigurationManager.AppSettings["PasswordOrderAPI"] });

            var response = await api.ExecuteResponseAsyn<T>(resources, headers, queryStrings, null, null);

            return response;
        }


        protected int SetValueDefault(object obj, int valueDefault)
        {
            int result = CommonLib.IsNullInt32(obj);

            if (result <= 0) // null or <= 0
                return valueDefault;

            return result;
        }
        #endregion
    }
}
