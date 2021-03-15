using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Report;

namespace Yes24.APIService.Report
{
    public class ReportAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<ReportAPI> lazy = new Lazy<ReportAPI>(() => new ReportAPI());
        public static ReportAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<ReportOrderItemModel> SearchOrderItem(ReportOrderItemSearchModel data)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ReportOrderItemModel>>, ReportOrderItemSearchModel>(
                "Report/SearchOrderItem",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<ReportMemberModel> SearchMember(ReportMemberSearchModel data)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ReportMemberModel>>, ReportMemberSearchModel>(
                "Report/SearchMember",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<ReportBasketModel> SearchBasket(ReportBasketSearchModel data)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ReportBasketModel>>, ReportBasketSearchModel>(
                "Report/SearchBasket",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

    }
}
