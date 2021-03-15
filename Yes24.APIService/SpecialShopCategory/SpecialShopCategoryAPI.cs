using RestSharp;
using System;
using System.Collections.Generic;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Catalog;

namespace Yes24.APIService.SpecialShopCategory
{
    public class SpecialShopCategoryAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<SpecialShopCategoryAPI> lazy = new Lazy<SpecialShopCategoryAPI>(() => new SpecialShopCategoryAPI());
        public static SpecialShopCategoryAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<DisplayCategorySubCategoryForSpecial> GetSpecialShopCategory(int categoryNo, int viewFlag)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubCategoryForSpecial>>>(
                "SpecialShopCategory/GetSpecialShopCategory",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "viewFlag", viewFlag.ToString() }
                });
            return response.Data;
        }

        public Tuple<List<DisplayCatalogAreaProductForSpecial>, List<MobileDisplayCatalogProductForSpecial>> GetSpecialShopSubCategory(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<DisplayCatalogAreaProductForSpecial>, List<MobileDisplayCatalogProductForSpecial>>>>(
                "SpecialShopCategory/GetSpecialShopSubCategory",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "areaId", areaId.ToString() }
                });
            return response.Data;
        }

        public List<DisplayCategorySubBrandForSpecial> GetSpecialSubCategory(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubBrandForSpecial>>>(
                "SpecialShopCategory/GetSpecialSubCategory",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }

        public List<DisplayCategorySpecial> GetSpecialCategory()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySpecial>>>(
                "SpecialShopCategory/GetSpecialCategory",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategorySpecial> SelectDisplayCategoryReply(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySpecial>>>(
                "SpecialShopCategory/SelectDisplayCategoryReply",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategoryForTodaySales> SelectTodaySalesCategory(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryForTodaySales>>>(
                "SpecialShopCategory/SelectTodaySalesCategory",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }

        public Tuple<List<DisplayCategoryForTodaySalesList>, List<DisplayCategoryForTodaySalesList2>, List<DisplayCategoryForTodaySalesList3>> SelectTodaySalesCategoryHistory(int categoryNo, int pCatogoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<DisplayCategoryForTodaySalesList>, List<DisplayCategoryForTodaySalesList2>, List<DisplayCategoryForTodaySalesList3>>>>(
                "SpecialShopCategory/SelectTodaySalesCategoryHistory",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "pCatogoryNo", pCatogoryNo.ToString() }
                });
            return response.Data;
        }

        public int InsertSMSForTodaySale(string LoginId, int CategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "SpecialShopCategory/InsertSMSForTodaySale",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "LoginId", LoginId },
                    new[] { "CategoryNo", CategoryNo.ToString() }
                });
            return response.Data;
        }

        public List<RecentProductList> SelectMobileRecentProduct(string ProductCodeList)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<RecentProductList>>>(
                "SpecialShopCategory/SelectMobileRecentProduct",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "ProductCodeList", ProductCodeList }
                });
            return response.Data;
        }

        public List<SuggestProductLis> SelectSuggestProduct(string ProductCodeList)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SuggestProductLis>>>(
                "SpecialShopCategory/SelectSuggestProduct",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "ProductCodeList", ProductCodeList }
                });
            return response.Data;
        }

        public Tuple<List<CategoryModel>, List<MobileDisplayCatalogProductForSpecial>> GetSpecialShopSubCategoryMobile(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<CategoryModel>, List<MobileDisplayCatalogProductForSpecial>>>>(
                "SpecialShopCategory/GetSpecialShopSubCategoryMobile",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "areaId", areaId }
                });
            return response.Data;
        }

        public Tuple<List<CategoryModel>, List<MobileDisplayCatalogProductForSpecial>> GetSpeicalShopSubCategoryMobile(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<CategoryModel>, List<MobileDisplayCatalogProductForSpecial>>>>(
                "SpecialShopCategory/GetSpecialShopSubCategoryMobile",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "areaId", areaId }
                });
            return response.Data;
        }

        public int SelectDisplayCategory2Depth(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "SpecialShopCategory/SelectDisplayCategory2Depth",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
    }
}
