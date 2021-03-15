using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
//using Yes24.DTO.Product;
using Yes24.DTO.Order;
using Yes24.DTO.Profile;

namespace Yes24.APIService.Order
{
    public class OrderAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<OrderAPI> lazy = new Lazy<OrderAPI>(() => new OrderAPI());
        public static OrderAPI Instance { get { return lazy.Value; } }
        #endregion

        public int CheckMemerTotalOrderAllow(string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Order/CheckMemerTotalOrderAllow",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGuid", memberGuid }
                });
            return response.Data;
        }

        public int GetFreeDeliverySetup(double DeliveryCost, string TotalPay, string TypeCd, int DeliveryUnitNo)
        {
            GetFreeDeliverySetupModel data = new GetFreeDeliverySetupModel
            {
                DeliveryCost = DeliveryCost,
                TotalPay = TotalPay,
                TypeCd = TypeCd,
                DeliveryUnitNo = DeliveryUnitNo
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, GetFreeDeliverySetupModel>(
                "Order/GetFreeDeliverySetup",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int GetFreeDeliverySetupSup(int DeliveryUnitNo, double DeliveryCost, string TotalPay)
        {
            GetFreeDeliverySetupModel data = new GetFreeDeliverySetupModel
            {
                DeliveryUnitNo = DeliveryUnitNo,
                DeliveryCost = DeliveryCost,
                TotalPay = TotalPay
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, GetFreeDeliverySetupModel>(
                "Order/GetFreeDeliverySetup",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int CountOrderForDeliveryRule()
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Order/CountOrderForDeliveryRule",
                Method.GET,
                null,
                null);
            return response.Data;
        }

        public int CheckDeliveryUnitNo(int DeliveryUnitNo, string TypeCd, int Num)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Order/CheckDeliveryUnitNo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "DeliveryUnitNo", DeliveryUnitNo.ToString() },
                    new[] { "TypeCd", TypeCd },
                    new[] { "Num", Num.ToString() }
                });
            return response.Data;
        }

        public List<OrderDataZalo> GetOrderNobyTransactionNo(string TransactionNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<OrderDataZalo>>>(
                "Order/GetOrderNobyTransactionNo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "TransactionNo", TransactionNo }
                });
            return response.Data;
        }

        public List<USP_ORD_OrderItemForFront_Q> GetItems(string orderGUID, int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderItemForFront_Q>>>(
                "Order/GetItemsForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID },
                    new[] { "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }
        public List<USP_ORD_OrderItemForFront_Q> GetItems(string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ORD_OrderItemForFront_Q>>>(
                "Order/GetItems",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID }
                });
            return response.Data;
        }

        public OrderData GetOrderDetailByOrderNo(long orderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<OrderData>>(
                "Order/GetDetail",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderNo", orderNo.ToString() }
                });
            return response.Data;
        }

        public bool CheckNonMemberOrderByCellNum(long orderNo, string CellNum)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Order/CheckNonMemberOrderByCellnum",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderNo", orderNo.ToString() },
                    new[] { "CellNum", CellNum }
                });
            return response.Data;
        }

        public List<OrderData> GetOrderOfCustomer(string loginID, DateTime fromDate, DateTime toDate)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<OrderData>>>(
                "Order/GetOrderOfCustomer",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginID", loginID },
                    new[] { "fromDate", fromDate.ToString() },
                    new[]{ "toDate",toDate.ToString() }
                });
            return response.Data;
        }

        public List<OrderDetailNew> SelectDeliveryOrderDetailsNew(string orderGUID, int deliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<OrderDetailNew>>>(
                "Order/SelectDeliveryOrderDetailsNew",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "orderGUID", orderGUID },
                    new[] { "deliveryUnitNo", deliveryUnitNo.ToString() }
                });
            return response.Data;
        }
    }
}
