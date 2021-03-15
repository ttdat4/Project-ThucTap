using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Yes24.DTO;
using Yes24.DTO.Catalog;
using Yes24.DTO.Product;
using Yes24.DTO.SystemManagerment;
using Yes24.Models;
using BaseAPI = Yes24.APIService.Helper.BaseAPI;
using CosmeticProductLog = Yes24.DTO.Product.CosmeticProductLog;
using ProductData = Yes24.DTO.Product.ProductData;
namespace Yes24.APIService.Product
{
    public class ProductAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<ProductAPI> lazy = new Lazy<ProductAPI>(() => new ProductAPI());
        public static ProductAPI Instance { get { return lazy.Value; } }
        #endregion

        public async Task<ProductData> GetProductDetailAsyn(string productCode)
        {
            var response = await GetDataFromApiOutAsyn<BaseResultAPI<ProductData>>(
                "Product/GetProductDetail2",
                Method.GET,
                null,
                new List<string[]> { new[] { "productCode", productCode } });
            return response.Data;
        }

        public ProductData GetProductDetail(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductData>>(
                "Product/GetProductDetail",
                Method.GET,
                null,
                new List<string[]> { new[] { "productCode", productCode } });
            return response.Data;
        }
        public ProductData GetProductDetailV2(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductData>>(
                "Product/GetProductDetailV2",
                Method.GET,
                null,
                new List<string[]> { new[] { "productCode", productCode } });
            return response.Data;
        }

        public int UpdateProductURL(int productNo, string productURL)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Product/UpdateProductURL",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() },
                    new[] { "productURL", productURL }
                });
            return response.Data;
        }

        public void UpdateProductCouselForFront(int CounselNo, int isLock)
        {
            GetDataFromApiOut<ResultAPI>(
                "Product/UpdateProductCouselForFront",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "CounselNo", CounselNo.ToString() },
                    new[] { "isLock", isLock.ToString() }
                });
        }

        public int InsertCosmeticProductType(int ID, int ProductCode, int ViewCount)
        {
            GetDataFromApiOut<ResultAPI>(
                "Product/InsertCosmeticProductType",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ID", ID.ToString() },
                    new[] { "ProductCode", ProductCode.ToString() },
                    new[] { "ViewCount", ViewCount.ToString() },
                });

            return 1;
        }

        public List<CosmeticProductLog> SP_THUAT_GetCosmeticProductLog(int ProductCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CosmeticProductLog>>>(
                "Product/SP_THUAT_GetCosmeticProductLog",
                Method.GET,
                null,
                new List<string[]> { new[] { "ProductCode", ProductCode.ToString() } });
            return response.Data;
        }

        public int GetRankProductInCate(string CategoryNo, string ProductCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Product/GetRankProductInCate",
                Method.GET,
                null,
                new List<string[]> { new[] { "CategoryNo", CategoryNo } });
            return response.Data;
        }


        public SP_THUAT_GetCosmeticProductSkin GetCosmeticProductSkin(int CategoryID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<SP_THUAT_GetCosmeticProductSkin>>(
                "Product/GetCosmeticProductSkin",
                Method.GET,
                null,
                new List<string[]> { new[] { "CategoryID", CategoryID.ToString() } });
            return response.Data;
        }

        public List<SP_THUAT_GetCosmeticProductSkin> GetCosmeticProductRankType(int CategoryID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SP_THUAT_GetCosmeticProductSkin>>>(
                "Product/GetCosmeticProductRankType",
                Method.GET,
                null,
                new List<string[]> { new[] { "CategoryID", CategoryID.ToString() } });
            return response.Data;
        }

        public List<CosmeticBestOfBestModel> GetCosmeticBestOfBest(string Type, DateTime DateRun)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CosmeticBestOfBestModel>>>(
                "Product/GetCosmeticBestOfBest",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Type", Type },
                    new[] { "DateRun", DateRun.ToString("yyyy/MM/dd HH:mm:ss") },

                });
            return response.Data;
        }

        public List<SP_THUAT_GetCosmeticBrand> GetCosmeticBrandList()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SP_THUAT_GetCosmeticBrand>>>(
                "Product/GetCosmeticBrandList",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<SP_THUAT_GetCosmeticNew> GetCosmeticNews()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SP_THUAT_GetCosmeticNew>>>(
                "Product/GetCosmeticNews",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<SP_THUAT_GetCosmeticImageReview> GetImageReivew(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SP_THUAT_GetCosmeticImageReview>>>(
                "Product/GetImageReivew",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductCode", productCode },
                });
            return response.Data;
        }

        public int RegNotifyProduct(int ProductCode, string Email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Product/RegNotifyProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductCode", ProductCode.ToString() },
                    new[] { "Email", Email },

                });
            return response.Data;
        }

        public List<ProductCodeModel> GetProductNoByCodeArr(string productCodeArr)
        {
            var data = new ProductArr
            {
                productNoArr = productCodeArr
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.ProductCodeModel>>, ProductArr>(
                "Product/GetProductNoByCodeArr",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }
        public List<Models.Product> GetProductNoFilterNew(string productNoArr)
        {
            var data = new ProductArr
            {
                productNoArr = productNoArr
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.Product>>, ProductArr>(
                "Product/GetProductNoFilterNew",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<Models.Product> GetProductNoFilterNewAllStatusCD(string productNoArr)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.Product>>>(
                "Product/GetProductNoFilterNewAllStatusCD",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNoArr", productNoArr }
                });
            return response.Data;
        }

        public List<ProductSKUForFrontNew> GetProductSKU(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductSKUForFrontNew>>>(
                "Product/SelectSKU",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<ProductDetailByListGroup> GetProductDetailByDataSetByListGroup(string listProductCode)
        {
            var data = new ProductDataEventModel
            {
                productCode = listProductCode
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductDetailByListGroup>>, ProductDataEventModel>(
                "Product/GetProductDetailByDataSetByListGroup",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<ProductDetailByListGroup> GetProductDetailByDataSetByListGroupV2(string listProductCode)
        {
            var data = new ProductDataEventModel
            {
                productCode = listProductCode
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductDetailByListGroup>>, ProductDataEventModel>(
                "Product/GetProductDetailByDataSetByListGroupV2",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<ProductDetailByListProNoAndCate> GetProductDetailByDataSetByListProNoAndCate(string listProductCode, int cate)
        {
            var data = new ProductDataEventModel
            {
                productCode = listProductCode,
                cate = cate
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductDetailByListProNoAndCate>>, ProductDataEventModel>(
                "Product/GetProductDetailByDataSetByListProNoAndCate",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<ProductDeliveryForFront> GetProductDeliveryDetail(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductDeliveryForFront>>>(
                "Product/GetProductDeliveryDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<ProductReviewForFrontByProductNo> GetProductReviewRecentList(int rowCount, int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductReviewForFrontByProductNo>>>(
                "Product/SelectListForFrontByProductNo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "rowCount", rowCount.ToString() },
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<ProductReview> GetProductReviewList(string productCode, int listSize, int page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductReview>>>(
                "Product/GetProductReviewList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode },
                    new[] { "listSize", listSize.ToString() },
                    new[] { "page", page.ToString() }
                });
            return response.Data;
        }
        public ProductReview GetProductMDReview(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductReview>>(
                "Product/GetProductMDReview",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode },
                });
            return response.Data;
        }
        public Tuple<List<ProductReview>, int> GetProductReviewListV2(string productCode, int listSize, int page, int Type)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<ProductReview>, int>>>(
                "Product/GetProductReviewListV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode },
                    new[] { "listSize", listSize.ToString() },
                    new[] { "page", page.ToString() },
                    new[] { "Type", Type.ToString() }
                });
            return response.Data;
        }

        public int GetProductReviewListPaging(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Product/GetProductReviewListPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode }
                });
            return response.Data;
        }

        public List<ProductReviewAvg> GetProductReviewAvg(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductReviewAvg>>>(
                "Product/GetProductReviewAvg",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public bool AddCommentProduct(string loginId, string memeberName, int productNo, string productCode, string productName, string content, int displayCategoryNo, string title, int rate, string commentiImage)
        {
            return AddProductReview(loginId, memeberName, productNo, productCode, productName, displayCategoryNo, title, content, rate, rate, rate, rate, commentiImage);
        }

        public bool AddProductReview(string loginId, string memberName, int productNo, string productCode, string productName, int displayCategoryNo, string title, string contents, int priceRate, int designRate, int qualityRate, int deliveryRate, string CommentImage)
        {
            var data = new AddProductReviewModel
            {
                LoginId = loginId,
                CommentImage = CommentImage,
                Contents = contents,
                DeliveryRate = deliveryRate,
                DesignRate = designRate,
                DisplayCategoryNo = displayCategoryNo,
                MemberName = memberName,
                PriceRate = priceRate,
                ProductCode = productCode,
                ProductName = productName,
                ProductNo = productNo,
                QualityRate = qualityRate,
                Title = title
            };

            var response = GetDataFromApiOut<BaseResultAPI<bool>, AddProductReviewModel>(
                "Product/AddProductReview",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }
        public int AddCommentProductV2(string loginId, string memeberName, int productNo, string productCode, string productName, string content, int displayCategoryNo, string title, int rate, string commentiImage)
        {
            return AddProductReviewV2(loginId, memeberName, productNo, productCode, productName, displayCategoryNo, title, content, rate, rate, rate, rate, commentiImage);
        }
        public int AddProductReviewV2(string loginId, string memberName, int productNo, string productCode, string productName, int displayCategoryNo, string title, string contents, int priceRate, int designRate, int qualityRate, int deliveryRate, string CommentImage)
        {
            var data = new AddProductReviewModel
            {
                LoginId = loginId,
                CommentImage = CommentImage,
                Contents = contents,
                DeliveryRate = deliveryRate,
                DesignRate = designRate,
                DisplayCategoryNo = displayCategoryNo,
                MemberName = memberName,
                PriceRate = priceRate,
                ProductCode = productCode,
                ProductName = productName,
                ProductNo = productNo,
                QualityRate = qualityRate,
                Title = title
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AddProductReviewModel>(
                "Product/AddProductReviewV2",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<ManToManCounselForFrontByProductNo> GetProductQnARecentList(int rowCount, int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ManToManCounselForFrontByProductNo>>>(
                "Product/GetProductQnARecentList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "rowCount", rowCount.ToString() },
                    new[] { "productNo", productNo.ToString() },
                });
            return response.Data;
        }

        public List<ManToManCounselForFront> GetProductQnAListAll(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ManToManCounselForFront>>>(
                "Product/GetProductQnAListAll",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<ManToManCounselForFrontByProductNo> GetProductQnAList(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ManToManCounselForFrontByProductNo>>>(
                "Product/GetProductQnAList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public bool AddProductQnANew(string loginId, string memberName, string memberEmail, int productNo, int displayCategoryNo, string title, string contents, int isLock)
        {
            ManToManCounselData manToManCounselData = new ManToManCounselData();
            manToManCounselData.ProductNo = productNo;
            manToManCounselData.UserIdCreatedBy = loginId;
            manToManCounselData.UserNameCreatedBy = memberName;
            manToManCounselData.UserEmail = memberEmail;
            manToManCounselData.Title = title;
            manToManCounselData.Contents = contents;
            manToManCounselData.DisplayCategoryNo = displayCategoryNo;
            manToManCounselData.IsLock = isLock;

            var response = GetDataFromApiOut<BaseResultAPI<bool>, ManToManCounselData>(
                "Product/AddProductQnANew",
                Method.POST,
                null,
                null,
                manToManCounselData);
            return response.Data;
        }

        public List<SetProductForFront> GetSet(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SetProductForFront>>>(
                "Product/GetSet",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;

        }

        public Tuple<DTO.Catalog.CategoryModel, DTO.Catalog.CategoryModel> GetProductNavigation(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<DTO.Catalog.CategoryModel, DTO.Catalog.CategoryModel>>>(
                "Product/GetProductNavigation",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<RelationProductModel> GetRelationProduct(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<RelationProductModel>>>(
                "Product/GetRelationProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public string GetProductCategoryUrl(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Product/GetProductCategoryUrl",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public ProductDisplayCategoryPath GetProductCategoryPath(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductDisplayCategoryPath>>(
                "Product/GetProductCategoryPath",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode }
                });
            return response.Data;
        }

        public bool UpdateProductStatusCd(int productNo, string statusCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Product/UpdateProductStatusCd",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() },
                    new[] { "statusCd", statusCd },
                });
            return response.Data;
        }

        public bool UpdateStockSKU(int productNo, string skuCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Product/UpdateStockSKU",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() },
                    new[] { "skuCode", skuCode },
                });
            return response.Data;
        }

        public int AddProductReviewLike(int boardNo, string userIdCreatedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Product/AddProductReviewLike",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "boardNo", boardNo.ToString() },
                    new[] { "userIdCreatedBy", userIdCreatedBy },
                });
            return response.Data;
        }

        public List<CustomerCouselForFront> GetProductCouselForFront(int ProductNo, int ListSize, int CurPage)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CustomerCouselForFront>>>(
                "Product/GetProductCouselForFront",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() },
                    new[] { "ListSize", ListSize.ToString() },
                    new[] { "CurPage", CurPage.ToString() },
                });
            return response.Data;
        }
        public Tuple<List<CustomerCouselForFront>, int> GetProductCouselForFrontV2(int ProductNo, int ListSize, int CurPage)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<CustomerCouselForFront>, int>>>(
                "Product/GetProductCouselForFrontV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() },
                    new[] { "ListSize", ListSize.ToString() },
                    new[] { "CurPage", CurPage.ToString() },
                });
            return response.Data;
        }

        public int GetProductCouselForFrontPaging(int ProductNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Product/GetProductCouselForFrontPaging",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() }
                });
            return response.Data;
        }

        public List<SearchKeywordForAutoComplete> SelectKeywordForAutoComplete(string keyword, int topRow)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SearchKeywordForAutoComplete>>>(
                "Product/SelectKeywordForAutoComplete",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "keyword", keyword },
                    new[] { "topRow", topRow.ToString() }
                });
            return response.Data;
        }

        public List<ProductSameBrand> SelectProductSameBrand(string ProductCodeList)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductSameBrand>>>(
                "Product/SelectProductSameBrand",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductCodeList", ProductCodeList }
                });
            return response.Data;
        }

        public List<ProductNoForSameBrand> SelectProductNoSameBrand(int ProductNo, int BrandNo, int CategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductNoForSameBrand>>>(
                "Product/SelectProductNoSameBrand",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() },
                    new[] { "BrandNo", BrandNo.ToString() },
                    new[] { "CategoryNo", CategoryNo.ToString() },
                });
            return response.Data;
        }

        public string GetBrandCategoryUrl(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Product/GetBrandCategoryUrl",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }


        public List<ProductVendorInfo> GetProductVendorInfo(int DeliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductVendorInfo>>>(
                "Product/GetProductVendorInfo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "DeliveryUnitNo", DeliveryUnitNo.ToString() }
                });
            return response.Data;
        }


        public List<ProductGift> SelectProductGift(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductGift>>>(
                "Product/SelectProductGift",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode }
                });
            return response.Data;
        }

        public List<OrderGiftProduct> SelectOrderGift(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<OrderGiftProduct>>>(
                "Product/SelectOrderGift",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<ProductGift> SelectGift_Finished(int orderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductGift>>>(
                "Product/SelectGift_Finished",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "orderNo", orderNo.ToString() }
                });
            return response.Data;
        }

        public List<GetListProductByGroupId> GetListProductByGroupId(int productCode, int groupId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetListProductByGroupId>>>(
                "Product/GetListProductByGroupId",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode.ToString() },
                    new[] { "groupId", groupId.ToString() }
                });
            return response.Data;
        }

        public List<GetProductDetailByProductNo> GetProductDetailByProductNo(int ProductNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetProductDetailByProductNo>>>(
                "Product/GetProductDetailByProductNo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() }
                });
            return response.Data;
        }

        public List<ProductSameBrand> GetProductSameBrand(int ProductNo, int BrandNo, int CategoryNo, string ProductHistory, int FirstCategoryNo)
        {
            List<ProductSameBrand> dsList = new List<ProductSameBrand>();
            string ProductNoList = "";
            var ds = SelectProductNoSameBrand(ProductNo, BrandNo, CategoryNo);
            int itemCount = ds.Count;
            if (itemCount > 0)
            {
                string ProductCode = "";
                string itemtype = "";
                int pCount = 0;
                if (FirstCategoryNo == 5261)
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        ProductCode = ds[i].ProductCode;
                        itemtype = ds[i].itemtype.ToString();

                        if (ProductHistory.IndexOf(ProductCode) < 0)
                        {
                            if (itemtype == "1" && pCount < 1)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                            else if (itemtype == "2" && pCount < 3)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                            else if (itemtype == "3" && pCount < 20)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        ProductCode = ds[i].ProductCode;
                        itemtype = ds[i].itemtype.ToString();

                        if (ProductHistory.IndexOf(ProductCode) < 0)
                        {
                            if (itemtype == "1" && pCount < 2)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                            else if (itemtype == "2" && pCount < 3)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                            else if (itemtype == "3" && pCount < 20)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                        }
                    }
                }

                if (pCount < 20) //Get Full list
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        ProductCode = ds[i].ProductCode;

                        if (ProductHistory.IndexOf(ProductCode) < 0)
                        {
                            if (pCount < 20)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                        }
                    }
                    if (pCount < 20) //last try ^_^
                    {
                        for (int i = 0; i < itemCount; i++)
                        {
                            ProductCode = ds[i].ProductCode;


                            if (pCount < 20)
                            {
                                ProductNoList = ProductNoList + ProductCode + ",";
                                pCount++;
                            }
                        }
                    }
                }
            }

            if (ProductNoList.Length > 1)
            {
                ProductNoList = ProductNoList.Substring(0, ProductNoList.Length - 1);
                dsList = SelectProductSameBrand(ProductNoList);
            }
            return dsList;
        }


        public ProductReview_IsBuy CheckIsBuy(string loginId, int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductReview_IsBuy>>(
                "Product/CheckIsBuy",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId },
                    new[] { "productNo", productNo.ToString() },
                });
            return response.Data;
        }

        public List<Models.Product> GetListProductSuggestGuest(string productCodeArr)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.Product>>>(
                "Product/GetListProductSuggestGuest",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCodeArr", productCodeArr }
                });
            return response.Data;
        }
        public List<Models.Product> GetListProductBuyRelation(int ProductNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.Product>>>(
                "Product/GetListProductBuyRelation",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() }
                });
            return response.Data;
        }
        public List<Yes24FlashModel> GetFlashSaleByDurationTime(int DurationTime, DateTime DateRun)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24FlashModel>>>(
                "Product/GetFlashSaleByDurationTime",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "DurationTime", DurationTime.ToString() },
                    new[] { "DateRun", DateRun.ToString("yyyy/MM/dd HH:mm:ss") },
                });
            return response.Data;
        }

        public List<Models.Product> GetFlashSaleByDurationTimeV2(int DurationTime, DateTime DateRun, string CategoryCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.Product>>>(
                "Product/GetFlashSaleByDurationTimeV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "DurationTime", DurationTime.ToString() },
                    new[] { "DateRun", DateRun.ToString("yyyy/MM/dd HH:mm:ss") },
                    new[] { "CategoryCode", CategoryCode.ToString() }
                });
            return response.Data;
        }

        public List<Models.Product> GetFlashSaleByDurationTimeByMemberGUID(int DurationTime, DateTime DateRun, string MemberGUID, string CategoryCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.Product>>>(
                "Product/GetFlashSaleByDurationTimeByMemberGUID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "DurationTime", DurationTime.ToString() },
                    new[] { "DateRun", DateRun.ToString("yyyy/MM/dd HH:mm:ss") },
                    new[] { "MemberGUID", MemberGUID.ToString() },
                    new[] { "CategoryCode", CategoryCode.ToString() }
                });
            return response.Data;
        }

        public List<Yes24FlashModel> GetFlashSaleByDurationTimeIgnoreQty(int DurationTime, DateTime DateRun)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24FlashModel>>>(
                "Product/GetFlashSaleByDurationTimeIgnoreQty",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "DurationTime", DurationTime.ToString() },
                    new[] { "DateRun", DateRun.ToString("yyyy/MM/dd HH:mm:ss") },
                });
            return response.Data;
        }
        public List<Yes24FlashModel> CheckFlashSaleProduct(int ProductNo, int DurationTime)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24FlashModel>>>(
                "Product/CheckFlashSaleProduct",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() },
                    new[] { "DurationTime", DurationTime.ToString() },
                });
            return response.Data;
        }

        public ProductContentsData GetProductContentsDetail(string productCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductContentsData>>(
                "Product/GetProductContentsDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productCode", productCode }
                });
            return response.Data;
        }

        public void UpdateInfoProductDetailFromFront(int productNo, string productURL, string statusCd)
        {
            var data = new UpdateInfoProductDetailFromFront
            {
                ProductNo = productNo,
                ProductURL = productURL,
                StatusCd = statusCd
            };
            GetDataFromApiOut<ResultAPI, UpdateInfoProductDetailFromFront>(
                "Product/UpdateInfoProductDetailFromFront",
                Method.POST,
                null,
                null,
                data);
        }

        public string GetRandomProductNo(int soluongcanlay)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Product/GetRandomProductNo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "soluongcanlay", soluongcanlay.ToString() }
                });
            return response.Data;
        }

        public List<HotestKeyword> SelectSearchKeywordHot()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<HotestKeyword>>>(
                "Product/SelectSearchKeywordHot",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public List<string> SelectProduct360(int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<string>>>(
                "Product/SelectSearchKeywordHot",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }
        public void AddOrderItemReview(long OrderNo, long OrderItemNo, string LoginID, int productNo, int OptionID1, int OptionID2, int OptionID3)
        {
            GetDataFromApiOut<ResultAPI>(
                "Product/AddOrderItemReview",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "OrderNo", OrderNo.ToString() },
                    new[] { "OrderItemNo", OrderItemNo.ToString() },
                    new[] { "LoginID", LoginID.ToString() },
                    new[] { "productNo", productNo.ToString() },
                    new[] { "OptionID1", OptionID1.ToString() },
                    new[] { "OptionID2", OptionID2.ToString() },
                    new[] { "OptionID3", OptionID3.ToString() }
                });
        }
        public List<OrderItemReview> GetOrderItemReviewByOrderNo(long OrderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<OrderItemReview>>>(
                "Product/GetOrderItemReviewByOrderNo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "OrderNo", OrderNo.ToString() }
                });
            return response.Data;
        }
        public List<LocationVoucherModel> GetLocationVoucher(int ProductNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<LocationVoucherModel>>>(
                "Product/GetLocationVoucher",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() }
                });
            return response.Data;
        }
        public List<FilterVoucher> GetFilterVoucher(int PlaceType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FilterVoucher>>>(
                "Product/GetFilterVoucher",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "PlaceType", PlaceType.ToString() }
                });
            return response.Data;
        }
        public List<Models.Product> GetProductSameOrder(int ProductNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Models.Product>>>(
                "Product/GetProductSameOrder",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ProductNo", ProductNo.ToString() }
                });
            return response.Data;
        }
        public ProductDetailWithDealHot GetDealBuyWithDeal(string productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductDetailWithDealHot>>(
                "Product/GetDealBuyWith",
                Method.GET,
                null,
                new List<string[]> { new[] { "productNo", productNo } });
            return response.Data;
        }
        public List<ProductDetailServiceRelation> ProductDetailServiceRelation(string productNo, string firstCateNo, string brandNo, string deliveryUnitNo, string providerNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductDetailServiceRelation>>>(
                "Product/ProductDetailServiceRelation",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo},
                    new[] { "firstCateNo", firstCateNo },
                    new[] { "brandNo", brandNo },
                    new[] { "deliveryUnitNo", deliveryUnitNo },
                    new[] { "providerNo", providerNo }
                });
            return response.Data;
        }
    }
}
