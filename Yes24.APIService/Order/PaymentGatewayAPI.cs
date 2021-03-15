using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Order;
using Yes24.DTO.PaymentGateway;
using AgribankPaymentGatewayLogData = Yes24.DTO.Order.AgribankPaymentGatewayLogData;


namespace Yes24.APIService.Order
{
    public class PaymentGatewayAPI : BaseOrderAPI
    {
        #region Singleton
        private static readonly Lazy<PaymentGatewayAPI> lazy = new Lazy<PaymentGatewayAPI>(() => new PaymentGatewayAPI());
        public static PaymentGatewayAPI Instance { get { return lazy.Value; } }
        #endregion

        public PaymentGatewayResultData ReceivePaymentGateway(PaymentGatewayLogData logInfo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<PaymentGatewayResultData>, PaymentGatewayLogData>(
                "PaymentGateway/ReceivePaymentGateway",
                Method.POST,
                null,
                null,
                logInfo);
            return response.Data;
        }

        public PaymentGatewayResultData AgribankReceivePaymentGateway(AgribankPaymentGatewayLogData logInfo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<PaymentGatewayResultData>, AgribankPaymentGatewayLogData>(
                "PaymentGateway/AgribankReceivePaymentGateway",
                Method.POST,
                null,
                null, 
                logInfo);
            return response.Data;
        }

        public PaymentGatewayResultData VNPayReceivePaymentGateway(VNPayPaymentGatewayLogData logInfo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<PaymentGatewayResultData>, VNPayPaymentGatewayLogData>(
                "PaymentGateway/VNPayReceivePaymentGateway",
                Method.POST,
                null,
                null,
                logInfo);
            return response.Data;
        }

        public PaymentGatewayResultData MoMoReceivePaymentGateway(MoMoPaymentGatewayLogData logInfo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<PaymentGatewayResultData>, MoMoPaymentGatewayLogData>(
                "PaymentGateway/MoMoReceivePaymentGateway",
                Method.POST,
                null,
                null,
                logInfo);
            return response.Data;
        }

        public PaymentGatewayResultData ZaloReceivePaymentGateway(ZaloPaymentGatewayLogData logInfo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<PaymentGatewayResultData>, ZaloPaymentGatewayLogData>(
                "PaymentGateway/ZaloReceivePaymentGateway",
                Method.POST,
                null,
                null,
                logInfo);
            return response.Data;
        }

        public PaymentGatewayResultData MocaReceivePaymentGateway(MocaPaymentGatewayLogData logInfo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<PaymentGatewayResultData>, MocaPaymentGatewayLogData>(
                "PaymentGateway/MocaReceivePaymentGateway",
                Method.POST,
                null,
                null,
                logInfo);
            return response.Data;
        }

    }
}
