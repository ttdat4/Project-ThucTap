using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Search;
using Yes24.DTO.Vendor;

namespace Yes24.APIService.Provider
{
    public class ProviderAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<ProviderAPI> lazy = new Lazy<ProviderAPI>(() => new ProviderAPI());
        public static ProviderAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<ProviderDetail> GetProviderByName(string name)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProviderDetail>>, SearchModel>(
                "Provider/GetProviderByName",
                Method.POST,
                null,
                null,
                new SearchModel
                {
                    Name = name
                });
            return response.Data;
        }

        

    }
}
