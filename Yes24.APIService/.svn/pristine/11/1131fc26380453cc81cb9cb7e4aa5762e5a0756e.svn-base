using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Catalog;
using Yes24.DTO.Search;

namespace Yes24.APIService.Brand
{
    public class BrandAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<BrandAPI> lazy = new Lazy<BrandAPI>(() => new BrandAPI());
        public static BrandAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<GetBrandInfo> GetBrandByName(string name)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetBrandInfo>>, SearchModel>(
                "Brand/GetBrandByName",
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
