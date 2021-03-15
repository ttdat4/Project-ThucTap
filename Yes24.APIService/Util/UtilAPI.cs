using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Promotion;
using Yes24.DTO.SystemManagerment;
using Yes24.DTO.Vendor;

namespace Yes24.APIService.Util
{
    public class UtilAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<UtilAPI> lazy = new Lazy<UtilAPI>(() => new UtilAPI());
        public static UtilAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<PostalCodeModel> GetZipCode(string searchText)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PostalCodeModel>>>(
                "Util/GetZipCode",
                Method.GET,
                null,
                new List<string[]> { new[] { "searchText", searchText } });
            return response.Data;
        }
        public PostalCodeModel GetPostalCodeById(int PostalCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<PostalCodeModel>>(
                "Util/GetPostalCodeById",
                Method.GET,
                null,
                new List<string[]> { new[] { "PostalCode", PostalCode.ToString() } });
            return response.Data;
        }

        public List<PostalVinaCodeV2> GetZipVinaCode(int type, string key1, string key2)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PostalVinaCodeV2>>>(
                "Util/GetZipVinaCode",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "type", type.ToString() },
                    new[] { "key1", key1 },
                    new[] { "key2", key2 }
                });
            return response.Data;
        }

        public List<NoticeForFront> GetNotice(int iCategoryNo, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<NoticeForFront>>>(
                "Util/GetForFrontList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "iCategoryNo", iCategoryNo.ToString() },
                    new[] { "rowCount", rowCount.ToString() }
                });
            return response.Data;
        }

        public List<CidCouponMailSet> GetCidCouponMailSet(int couponId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CidCouponMailSet>>>(
                "Util/GetCidCouponMailSet",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "couponId", couponId.ToString() }
                });
            return response.Data;
        }

        public List<DeliveryUnitCost> GetDeliveryUnitCost(int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DeliveryUnitCost>>>(
                "Util/GetDeliveryUnitCost",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }
        public List<ProviderDetail> GetProviderDetail(int providerNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProviderDetail>>>(
                "Util/GetProviderDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "providerNo", providerNo.ToString() }
                });
            return response.Data;
        }

        public int RegisterEmail(string EmailInput, string Gender)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Util/RegisterEmail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "EmailInput", EmailInput },
                    new[] { "Gender", Gender }
                });
            return response.Data;
        }

        public List<PostalVinaCodeV2> GetZipVinaCodeV2(int type, int state, int city)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<PostalVinaCodeV2>>>(
                "Util/GetZipVinaCodeV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "type", type.ToString() },
                    new[] { "state", state.ToString() },
                    new[] { "city", city.ToString() }
                });
            return response.Data;
        }

        public int VersionAppInsert(string ckVersionApp, string macAddress, string clientIp, string userAgent, string version)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Util/VersionAppInsert",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ckVersionApp", ckVersionApp },
                    new[] { "macAddress", macAddress },
                    new[] { "clientIp", clientIp },
                    new[] { "userAgent", userAgent },
                    new[] { "version", version },
                });
            return response.Data;
        }

        public string GetLanguageValue(string Pages, string Position, string Cookie)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Redis/GetLanguageValue",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Pages", Pages },
                    new[] { "Position", Position },
                    new[] { "Cookie", Cookie }
                });
            return response.Data;
        }
        public int LogUser(string LogFunction, string LoginId, int OrderNo, int DeliveryCost, string IPClient, bool IsCartClick, string Errors, string SessionID, string UserAgent)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Util/LogUser",
                Method.POST,
                null,
                new List<string[]>
                {
                    new[] { "LogFunction", LogFunction },
                    new[] { "LoginId", LoginId },
                    new[] { "OrderNo", OrderNo.ToString() },
                    new[] { "DeliveryCost", DeliveryCost.ToString() },
                    new[] { "IPClient", IPClient },
                    new[] { "IsCartClick", IsCartClick.ToString() },
                    new[] { "Errors", Errors },
                    new[] { "SessionID", SessionID },
                    new[] { "UserAgent", UserAgent },
                });
            return response.Data;
        }
    }
}
