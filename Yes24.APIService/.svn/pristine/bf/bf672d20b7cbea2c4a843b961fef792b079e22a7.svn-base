using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.SystemManagerment;
using Yes24.DTO.Order;
using Yes24.DTO.Profile;
using Yes24.DTO.Catalog;

namespace Yes24.APIService.MyPage
{
    public class MyPageAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<MyPageAPI> lazy = new Lazy<MyPageAPI>(() => new MyPageAPI());
        public static MyPageAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<NoticeForFrontMyPage> GetNotice(int RowCount, string SearchType, string SearchText)
        {
            GetNoticeModel data = new GetNoticeModel
            {
                RowCount = RowCount,
                SearchType = SearchType,
                SearchText = SearchText
            };

            var response = GetDataFromApiOut<BaseResultAPI<List<NoticeForFrontMyPage>>, GetNoticeModel>(
                "MyPage/GetNotice",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<NoticeDetailForFrontMypage> GetNoticeDetail(int noticeId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<NoticeDetailForFrontMypage>>>(
                "MyPage/GetNoticeDetail",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "noticeId", noticeId.ToString() }
                });
            return response.Data;
        }

        public List<USP_ORD_OrderForFrontComplete_Q> GetOrderCompleteList(string LoginId, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderForFrontComplete_Q>>>(
                "MyPage/GetOrderCompleteList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginId", LoginId },
                    new[] { "dateFrom", dateFrom.ToString() },
                    new[] { "dateTo", dateTo.ToString() }
                });
            return response.Data;
        }

        public List<USP_ORD_DeliveryInfo_Q> GetDeliveryInfo(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_DeliveryInfo_Q>>>(
                "MyPage/GetDeliveryInfo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }
                });
            return response.Data;
        }

        public List<USP_ORD_DeliveryInfoV2_Q> GetDeliveryInfo(string orderGUID, int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_DeliveryInfoV2_Q>>>(
                "MyPage/GetDeliveryInfo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID },
                    new[] { "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }

        public List<USP_ORD_PaymentInfo_Q> GetPaymentInfo(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_PaymentInfo_Q>>>(
                "MyPage/GetPaymentInfo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }
                });
            return response.Data;
        }

        public List<CustomerCouselForFrontMyPage> GetCustomerCounselList(string UserIdCreatedBy, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CustomerCouselForFrontMyPage>>>(
                "MyPage/GetCustomerCounselList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "UserIdCreatedBy", UserIdCreatedBy },
                    new[] { "dateFrom", dateFrom.ToString() },
                    new[] { "dateTo", dateTo.ToString() }
                });
            return response.Data;
        }

        public List<ManToManCounselForFrontMyPage> GetManToManCounselList(string UserIdCreatedBy, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ManToManCounselForFrontMyPage>>>(
                "MyPage/GetManToManCounselList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "UserIdCreatedBy", UserIdCreatedBy },
                    new[] { "dateFrom", dateFrom.ToString() },
                    new[] { "dateTo", dateTo.ToString() }
                });
            return response.Data;
        }

        public List<ManToManCounselDetailForFront> GetManToManCounselDetail(int counselNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ManToManCounselDetailForFront>>>(
                "MyPage/GetManToManCounselDetail",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "counselNo", counselNo.ToString() }
                });
            return response.Data;
        }

        public List<ManToManCounselDetailForFront> GetManToManCounselDetailCompress(int CounselNo)
        {
            List<ManToManCounselDetailForFront> ds = GetManToManCounselDetail(CounselNo);
            return ds;
        }

        public int AddManToManCounsel(string CounselCategoryCd,
                                    string CounselTypeCd,
                                    string ChildCounselTypeCd,
                                    int ProductNo,
                                    long OrderNo,
                                    int MemberAccountId,
                                    string UserIdCreatedBy,
                                    string UserNameCreatedBy,
                                    string UserEmail,
                                    string Title,
                                    string Contents)
        {
            AddManToManCounselModel data = new AddManToManCounselModel
            {
                CounselCategoryCd = CounselCategoryCd,
                CounselTypeCd = CounselTypeCd,
                ChildCounselTypeCd = ChildCounselTypeCd,
                ProductNo = ProductNo,
                OrderNo = OrderNo,
                MemberAccountId = MemberAccountId,
                UserIdCreatedBy = UserIdCreatedBy,
                UserNameCreatedBy = UserNameCreatedBy,
                UserEmail = UserEmail,
                Title = Title,
                Contents = Contents
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AddManToManCounselModel>(
                "MyPage/AddManToManCounsel",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<USP_PRF_MemberAddressForFront_Q> GetMemberAddressList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberAddressForFront_Q>>>(
                "MyPage/GetMemberAddressList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_WishList_Q> GetWishList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_WishList_Q>>>(
                "MyPage/GetWishList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_WishList_Q_V2> GetWishListV2(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_WishList_Q_V2>>>(
                "MyPage/GetWishListV2",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public int RemoveSelectWishList(string memberGUID, int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MyPage/RemoveSelectWishList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID },
                    new[] { "productNo", productNo.ToString() }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberPointForFront_Q> GetPointList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberPointForFront_Q>>>(
                "MyPage/GetPointList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberPointForFront_Q> GetPointListCompress(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberPointForFront_Q>>>(
                "MyPage/GetPointListCompress",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberPointForByExchange_Q> GetPointByExchange(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberPointForByExchange_Q>>>(
                "MyPage/GetPointByExchange",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberMileageForFront_Q> GetMileageList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberMileageForFront_Q>>>(
                "MyPage/GetMileageList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberMileageForFront_Q> GetMemberMileageForFront(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberMileageForFront_Q>>>(
                "MyPage/GetMemberMileageForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<ProductReviewForFront> GetProductReview(string LoginId, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductReviewForFront>>>(
                "MyPage/GetProductReview",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginId", LoginId },
                    new[] { "dateFrom", dateFrom.ToString() },
                    new[] { "dateTo", dateTo.ToString() }
                });
            return response.Data;
        }

        public List<ProductReviewForFrontV2> GetProductReviewV2(string LoginId, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductReviewForFrontV2>>>(
                "MyPage/GetProductReviewV2",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginId", LoginId },
                    new[] { "dateFrom", dateFrom.ToString() },
                    new[] { "dateTo", dateTo.ToString() }
                });
            return response.Data;
        }

        public List<ProductReviewForFrontV2> GetProductReviewCompressV2(string LoginId, DateTime dateFrom, DateTime dateTo)
        {
            List<ProductReviewForFrontV2> ds = GetProductReviewV2(LoginId, dateFrom, dateTo);
            return ds;
        }

        public ProductReviewDetailForFront GetProductReviewDetail(int ReviewNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<ProductReviewDetailForFront>>(
                "MyPage/GetProductReviewDetail",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "ReviewNo", ReviewNo.ToString() }
                });
            return response.Data;
        }

        public ProductReviewDetailForFront GetProductReviewDetailCompress(int reviewNo)
        {
            ProductReviewDetailForFront ds = GetProductReviewDetail(reviewNo);
            return ds;
        }

        public int RemoveProductReview(int[] reviewNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MyPage/RemoveProductReview",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "reviewNo", String.Join(",", reviewNo) }
                });
            return response.Data;
        }

        public List<USP_PRF_PointExchangeForFront_Q> GetPointExchangeList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_PointExchangeForFront_Q>>>(
                "MyPage/GetPointExchangeList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public int AddPointExchangeLog(string memberGUID, int usedPoint, decimal mileage)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MyPage/AddPointExchangeLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID },
                    new[] { "usedPoint", usedPoint.ToString() },
                    new[] { "mileage", mileage.ToString() }
                });
            return response.Data;
        }

        public List<USP_ORD_OrderExceptionByLoginId_Q> GetOrderException(string loginId, string exceptionTypeCd, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderExceptionByLoginId_Q>>>(
                "MyPage/GetOrderException",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId },
                    new[] { "exceptionTypeCd", exceptionTypeCd },
                    new[] { "dateFrom", dateFrom.ToString() },
                    new[] { "dateTo", dateTo.ToString() }
                });
            return response.Data;
        }

        public List<USP_ORD_VirtualAccountLogForFront_Q> GetVitualAccountLog(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_VirtualAccountLogForFront_Q>>>(
                "MyPage/GetVitualAccountLog",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }
                });
            return response.Data;
        }

        public List<USP_ORD_DirectTransferLogForFront_Q> GetDirectTransferLog(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_DirectTransferLogForFront_Q>>>(
                "MyPage/GetDirectTransferLog",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }
                });
            return response.Data;
        }

        public List<CounselTypeByCategory> GetByCategory(string counselCategoryCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CounselTypeByCategory>>>(
                "MyPage/GetByCategory",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "counselCategoryCd", counselCategoryCd }
                });
            return response.Data;
        }

        public List<CounselTypeByCategory> GetChild(int itemNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CounselTypeByCategory>>>(
                "MyPage/GetChild",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "itemNo", itemNo.ToString() }
                });
            return response.Data;
        }

        public List<USP_ORD_OrderSummaryForMember_Q> GetOrderSummaryForMember(string loginId, string memberName)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderSummaryForMember_Q>>>(
                "MyPage/GetOrderSummaryForMember",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId },
                    new[] { "memberName", memberName }
                });
            return response.Data;
        }

        public List<USP_ORD_OrderItemList_Q> GetOrderItemList(string LoginId, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderItemList_Q>>>(
                "MyPage/GetOrderItemList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginId", LoginId },
                    new[] { "dateFrom", dateFrom.ToString() },
                    new[] { "dateTo", dateTo.ToString() }
                });
            return response.Data;
        }

        public List<USP_ORD_OrderItemListV2_Q> GetOrderItemListV2(string LoginId, DateTime dateFrom, DateTime dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderItemListV2_Q>>>(
                "MyPage/GetOrderItemListV2",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginId", LoginId },
                    new[] { "dateFrom", dateFrom.ToString("yyyy-MM-dd") },
                    new[] { "dateTo", dateTo.ToString("yyyy-MM-dd") }
                });
            return response.Data;
        }

        public List<USP_ORD_OrderItemListV2_Q> CheckOrderList(string OrderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderItemListV2_Q>>>(
                "MyPage/CheckOrderList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "OrderGUID", OrderGUID }
                });
            return response.Data;
        }

        public List<USP_ORD_DeliveryOrderForFront_Q> GetDeliveryInvoiceItemList(string orderGUID, int deliveryUnitNo, string ProductCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_DeliveryOrderForFront_Q>>>(
                "MyPage/GetDeliveryInvoiceItemList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID },
                    new[] { "deliveryUnitNo", deliveryUnitNo.ToString() },
                    new[] { "ProductCode", ProductCode }
                });
            return response.Data;
        }

        public List<FSP_ORD_DeliveryOrderForInvoiceNo_Q> GetDeliveryOrderForInvoiceNo(string invoiceNo, string orderGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_ORD_DeliveryOrderForInvoiceNo_Q>>>(
                "MyPage/GetDeliveryOrderForInvoiceNo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "invoiceNo", invoiceNo },
                    new[] { "orderGuid", orderGuid }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberDigiMoneyForFront_Q> GetDigiMoneyList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberDigiMoneyForFront_Q>>>(
                "MyPage/GetDigiMoneyList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberMileageForFront_Q> GetMemberMileageList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberMileageForFront_Q>>>(
                "MyPage/GetMileageList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberDigiMoneyForFront_Q> GetDigiMoneyListCompress(string memberGUID)
        {
            List<USP_PRF_MemberDigiMoneyForFront_Q> ds = GetDigiMoneyList(memberGUID);
            return ds;
        }

        public List<USP_PRF_MemberDigiMoneyForFront_Q> GetMemberDigiMoneyList(string memberGUID)
        {
            List<USP_PRF_MemberDigiMoneyForFront_Q> ds = GetDigiMoneyList(memberGUID);
            return ds;
        }

        public List<USP_PRF_MemberPointForFront_Q> GetMemberPointList(string memberGUID)
        {
            List<USP_PRF_MemberPointForFront_Q> ds = GetPointList(memberGUID);
            return ds;
        }
    }
}
