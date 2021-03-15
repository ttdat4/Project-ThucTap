using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using Yes24.DTO;
using Yes24.DTO.Coupon;
using Yes24.Utilities;
using BaseAPI = Yes24.APIService.Helper.BaseAPI;

namespace Yes24.APIService.Coupon
{
    public class CouponAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<CouponAPI> lazy = new Lazy<CouponAPI>(() => new CouponAPI());
        public static CouponAPI Instance { get { return lazy.Value; } }
        #endregion

        private string _mallId = null;

        private CouponAPI()
        {
            _mallId = CommonLib.IsNullString(ConfigurationManager.AppSettings["COUPON_MALLID"], "ISTYLE24");

        }

        public List<USP_SR_SerialProduct_Q> SelectListForSerialProduct(int productno, string itemno, int brandno)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_SR_SerialProduct_Q>>>(
                "Coupon/SelectListForSerialProduct",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "productno", productno.ToString() },
                    new[] { "itemno", itemno.ToString() },
                    new[] { "brandno", brandno.ToString() }
                });
            return response.Data;
        }

        public int AddSerialForMember(int serialsubid, string loginId, string memberName)
        {
            AddSerialForMemberModel data = new AddSerialForMemberModel
            {
                serialsubid = serialsubid,
                loginid = loginId,
                membername = memberName
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AddSerialForMemberModel>(
                "Coupon/AddSerialForMember",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<SerialForEventByListGroup> SelectListSerialCntEventByListGroup(string SerialId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SerialForEventByListGroup>>>(
                "Coupon/SelectListSerialCntEventByListGroup",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "SerialId", SerialId }
                });
            return response.Data;
        }

        public List<USP_CPN_SerialIssueForListOrder_Q> SelectListSerialOrder(string loginId, string memberGUID, string statusCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_CPN_SerialIssueForListOrder_Q>>>(
                "Coupon/SelectListSerialOrder",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId },
                    new[] { "memberGUID", memberGUID },
                    new[] { "statusCd", statusCd }
                });
            return response.Data;
        }

        public List<CouponIssueData> GetAllMemberCoupon(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CouponIssueData>>>(
                "Coupon/GetListForMember",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId },
                    new[] { "mallId", _mallId },
                    new[] { "statusCd", "" }
                });
            return response.Data;
        }

        public List<USP_CPN_SerialForEvent_Q> SelectListSerialCntEvent(string SerialId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_CPN_SerialForEvent_Q>>>(
                "Coupon/SelectListSerialCntEvent",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "SerialId", SerialId },
                });
            return response.Data;
        }

        public string CheckClassTypeSerial(string SerialId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Coupon/CheckClassTypeSerial",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "SerialId", SerialId },
                });
            return response.Data;
        }

        public List<USP_CPN_SerialIssueForCondition_Q> GetSerialForOrder(string serialno, string memberguid, string loginId, string orderItemXML)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_CPN_SerialIssueForCondition_Q>>>(
                "Coupon/GetSerialListForOrder",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "serialno", serialno },
                    new[] { "memberguid", memberguid },
                    new[] { "loginId", loginId },
                    new[] { "orderItemXML", orderItemXML }
                });
            return response.Data;
        }

        public List<CheckSerialForDeliveryModel> CheckSerialForDelivery(string serialno, string memberGUID, string loginId, string basketTypeCd, string postalCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CheckSerialForDeliveryModel>>>(
                "Coupon/CheckSerialForDelivery",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "serialno", serialno },
                    new[] { "memberguid", memberGUID },
                    new[] { "loginid", loginId },
                    new[] { "postalCode", postalCode }
                });
            return response.Data;
        }

        public List<CouponIssueByCouponTypeCd> GetCouponForOrder(string memberGUID, string loginId, string basketTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CouponIssueByCouponTypeCd>>>(
                "Coupon/GetCouponForOrder",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID },
                    new[] { "loginId", loginId },
                    new[] { "basketTypeCd", basketTypeCd }
                });
            return response.Data;
        }
    }
}
