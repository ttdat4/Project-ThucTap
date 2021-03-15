using RestSharp;
using System;
using System.Collections.Generic;
using Yes24.APIService.Helper;
using Yes24.DTO;

namespace Yes24.APIService.PluginEvent
{
    public class PluginEventAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<PluginEventAPI> lazy = new Lazy<PluginEventAPI>(() => new PluginEventAPI());
        public static PluginEventAPI Instance { get { return lazy.Value; } }
        #endregion

        public int CheckKeoSaoGift(string LoginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/CheckKeoSaoGift",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginID", LoginID },
               });
            return response.Data;
        }

        public int CheckTichLuyLaneige(string LoginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/CheckTichLuyLaneige",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginID", LoginID },
               });
            return response.Data;
        }
        public int InsertKotraOfflineLog(string Data, string Type)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/InsertKotraOfflineLog",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "Data", Data },
                    new[] { "Type", Type },
               });
            return response.Data;
        }
        public int SendKotraSerialSMS(string phone, string content)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/SendKotraSerialSMS",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "phone", phone },
                    new[] { "content", content },
               });
            return response.Data;
        }
        public int UpdateGiftNoteOrderEvent(int OrderNo, string GiftName, int BrandNo = 0)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/UpdateGiftNoteOrderEvent",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "OrderNo", OrderNo.ToString() },
                    new[] { "GiftName", GiftName },
                    new[] { "BrandNo", BrandNo.ToString() },
               });
            return response.Data;
        }
        public int VoteChuyenVeMe(string LoginID, string UserNameCreatedBy, string TagName, int BoardNo, int EventNo, string ClientIpCreatedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/VoteChuyenVeMe",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginID", LoginID },
                    new[] { "UserNameCreatedBy", UserNameCreatedBy },
                    new[] { "TagName", TagName},
                    new[] { "BoardNo", BoardNo.ToString()},
                    new[] { "EventNo", EventNo.ToString()},
                    new[] { "ClientIpCreatedBy", ClientIpCreatedBy},
               });
            return response.Data;
        }
        public int RegisterKotraDealHoi(string LoginID, string UserNameCreatedBy, string TagName, int EventNo, string ClientIpCreatedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/RegisterKotraDealHoi",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginID", LoginID },
                    new[] { "UserNameCreatedBy", UserNameCreatedBy },
                    new[] { "TagName", TagName},
                    new[] { "EventNo", EventNo.ToString()},
                    new[] { "ClientIpCreatedBy", ClientIpCreatedBy},
               });
            return response.Data;
        }
        public int GetGiftLaneige(int EventFEBNoFrom, int EventFEBNoTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "PluginEvent/GetGiftLaneige",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginID", EventFEBNoFrom.ToString() },
                    new[] { "EventFEBNoTo", EventFEBNoTo.ToString()},
               });
            return response.Data;
        }
        public int GetValidateOrder505(string LoginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
               "PluginEvent/GetValidateOrder505",
               Method.GET,
               null,
               new List<string[]> {
                    new[] { "LoginID", LoginID },
              });
            return response.Data;
        }
    }
}
