using RestSharp;
using System;
using System.Collections.Generic;
using System.Web;
using Yes24.DTO;
using Yes24.DTO.Profile;
using Yes24.Utilities;
using BaseAPI = Yes24.APIService.Helper.BaseAPI;
using System.Configuration;
using Yes24.DTO.SCM;

namespace Yes24.APIService.SCM
{
    public class SCMAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<SCMAPI> lazy = new Lazy<SCMAPI>(() => new SCMAPI());
        public static SCMAPI Instance { get { return lazy.Value; } }
        #endregion

        public int AuthUserInfo(string loginId, string password)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            AuthUserModel data = new AuthUserModel
            {
                loginId = loginId,
                password = password
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AuthUserModel>(
                 "HomeAPI/AuthUserInfo",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }
        public VendorModel GetVendorInfo(string LoginID)
        {
            VendorModel result = new VendorModel();
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            var response = GetDataFromApiOut<BaseResultAPI<VendorModel>>(
                    "HomeAPI/GetVendorInfo",
                    Method.GET,
                    null,
                    new List<string[]> {
                    new[] { "LoginID", LoginID }
                    });
            return response.Data;
        }
        public Tuple<InfoSaleOfSupplierModel, List<InfoSaleOfSupplierWeekModel>> GetInfoSaleOfSupplierModel(int providerNo)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<InfoSaleOfSupplierModel, List<InfoSaleOfSupplierWeekModel>>>>(
                "HomeAPI/GetInfoSaleOfSupplierModel",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "providerNo", providerNo.ToString() },
                });
            return response.Data;
        }
        public List<NoticeForFrontMyPageModel> SelectNotice_SCM(int ProviderNo = 0)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            var response = GetDataFromApiOut<BaseResultAPI<List<NoticeForFrontMyPageModel>>>(
               "HomeAPI/SelectNotice",
               Method.GET,
               null,
               new List<string[]>
               {
                    new[] { "ProviderNo", ProviderNo.ToString() },
               });
            return response.Data;
        }
        public DeliveryOrderSumary OrderSearchSumary(int ProviderNo)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            SearchOrdersModel data = new SearchOrdersModel
            {
                DeliveryTypeV2 = string.Empty,
                ProductCode = string.Empty,
                InvoiceNo = string.Empty,
                Receiver = string.Empty,
                ProviderNo = ProviderNo,
                DateFrom = $"{DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd")} 00:00:00",
                DateTo = $"{DateTime.Now.ToString("yyyy-MM-dd")} 23:59:59",
            };
            var response = GetDataFromApiOut<BaseResultAPI<DeliveryOrderSumary>, SearchOrdersModel>(
                 "OrderAPI/OrderSearchSumary",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }
        public List<DeliveryOrderParentData> GetList(int ProviderNo, string StatusCD, string OrderNo = "")
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            SearchOrdersModel data = new SearchOrdersModel
            {
                OrderNo = OrderNo,
                ProviderNo = ProviderNo,
                DateFrom = $"{DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd")} 00:00:00",
                DateTo = $"{DateTime.Now.ToString("yyyy-MM-dd")} 23:59:59",
                Status = StatusCD
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<DeliveryOrderParentData>>, SearchOrdersModel>(
                 "OrderAPI/GetList",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }
        public List<DeliveryOrderData> GetDeliveryOrderDetail(int deliveryOrderNo, string status, int providerNo)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            var response = GetDataFromApiOut<BaseResultAPI<List<DeliveryOrderData>>>(
                    "OrderAPI/GetDeliveryOrderDetail",
                    Method.GET,
                    null,
                    new List<string[]> {
                        new string[]{ "deliveryOrderNo", deliveryOrderNo.ToString()},
                        new string[]{ "status", status },
                        new string[]{ "providerNo", providerNo.ToString() }
                        }
                    )
                    ;
            return response.Data;
        }
        public int UpdateDeliveryOrder(int[] DeliveryOrderItemNo, string[] ExceptionDesc, string[] ProductStatus)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            UpdateDeliveryOrderModel data = new UpdateDeliveryOrderModel
            {
                DeliveryOrderItemNo = DeliveryOrderItemNo,
                ExceptionDesc = ExceptionDesc,
                ProductStatus = ProductStatus,
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, UpdateDeliveryOrderModel>(
                 "OrderAPI/UpdateDeliveryOrder",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }
        public int CompleteDeliveryOrder(int[] DeliveryOrderNo,int ProviderNo)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            CompleteDeliveryOrderModel data = new CompleteDeliveryOrderModel
            {
                DeliveryOrderNo = DeliveryOrderNo,
                ProviderNo=ProviderNo
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, CompleteDeliveryOrderModel>(
                 "OrderAPI/CompleteDeliveryOrder",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }
        public int CreateInvoice(int[] DeliveryOrderNo, int ProviderNo)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            CreateInvoiceDeliveryOrderModel data = new CreateInvoiceDeliveryOrderModel
            {
                DeliveryOrderNo = DeliveryOrderNo,
                ProviderNo = ProviderNo
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, CreateInvoiceDeliveryOrderModel>(
                 "OrderAPI/CreateInvoice",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }
        public NoticeDetailForFrontMypageModel NotifyDetail(int id)
        {
            BaseURL = ConfigurationManager.AppSettings["URLSCMAPI"];
            var response = GetDataFromApiOut<BaseResultAPI<NoticeDetailForFrontMypageModel>>(
                    "HomeAPI/NotifyDetail",
                    Method.GET,
                    null,
                    new List<string[]>
                    {
                        new[] { "id", id.ToString() },
                    });
            return response.Data;
        }
    }
}
