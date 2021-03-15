using RestSharp;
using System;
using System.Collections.Generic;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Catalog;
using Yes24.DTO.Vendor;
using Yes24.Models;

namespace Yes24.APIService.DisplayCategory
{
    public class DisplayCategoryAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<DisplayCategoryAPI> lazy = new Lazy<DisplayCategoryAPI>(() => new DisplayCategoryAPI());
        public static DisplayCategoryAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<DisplayCategoryTree> GetTree()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryTree>>>(
                "DisplayCategory/GetTree",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public List<BrandDetail> GetBrandDetailByBrandNo(int BrandNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<BrandDetail>>>(
                "DisplayCategory/GetBrandDetailByBrandNo",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategoryTree> GetTreeCompress()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryTree>>>(
                "DisplayCategory/GetTreeCompress",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategoryTreeForFlash> GetTreeForFlash()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryTreeForFlash>>>(
                            "DisplayCategory/GetTreeForFlash",
                            Method.GET,
                            null,
                            null);
            return response.Data;
        }

        public List<DisplayCategoryRoot> GetRootCategory()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryRoot>>>(
                "DisplayCategory/GetRootCategory",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategoryRoot> GetRootCategoryCompress()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryRoot>>>(
                 "DisplayCategory/GetRootCategoryCompress",
                 Method.GET,
                 null,
                 null);
            return response.Data;
        }

        public List<DisplayCategoryFirst> GetFirstCategory()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryFirst>>>(
                "DisplayCategory/GetFirstCategory",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<DisplayCategoryFirst> GetFirstCategoryCompress()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryFirst>>>(
                 "DisplayCategory/GetFirstCategoryCompress",
                 Method.GET,
                 null,
                 null);
            return response.Data;
        }

        public List<DisplayCategorySub> GetSubCategory(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySub>>>(
                 "DisplayCategory/GetSubCategory",
                 Method.GET,
                 null,
                 new List<string[]> { new[] { "categoryNo", categoryNo.ToString() } });
            return response.Data;
        }

        public List<DisplayCategorySub> GetSubCategoryCompress(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySub>>>(
                "DisplayCategory/GetSubCategoryCompress",
                Method.GET,
                null,
                new List<string[]> { new[] { "categoryNo", categoryNo.ToString() } });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetSubCategoryByClassType(int categoryNo, string classTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                      "DisplayCategory/GetSubCategoryByClassType",
                      Method.GET,
                      null,
                      new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "classTypeCd", classTypeCd }
                      });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetSubCategoryByClassTypeCompress(int categoryNo, string classTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                  "DisplayCategory/GetSubCategoryByClassTypeCompress",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "classTypeCd", classTypeCd }
                  });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd_V2> GetSubCategoryByClassTypeV2(string displaycategorycode, int categoryNo, string classTypeCd, string countryfilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd_V2>>>(
                  "DisplayCategory/GetSubCategoryByClassTypeV2",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode },
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "classTypeCd", classTypeCd },
                    new[] { "countryfilter", countryfilter }
                  });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd_V2> GetSubCategoryByClassTypeV4(int categoryNo, string countryfilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd_V2>>>(
                "DisplayCategory/GetSubCategoryByClassTypeV4",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "countryfilter", countryfilter }
                });
            return response.Data;
        }

        public List<USP_CAT_ProductCategoryNo_DisplayCategoryCodeForFrontV6_Q> SelectProductCategoryNoByDisplayCategoryV6(string displaycategorycode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_CAT_ProductCategoryNo_DisplayCategoryCodeForFrontV6_Q>>>(
                 "DisplayCategory/SelectProductCategoryNoByDisplayCategoryV6",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode }
                 });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetItemGroupCategory(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                  "DisplayCategory/GetItemGroupCategory",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "firstCategoryNo", firstCategoryNo.ToString() }
                  });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetItemGroupCategoryCompress(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                "DisplayCategory/GetItemGroupCategoryCompress",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "firstCategoryNo", firstCategoryNo.ToString() }
                });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetBrandZoneCategory(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                  "DisplayCategory/GetBrandZoneCategory",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "firstCategoryNo", firstCategoryNo.ToString() }
                  });
            return response.Data;
        }

        public List<DisplayCategorySubByClassTypeCd> GetBrandZoneCategoryCompress(int firstCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategorySubByClassTypeCd>>>(
                 "DisplayCategory/GetBrandZoneCategoryCompress",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "firstCategoryNo", firstCategoryNo.ToString() }
                 });
            return response.Data;
        }

        public List<DisplayCategoryData> GetBrandSubItemCategory(int brandCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryData>>>(
                 "DisplayCategory/GetBrandSubItemCategory",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "brandCategoryNo", brandCategoryNo.ToString() }
                 });
            return response.Data;
        }

        public List<DisplayCategoryBrandSubItem> GetBrandSubItemCategoryForV2(int brandNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryBrandSubItem>>>(
                  "DisplayCategory/GetBrandSubItemCategoryForV2",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "brandNo", brandNo.ToString() }
                  });
            return response.Data;
        }

        public List<DisplayCategoryBrandSubItem> GetBrandSubItemCategoryCompress(int brandCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryBrandSubItem>>>(
                 "DisplayCategory/GetBrandSubItemCategoryCompress",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "brandCategoryNo", brandCategoryNo.ToString() }
                 });
            return response.Data;
        }

        public string GetImage(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                   "DisplayCategory/GetImage",
                   Method.GET,
                   null,
                   new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                   });
            return response.Data;
        }

        public DisplayCategoryData GetDisplayCaetgoryDetailCompress(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<DisplayCategoryData>>(
                 "DisplayCategory/GetDisplayCaetgoryDetailCompress",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                 });
            return response.Data;
        }

        public DisplayCategoryData GetDisplayCategoryDetailByDataSet(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<DisplayCategoryData>>(
                  "DisplayCategory/GetDisplayCategoryDetailByDataSet",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                  });
            return response.Data;
        }

        public DisplayCategoryData GetDisplayCategoryDetail(int categoryNo)
        {
            return GetDisplayCategoryDetailByDataSetCompress(categoryNo);
        }

        public DisplayCategoryData GetDisplayCategoryDetailByDataSetCompress(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<DisplayCategoryData>>(
                "DisplayCategory/GetDisplayCategoryDetailByDataSet",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                });
            return response.Data;
        }

        public string GetCategoryPath(int categoryNo, int fCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                 "DisplayCategory/GetCategoryPath",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "fCategoryNo", fCategoryNo.ToString() }
                 });
            return response.Data;
        }

        public List<BrandLogo> GetBrandCategoryLogo(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<BrandLogo>>>(
                  "DisplayCategory/GetBrandCategoryLogo",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                  });
            return response.Data;
        }

        public string GetDisplayCategoryName(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                 "DisplayCategory/GetDisplayCategoryName",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                 });
            return response.Data;
        }

        public string SelectDisplayCategoryName_BrandV2(string displaycategorycode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                 "DisplayCategory/SelectDisplayCategoryName_BrandV2",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode.ToString() }
                 });
            return response.Data;
        }

        public string SelectDisplayCategoryName_BrandNameV2(string displaycategorycode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "DisplayCategory/SelectDisplayCategoryName_BrandNameV2",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode.ToString() }
                });
            return response.Data;
        }

        public ProductCategoryNo_DisplayCategoryCodeForFront SelectProductCategoryNoByDisplayCategoryV2(string displaycategorycode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductCategoryNo_DisplayCategoryCodeForFront>>(
                "DisplayCategory/SelectProductCategoryNoByDisplayCategoryV2",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode }
                });
            return response.Data;
        }

        public ProductCategoryNo_DisplayCategoryCodeForFrontV4 SelectProductCategoryNoByDisplayCategoryV4(string displaycategorycode, int pCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductCategoryNo_DisplayCategoryCodeForFrontV4>>(
                            "DisplayCategory/SelectProductCategoryNoByDisplayCategoryV4",
                            Method.GET,
                            null,
                            new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode.ToString() },
                    new[] { "pCategoryNo", pCategoryNo.ToString() }
                            });
            return response.Data;
        }

        public string SelectProductCategoryNoByDisplayCategoryV3(string displaycategorycode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                      "DisplayCategory/SelectProductCategoryNoByDisplayCategoryV3",
                      Method.GET,
                      null,
                      new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode.ToString() }
                      });
            return response.Data;
        }

        public string ReDirectCategorySearch(string displaycategorycode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                      "DisplayCategory/ReDirectCategorySearch",
                      Method.GET,
                      null,
                      new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode.ToString() }
                      });
            return response.Data;
        }

        public string SelectPathByDisplayCategoryV4(string displaycategorycode, int pCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "DisplayCategory/SelectPathByDisplayCategoryV4",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode },
                    new[] { "pCategoryNo", pCategoryNo.ToString() }
                });
            return response.Data;
        }

        public string GetFullDisplayCategoryName(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                            "DisplayCategory/GetFullDisplayCategoryName",
                            Method.GET,
                            null,
                            new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                            });
            return response.Data;
        }

        public List<DisplayCategoryTreeByCate> GetDisplayCategoryTreeByCate(int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryTreeByCate>>>(
                      "DisplayCategory/GetDisplayCategoryTreeByCate",
                      Method.GET,
                      null,
                      new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() }
                      });
            return response.Data;
        }

        public List<DisplayCategoryDeatailByCode> SelectDisplayCategoryDeatailByCate(string categoryCode, int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryDeatailByCode>>>(
                     "DisplayCategory/SelectDisplayCategoryDeatailByCate",
                     Method.GET,
                     null,
                     new List<string[]> {
                    new[] { "categoryCode", categoryCode.ToString() },
                    new[] { "categoryNo", categoryNo.ToString() }
                     });
            return response.Data;
        }

        public string GetBreadCrumbV2(string displayCategoryCode, int depth, string brand, int productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "DisplayCategory/GetBreadCrumbV2",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "displayCategoryCode", displayCategoryCode },
                    new[] { "depth", depth.ToString() },
                    new[] { "brand", brand },
                    new[] { "productCode", productCode.ToString() }
                });
            return response.Data;
        }

        public List<DisplayCategoryDeatailByCode_V2> SelectDisplayDeatailByCateCodeV2(string categoryCode, int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCategoryDeatailByCode_V2>>>(
                            "DisplayCategory/SelectDisplayDeatailByCateCodeV2",
                            Method.GET,
                            null,
                            new List<string[]> {
                    new[] { "categoryCode", categoryCode },
                    new[] { "categoryNo", categoryNo.ToString() }
                            });
            return response.Data;
        }

        public List<GetBrandInfo> SelectDisplayGetBrandInfoV2(string urlLink, int pCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetBrandInfo>>>(
                            "DisplayCategory/SelectDisplayGetBrandInfoV2",
                            Method.GET,
                            null,
                            new List<string[]> {
                    new[] { "urlLink", urlLink },
                    new[] { "pCategoryNo", pCategoryNo.ToString() }
                            });
            return response.Data;
        }

        public string GetBrandNameByBrandNo(int brandNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                            "DisplayCategory/GetBrandNameByBrandNo",
                            Method.GET,
                            null,
                            new List<string[]> {
                    new[] { "brandNo", brandNo.ToString() }
                            });
            return response.Data;
        }

        public List<GetAllBrand> SelectAllBrand()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetAllBrand>>>(
                  "DisplayCategory/SelectAllBrand",
                  Method.GET,
                  null,
                  null);
            return response.Data;
        }

        public Tuple<List<FirstCategoryByBrand>, List<FirstCategoryByBrand02>> SelectFirstCategoryByBrand(int brandNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<FirstCategoryByBrand>, List<FirstCategoryByBrand02>>>>(
                      "DisplayCategory/SelectFirstCategoryByBrand",
                      Method.GET,
                      null,
                      new List<string[]> {
                    new[] { "brandNo", brandNo.ToString() }
                      });
            return response.Data;
        }

        public List<GetBrandInfoByUrl> SelectBrandByUrl(string linkUrl)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetBrandInfoByUrl>>>(
                  "DisplayCategory/SelectBrandByUrl",
                  Method.GET,
                  null,
                  new List<string[]> {
                    new[] { "linkUrl", linkUrl }
                  });
            return response.Data;
        }

        public string SelectListBrandNoByUrl(string linkUrl)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                   "DisplayCategory/SelectListBrandNoByUrl",
                   Method.GET,
                   null,
                   new List<string[]> {
                    new[] { "linkUrl", linkUrl }
                   });
            return response.Data;
        }

        public List<USP_Cat_GetListCateByProviderNo_Q> GetDisplayCategoryByProviderNo(int providerNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_Cat_GetListCateByProviderNo_Q>>>(
                "DisplayCategory/GetDisplayCategoryByProviderNo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "providerNo", providerNo.ToString() }
                });
            return response.Data;
        }

        public List<Yes24.Models.BrandProvider> SelectDisplayBrandByProviderNo(int providerNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24.Models.BrandProvider>>>(
                "DisplayCategory/SelectDisplayBrandByProviderNo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "providerNo", providerNo.ToString() }
                });
            return response.Data;
        }
        public List<Yes24.Models.ProviderBanner> SelectListBannerByProviderNo(int providerNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24.Models.ProviderBanner>>>(
                "DisplayCategory/SelectListBannerByProviderNo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "providerNo", providerNo.ToString() }
                });
            return response.Data;
        }

        public List<USP_Ven_GetListBrandByProviderNo_Q> SelectDisplayDeatailByProviderNo(string categoryCode, int providerNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_Ven_GetListBrandByProviderNo_Q>>>(
                 "DisplayCategory/SelectDisplayDeatailByProviderNo",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "categoryCode", categoryCode.ToString() },
                    new[] { "providerNo", providerNo.ToString() }
                 });
            return response.Data;
        }

        public List<LeftBrandModel> GetSubCategoryByClassTypeV3Dapper(string displaycategorycode, int categoryNo, string classTypeCd, string countryfilter, int Cate)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<LeftBrandModel>>>(
                   "DisplayCategory/GetSubCategoryByClassTypeV3Dapper",
                   Method.GET,
                   null,
                   new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode },
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "classTypeCd", classTypeCd },
                    new[] { "countryfilter", countryfilter },
                    new[] { "Cate", Cate.ToString() }
                   });
            return response.Data;
        }

        public List<LeftBrandModel> GetSubCategoryByClassTypeV4Dapper(int categoryNo, string countryfilter)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<LeftBrandModel>>>(
                    "DisplayCategory/GetSubCategoryByClassTypeV4Dapper",
                    Method.GET,
                    null,
                    new List<string[]> {
                    new[] { "categoryNo", categoryNo.ToString() },
                    new[] { "countryfilter", countryfilter }
                    });
            return response.Data;
        }

        public List<USP_CAT_ProductCategoryNo_DisplayCategoryCodeForFrontV5_Q> SelectProductCategoryNoByDisplayCategoryV5(string displaycategorycode, int pCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_CAT_ProductCategoryNo_DisplayCategoryCodeForFrontV5_Q>>>(
                 "DisplayCategory/SelectProductCategoryNoByDisplayCategoryV5",
                 Method.GET,
                 null,
                 new List<string[]> {
                    new[] { "displaycategorycode", displaycategorycode },
                    new[] { "pCategoryNo", pCategoryNo.ToString() }
                 });
            return response.Data;
        }
    }
}
