using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Catalog;

namespace Yes24.APIService.FlashWs
{
    public class FlashWsAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<FlashWsAPI> lazy = new Lazy<FlashWsAPI>(() => new FlashWsAPI());
        public static FlashWsAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<DisplayCatalogContentsForCafeStyle> GetBanner(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogContentsForCafeStyle>>>(
                "Contents/GetList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "areaId", areaId }
                });
            return response.Data;
        }

        public List<CategoryMultiBanner> GetMultiBanner(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CategoryMultiBanner>>>(
                "Contents/GetMultiBanner",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "areaId", areaId }
                });
            return response.Data;
        }

        public List<CategoryTextBanner> GetTextBanner(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CategoryTextBanner>>>(
                "Contents/GetTextBanner",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "areaId", areaId }
                });
            return response.Data;
        }

        public List<ProductHitKeywordForFront> GetHitKeyword()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductHitKeywordForFront>>>(
                "Contents/GetHitKeyword",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategoryFirst> GetFirstCategory()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryFirst>>>(
                "Contents/GetFirstCategory",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetItemZone(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                "Contents/GetFirstCategory",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "firstCategoryNo", firstCategoryNo.ToString() }
                });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetBrandZone(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                "Contents/GetBrandZone",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "firstCategoryNo", firstCategoryNo.ToString() }
                });
            return response.Data;
        }

        public List<DisplayCategoryTreeForFlash> GetCategoryTree()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryTreeForFlash>>>(
                "Contents/GetCategoryTree",
                Method.GET,
                null,
                null);
            return response.Data;
        }
    }
}
