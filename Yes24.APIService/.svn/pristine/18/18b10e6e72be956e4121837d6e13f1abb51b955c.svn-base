using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Catalog;
using Yes24.DTO.Vendor;
using Yes24.Models;
using Yes24.Utilities;
using BaseAPI = Yes24.APIService.Helper.BaseAPI;

namespace Yes24.APIService.Catalog
{
    public class CatalogAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<CatalogAPI> lazy = new Lazy<CatalogAPI>(() => new CatalogAPI());
        public static CatalogAPI Instance { get { return lazy.Value; } }
        #endregion
        public List<DisplayCatalogProduct> GetDisplayCatalog(int categoryNo, string areaId, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProduct>>>(
                "Catalog/GetDisplayCatalog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId },
                    new[]{ "rowCount", rowCount.ToString() },
                });
            return response.Data;
        }
        public List<DisplayCatalogProduct> GetDisplayCatalogCompress(int categoryNo, string areaId, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProduct>>>(
                "Catalog/GetDisplayCatalogCompress",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId },
                    new[]{ "rowCount", rowCount.ToString() },
                });
            return response.Data;
        }
        public string GetDisplayCatalogForFlash(int categoryNo, string areaId, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Catalog/GetDisplayCatalogForFlash",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId },
                    new[]{ "rowCount", rowCount.ToString() },
                });
            return response.Data;
        }
        public List<DisplayCatalogContentsByAreaType> GetCategoryBanner(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogContentsByAreaType>>>(
                "Catalog/GetCategoryBanner",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;

        }
        public List<DisplayCatalogContentsForCafeStyle> GetCategoryBannerByAreaId(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogContentsForCafeStyle>>>(
                "Catalog/GetCategoryBannerByAreaId",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId }
                });
            return response.Data;

        }
        public List<CategoryTextBanner> GetCategoryTextBanner(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CategoryTextBanner>>>(
                "Catalog/GetCategoryTextBanner",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId }
                });
            return response.Data;
        }
        public List<CategoryMultiBanner> GetCategoryMultiBanner(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CategoryMultiBanner>>>(
                "Catalog/GetCategoryMultiBanner",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId }
                });
            return response.Data;
        }
        public List<DisplayCatalogContentsByAreaType> GetCategoryHTML(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogContentsByAreaType>>>(
                "Catalog/GetCategoryHTML",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogContents> GetCatalogContents(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogContents>>>(
                "Catalog/GetCatalogContents",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId }
                });
            return response.Data;
        }
        public List<DisplayCatalogContents> GetCatalogContentsV2(int categoryNo, string areaId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogContents>>>(
                "Catalog/GetCatalogContentsV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId }
                });
            return response.Data;
        }
        public List<MDCommentModel> GetMDCommentAll(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<MDCommentModel>>>(
                "Catalog/GetMDCommentAll",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public List<MDComment2Model> GetMDComment(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<MDComment2Model>>>(
                "Catalog/GetMDComment",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public Tuple<List<BestReviewModel>, BestReview2Model> GetBestReview(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<BestReviewModel>, BestReview2Model>>>(
                "Catalog/GetBestReview",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public BestReviewModel GetBestReviewForMain(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<BestReviewModel>>(
                "Catalog/GetBestReviewForMain",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public List<ProductViewLogTopByCategory> GetBestReivewProduct(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductViewLogTopByCategory>>>(
                "Catalog/GetBestReivewProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "firstCategoryNo", firstCategoryNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItem> GetBrandProduct(int categoryNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItem>>>(
                "Catalog/GetBrandProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", categoryNo.ToString() },
                    new[]{ "priceFrom", categoryNo.ToString() },
                    new[]{ "priceTo", categoryNo.ToString() },
                    new[]{ "sortType", categoryNo.ToString() },
                    new[]{ "listSize", categoryNo.ToString() },
                    new[]{ "page", categoryNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItem> GetBrandProductForV2(int categoryNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItem>>>(
                "Catalog/GetBrandProductForV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", categoryNo.ToString() },
                    new[]{ "priceFrom", categoryNo.ToString() },
                    new[]{ "priceTo", categoryNo.ToString() },
                    new[]{ "sortType", categoryNo.ToString() },
                    new[]{ "listSize", categoryNo.ToString() },
                    new[]{ "page", categoryNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemPaging> GetBrandProductPaging(int categoryNo, string searchWord, double priceFrom, double priceTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemPaging>>>(
                "Catalog/GetBrandProductPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", categoryNo.ToString() },
                    new[]{ "priceFrom", categoryNo.ToString() },
                    new[]{ "priceTo", categoryNo.ToString() },
                    new[]{ "sortType", categoryNo.ToString() },
                    new[]{ "listSize", categoryNo.ToString() },
                    new[]{ "page", categoryNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductBest> GetBrandProductForBest(int brandNo, int rangeCount, int rowCount, int sortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductBest>>>(
                "Catalog/GetBrandProductForBest",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "brandNo", brandNo.ToString() },
                    new[]{ "rangeCount", rangeCount.ToString() },
                    new[]{ "rowCount", rowCount.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItem> GetItemProduct(int categoryNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItem>>>(
                "Catalog/GetItemProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                     new[]{ "page", page.ToString() },
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemPaging> GetItemProductPaging(int categoryNo, string searchWord, double priceFrom, double priceTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemPaging>>>(
                "Catalog/GetItemProductPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductBest> GetItemProductForBest(int categoryNo, int rangeCount, int rowCount, int sortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductBest>>>(
                "Catalog/GetItemProductForBest",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "rangeCount", rangeCount.ToString() },
                    new[]{ "rowCount", rowCount.ToString() },
                    new[]{ "sortType", sortType.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItem> GetBrandItemProduct(int categoryNo, string searchWord, double priceFrom, double priceTo, int categoryType, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItem>>>(
                "Catalog/GetBrandItemProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "categoryType", categoryNo.ToString() },
                    new[]{ "sortType", searchWord.ToString() },
                    new[]{ "listSize", priceFrom.ToString() },
                    new[]{ "page", priceTo.ToString() }
                });
            return response.Data;
        }
        public Tuple<List<DisplayCatalogProduct>, List<DisplayCatalogProductBest>> GetBrandItemProductForBest(int categoryNo, int categoryType, int rangeCount, int rowCount, int sortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<DisplayCatalogProduct>, List<DisplayCatalogProductBest>>>>(
                "Catalog/GetBrandItemProductForBest",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "categoryType", categoryType.ToString() },
                    new[]{ "rangeCount", rangeCount.ToString() },
                    new[]{ "rowCount", rowCount.ToString() },
                    new[]{ "sortType", sortType.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandZone> GetBrandZoneProduct(int brandZoneCategoryNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandZone>>>(
                "Catalog/GetBrandZoneProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "brandZoneCategoryNo", brandZoneCategoryNo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandZonePaging> GetBrandZoneProductPaging(int brandZoneCategoryNo, string searchWord, double priceFrom, double priceTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandZonePaging>>>(
                "Catalog/GetBrandZoneProductPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "brandZoneCategoryNo", brandZoneCategoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductBestForBrandZone> GetBrandZoneProductForBest(int categoryNo, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductBestForBrandZone>>>(
                "Catalog/GetBrandZoneProductForBest",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "rowCount", rowCount.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItem> GetBrandSubItemProductForV2(int brandNo, int itemNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItem>>>(
                "Catalog/GetBrandSubItemProductForV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "brandNo", brandNo.ToString() },
                    new[]{ "itemNo", itemNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() }

                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemPaging> GetBrandSubItemProductPaging(int brandCategoryNo, int itemNo, string searchWord, double priceFrom, double priceTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemPaging>>>(
                "Catalog/GetBrandSubItemProductPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "brandCategoryNo", brandCategoryNo.ToString() },
                    new[]{ "itemNo", itemNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemPaging> GetBrandSubItemProductPaging2(int brandCategoryNo, int itemNo, string searchWord, double priceFrom, double priceTo, int SortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemPaging>>>(
                "Catalog/GetBrandSubItemProductPaging2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "brandCategoryNo", brandCategoryNo.ToString() },
                    new[]{ "itemNo", itemNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() }
                });
            return response.Data;
        }
        public Tuple<List<ProductSearchForFront>, List<ProductSearchForFront2>> SearchResult(int rootCategoryNo, string brandName, string itemName, string keyword, double priceFrom, double priceTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<ProductSearchForFront>, List<ProductSearchForFront2>>>>(
                "Catalog/SearchResult",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "rootCategoryNo", rootCategoryNo.ToString() },
                    new[]{ "brandName", brandName.ToString() },
                    new[]{ "itemName", itemName.ToString() },
                    new[]{ "keyword", keyword.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() }
                });
            return response.Data;
        }
        public List<ProductListSearchForFrontByBySortType> SearchListResult(int rootCategoryNo, string brandName, string itemName, string keyword, double priceFrom, double priceTo, int sortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductListSearchForFrontByBySortType>>>(
                "Catalog/SearchListResult",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "rootCategoryNo", rootCategoryNo.ToString() },
                    new[]{ "brandName", brandName.ToString() },
                    new[]{ "itemName", itemName.ToString() },
                    new[]{ "keyword", keyword.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() }
                });
            return response.Data;
        }
        public List<MySearchForCategory2> SearchBrandResultNew(int rootCategoryNo, string keyword1, string keyword2, int inResultType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<MySearchForCategory2>>>(
                "Catalog/SearchBrandResultNew",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "rootCategoryNo", rootCategoryNo.ToString() },
                    new[]{ "keyword1", keyword1.ToString() },
                    new[]{ "keyword2", keyword2.ToString() },
                    new[]{ "inResultType", inResultType.ToString() },
                });
            return response.Data;
        }
        public Tuple<TotalMinMax, List<ProductCategoryShort>, List<Yes24.Models.Product>, List<BrandShort>> SearchListResultNew(int rootCategoryNo, string keyword1, string keyword2, string brandNo, double priceFrom, double priceTo, int sortType, int inResultType, int pageCount, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<TotalMinMax, List<ProductCategoryShort>, List<Yes24.Models.Product>, List<BrandShort>>>>(
                "Catalog/SearchListResultNew",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "rootCategoryNo", rootCategoryNo.ToString() },
                    new[]{ "keyword1", keyword1.ToString() },
                    new[]{ "keyword2", keyword2.ToString() },
                    new[]{ "brandNo", brandNo.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "inResultType", inResultType.ToString() },
                    new[]{ "pageCount", pageCount.ToString() },
                    new[]{ "rowCount", rowCount.ToString() },
                });
            return response.Data;
        }
        public List<DisplayCatalogProduct> GetBasketCatalog(string areaId, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProduct>>>(
                "Catalog/GetBasketCatalog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "areaId", areaId.ToString() },
                    new[]{ "rowCount", rowCount.ToString() }
                });
            return response.Data;
        }
        public List<DeliveryUnitBannerForFront> GetDeliveryUnitBannerForFront(int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DeliveryUnitBannerForFront>>>(
                "Catalog/GetDeliveryUnitBannerForFront",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }
        public List<DeliveryUnitContentsForFront> GetDeliveryUnitContentsForFront(int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DeliveryUnitContentsForFront>>>(
                "Catalog/GetDeliveryUnitContentsForFront",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductForDeliveryUnit> GetDeliveryUnitProduct(int deliveryUnitNo, string productCategoryCode, int brandNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductForDeliveryUnit>>>(
                "Catalog/GetDeliveryUnitProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "productCategoryCode", productCategoryCode.ToString() },
                    new[]{ "brandNo", brandNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() },
                });
            return response.Data;
        }
        public List<DisplayCatalogProductForDeliveryUnitPaging> GetDeliveryUnitProductPaging(int deliveryUnitNo, string productCategoryCode, int brandNo, string searchWord, double priceFrom, double priceTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductForDeliveryUnitPaging>>>(
                "Catalog/GetDeliveryUnitProductPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "productCategoryCode", productCategoryCode.ToString() },
                    new[]{ "brandNo", brandNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductForDeliveryUnitFirstCategory> GetDeliveryUnitFirstCategory(int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductForDeliveryUnitFirstCategory>>>(
                "Catalog/GetDeliveryUnitFirstCategory",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }
        public Tuple<List<DisplayCatalogProductForDeliveryUnitItemBrand>, List<DisplayCatalogProductForDeliveryUnitItemBrand>> GetDeliveryUnitSubItemBrand(int deliveryUnitNo, int firstCategoryNo, int productCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<DisplayCatalogProductForDeliveryUnitItemBrand>, List<DisplayCatalogProductForDeliveryUnitItemBrand>>>>(
                "Catalog/GetDeliveryUnitSubItemBrand",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "firstCategoryNo", firstCategoryNo.ToString() },
                    new[]{ "productCategoryNo", productCategoryNo.ToString() }
                });
            return response.Data;
        }
        public string GetDisplayCategoryName(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Catalog/GetDisplayCategoryName",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public Tuple<List<ProductInfoForFront2Model>, List<ProductInfoForFront>> GetClassifiedProduct(int categoryNo, string areaId, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<ProductInfoForFront2Model>, List<ProductInfoForFront>>>>(
                "Catalog/GetClassifiedProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "areaId", areaId.ToString() },
                    new[]{ "rowCount", rowCount.ToString() }
                });
            return response.Data;
        }
        public List<ProductReviewRecent> GetRecentProductReviewCatalog(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductReviewRecent>>>(
                "Catalog/GetRecentProductReviewCatalog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "firstCategoryNo", firstCategoryNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductItemCategory> GetItemCategoryBestProduct(int productNo, int sortType, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductItemCategory>>>(
                "Catalog/GetItemCategoryBestProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "productNo", productNo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "rowCount", rowCount.ToString() }
                });
            return response.Data;
        }
        public List<BrandSearch> SearchBrandList(int fCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<BrandSearch>>>(
                 "Catalog/SearchBrandList",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[]{ "fCategoryNo", fCategoryNo.ToString() }
                 });
            return response.Data;
        }
        public List<BrandSearchKeyword> SearchForBrandKeyword(string keyword)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<BrandSearchKeyword>>>(
                "Catalog/SearchForBrandKeyword",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "keyword", keyword.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductForDeliveryUnitPaging> GetProductByDeliveryUnitPaging(int deliveryUnitNo, int DisplayCategoryNo, string searchWord, double priceFrom, double priceTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductForDeliveryUnitPaging>>>(
                "Catalog/GetProductByDeliveryUnitPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "DisplayCategoryNo", DisplayCategoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByDeliveryUnit> GetProductByDeliveryUnit(int deliveryUnitNo, int DisplayCategoryNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByDeliveryUnit>>>(
                "Catalog/GetProductByDeliveryUnit",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "DisplayCategoryNo", DisplayCategoryNo.ToString() },
                    new[]{ "searchWord", searchWord },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByDeliveryUnit> GetTopProductByDeliveryUnit(int deliveryUnitNo, int SortType, int listSize)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByDeliveryUnit>>>(
                "Catalog/GetTopProductByDeliveryUnit",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "SortType", SortType.ToString() },
                    new[]{ "listSize", listSize.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogNewProductByTrendyPaging> GetNewProductByTrendyPaging(string searchWord, double priceFrom, double priceTo, int SortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogNewProductByTrendyPaging>>>(
                "Catalog/GetNewProductByTrendyPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "SortType", SortType.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogNewProductByTrendy> GetNewProductByTrendy(string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogNewProductByTrendy>>>(
                "Catalog/GetNewProductByTrendy",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() }
                });
            return response.Data;
        }
        public List<PopUpForCategody> GetCategoryPopup(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PopUpForCategody>>>(
                "Catalog/GetCategoryPopup",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public BrandShopConfig SelectBrandShopInfo(string brandName, int CategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<BrandShopConfig>>(
                 "Catalog/SelectBrandShopInfo",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[]{ "brandName", brandName.ToString() },
                    new[]{ "CategoryNo", CategoryNo.ToString() }
                 });
            return response.Data;
        }
        public List<BrandShopProductItem> GetBrandShopItemProduct(int categoryNo, string searchWord, double priceFrom, double priceTo, int sortType, string BrandNos, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<BrandShopProductItem>>>(
                "Catalog/GetBrandShopItemProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "BrandNos", BrandNos.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() }
                });
            return response.Data;
        }
        public List<BrandShopProductItemPaging> GetBrandShopItemProductPaging(int categoryNo, string searchWord, double priceFrom, double priceTo, string BrandNos)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<BrandShopProductItemPaging>>>(
                "Catalog/GetBrandShopItemProductPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "BrandNos", BrandNos.ToString() }
                });
            return response.Data;
        }
        public List<PromotionBannerMain> GetMobilePromotionMain(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMain>>>(
                "Catalog/GetMobilePromotionMain",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBestSeller> GetBestSellerItemProduct(string CategoryType, int TopRow)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBestSeller>>>(
                "Catalog/GetBestSellerItemProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "CategoryType", CategoryType.ToString() },
                    new[]{ "TopRow", TopRow.ToString() }
                });
            return response.Data;
        }

        public List<DisplayCatalogProductByBestSeller> GetBestSellerItemProductByMemberGUID(string CategoryType, int TopRow, string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBestSeller>>>(
                "Catalog/GetBestSellerItemProductByMemberGUID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "CategoryType", CategoryType.ToString() },
                    new[]{ "TopRow", TopRow.ToString() },
                    new[]{ "MemberGUID", MemberGUID.ToString() }
                });
            return response.Data;
        }

        public List<PromotionBannerMainV2> GetPCPromotionMainV2(int categoryNo, string promotionType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMainV2>>>(
                "Catalog/GetPCPromotionMainV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "promotionType", promotionType.ToString() }
                });
            return response.Data;
        }
        public List<PromotionBannerMainV2> GetPCPromotionMainV3(int categoryNo, string promotionType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMainV2>>>(
                "Catalog/GetPCPromotionMainV3",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "promotionType", promotionType.ToString() }
                });
            return response.Data;
        }
        public List<PromotionBannerMainV2> GetPCPromotionMainV4(int categoryNo, string promotionType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMainV2>>>(
                "Catalog/GetPCPromotionMainV4",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "promotionType", promotionType.ToString() }
                });
            return response.Data;
        }

        public List<PromotionBannerMainV2> GetPCPromotionMainV2ByMemberGUID(int categoryNo, string promotionType, string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMainV2>>>(
                "Catalog/GetPCPromotionMainV2ByMemberGUID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "promotionType", promotionType.ToString() },
                    new[]{ "MemberGUID", MemberGUID.ToString() }
                });
            return response.Data;
        } 
        public List<PromotionBannerMainV2> GetPCPromotionMainV3ByMemberGUID(int categoryNo, string promotionType, string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMainV2>>>(
                "Catalog/GetPCPromotionMainV3ByMemberGUID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "promotionType", promotionType.ToString() },
                    new[]{ "MemberGUID", MemberGUID.ToString() }
                });
            return response.Data;
        } 
        public List<PromotionBannerMainV2> GetPCPromotionMainV5ByMemberGUID(int categoryNo, string promotionType, string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMainV2>>>(
                "Catalog/GetPCPromotionMainV5ByMemberGUID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "promotionType", promotionType.ToString() },
                    new[]{ "MemberGUID", MemberGUID.ToString() }
                });
            return response.Data;
        }

        public void AddKeywordSearchLog(string KeyWord, string ClientIp, int IsProduct)
        {
            var response = GetDataFromApiOut<ResultAPI>(
                "Catalog/AddKeywordSearchLog",
                Method.POST,
                null,
                new List<string[]>
                {
                    new[] { "KeyWord", KeyWord.ToString() },
                    new[] { "ClientIp", ClientIp.ToString() },
                    new[] { "IsProduct", IsProduct.ToString() }
                });
        }
        public List<DisplayCatalogProductByBrandItemNew> GetItemProductNew(int categoryNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page, string ShoeFilter, string ShirtFilter, string CosmeFilter, string ElectFilter, string PhoneFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemNew>>>(
                "Catalog/GetItemProductNew",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() },
                    new[]{ "ShoeFilter", ShoeFilter.ToString() },
                    new[]{ "ShirtFilter", ShirtFilter.ToString() },
                    new[]{ "CosmeFilter", CosmeFilter.ToString() },
                    new[]{ "ElectFilter", ElectFilter.ToString() },
                    new[]{ "PhoneFilter", PhoneFilter.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemNewPaging> GetItemProductPagingNew(int categoryNo, string searchWord, double priceFrom, double priceTo, string ShoeFilter, string ShirtFilter, string CosmeFilter, string ElectFilter, string PhoneFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemNewPaging>>>(
                "Catalog/GetItemProductPagingNew",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "ShoeFilter", ShoeFilter.ToString() },
                    new[]{ "ShirtFilter", ShirtFilter.ToString() },
                    new[]{ "CosmeFilter", CosmeFilter.ToString() },
                    new[]{ "ElectFilter", ElectFilter.ToString() },
                    new[]{ "PhoneFilter", PhoneFilter.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemNew2Paging> GetItemProductPagingNew2(int categoryNo, string searchWord, double priceFrom, double priceTo, string ShoeFilter, string ShirtFilter, string CosmeFilter, string ElectFilter, string PhoneFilter, int sortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemNew2Paging>>>(
                "Catalog/GetItemProductPagingNew2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "ShoeFilter", ShoeFilter.ToString() },
                    new[]{ "ShirtFilter", ShirtFilter.ToString() },
                    new[]{ "CosmeFilter", CosmeFilter.ToString() },
                    new[]{ "ElectFilter", ElectFilter.ToString() },
                    new[]{ "PhoneFilter", PhoneFilter.ToString() },
                    new[]{ "sortType", sortType.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogHotItems> GetDisplayCatalogHotItems(int CategoryNo, string AreaId, int ItemNo, int RowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogHotItems>>>(
                "Catalog/GetDisplayCatalogHotItems",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "CategoryNo", CategoryNo.ToString() },
                    new[]{ "AreaId", AreaId.ToString() },
                    new[]{ "ItemNo", ItemNo.ToString() },
                    new[]{ "RowCount", RowCount.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemV2> GetBrandSubItemProductCompressV2(int productcategoryno, string brandNo, string searchWord, double priceFrom, double priceTo, int sortType, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemV2>>>(
                "Catalog/GetBrandSubItemProductCompressV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "productcategoryno", productcategoryno.ToString() },
                    new[]{ "brandNo", brandNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemPaging2V2> GetBrandSubItemProductPaging2V2(int itemNo, string brandCategoryNo, string searchWord, double priceFrom, double priceTo, int SortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemPaging2V2>>>(
                "Catalog/GetBrandSubItemProductPaging2V2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "itemNo", itemNo.ToString() },
                    new[]{ "brandCategoryNo", brandCategoryNo.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "SortType", SortType.ToString() }
                });
            return response.Data;
        }
        public List<DisplayCatalogProductByBrandItemV2> GetItemProductNewV2(int categoryNo, string brandFilter, string searchWord, int deliveryUnitNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string SizeFilter, string ColorFilter, string ShirtFilter, string CosmeFilter, string ElectFilter, string PhoneFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductByBrandItemV2>>>(
                "Catalog/GetItemProductNewV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "brandFilter", brandFilter.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() },
                    new[]{ "SizeFilter", SizeFilter.ToString() },
                    new[]{ "ColorFilter", ColorFilter.ToString() },
                    new[]{ "ShirtFilter", ShirtFilter.ToString() },
                    new[]{ "CosmeFilter", CosmeFilter.ToString() },
                    new[]{ "ElectFilter", ElectFilter.ToString() },
                    new[]{ "PhoneFilter", PhoneFilter.ToString() }
                });
            return response.Data;
        }
        public List<Models.Product> GetListProductV2(int categoryNo, string brandFilter, string searchWord, int deliveryUnitNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string sizeFilter, string colorFilter)
        {
            List<Yes24.Models.Product> listProduct = new List<Yes24.Models.Product>();
            List<DisplayCatalogProductByBrandItemV2> dsProduct = GetItemProductNewV2(categoryNo, brandFilter, searchWord, deliveryUnitNo, priceFrom, priceTo, sortType, listSize, page, sizeFilter, colorFilter, string.Empty, string.Empty, string.Empty, string.Empty);
            if (dsProduct != null && dsProduct.Count > 0)
            {
                foreach (var m in dsProduct)
                {
                    Yes24.Models.Product product = new Yes24.Models.Product();
                    product.BrandName = m.BrandName;
                    product.BrandNo = Utilities.CommonLib.IsNullInt32(m.BrandNo);
                    product.CategoryCode = Utilities.CommonLib.IsNullString(m.CategoryCode);
                    product.CategoryNo = Utilities.CommonLib.IsNullInt32(m.CategoryNo);
                    product.CouponInfo = Utilities.CommonLib.IsNullString(m.CouponInfo);
                    product.DateSystemRegister = m.DateSystemRegister.ToString().Substring(0, 10);
                    product.DeliveryClassCd = m.DeliveryClassCd;
                    product.DiscountPrice = Utilities.CommonLib.IsNullDecimal(m.DiscountPrice);
                    product.DisplayOrder = Utilities.CommonLib.IsNullInt32(m.DisplayOrder);
                    product.DisplayPrice = Utilities.CommonLib.IsNullDecimal(m.DisplayPrice);
                    product.DisplayProductName = m.DisplayProductName;
                    product.KeoSao = Utilities.CommonLib.IsNullDouble(m.KeoSao);
                    product.ListPrice = Utilities.CommonLib.IsNullDecimal(m.ListPrice);
                    product.Main_S = Utilities.CommonLib.IsNullString(m.Main_S);
                    product.Main_M = Utilities.CommonLib.IsNullString(m.Main_M);
                    product.Main_XS = Utilities.CommonLib.IsNullString(m.Main_XS);
                    product.Model = Utilities.CommonLib.IsNullString(m.Model);
                    product.OrderCountSum = Utilities.CommonLib.IsNullInt32(m.OrderCountSum);
                    product.OriginPrice = Utilities.CommonLib.IsNullDecimal(m.OriginPrice);
                    product.Point = Utilities.CommonLib.IsNullDouble(m.Point);
                    product.Price = Utilities.CommonLib.IsNullDecimal(m.Price);
                    product.ProductCategoryNo = Utilities.CommonLib.IsNullInt32(m.ProductCategoryNo);
                    product.ProductCode = m.ProductCode;
                    product.ProductName = m.ProductName;
                    product.ProductNo = Utilities.CommonLib.IsNullInt32(m.ProductNo);
                    product.ProductTypeCd = m.ProductTypeCd;
                    product.ReviewCountSum = Utilities.CommonLib.IsNullInt32(m.ReviewCountSum);
                    //product.RowNo = Utilities.CommonLib.IsNullInt64(m.RowNo.ToString());
                    product.SalePrice = Utilities.CommonLib.IsNullDecimal(m.SalePrice);
                    product.SellingStatusCd = m.SellingStatusCd;
                    product.Sticker = m.Sticker;
                    product.ViewCountSum = Utilities.CommonLib.IsNullInt32(m.ViewCountSum);
                    product.DeliveryUnitNo = Utilities.CommonLib.IsNullInt32(m.DeliveryUnitNo);
                    product.MCouponInfo = m.MCouponInfo;
                    product.ProductUrl = m.ProductURL;
                    product.ImageOrther = Utilities.CommonLib.IsNullString(m.ImageOrther);
                    product.PromotionTag = Utilities.CommonLib.IsNullString(m.PromotionTag);
                    product.SerialInfo = Utilities.CommonLib.IsNullString(m.SerialInfo);
                    product.SerialMaxDiscount = Utilities.CommonLib.IsNullDecimal(m.SerialMaxDiscount);
                    product.ProductGift = Utilities.CommonLib.IsNullString(m.ProductGiftList);
                    product.DeliveryType = Utilities.CommonLib.IsNullInt32(m.DeliveryType);
                    // product.ReviewCount =int.Parse(m.ReviewCount.ToString());
                    if (product.Point <= 10)
                    {
                        product.Point = (product.Point * (double)product.ListPrice) / 100;
                    }
                    if (product.KeoSao <= 10)
                    {
                        product.KeoSao = (product.KeoSao * (double)product.ListPrice) / 100;
                    }

                    listProduct.Add(product);
                }
            }
            return listProduct;
        }
        public int GetItemProductPagingNewV2(int categoryNo, string brandFilter, string searchWord, int deliveryUnitNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string sizeFilter, string colorFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Catalog/GetItemProductPagingNewV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "brandFilter", brandFilter.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() },
                    new[]{ "SizeFilter", sizeFilter.ToString() },
                    new[]{ "ColorFilter", colorFilter.ToString() },
                    new[]{ "ShirtFilter", "" },
                    new[]{ "CosmeFilter", "" },
                    new[]{ "ElectFilter", "" },
                    new[]{ "PhoneFilter", "" }
                });
            return response.Data;
        }
        public Tuple<ProductNavigation, List<ProductNavigation>, List<ProductNavigation>, List<ProductNavigation>> SelectCateForBrandExists(int categoryParentNo, int categoryNo, string brandFilter, int cateDepth)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<ProductNavigation, List<ProductNavigation>, List<ProductNavigation>, List<ProductNavigation>>>>(
                "Catalog/SelectCateForBrandExists",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryParentNo", categoryParentNo.ToString() },
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "brandFilter", brandFilter.ToString() },
                    new[]{ "cateDepth", cateDepth.ToString() }
                });
            return response.Data;
        }
        public List<GetKrProductList> GetKrProductList(string Type, string CateType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetKrProductList>>>(
                "Catalog/GetKrProductList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "Type", Type.ToString() },
                    new[]{ "CateType", CateType.ToString() }
                });
            return response.Data;
        }
        public List<GetKrProductList> GetKrProductListV2(string Type, string CateType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetKrProductList>>>(
                "Catalog/GetKrProductListV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "Type", Type.ToString() },
                    new[]{ "CateType", CateType.ToString() }
                });
            return response.Data;
        }
        public List<GetKrBanner> GetKrBanner(string Type)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetKrBanner>>>(
                "Catalog/GetKrBanner",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "Type", Type.ToString() }
                });
            return response.Data;
        }
        public List<GetCafeStyle> GetKrCafeStyle()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetCafeStyle>>>(
                 "Catalog/GetKrCafeStyle",
                 Method.GET,
                 null,
                 new List<string[]>
                 {

                 });
            return response.Data;
        }
        public Tuple<List<Yes24.Models.Product>, int> GetListProductV3(int categoryNo, string CategoryCode, string brandFilter, string searchWord, int deliveryUnitNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string sizeFilter, string colorFilter, string CountryFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<Yes24.Models.Product>, int>>>(
                "Catalog/GetListProductV3",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "CategoryCode", CategoryCode.ToString() },
                    new[]{ "brandFilter", brandFilter.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() },
                    new[]{ "sizeFilter", sizeFilter.ToString() },
                    new[]{ "colorFilter", colorFilter },
                    new[]{ "CountryFilter", CountryFilter },
                    new[]{ "ElectFilter", string.Empty },
                    new[]{ "PhoneFilter", string.Empty }
                });
            return response.Data;
        }
        public Tuple<List<Yes24.Models.Product>, int> GetListProductV4(int categoryNo, string CategoryCode, string brandFilter, string searchWord, int deliveryUnitNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string sizeFilter, string colorFilter, string CountryFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<Yes24.Models.Product>, int>>>(
                "Catalog/GetListProductV4",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "CategoryCode", CategoryCode.ToString() },
                    new[]{ "brandFilter", brandFilter.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() },
                    new[]{ "sizeFilter", sizeFilter.ToString() },
                    new[]{ "colorFilter", colorFilter },
                    new[]{ "CountryFilter", CountryFilter },
                    new[]{ "ElectFilter", string.Empty },
                    new[]{ "PhoneFilter", string.Empty }
                });
            return response.Data;
        }
        public Tuple<List<Yes24.Models.Product>, int> GetListProductEVocher(int categoryNo, string CategoryCode, string brandFilter, string searchWord, int deliveryUnitNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string sizeFilter, string colorFilter, string CountryFilter, int NationID, int CityID, int DistrictID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<Yes24.Models.Product>, int>>>(
                "Catalog/GetListProductEVocher",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "CategoryCode", CategoryCode.ToString() },
                    new[]{ "brandFilter", brandFilter.ToString() },
                    new[]{ "searchWord", searchWord.ToString() },
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[]{ "priceFrom", priceFrom.ToString() },
                    new[]{ "priceTo", priceTo.ToString() },
                    new[]{ "sortType", sortType.ToString() },
                    new[]{ "listSize", listSize.ToString() },
                    new[]{ "page", page.ToString() },
                    new[]{ "sizeFilter", sizeFilter.ToString() },
                    new[]{ "colorFilter", colorFilter },
                    new[]{ "CountryFilter", CountryFilter },
                    new[]{ "NationID", NationID.ToString() },
                    new[]{ "CityID", CityID.ToString() },
                    new[]{ "DistrictID", DistrictID.ToString() }
                });
            return response.Data;
        }
        public List<GetBannerMobile> GetBannerMobile(string BannerType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetBannerMobile>>>(
                "Catalog/GetBannerMobile",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "BannerType", BannerType.ToString() }
                });
            return response.Data;
        }
        public List<GetBannerProductMobile> GetBannerProductMobile(int IdBanner)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetBannerProductMobile>>>(
                "Catalog/GetBannerProductMobile",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "IdBanner", IdBanner.ToString() }
                });
            return response.Data;
        }
        public Tuple<List<SelectProductByProviderNo>, int> SelectProductByProviderNo(int productCategoryNo, string brandFilter, string providerFilter, string searchWord, int providerNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string SizeFilter, string ColorFilter, string ShirtFilter, string CosmeFilter, string ElectFilter, string PhoneFilter)
        {
            var data = new ProductByProviderNoSearch
            {
                ProductCategoryNo = productCategoryNo,
                BrandFilter = brandFilter,
                ProviderFilter = providerFilter,
                SearchWord = searchWord,
                ProviderNo = providerNo,
                PriceFrom = priceFrom,
                PriceTo = priceTo,
                SortType = sortType,
                ListSize = listSize,
                Page = page,
                SizeFilter = SizeFilter,
                ColorFilter = ColorFilter,
                CosmeFilter = CosmeFilter,
                ElectFilter = ElectFilter,
                PhoneFilter = PhoneFilter
            };
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<SelectProductByProviderNo>, int>>, ProductByProviderNoSearch>(
                "Catalog/SelectProductByProviderNo",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }
        public List<GetListBrandKotra> GetListBrandKotra(string providerFilter, string ProductCategoryNo, string BrandFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetListBrandKotra>>>(
                 "Catalog/GetListBrandKotra",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[]{ "providerFilter", providerFilter.ToString() },
                    new[]{ "ProductCategoryNo", ProductCategoryNo.ToString() },
                    new[]{ "BrandFilter", BrandFilter.ToString() }
                 });
            return response.Data;
        }
        public List<GetListCategoryKotra> GetListCategoryKotra(string providerFilter, string RootCate, string BrandFilter)
        {
            var data = new ProductByProviderNoSearch
            {
                ProviderFilter = providerFilter,
                RootCate = RootCate,
                BrandFilter = BrandFilter
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<GetListCategoryKotra>>, ProductByProviderNoSearch>(
                "Catalog/GetListCategoryKotra",
                 Method.POST,
                null,
                null,
                data);
            return response.Data;
        }
        public List<GetListProductFilter> GetListProductFilter(string ProductCodeFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetListProductFilter>>>(
                "Catalog/GetListProductFilter",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "ProductCodeFilter", ProductCodeFilter.ToString() }
                });
            return response.Data;
        }
        public List<Yes24.Models.Product> GetListProductCode(string ProductCodeFilter)
        {
            List<Yes24.Models.Product> listProduct = new List<Yes24.Models.Product>();
            List<GetListProductFilter> dsProduct = GetListProductFilter(ProductCodeFilter);
            if (dsProduct != null && dsProduct.Count > 0)
            {
                foreach (var m in dsProduct)
                {
                    Yes24.Models.Product product = new Yes24.Models.Product();
                    product.BrandName = Utilities.CommonLib.IsNullString(m.BrandName);
                    product.BrandNo = Utilities.CommonLib.IsNullInt32(m.BrandNo);
                    product.CategoryCode = Utilities.CommonLib.IsNullString(m.CategoryCode);
                    //product.CategoryNo = Utilities.CommonLib.IsNullInt32(m.CategoryNo);
                    product.CouponInfo = Utilities.CommonLib.IsNullString(m.CouponInfo);
                    product.DateSystemRegister = m.DateSystemRegister.ToString().Substring(0, 10);
                    product.DeliveryClassCd = m.DeliveryClassCd.ToString();
                    product.DiscountPrice = Utilities.CommonLib.IsNullDecimal(m.DiscountPrice);
                    product.DisplayOrder = Utilities.CommonLib.IsNullInt32(m.DisplayOrder);
                    product.DisplayPrice = Utilities.CommonLib.IsNullDecimal(m.DisplayPrice);
                    product.DisplayProductName = m.DisplayProductName.ToString();
                    product.KeoSao = Utilities.CommonLib.IsNullDouble(m.KeoSao);
                    product.ListPrice = Utilities.CommonLib.IsNullDecimal(m.ListPrice);
                    product.Main_S = m.Main_S.ToString();
                    product.Main_M = m.Main_M.ToString();
                    product.Main_XS = m.Main_XS.ToString();
                    product.Model = m.Model.ToString();
                    product.OrderCountSum = Utilities.CommonLib.IsNullInt32(m.OrderCountSum);
                    product.OriginPrice = Utilities.CommonLib.IsNullDecimal(m.OriginPrice);
                    product.Point = Utilities.CommonLib.IsNullDouble(m.Point);
                    product.Price = Utilities.CommonLib.IsNullDecimal(m.Price);
                    product.ProductCategoryNo = Utilities.CommonLib.IsNullInt32(m.ProductCategoryNo);
                    product.ProductCode = m.ProductCode.ToString();
                    product.ProductName = m.ProductName.ToString();
                    product.ProductNo = Utilities.CommonLib.IsNullInt32(m.ProductNo);
                    product.ProductTypeCd = m.ProductTypeCd.ToString();
                    product.ReviewCountSum = Utilities.CommonLib.IsNullInt32(m.ReviewCountSum);
                    //product.RowNo = Utilities.CommonLib.IsNullInt64(m.RowNo.ToString());
                    product.SalePrice = Utilities.CommonLib.IsNullDecimal(m.SalePrice);
                    product.SellingStatusCd = m.SellingStatusCd.ToString();
                    product.Sticker = m.Sticker.ToString();
                    product.ViewCountSum = Utilities.CommonLib.IsNullInt32(m.ViewCountSum);
                    product.DeliveryUnitNo = Utilities.CommonLib.IsNullInt32(m.DeliveryUnitNo);
                    product.MCouponInfo = m.MCouponInfo.ToString();
                    product.ProductUrl = m.ProductURL.ToString();
                    product.ImageOrther = Utilities.CommonLib.IsNullString(m.ImageOrther);
                    product.PromotionTag = Utilities.CommonLib.IsNullString(m.PromotionTag);
                    product.SerialInfo = Utilities.CommonLib.IsNullString(m.SerialInfo);
                    product.SerialMaxDiscount = Utilities.CommonLib.IsNullDecimal(m.SerialMaxDiscount);
                    product.ProductGift = Utilities.CommonLib.IsNullString(m.ProductGiftList);
                    product.DeliveryType = Utilities.CommonLib.IsNullInt32(m.DeliveryType);
                    // product.ReviewCount =int.Parse(m.ReviewCount.ToString());
                    //Check Point And KeoSao
                    if (product.Point <= 10)
                    {
                        product.Point = (product.Point * (double)product.ListPrice) / 100;
                    }
                    if (product.KeoSao <= 10)
                    {
                        product.KeoSao = (product.KeoSao * (double)product.ListPrice) / 100;
                    }

                    listProduct.Add(product);
                }
            }
            return listProduct;
        }
        public List<Yes24.Models.Product> GetListProductKotra(int categoryNo, string brandFilter, string providerFilter, string searchWord, int deliveryUnitNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string sizeFilter, string colorFilter, ref int Total)
        {
            List<Yes24.Models.Product> listProduct = new List<Yes24.Models.Product>();
            var data = SelectProductByProviderNo(categoryNo, brandFilter, providerFilter, searchWord, deliveryUnitNo, priceFrom, priceTo, sortType, listSize, page, sizeFilter, colorFilter,
                 string.Empty, string.Empty, string.Empty, string.Empty);
            if (data != null)
            {
                if (data.Item1 != null && data.Item1.Count > 0)
                {
                    foreach (var m in data.Item1)
                    {
                        Yes24.Models.Product product = new Yes24.Models.Product();
                        product.BrandName = Utilities.CommonLib.IsNullString(m.BrandName);
                        product.BrandNo = Utilities.CommonLib.IsNullInt32(m.BrandNo);
                        product.CategoryCode = Utilities.CommonLib.IsNullString(m.CategoryCode);
                        //product.CategoryNo = Utilities.CommonLib.IsNullInt32(m.CategoryNo);
                        product.CouponInfo = Utilities.CommonLib.IsNullString(m.CouponInfo);
                        product.DateSystemRegister = m.DateSystemRegister.ToString().Substring(0, 10);
                        product.DeliveryClassCd = m.DeliveryClassCd;
                        product.DiscountPrice = Utilities.CommonLib.IsNullDecimal(m.DiscountPrice);
                        product.DisplayOrder = Utilities.CommonLib.IsNullInt32(m.DisplayOrder);
                        product.DisplayPrice = Utilities.CommonLib.IsNullDecimal(m.DisplayPrice);
                        product.DisplayProductName = m.DisplayProductName;
                        product.KeoSao = Utilities.CommonLib.IsNullDouble(m.KeoSao);
                        product.ListPrice = Utilities.CommonLib.IsNullDecimal(m.ListPrice);
                        product.Main_S = m.Main_S;
                        product.Main_M = m.Main_M;
                        product.Main_XS = m.Main_XS;
                        product.Model = m.Model;
                        product.OrderCountSum = Utilities.CommonLib.IsNullInt32(m.OrderCountSum);
                        product.OriginPrice = Utilities.CommonLib.IsNullDecimal(m.OriginPrice);
                        product.Point = Utilities.CommonLib.IsNullDouble(m.Point);
                        product.Price = Utilities.CommonLib.IsNullDecimal(m.Price);
                        product.ProductCategoryNo = Utilities.CommonLib.IsNullInt32(m.ProductCategoryNo);
                        product.ProductCode = m.ProductCode;
                        product.ProductName = m.ProductName;
                        product.ProductNo = Utilities.CommonLib.IsNullInt32(m.ProductNo);
                        product.ProductTypeCd = m.ProductTypeCd;
                        product.ReviewCountSum = Utilities.CommonLib.IsNullInt32(m.ReviewCountSum);
                        //product.RowNo = Utilities.CommonLib.IsNullInt64(m.RowNo.ToString());
                        product.SalePrice = Utilities.CommonLib.IsNullDecimal(m.SalePrice);
                        product.SellingStatusCd = m.SellingStatusCd;
                        product.Sticker = m.Sticker;
                        product.ViewCountSum = Utilities.CommonLib.IsNullInt32(m.ViewCountSum);
                        product.DeliveryUnitNo = Utilities.CommonLib.IsNullInt32(m.DeliveryUnitNo);
                        product.MCouponInfo = m.MCouponInfo;
                        product.ProductUrl = m.ProductURL;
                        product.ImageOrther = Utilities.CommonLib.IsNullString(m.ImageOrther);
                        product.PromotionTag = Utilities.CommonLib.IsNullString(m.PromotionTag);
                        product.SerialInfo = Utilities.CommonLib.IsNullString(m.SerialInfo);
                        product.SerialMaxDiscount = Utilities.CommonLib.IsNullDecimal(m.SerialMaxDiscount);
                        product.ProductGift = Utilities.CommonLib.IsNullString(m.ProductGiftList);
                        product.DeliveryType = Utilities.CommonLib.IsNullInt32(m.DeliveryType);
                        // product.ReviewCount =int.Parse(m.ReviewCount.ToString());
                        //Check Point And KeoSao
                        if (product.Point <= 10)
                        {
                            product.Point = (product.Point * (double)product.ListPrice) / 100;
                        }
                        if (product.KeoSao <= 10)
                        {
                            product.KeoSao = (product.KeoSao * (double)product.ListPrice) / 100;
                        }

                        listProduct.Add(product);
                    }
                }
                if (CommonLib.IsNullInt32(data.Item2, 0) != 0)
                {
                    Total = data.Item2;
                }
                else
                    Total = 0;
            }

            return listProduct;
        }
        public List<LeftBrandModel> GetBrandNobyDeliveryUnitNoDapper(int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<LeftBrandModel>>>(
                "Catalog/GetBrandNobyDeliveryUnitNoDapper",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }
        public void InsertProductSeen(string memberGuid, string productArr, int productNo)
        {
            var response = GetDataFromApiOut<ResultAPI>(
                "Catalog/InsertProductSeen",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGuid", memberGuid.ToString() },
                    new[] { "productArr", productArr.ToString() },
                    new[] { "productNo", productNo.ToString() }
                });
        }
        public List<Yes24.Models.Product> GetProductSeen(string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24.Models.Product>>>(
            "Catalog/GetProductSeen",
            Method.GET,
            null,
            new List<string[]>
            {
                new[]{ "memberGuid", memberGuid.ToString() }
            });
            return response.Data;

        }
        public List<SelectBestBrandItemProductNewProviderNo> GetBestItemProductNewByProviderNo(int providerNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SelectBestBrandItemProductNewProviderNo>>>(
             "Catalog/GetBestItemProductNewByProviderNo",
             Method.GET,
             null,
             new List<string[]>
             {
                new[]{ "providerNo", providerNo.ToString() }
             });
            return response.Data;
        }
        public List<Yes24.Models.Product> GetListBestProductByProviderNo(int providerNo)
        {
            //CatalogSVC catalog = new Catalog();
            List<Yes24.Models.Product> listProduct = new List<Yes24.Models.Product>();
            var dsProduct = GetBestItemProductNewByProviderNo(providerNo);
            if (dsProduct != null && dsProduct.Count > 0)
            {
                foreach (var m in dsProduct)
                {
                    Yes24.Models.Product product = new Yes24.Models.Product();
                    product.BrandName = Utilities.CommonLib.IsNullString(m.BrandName);
                    product.BrandNo = Utilities.CommonLib.IsNullInt32(m.BrandNo);
                    product.CategoryCode = Utilities.CommonLib.IsNullString(m.CategoryCode);
                    //product.CategoryNo = Utilities.CommonLib.IsNullInt32(m.CategoryNo);
                    product.CouponInfo = Utilities.CommonLib.IsNullString(m.CouponInfo);
                    product.DateSystemRegister = m.DateSystemRegister.ToString().Substring(0, 10);
                    product.DeliveryClassCd = m.DeliveryClassCd;
                    product.DiscountPrice = Utilities.CommonLib.IsNullDecimal(m.DiscountPrice);
                    product.DisplayOrder = Utilities.CommonLib.IsNullInt32(m.DisplayOrder);
                    product.DisplayPrice = Utilities.CommonLib.IsNullDecimal(m.DisplayPrice);
                    product.DisplayProductName = m.DisplayProductName;
                    product.KeoSao = Utilities.CommonLib.IsNullDouble(m.KeoSao);
                    product.ListPrice = Utilities.CommonLib.IsNullDecimal(m.ListPrice);
                    product.Main_S = m.Main_S;
                    product.Main_M = m.Main_M;
                    product.Main_XS = m.Main_XS;
                    product.Model = m.Model;
                    product.OrderCountSum = Utilities.CommonLib.IsNullInt32(m.OrderCountSum);
                    product.OriginPrice = Utilities.CommonLib.IsNullDecimal(m.OriginPrice);
                    product.Point = Utilities.CommonLib.IsNullDouble(m.Point);
                    product.Price = Utilities.CommonLib.IsNullDecimal(m.Price);
                    product.ProductCategoryNo = Utilities.CommonLib.IsNullInt32(m.ProductCategoryNo);
                    product.ProductCode = m.ProductCode.ToString();
                    product.ProductName = m.ProductName.ToString();
                    product.ProductNo = Utilities.CommonLib.IsNullInt32(m.ProductNo);
                    product.ProductTypeCd = m.ProductTypeCd;
                    product.ReviewCountSum = Utilities.CommonLib.IsNullInt32(m.ReviewCountSum);
                    //product.RowNo = Utilities.CommonLib.IsNullInt64(m.RowNo.ToString());
                    product.SalePrice = Utilities.CommonLib.IsNullDecimal(m.SalePrice);
                    product.SellingStatusCd = m.SellingStatusCd;
                    product.Sticker = m.Sticker;
                    product.ViewCountSum = Utilities.CommonLib.IsNullInt32(m.ViewCountSum);
                    product.DeliveryUnitNo = Utilities.CommonLib.IsNullInt32(m.DeliveryUnitNo);
                    product.MCouponInfo = m.MCouponInfo;
                    product.ProductUrl = m.ProductURL;
                    product.ImageOrther = Utilities.CommonLib.IsNullString(m.ImageOrther);
                    product.PromotionTag = Utilities.CommonLib.IsNullString(m.PromotionTag);
                    product.SerialInfo = Utilities.CommonLib.IsNullString(m.SerialInfo);
                    product.SerialMaxDiscount = Utilities.CommonLib.IsNullDecimal(m.SerialMaxDiscount);
                    product.ProductGift = Utilities.CommonLib.IsNullString(m.ProductGiftList);
                    product.DeliveryType = Utilities.CommonLib.IsNullInt32(m.DeliveryType);
                    // product.ReviewCount =int.Parse(m.ReviewCount.ToString());
                    //Check Point And KeoSao
                    if (product.Point <= 10)
                    {
                        product.Point = (product.Point * (double)product.ListPrice) / 100;
                    }
                    if (product.KeoSao <= 10)
                    {
                        product.KeoSao = (product.KeoSao * (double)product.ListPrice) / 100;
                    }
                    listProduct.Add(product);
                }
            }
            return listProduct;
        }
        public Tuple<List<SelectBrandItemProductNewProviderNo>, int> GetItemProductNewByProviderNo(int categoryNo, string brandFilter, string searchWord, int providerNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string SizeFilter, string ColorFilter, string ShirtFilter, string CosmeFilter, string ElectFilter, string PhoneFilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<SelectBrandItemProductNewProviderNo>, int>>>(
            "Catalog/SelectBrandItemProductNewProviderNo",
            Method.GET,
            null,
            new List<string[]>
            {
                new[]{ "productCategoryNo", categoryNo.ToString() },
                new[]{ "brandFilter", brandFilter.ToString() },
                new[]{ "searchWord", searchWord.ToString() },
                new[]{ "providerNo", providerNo.ToString() },
                new[]{ "priceFrom", priceFrom.ToString() },
                new[]{ "priceTo", priceTo.ToString() },
                new[]{ "sortType", sortType.ToString() },
                new[]{ "listSize", listSize.ToString() },
                new[]{ "page", page.ToString() },
                new[]{ "SizeFilter", SizeFilter.ToString() },
                new[]{ "ColorFilter", ColorFilter.ToString() },
                new[]{ "ShirtFilter", ShirtFilter.ToString() },
                new[]{ "CosmeFilter", CosmeFilter.ToString() },
                new[]{ "ElectFilter", ElectFilter.ToString() },
                new[]{ "PhoneFilter", PhoneFilter.ToString() }
            });
            return response.Data;
        }
        public List<Yes24.Models.Product> GetListProductByProviderNo(int categoryNo, string brandFilter, string searchWord, int providerNo, double priceFrom, double priceTo, int sortType, int listSize, int page, string sizeFilter, string colorFilter, ref int totalRow)
        {
            List<Yes24.Models.Product> listProduct = new List<Yes24.Models.Product>();
            var dsProduct = GetItemProductNewByProviderNo(categoryNo, brandFilter, searchWord, providerNo, priceFrom, priceTo, sortType, listSize, page, sizeFilter, colorFilter,
               string.Empty, string.Empty, string.Empty, string.Empty);
            if (dsProduct != null && dsProduct.Item1 != null && dsProduct.Item1.Count > 0)
            {
                foreach (var m in dsProduct.Item1)
                {
                    Yes24.Models.Product product = new Yes24.Models.Product();
                    product.BrandName = Utilities.CommonLib.IsNullString(m.BrandName);
                    product.BrandNo = Utilities.CommonLib.IsNullInt32(m.BrandNo);
                    product.CategoryCode = Utilities.CommonLib.IsNullString(m.CategoryCode);
                    //product.CategoryNo = Utilities.CommonLib.IsNullInt32(m.CategoryNo);
                    product.CouponInfo = Utilities.CommonLib.IsNullString(m.CouponInfo);
                    product.DateSystemRegister = m.DateSystemRegister.ToString().Substring(0, 10);
                    product.DeliveryClassCd = m.DeliveryClassCd;
                    product.DiscountPrice = Utilities.CommonLib.IsNullDecimal(m.DiscountPrice);
                    product.DisplayOrder = Utilities.CommonLib.IsNullInt32(m.DisplayOrder);
                    product.DisplayPrice = Utilities.CommonLib.IsNullDecimal(m.DisplayPrice);
                    product.DisplayProductName = m.DisplayProductName;
                    product.KeoSao = Utilities.CommonLib.IsNullDouble(m.KeoSao);
                    product.ListPrice = Utilities.CommonLib.IsNullDecimal(m.ListPrice);
                    product.Main_S = m.Main_S;
                    product.Main_M = m.Main_M;
                    product.Main_XS = m.Main_XS;
                    product.Model = m.Model;
                    product.OrderCountSum = Utilities.CommonLib.IsNullInt32(m.OrderCountSum);
                    product.OriginPrice = Utilities.CommonLib.IsNullDecimal(m.OriginPrice);
                    product.Point = Utilities.CommonLib.IsNullDouble(m.Point);
                    product.Price = Utilities.CommonLib.IsNullDecimal(m.Price);
                    product.ProductCategoryNo = Utilities.CommonLib.IsNullInt32(m.ProductCategoryNo);
                    product.ProductCode = m.ProductCode;
                    product.ProductName = m.ProductName;
                    product.ProductNo = Utilities.CommonLib.IsNullInt32(m.ProductNo);
                    product.ProductTypeCd = m.ProductTypeCd;
                    product.ReviewCountSum = Utilities.CommonLib.IsNullInt32(m.ReviewCountSum);
                    //product.RowNo = Utilities.CommonLib.IsNullInt64(m.RowNo.ToString());
                    product.SalePrice = Utilities.CommonLib.IsNullDecimal(m.SalePrice);
                    product.SellingStatusCd = m.SellingStatusCd;
                    product.Sticker = m.Sticker;
                    product.ViewCountSum = Utilities.CommonLib.IsNullInt32(m.ViewCountSum);
                    product.DeliveryUnitNo = Utilities.CommonLib.IsNullInt32(m.DeliveryUnitNo);
                    product.MCouponInfo = m.MCouponInfo;
                    product.ProductUrl = m.ProductURL;
                    product.ImageOrther = Utilities.CommonLib.IsNullString(m.ImageOrther);
                    product.PromotionTag = Utilities.CommonLib.IsNullString(m.PromotionTag);
                    product.SerialInfo = Utilities.CommonLib.IsNullString(m.SerialInfo);
                    product.SerialMaxDiscount = Utilities.CommonLib.IsNullDecimal(m.SerialMaxDiscount);
                    product.ProductGift = Utilities.CommonLib.IsNullString(m.ProductGiftList);
                    product.DeliveryType = Utilities.CommonLib.IsNullInt32(m.DeliveryType);
                    // product.ReviewCount =int.Parse(m.ReviewCount.ToString());
                    //Check Point And KeoSao
                    if (product.Point <= 10)
                    {
                        product.Point = (product.Point * (double)product.ListPrice) / 100;
                    }
                    if (product.KeoSao <= 10)
                    {
                        product.KeoSao = (product.KeoSao * (double)product.ListPrice) / 100;
                    }

                    listProduct.Add(product);

                }
                totalRow = dsProduct.Item2;
            }
            return listProduct;
        }
        public async Task<int> InsertProductSeenAsync(string memberGuid, string productArr, int productNo)
        {
            var response = await GetDataFromApiOutAsyn<BaseResultAPI<int>>(
                "Catalog/InsertProductSeenAsync",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGuid", memberGuid },
                    new[] { "productArr", productArr },
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<PromotionBannerMainV2> GetMobilePromotionMainV2(int categoryNo, string promotionType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PromotionBannerMainV2>>>(
                "Catalog/GetMobilePromotionMainV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "categoryNo", categoryNo.ToString() },
                    new[]{ "promotionType", promotionType.ToString() }
                });
            return response.Data;
        }
        public List<ShopGiaoNhanhBanner> GetShopGiaoNhanhBanner(int CategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ShopGiaoNhanhBanner>>>(
                "Catalog/GetShopGiaoNhanhBanner",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "CategoryNo", CategoryNo.ToString() },
                });
            return response.Data;
        }
        public Tuple<List<ShopGiaoNhanhBrand>, List<DisplayCatalogProductByDeliveryUnit>> SelectYes24MallBrandProduct(int CategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<ShopGiaoNhanhBrand>, List<DisplayCatalogProductByDeliveryUnit>>>>(
                "Catalog/Yes24MallBrandProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[]{ "CategoryNo", CategoryNo.ToString() }
                });
            return response.Data;
        }
    }
}
