using System;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO.EVoucher;

namespace Yes24.APIService.EVoucher
{
    public class EVoucherAPI : BaseEVoucherAPI
    {
        #region Singleton
        private static readonly Lazy<EVoucherAPI> lazy = new Lazy<EVoucherAPI>(() => new EVoucherAPI());
        public static EVoucherAPI Instance { get { return lazy.Value; } }
        #endregion

        public OrderEVoucherResponse SendOrder(OrderEVoucherRequest model)
        {
            var response = GetDataFromApiOut<OrderEVoucherResponse, OrderEVoucherRequest>(
                "Evoucher/SendOrder",
                Method.POST,
                null,
                null, model);
            return response;
        }
    }
}
