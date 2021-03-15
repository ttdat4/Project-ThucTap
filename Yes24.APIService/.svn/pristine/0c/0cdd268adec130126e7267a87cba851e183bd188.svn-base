using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Interface;

namespace Yes24.APIService.Interface
{
    public class InterfaceAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<InterfaceAPI> lazy = new Lazy<InterfaceAPI>(() => new InterfaceAPI());
        public static InterfaceAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<USP_IF_CidBizForwardingDataItemLog_Q> GetCidBizForwardingDataItemLog(long Uid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_IF_CidBizForwardingDataItemLog_Q>>>(
                "Interface/GetCidBizForwardingDataItemLog",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "Uid", Uid.ToString() }
                });
            return response.Data;
        }

        public List<USP_IF_CidBizForwardingDataLog_Q> GetCidBizForwardingDataLog(string datetime_01)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_IF_CidBizForwardingDataLog_Q>>>(
                "Interface/GetCidBizForwardingDataLog",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "datetime_01", datetime_01 }
                });
            return response.Data;
        }
        public int InsertVendorContact(VendorContact vendorContact)
        {
            var data = vendorContact;
            var response = GetDataFromApiOut<BaseResultAPI<int>, VendorContact>(
                   "Interface/InsertVendorContact",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
    }
}
