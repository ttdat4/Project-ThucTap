using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Basket;
using Yes24.DTO.Order;


namespace Yes24.APIService.Order
{
    public class BasketAPINew : BaseOrderAPI
    {
        #region Singleton
        private static readonly Lazy<BasketAPINew> lazy = new Lazy<BasketAPINew>(() => new BasketAPINew());
        public static BasketAPINew Instance { get { return lazy.Value; } }
        #endregion


        public int SaveOrderDataLog(string contentsData)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, BasketDataLog>(
                "Basket/SaveOrderDataLog",
                Method.POST,
                null,
                null,
                new BasketDataLog
                {
                    ContentsData = contentsData
                });
            return response.Data;
        }

        public string SelectOrderDataLog(int ID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Basket/SelectOrderDataLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "ID", ID.ToString()}
                });
            return response.Data;
        }

        public List<USP_ORD_BasketLogstics_Q_Result> SelectBasketLogisticsNew(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_BasketLogstics_Q_Result>>>(
                "Basket/SelectBasketLogisticsNew",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public double GetPaymentTotal(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Basket/GetPaymentTotal",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_ORD_BasketDelivery_Q_Result> GetBasketGroup(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_BasketDelivery_Q_Result>>>(
                "Basket/GetBasketGroup",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public int RemoveWithoutStock(string memberGUID, string orderTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/RemoveWithoutStock",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID},
                    new []{ "orderTypeCd", orderTypeCd},
                });
            return response.Data;
        }

        public List<USP_ORD_BasketItem_Q_Result> GetItems(string memberGUID, int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_BasketItem_Q_Result>>>(
                "Basket/GetItems",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "deliveryUnitNo", deliveryUnitNo.ToString() },
                });
            return response.Data;
        }

        public double GetCategoryPaymentTotal(string memberGUID, int CategoryType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Basket/GetCategoryPaymentTotal",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "CategoryType", CategoryType.ToString() },
                });
            return response.Data;
        }

        public int Clear(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/Clear",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "basketTypeCd", "B" },
                });
            return response.Data;
        }

        public List<FSP_ORD_OrderGiftCart_Q_Result> SelectOrderGiftCart(string orderType, string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_ORD_OrderGiftCart_Q_Result>>>(
                "Basket/SelectOrderGiftCart",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "orderType", orderType },
                    new []{ "memberGUID", memberGUID },
                });
            return response.Data;
        }

        public double GetDeliveryCostTotal(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Basket/GetDeliveryCostTotal",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                });
            return response.Data;
        }

        public int AddWishList(string memberGUID, int productNo, string skuCode, int SetProductNo, int DisplayCategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/AddWishList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "productNo", productNo.ToString() },
                    new []{ "skuCode", skuCode },
                    new []{ "SetProductNo", SetProductNo.ToString() },
                    new []{ "DisplayCategoryNo", DisplayCategoryNo.ToString() }
                });
            return response.Data;
        }

        public int UpdateBasketStatus(int basketItemNo, string memberGUID, string StatusCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/UpdateBasketStatus",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "basketItemNo", basketItemNo.ToString() },
                    new []{ "StatusCd", StatusCd },
                });
            return response.Data;
        }

        public int UpdateBasketStatusAll(string memberGUID, string StatusCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/UpdateBasketStatusAll",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "StatusCd", StatusCd },
                });
            return response.Data;
        }

        public int GetBasketCountQty(string MemberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/GetBasketCountQty",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGuid", MemberGuid }
                });
            return response.Data;
        }

        public List<Yes24.Models.BasketItem> GetBasketDiscountPromotions(string MemberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24.Models.BasketItem>>>(
                "Basket/GetBasketDiscountPromotions",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "MemberGuid", MemberGuid }
                });
            return response.Data;
        }

        public double GetBasketDiscountHNHQ(string MemberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Basket/GetBasketDiscountHNHQ",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGuid", MemberGuid }
                });
            return response.Data;
        }

        public double GetBasketEventDiscount(string MemberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Basket/GetBasketEventDiscount",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGuid", MemberGuid }
                });
            return response.Data;
        }

        public void Change(string guestGUID, string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/Change",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "guestGUID", guestGUID },
                    new[] { "memberGUID", memberGUID }
                });
            //return response.Data;
        }

        public int SaveSet(string memberGUID, int productNo, string[] skuArr, int Qty, string basketTypeCd, int categoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, SaveSetModel>(
                "Basket/SaveSet",
                Method.POST,
                null,
                null,
                new SaveSetModel
                {
                    Qty = Qty,
                    ProductNo = productNo,
                    MemberGUID = memberGUID,
                    BasketTypeCd = basketTypeCd,
                    DisplayCategoryNo = categoryNo,
                    SetSKUCodeArr = skuArr
                });
            return response.Data;
        }

        public int Save(string memberGUID, int productNo, string SKUCode, int Qty, string basketTypeCd, int categoryNo, string ChannelCd, string ChannelCdLink, string ChannelCdEvent)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, BasketSaveModel>(
                "Basket/Save",
                Method.POST,
                null,
                null,
                new BasketSaveModel
                {
                    Qty = Qty,
                    ProductNo = productNo,
                    MemberGUID = memberGUID,
                    BasketTypeCd = basketTypeCd,
                    SKUCode = SKUCode,
                    ChannelCd = ChannelCd,
                    ChannelCdEvent = ChannelCdEvent,
                    ChannelCdLink = ChannelCdLink,
                    DisplayCategoryNo = categoryNo
                });
            return response.Data;
        }

        public int SaveEcom(string memberGUID, int productNo, string SKUCode, int Qty, double ListPrice, string BasketTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, SaveEcomModel>(
                "Basket/SaveEcom",
                Method.POST,
                null,
                null,
                new SaveEcomModel
                {
                    Qty = Qty,
                    ProductNo = productNo,
                    MemberGUID = memberGUID,
                    SKUCode = SKUCode,
                    ListPrice = ListPrice,
                    BasketTypeCd = BasketTypeCd
                });
            return response.Data;
        }

        public int ModifyQty(string memberGUID, int productNo, string skuCode, int qty, int basketItemNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/ModifyQty",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "productNo", productNo.ToString() },
                    new []{ "skuCode", skuCode },
                    new []{ "qty", qty.ToString() },
                    new []{ "basketItemNo", basketItemNo.ToString() },
                }
                );
            return response.Data;
        }

        public int RemoveItem(string memberGUID, string basketTypeCd, int productNo, string skuCode, int basketItemNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/RemoveItem",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "memberGUID", memberGUID },
                    new []{ "productNo", productNo.ToString() },
                    new []{ "skuCode", skuCode },
                    new []{ "basketItemNo", basketItemNo.ToString() },
                    new []{ "basketTypeCd", basketTypeCd },
                }
            );
            return response.Data;
        }

        public double CalKg(string memberGUID, int deliveryUnitNo, double infoKgCal)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Basket/CalKg",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID },
                    new[] { "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[] { "infoKgCal", infoKgCal.ToString() }
                }
            );

            return response.Data;
        }

        public int GetStockQty(int productNo, string skuCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Basket/GetStockQty",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "productNo", productNo.ToString() },
                    new[] { "skuCode", skuCode },
                });
            return response.Data;
        }
    }
}
