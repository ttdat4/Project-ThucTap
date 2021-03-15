using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Catalog;
using Yes24.DTO.Event;

namespace Yes24.APIService.Event
{
    public class EventAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<EventAPI> lazy = new Lazy<EventAPI>(() => new EventAPI());
        public static EventAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<EventEntryPrizesForEntry_Q> GetEventEntryPrizesForEntry()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntryPrizesForEntry_Q>>>(
                "Event/GetEventEntryPrizesForEntry",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public List<EventEntryPrizesForEntry_Q> GetEventEntryPrizesForEntryCompress()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntryPrizesForEntry_Q>>>(
                "Event/GetEventEntryPrizesForEntryCompress",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public int GetEntryTicketCount(int eventNo, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
               "Event/GetEntryTicketCount",
               Method.GET,
               null,
               new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "loginId", loginId }
               });
            return response.Data;
        }
        public List<EntriesTicket> GetMyEntryList(int eventNo, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EntriesTicket>>>(
                "Event/GetMyEntryList",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "loginId", loginId }
               });
            return response.Data;
        }
        public List<EntriesTicket> GetMyEntryListCompress(int eventNo, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EntriesTicket>>>(
                "Event/GetMyEntryListCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "loginId", loginId }
               });
            return response.Data;
        }
        public int AddEventEntriesLogForEntry(int eventNo, string memberGuid, int prizeId, string clientIpJoined)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/AddEventEntriesLogForEntry",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGuid", memberGuid },
                    new[] { "prizeId", prizeId.ToString() },
                    new[] { "clientIpJoined", clientIpJoined }
               });
            return response.Data;
        }
        public int AddEventEntryPrize(int eventNo, string memberGUID, string loginId, string memberName, bool isCorrect, string clientIpCreatedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/AddEventEntryPrize",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGUID", memberGUID },
                    new[] { "loginId", loginId },
                    new[] { "memberName", memberName },
                    new[] { "isCorrect", isCorrect.ToString() },
                    new[] { "clientIpCreatedBy", clientIpCreatedBy }
               });
            return response.Data;
        }
        public int CheckDateValidate(int eventNo, string nowDate)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/CheckDateValidate",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "nowDate", nowDate }
               });
            return response.Data;
        }
        public int CheckEventEntryCount(int eventNo, string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/CheckEventEntryCount",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGUID", memberGUID }
               });
            return response.Data;
        }
        public List<EntryPrizeInfoByPrizeId> GetEntryPrizeInfoByPrizeId(int PrizeId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EntryPrizeInfoByPrizeId>>>(
                "Event/GetEntryPrizeInfoByPrizeId",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "PrizeId", PrizeId.ToString() }
               });
            return response.Data;
        }
        public List<EntryPrizeInfoByPrizeId> GetEntryPrizeInfoByPrizeIdCompress(int PrizeId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EntryPrizeInfoByPrizeId>>>(
                "Event/GetEntryPrizeInfoByPrizeIdCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "PrizeId", PrizeId.ToString() }
               });
            return response.Data;
        }
        public int UpdateEventSerial(int eventNo, string serialNo, string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/UpdateEventSerial",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "serialNo", serialNo },
                    new[] { "memberGuid", memberGuid }
               });
            return response.Data;
        }
        public List<EventSerial> SelectEventSerialForPrize(int eventNo, int prizeId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventSerial>>>(
                "Event/SelectEventSerialForPrize",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "prizeId", prizeId.ToString() }
               });
            return response.Data;
        }
        public List<EventSerial> SelectEventSerialForPrizeCompress(int eventNo, int prizeId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventSerial>>>(
                "Event/SelectEventSerialForPrizeCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "prizeId", prizeId.ToString() }
               });
            return response.Data;
        }
        public List<EventEntryPrizes> GetEventEntryPrizes(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntryPrizes>>>(
                "Event/GetEventEntryPrizes",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
               });
            return response.Data;
        }
        public List<EventEntryPrizes> GetEventEntryPrizesCompress(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntryPrizes>>>(
                "Event/GetEventEntryPrizesCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
               });
            return response.Data;
        }
        public int AddEventEntriesLog(int eventNo, string memberGuid, int entryPrizeId, int entryPrizeEtc, string entryRefKey, string clientIpCreatedBy, string isPrize)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/AddEventEntriesLog",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGuid", memberGuid },
                    new[] { "entryPrizeId", entryPrizeId.ToString() },
                    new[] { "entryPrizeEtc", entryPrizeEtc.ToString() },
                    new[] { "entryRefKey", entryRefKey },
                    new[] { "clientIpCreatedBy", clientIpCreatedBy },
                    new[] { "isPrize", isPrize }
               });
            return response.Data;
        }
        public List<EventInfo> GetEventInfoForAttend(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventInfo>>>(
                "Event/GetEventInfoForAttend",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() }
               });
            return response.Data;
        }
        public List<EventInfo> GetEventInfoForAttendCompress(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventInfo>>>(
                "Event/GetEventInfoForAttendCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() }
               });
            return response.Data;
        }
        public int AddEventEntryPrizeForAttend(int eventNo, string memberGUID, string loginId, string memberName, string clientIpCreatedBy,
                                    int prizeEntry, int maxLimitCnt, string entryStartDate, int defaultEntryCnt)
        {
            var data = new AddEventEntryPrizeForAttendModel
            {
                EventNo = eventNo,
                MemberGUID = memberGUID,
                LoginId = loginId,
                MemberName = memberName,
                ClientIpCreatedBy = clientIpCreatedBy,
                PrizeEntry = prizeEntry,
                MaxLimitCnt = maxLimitCnt,
                EntryStartDate = entryStartDate,
                DefaultEntryCnt = defaultEntryCnt
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventEntryPrizeForAttendModel>(
                "Event/AddEventEntryPrizeForAttend",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }
        public List<EventEntriesLogTotal> GetEventEntriesLogCount(int eventNo, string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntriesLogTotal>>>(
                "Event/GetEventInfoForAttendCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGuid", memberGuid }
               });
            return response.Data;
        }
        public List<EventEntriesLogTotal> GetAllEventEntriesLogCount(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntriesLogTotal>>>(
                "Event/GetAllEventEntriesLogCount",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() }
               });
            return response.Data;
        }
        public bool CheckEventEntriesLogCount(int eventNo, string LoginId, long orderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Event/AddEventEntryPrizeForAttend",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "LoginId", LoginId },
                    new[] { "orderNo", orderNo.ToString()  },
               });
            return response.Data;
        }
        public List<EventEntriesLogTotal> GetAllEventEntriesLogCountCompress(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntriesLogTotal>>>(
                "Event/GetAllEventEntriesLogCountCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() }
               });
            return response.Data;
        }
        public List<EventEntriesLogTotal> GetEventEntriesLogCountCompress(int eventNo, string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntriesLogTotal>>>(
                "Event/GetEventEntriesLogCountCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() }
               });
            return response.Data;
        }
        public List<EventEntriesLog> GetEventEntriesLogForHistory(string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntriesLog>>>(
                "Event/GetEventEntriesLogForHistory",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "memberGuid", memberGuid }
               });
            return response.Data;
        }
        public List<EventEntriesLog> GetEventEntriesLogForHistoryCompress(string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntriesLog>>>(
                "Event/GetEventEntriesLogForHistoryCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "memberGuid", memberGuid }
               });
            return response.Data;
        }
        public List<EventEntryPrizes> GetContentsAreaMgmt(string eventAreaCode, string contentsTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntryPrizes>>>(
                "Event/GetContentsAreaMgmt",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventAreaCode", eventAreaCode },
                    new[] { "contentsTypeCd", contentsTypeCd }
               });
            return response.Data;
        }
        public List<EventEntryPrizes> GetContentsAreaMgmtCompress(string eventAreaCode, string contentsTypeCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventEntryPrizes>>>(
                "Event/GetContentsAreaMgmtCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventAreaCode", eventAreaCode },
                    new[] { "contentsTypeCd", contentsTypeCd }
               });
            return response.Data;
        }
        public int AddEventNewsLetter(string sentName, string ReceiveName, string ReceiveMobile, string ReceiveText,
                                        string ReceiveEmail, string LoginId, string ProductCode, string clientIpCreatedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/AddEventNewsLetter",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "sentName", sentName },
                    new[] { "ReceiveName", ReceiveName },
                    new[] { "ReceiveMobile", ReceiveMobile },
                    new[] { "ReceiveText", ReceiveText },
                    new[] { "ReceiveEmail", ReceiveEmail },
                    new[] { "LoginId", LoginId },
                    new[] { "ProductCode", ProductCode},
                    new[] { "clientIpCreatedBy", clientIpCreatedBy },
               });
            return response.Data;
        }
        public List<DisplayCatalogProductForEvent> GetDisplayCatalogProductForEvent(double PriceFrom, double PriceTo, int rangeCount, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductForEvent>>>(
                "Event/GetDisplayCatalogProductForEvent",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "PriceFrom", PriceFrom.ToString() },
                    new[] { "PriceTo", PriceTo.ToString() },
                    new[] { "rangeCount", rangeCount.ToString() },
                    new[] { "rowCount", rowCount.ToString() },
               });
            return response.Data;
        }
        public List<DisplayCatalogProductForEvent> GetListGift(int EventFEBNoFrom, int EventFEBNoTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogProductForEvent>>>(
                "Event/GetListGift",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "EventFEBNoFrom", EventFEBNoFrom.ToString()},
                    new[] { "EventFEBNoTo", EventFEBNoTo.ToString() }
               });
            return response.Data;
        }
        public List<GetImageShareFb> GetImageShareFb(int CategoryNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetImageShareFb>>>(
                "Event/GetImageShareFb",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "CategoryNo", CategoryNo.ToString()},
               });
            return response.Data;
        }
        public int GetTotalTimesPlayEvent(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/GetTotalTimesPlayEvent",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },

               });
            return response.Data;
        }
        public List<Yes24PickModel> GetYes24Pick()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24PickModel>>>(
                "Event/GetYes24Pick",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public List<Yes24PickModel> GetYes24Black()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24PickModel>>>(
                "Event/GetYes24Black",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public Yes24PickModel GetYes24PickByID(int PickID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Yes24PickModel>>(
                "Event/GetYes24PickByID",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "PickID", PickID.ToString() },

               });
            return response.Data;
        }
        public List<HoneyDealModel> GetHoneyDealQuantity(string arrProductNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<HoneyDealModel>>>(
                "Event/GetHoneyDealQuantity",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "arrProductNo", arrProductNo },
               });
            return response.Data;
        }
        public List<EventListRankModel> GetListRankEvent(string loginId, int top, int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventListRankModel>>>(
                "Event/GetListRankEvent",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId },
                    new[] { "top", top.ToString() },
                    new[] { "eventNo", eventNo.ToString() }
               });
            return response.Data;
        }

        public int FeedLikeMemberInsert(int FeedID, string LoginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/FeedLikeMemberInsert",
                Method.POST,
                null,
                 new List<string[]> {
                    new[] { "FeedID", FeedID.ToString() },
                    new[] { "LoginID", LoginID.ToString() },

               });
            return response.Data;
        }
        public int FeedFollowByLoginIDInsertUpdate(string LoginID, int DeliveryUnitNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/FeedFollowByLoginIDInsertUpdate",
                Method.POST,
                null,
                 new List<string[]> {
                    new[] { "LoginID", LoginID },
                    new[] { "DeliveryUnitNo", DeliveryUnitNo.ToString()},

               });
            return response.Data;
        }
        public int FeedCommentByIdInsert(string LoginID, string Avatar, int FeedID, int Type, int ParentCommentID, string Content)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Event/FeedCommentByIdInsert",
                Method.POST,
                null,
                 new List<string[]> {
                    new[] { "LoginID", LoginID },
                    new[] { "Avatar", Avatar },
                    new[] { "FeedID", FeedID.ToString() },
                    new[] { "Type", Type.ToString() },
                    new[] { "ParentCommentID", ParentCommentID.ToString()},
                    new[] { "Content", Content},

               });
            return response.Data;
        }
        public List<FeedComment> FeedCommentByFeedID(int FeedID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FeedComment>>>(
                "Event/FeedCommentByFeedID",
                Method.POST,
                null,
                new List<string[]> {
                    new[] { "FeedID", FeedID.ToString() },
               });
            return response.Data;
        }
        public List<FeedProduct> FeedProductByLoginID(string loginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FeedProduct>>>(
                "Event/FeedProductByLoginID",
                Method.POST,
                null,
                new List<string[]> {
                    new[] { "loginID", loginID },
               });
            return response.Data;
        }
        public Feed FeedDetailByIdAndLoginID(int FeedID, string LoginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Feed>>(
                "Event/FeedDetailByIdAndLoginID",
                Method.POST,
                null,
                new List<string[]> {
                    new[] { "FeedID", FeedID.ToString() },
                    new[] { "LoginID", LoginID },
               });
            return response.Data;
        }
        public Tuple<List<FeedPaging>, int> FeedPaging(string LoginID, int PageIndex, int Pagelength)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<FeedPaging>, int>>>(
            "Event/FeedPaging",
            Method.POST,
            null,
            new List<string[]>
            {
                new[]{ "LoginID", LoginID },
                new[]{ "PageIndex", PageIndex.ToString()  },
                new[]{ "Pagelength", Pagelength.ToString()  },
            });
            return response.Data;
        }
    }
}
