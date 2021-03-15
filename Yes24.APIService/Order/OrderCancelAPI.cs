using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Order;
using OrderPaymentResultData = Yes24.DTO.Order.OrderPaymentResultData;

namespace Yes24.APIService.Order
{
    public class OrderCancelAPI : BaseOrderAPI
    {
        #region Singleton
        private static readonly Lazy<OrderCancelAPI> lazy = new Lazy<OrderCancelAPI>(() => new OrderCancelAPI());
        public static OrderCancelAPI Instance { get { return lazy.Value; } }
        #endregion

        public bool CheckIsAllCancel(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "OrderCancel/CheckIsAllCancel",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }
                });
            return response.Data;
        }

        public OrderExceptionResultData2 CancelOrderWithPayment(string orderGUID, string bankName, string accountNum, string depositName, string memo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<OrderExceptionResultData2>, CancelAllModel>(
                "OrderCancel/CancelAll",
                Method.POST,
                null,
                null,
                new CancelAllModel
                {
                    OrderGUID = orderGUID,
                    AccountNum = accountNum,
                    BankName = bankName,
                    DepositName = depositName,
                    Memo = memo
                });
            return response.Data;
        }
    }
}
