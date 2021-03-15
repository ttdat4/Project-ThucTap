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
    public class OrderAPINew : BaseOrderAPI
    {
        #region Singleton
        private static readonly Lazy<OrderAPINew> lazy = new Lazy<OrderAPINew>(() => new OrderAPINew());
        public static OrderAPINew Instance { get { return lazy.Value; } }
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

        public CommandResult ReceiveOrder(OrderFormData orderForm)
        {
            var response = GetDataFromApiOut<BaseResultAPI<CommandResult>, OrderFormData>(
                "Order/ReceiveOrder",
                Method.POST,
                null,
                null, orderForm);
            return response.Data;
        }

        public CommandResult ReceiveOrderEcom(OrderFormData orderForm)
        {
            var response = GetDataFromApiOut<BaseResultAPI<CommandResult>, OrderFormData>(
                "Order/ReceiveOrderEcom",
                Method.POST,
                null,
                null, orderForm);
            return response.Data;
        }

        public OrderPaymentResultData CompleteOrder(Yes24.DTO.OrderData.OrderData orderForm)
        {
            var response = GetDataFromApiOut<BaseResultAPI<OrderPaymentResultData>, Yes24.DTO.OrderData.OrderData>(
                "Order/CompleteOrder",
                Method.POST,
                null,
                null, orderForm);
            return response.Data;
        }

        public OrderPaymentResultData CompleteOrderEcom(Yes24.DTO.OrderData.OrderData orderForm)
        {
            var response = GetDataFromApiOut<BaseResultAPI<OrderPaymentResultData>, Yes24.DTO.OrderData.OrderData>(
                "Order/CompleteOrderEcom",
                Method.POST,
                null,
                null, orderForm);
            return response.Data;
        }

        public CommandResult CheckPromotionOrder(string BasketId, string deviceMode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<CommandResult>>(
                "Order/CheckPromotionOrder",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "BasketId", BasketId },
                    new []{ "DeviceMode", deviceMode }
                });
            return response.Data;
        }

        public GetMemberOrderData GetMemberDataOrder(string MemberGUID, string basketTypeCd, string sessionId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<GetMemberOrderData>>(
                "Order/GetMemberDataOrder",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "MemberGUID", MemberGUID },
                    new[] { "basketTypeCd", basketTypeCd },
                    new[] { "sessionId", sessionId }
                });
            return response.Data;
        }

        public int UpdateOrderType(string orderGUID, string OrderTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Order/UpdateOrderType",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID },
                    new[] { "OrderTypeCd", OrderTypeCd }}
                );
            return response.Data;
        }

        public List<USP_ORD_OrderItemForFront_Q> GetOrderItem(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderItemForFront_Q>>>(
                "Order/GetOrderItem",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }}
            );
            return response.Data;
        }

        public USP_ORD_OrderSummaryForFront_Q GetOrderSummary(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<USP_ORD_OrderSummaryForFront_Q>>(
                "Order/GetOrderSummary",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }}
            );
            return response.Data;
        }

        public double GetTotalPaymentForGateWay(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<USP_ORD_OrderSummaryForFront_Q>>(
                "Order/GetOrderSummary",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }}
            );

            if (response.Data != null)
            {
                var TotalAmountDeposit = response.Data.TotalAmountDeposit.GetValueOrDefault(0);
                if (TotalAmountDeposit > 0 && response.Data.PaymentTypeCd == "COD")
                {
                    return TotalAmountDeposit;
                }
                return response.Data.PaymentTotal;
            }

            return 0;
        }

        public double GetTotalPayment(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<USP_ORD_OrderSummaryForFront_Q>>(
                "Order/GetOrderSummary",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }}
            );

            if (response.Data != null)
            {
                return response.Data.PaymentTotal;
            }

            return 0;
        }

        public int AddAgencyOrder(string LoginID, string APINFO, string ORDER_CODE, string PRODUCT_CODE,
            int ITEM_COUNT, double PRICE,
            string PRODUCT_NAME, string CATEGORY_CODE, string MemberNAME, string REMOTE_ADDR, string STATUSCD,
            string Agency, string ClickId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, AgencyOrder>(
                "Order/AddAgencyOrder",
                Method.POST,
                null,
                null,
                new AgencyOrder
                {
                    LoginID = LoginID,
                    APINFO = APINFO,
                    Agency = Agency,
                    CATEGORY_CODE = CATEGORY_CODE,
                    ClickId = ClickId,
                    ITEM_COUNT = ITEM_COUNT,
                    MemberNAME = MemberNAME,
                    ORDER_CODE = ORDER_CODE,
                    PRICE = PRICE,
                    PRODUCT_CODE = PRODUCT_CODE,
                    PRODUCT_NAME = PRODUCT_NAME,
                    REMOTE_ADDR = REMOTE_ADDR,
                    STATUSCD = STATUSCD
                });
            return response.Data;
        }

        public List<USP_ORD_OrderGiftNoteComplete_Q> SelectOrderGiftComplete(long orderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderGiftNoteComplete_Q>>>(
                "Order/SelectOrderGiftComplete",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderNo", orderNo.ToString() }}
            );
            return response.Data;
        }

        public double GetAddDeliveryCost(int logisticsNo, string postalCode, string basketId, double itemTotal, int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>, DeliveryCostNewModel>(
                "Order/GetAddDeliveryCost",
                Method.POST,
                null,
                null,
                new DeliveryCostNewModel
                {
                    basketId = basketId,
                    deliveryUnitNo = deliveryUnitNo,
                    itemTotal = itemTotal,
                    logisticsNo = logisticsNo,
                    postalCode = postalCode
                }
            );

            return response.Data;
        }

        public double GetAddDeliveryCostNew(int logisticsNo, string postalCode, string basketId, double itemTotal, int deliveryUnitNo, double kgCal)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>, DeliveryCostNewModel>(
                "Order/GetAddDeliveryCostNew",
                Method.POST,
                null,
                null,
                new DeliveryCostNewModel
                {
                    basketId = basketId,
                    deliveryUnitNo = deliveryUnitNo,
                    itemTotal = itemTotal,
                    kgCal = kgCal,
                    logisticsNo = logisticsNo,
                    postalCode = postalCode
                }
            );

            return response.Data;
        }

        public double SelectDeliveryTime(string PostalCode, int DeliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Order/SelectDeliveryTime",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "PostalCode", PostalCode },
                    new[] { "DeliveryUnitNo", DeliveryUnitNo.ToString() }
                }
            );

            return response.Data;
        }

        public double GetAddDeliveryCostNew3462(int logisticsNo, string postalCode, string basketId, double itemTotal, int deliveryUnitNo, double kgCal)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>, DeliveryCostNewModel>(
                "Order/GetAddDeliveryCostNew3462",
                Method.POST,
                null,
                null,
                new DeliveryCostNewModel
                {
                    basketId = basketId,
                    deliveryUnitNo = deliveryUnitNo,
                    itemTotal = itemTotal,
                    kgCal = kgCal,
                    logisticsNo = logisticsNo,
                    postalCode = postalCode
                }
            );

            return response.Data;
        }

        public int GetFeeShipBySupplier(string BasketId, string DeliveryPostalCode, int DeliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, DeliveryCostNewModel>(
                "Order/GetFeeShipBySupplier",
                Method.POST,
                null,
                null,
                new DeliveryCostNewModel
                {
                    basketId = BasketId,
                    deliveryUnitNo = DeliveryUnitNo,
                    postalCode = DeliveryPostalCode
                }
            );

            return response.Data;
        }

        public MemberPaymentData GetGuestPaymentInfo(string sessionID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<MemberPaymentData>>(
                "Order/GetGuestPaymentInfo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "sessionID", sessionID }}
            );
            return response.Data;
        }

        public MemberPaymentData GetMemberPaymentInfo(string memberGUID, string basketTypeCd, string sessionId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<MemberPaymentData>>(
                "Order/GetMemberPaymentInfo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "sessionId", sessionId },
                    new[] { "memberGUID", memberGUID },
                    new[] { "basketTypeCd", basketTypeCd },

                }
            );
            return response.Data;
        }

        public int UpdateOrderCancelReason(string orderGuid, string reasonCancel)
        {
            var data = new UpdateOrderCancelReason
            {
                OrderGuid = orderGuid,
                ReasonCancel = reasonCancel
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, UpdateOrderCancelReason>(
                "Order/UpdateOrderCancelReason",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<USP_ORD_OrderDetailForFront_Q> GetOrderDetail(string orderGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderDetailForFront_Q>>>(
                "Order/GetMemberPaymentInfo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGuid", orderGuid },

                }
            );
            return response.Data;
        }

        public void OrderEcomAutoReceive()
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Order/GetMemberPaymentInfo",
                Method.GET,
                null,
                null
            );
        }

        public List<GetDeliveryCostModel> GetDeliveryCost(string MemberGUID, string CustomerTypeCd, string PostalCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetDeliveryCostModel>>>(
                "Order/GetDeliveryCost",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "MemberGUID", MemberGUID },
                    new[] { "CustomerTypeCd", CustomerTypeCd },
                    new[] { "PostalCode", PostalCode }
                }
            );
            return response.Data;
        }

        public string CheckPhoneUnconfirmed(string Cellnum, string Email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Order/CheckPhoneUnconfirmed",
                Method.POST,
                null,
                new List<string[]> {
                    new[] { "Cellnum", Cellnum },
                    new[] { "Email", Email }
                }
            );

            return response.Data;
        }
    }
}
