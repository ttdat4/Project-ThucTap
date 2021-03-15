using RestSharp;
using System;
using System.Collections.Generic;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Coupon;
using Yes24.DTO.Event;
using Yes24.DTO.Promotion;

namespace Yes24.APIService.Promotion
{
    public class PromotionAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<PromotionAPI> lazy = new Lazy<PromotionAPI>(() => new PromotionAPI());
        public static PromotionAPI Instance { get { return lazy.Value; } }
        #endregion

        public int RunEventPromotion(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/RunEventPromotion",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID },
               });
            return response.Data;
        }
        public bool IsExistsEventEntriesLog(string LoginId, int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Promotion/IsExistsEventEntriesLog",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoginId", LoginId },
                    new[] { "eventNo", eventNo.ToString() },
               });
            return response.Data;
        }
        public int AddEventEntriesLog(int eventNo, string eventTitle, string LoginId, string memberName, string cellNum, string tellNum, string email, long orderNo, decimal itemTotal, decimal usedMileage, decimal paymentTotal, string entryPrizeNo)
        {
            var data = new AddEventEntriesLogModel
            {
                EventNo = eventNo,
                EventTitle = eventTitle,
                LoginId = LoginId,
                MemberName = memberName,
                CellNum = cellNum,
                TellNum = tellNum,
                Email = email,
                OrderNo = orderNo,
                ItemTotal = itemTotal,
                UsedMileage = usedMileage,
                PaymentTotal = paymentTotal,
                EntryPrizeNo = entryPrizeNo
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventEntriesLogModel>(
                   "Promotion/AddEventEntriesLog",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int GetEventEntriesLogByDate(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetEventEntriesLogByDate",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
               });
            return response.Data;
        }
        public List<SerialCouponInfo> GetSerialCouponInfo()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SerialCouponInfo>>>(
                 "Promotion/GetSerialCouponInfo",
                 Method.GET,
                 null,
                 null);
            return response.Data;
        }
        public byte[] GetSerialCouponInfoCompress()
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                 "Promotion/GetSerialCouponInfoCompress",
                 Method.GET,
                 null,
                 null);
            return response.Data;
        }
        public int GetSerialCouponCheckSerial(string SerialNo, string MemberGuid, int SerialSetNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetSerialCouponCheckSerial",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "SerialNo", SerialNo },
                    new[] { "MemberGuid", MemberGuid },
                    new[] { "SerialSetNo", SerialSetNo.ToString() },
               });
            return response.Data;
        }
        public int GetSerialCouponCheckUnique(string SerialNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetSerialCouponCheckUnique",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "SerialNo", SerialNo }
               });
            return response.Data;
        }
        public int ModifySerialCouponIssue(string SerialNo, string MemberGUID, int IsUnique, long couponId, string loginId, string memberName)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/ModifySerialCouponIssue",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "SerialNo", SerialNo },
                    new[] { "MemberGUID", MemberGUID },
                    new[] { "IsUnique", IsUnique.ToString() },
                    new[] { "couponId", couponId.ToString() },
                    new[] { "loginId", loginId },
                    new[] { "memberName", memberName },
               });
            return response.Data;
        }
        public int AddEventEntry(int eventNo, string memberGUID, int entryPrizeEtc, int entryRefKey, int isGradeLimit, bool isCorrect, string clientIpCreatedBy)
        {
            var data = new AddEventEntryPrizeModel
            {
                EventNo = eventNo,
                MemberGUID = memberGUID,
                EntryPrizeEtc = entryPrizeEtc,
                EntryRefKey = entryRefKey,
                IsGradeLimit = isGradeLimit,
                IsCorrect = isCorrect,
                ClientIpCreatedBy = clientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventEntryPrizeModel>(
                   "Promotion/AddEventEntry",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int AddEventEntryPrize(int eventNo, string memberGUID, string loginId, string memberName, int entryPrizeEtc, int entryRefKey, int isGradeLimit, bool isCorrect, string clientIpCreatedBy)
        {
            var data = new AddEventEntryPrizeModel
            {
                EventNo = eventNo,
                MemberGUID = memberGUID,
                LoginId = loginId,
                MemberName = memberName,
                EntryPrizeEtc = entryPrizeEtc,
                EntryRefKey = entryRefKey,
                IsGradeLimit = isGradeLimit,
                IsCorrect = isCorrect,
                ClientIpCreatedBy = clientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventEntryPrizeModel>(
                   "Promotion/AddEventEntryPrize",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public List<EventInfosForFront> GetEventInfosForFront(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventInfosForFront>>>(
                "Promotion/GetEventInfosForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() }
                });
            return response.Data;
        }
        public byte[] GetEventInfosForFrontCompress(int eventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/GetEventInfosForFrontCompress",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() }
                });
            return response.Data;
        }
        public List<EntryCountByPrize> GetEntryCountByPrize(int eventNo, string memberGuid, string entryStartDate)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EntryCountByPrize>>>(
                "Promotion/GetEventInfosForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGuid", memberGuid },
                    new[] { "entryStartDate",entryStartDate },
                });
            return response.Data;
        }
        public byte[] GetEntryCountByPrizeCompress(int eventNo, string memberGuid, string entryStartDate)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/GetEventInfosForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGuid", memberGuid },
                    new[] { "entryStartDate",entryStartDate },
                });
            return response.Data;
        }
        public int AddEventEntriesLogPrize(int eventNo, string memberGUID, int entryPrizeId, int entryPrizeEtc, int entryRefKey, string clientIpCreatedBy, string isPrize)
        {
            var data = new AddEventEntryPrizeModel
            {
                EventNo = eventNo,
                MemberGUID = memberGUID,
                EntryPrizeId = entryPrizeId,
                IsPrize = isPrize,
                EntryPrizeEtc = entryPrizeEtc,
                EntryRefKey = entryRefKey,
                ClientIpCreatedBy = clientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventEntryPrizeModel>(
                   "Promotion/AddEventEntriesLogPrize",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public List<GetRandomPrize> GetRandomPrize(int eventNo, int isGradeLimit)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetRandomPrize>>>(
                "Promotion/GetRandomPrize",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "isGradeLimit", isGradeLimit.ToString() }
                });
            return response.Data;
        }
        public byte[] GetRandomPrizeCompress(int eventNo, int isGradeLimit)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/GetRandomPrizeCompress",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "isGradeLimit", isGradeLimit.ToString() }
                });
            return response.Data;
        }
        public int AddPointLogForFront(string memberGUID, int point)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/AddPointLogForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID },
                    new[] { "point", point.ToString() }
               });
            return response.Data;
        }
        public int CheckDateValidate(int eventNo, string nowDate)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/CheckDateValidate",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "nowDate", nowDate }
               });
            return response.Data;
        }
        public bool CheckEventEntryCount(int eventNo, string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Promotion/CheckEventEntryCount",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "memberGUID", memberGUID }
               });
            return response.Data;
        }
        public List<ContentsAreaMgmtForFront> GetContentsAreaMgmtForFront(string contentsArea)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ContentsAreaMgmtForFront>>>(
                "Promotion/GetContentsAreaMgmtForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "contentsArea", contentsArea }
                });
            return response.Data;
        }
        public byte[] GetContentsAreaMgmtForFrontCompress(string contentsArea)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/GetContentsAreaMgmtForFrontCompress",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "contentsArea", contentsArea }
                });
            return response.Data;
        }
        public bool GetContentsAreaExceptionForFront(int contentsNo, int productNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Promotion/GetContentsAreaExceptionForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "contentsNo", contentsNo.ToString() },
                    new[] { "productNo", productNo.ToString() }
               });
            return response.Data;
        }
        public List<CidCouponMailSend> GetPromotionMailList()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CidCouponMailSend>>>(
                "Promotion/GetPromotionMailList",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public byte[] GetPromotionMailListCompress()
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/GetPromotionMailListCompress",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public List<EventBoardReplycs> getEventReply(int boardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventBoardReplycs>>>(
                "Promotion/getEventReply",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() }
               });
            return response.Data;
        }
        public byte[] getEventReplyCompress(int boardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/getEventReplyCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() }
               });
            return response.Data;
        }
        public byte[] getEventTopReply(int boardNo, int numrow)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/getEventTopReply",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() },
                    new[] { "numrow", numrow.ToString() }
               });
            return response.Data;
        }
        public List<EventMainReplyTop> getEventMainTopReply(int boardNo, int numrow)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainReplyTop>>>(
                "Promotion/getEventReply",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() },
                    new[] { "numrow", numrow.ToString() }
               });
            return response.Data;
        }
        public byte[] getEventReplyForFront(int boardNo, int numrow, int orderby)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/getEventReplyForFront",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() },
                    new[] { "numrow", numrow.ToString() },
                    new[] { "orderby", orderby.ToString() }
               });
            return response.Data;
        }
        public List<EventBoardAuctionUserId> getEventUserIdAuction(int boardNo, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventBoardAuctionUserId>>>(
                "Promotion/getEventUserIdAuction",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() },
                    new[] { "loginId",loginId }
               });
            return response.Data;
        }
        public List<EventBoardByUserId> getEventRepplyByUserId(int boardNo, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventBoardByUserId>>>(
                "Promotion/getEventRepplyByUserId",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() },
                    new[] { "loginId",loginId }
               });
            return response.Data;
        }
        public int AddEventReply(int boardNo, string itemContents, string userIdCreatedBy, string userNameCreatedBy, string clientIpCreatedBy)
        {
            var data = new AddEventReplyModel
            {
                BoardNo = boardNo,
                ItemContents = itemContents,
                UserIdCreatedBy = userIdCreatedBy,
                UserNameCreatedBy = userNameCreatedBy,
                ClientIpCreatedBy = clientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventReplyModel>(
                   "Promotion/AddEventReply",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int AddEventMainReply(int boardNo, string itemContents, string userIdCreatedBy, string userNameCreatedBy, string clientIpCreatedBy)
        {
            var data = new AddEventReplyModel
            {
                BoardNo = boardNo,
                ItemContents = itemContents,
                UserIdCreatedBy = userIdCreatedBy,
                UserNameCreatedBy = userNameCreatedBy,
                ClientIpCreatedBy = clientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventReplyModel>(
                   "Promotion/AddEventMainReply",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int AddEventMainLikeByType(int boardNo, string userIdCreatedBy, int EventType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/AddEventMainLikeByType",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() },
                    new[] { "userIdCreatedBy", userIdCreatedBy },
                    new[] { "EventType", EventType.ToString() }
               });
            return response.Data;
        }
        public int AddEventAuction(int boardNo, string itemContents, string userIdCreatedBy, string userNameCreatedBy, string clientIpCreatedBy)
        {
            var data = new AddEventReplyModel
            {
                BoardNo = boardNo,
                ItemContents = itemContents,
                UserIdCreatedBy = userIdCreatedBy,
                UserNameCreatedBy = userNameCreatedBy,
                ClientIpCreatedBy = clientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, AddEventReplyModel>(
                   "Promotion/AddEventAuction",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public List<EventAuctionHighestPrice> GetAuctionHighestPrice(int boardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventAuctionHighestPrice>>>(
                "Promotion/GetAuctionHighestPrice",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "boardNo", boardNo.ToString() }
               });
            return response.Data;
        }
        public int DeleteEventReply(int itemNo, string userIdDeletedBy, string userNameDeletedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/DeleteEventReply",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "itemNo", itemNo.ToString() },
                    new[] { "userIdDeletedBy", userIdDeletedBy },
                    new[] { "userNameDeletedBy", userNameDeletedBy }
               });
            return response.Data;
        }
        public int DeleteEventMainReply(int itemNo, string userIdDeletedBy, string userNameDeletedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/DeleteEventMainReply",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "itemNo", itemNo.ToString() },
                    new[] { "userIdDeletedBy", userIdDeletedBy },
                    new[] { "userNameDeletedBy", userNameDeletedBy }
               });
            return response.Data;
        }
        public int InsertEventMain(int EventNo, string LoginId, string UserNameCreatedBy, string DataText1, string DataText2, string DataText3, int DataNumber1,
                                   int DataNumber2, int DataNumber3, string DataContents, string ClientIpCreatedBy)
        {
            var data = new EventMainForFront
            {
                EventNo = EventNo,
                LoginId = LoginId,
                UserNameCreatedBy = UserNameCreatedBy,
                DataText1 = DataText1,
                DataText2 = DataText2,
                DataText3 = DataText3,
                DataNumber1 = DataNumber1,
                DataNumber2 = DataNumber2,
                DataNumber3 = DataNumber3,
                DataContents = DataContents,
                ClientIpCreatedBy = ClientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, EventMainForFront>(
                   "Promotion/InsertEventMain",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int UpdateEventFEB(int EventFEBNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/UpdateEventFEB",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventFEBNo", EventFEBNo.ToString() },
               });
            return response.Data;
        }
        public int UpdateEventMain(int BoardNo, int EventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/UpdateEventMain",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "BoardNo", BoardNo.ToString() },
                    new[] { "EventNo", EventNo.ToString() }
               });
            return response.Data;
        }
        public List<EventMainForFront> GetEventMainList(int EventNo, int BoardNo, int TopRow, int OrderType, string LoginId, string dateFrom, string dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainForFront>>>(
                "Promotion/GetEventMainList",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "BoardNo", BoardNo.ToString() },
                    new[] { "TopRow", TopRow.ToString() },
                    new[] { "OrderType", OrderType.ToString() },
                    new[] { "LoginId", LoginId},
                    new[] { "dateFrom", dateFrom },
                    new[] { "dateTo", dateTo }
               });
            return response.Data;
        }
        public List<AjaxEventMainForFront> GetEventMainListAjax(int EventNo, int BoardNo, int TopRow, int OrderType, string LoginId, string dateFrom, string dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<AjaxEventMainForFront>>>(
                "Promotion/GetEventMainListAjax",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "BoardNo", BoardNo.ToString() },
                    new[] { "TopRow", TopRow.ToString() },
                    new[] { "OrderType", OrderType.ToString() },
                    new[] { "LoginId", LoginId},
                    new[] { "dateFrom", dateFrom },
                    new[] { "dateTo", dateTo }
               });
            return response.Data;
        }
        public List<EventFEBForFront> GetEventFEBList(int EventFEBNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventFEBForFront>>>(
                "Promotion/GetEventFEBList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventFEBNo", EventFEBNo.ToString() }
               });
            return response.Data;
        }
        public List<EventFEBForFront> GetEventRandomFEBList(int EventFEBNo, string GiftType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventFEBForFront>>>(
                "Promotion/GetEventRandomFEBList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventFEBNo", EventFEBNo.ToString() },
                    new[] { "GiftType", GiftType }
               });
            return response.Data;
        }
        public int GetEventMainCnt(int EventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetEventMainCnt",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
               });
            return response.Data;
        }
        public int DeleteEventMain(int BoardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/DeleteEventMain",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "BoardNo", BoardNo.ToString() }
               });
            return response.Data;
        }
        public int GetMemberEventMainCnt(int EventNo, string LoginId, int isDeleted)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetMemberEventMainCnt",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "LoginId", LoginId },
                    new[] { "isDeleted", isDeleted.ToString() }
               });
            return response.Data;
        }
        public string GetServerTime()
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Promotion/GetServerTime",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public List<GetQuestion> SelectQuestionForFront(int eventNo, string nowDate, int RowCount, int SortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetQuestion>>>(
                "Promotion/SelectQuestionForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "nowDate", nowDate },
                    new[] { "RowCount", RowCount.ToString() },
                    new[] { "SortType", SortType.ToString() }
               });
            return response.Data;
        }
        public List<GetAnswers> SelectAnswersForFront(int qid, int SortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<GetAnswers>>>(
                "Promotion/SelectAnswersForFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "qid", qid.ToString() },
                    new[] { "SortType", SortType.ToString() }
               });
            return response.Data;
        }
        public List<SerialCouponMaster> GetSerialCouponInfoNew()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SerialCouponMaster>>>(
                "Promotion/GetSerialCouponInfoNew",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public byte[] GetSerialCouponInfoNewCompress()
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "Promotion/GetSerialCouponInfoNewCompress",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public int GetSerialCouponCheckSerialNew(string SerialNo, string MemberGuid, int MasterID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetSerialCouponCheckSerialNew",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "SerialNo", SerialNo },
                    new[] { "MemberGuid", MemberGuid },
                    new[] { "MasterID", MasterID.ToString() }
               });
            return response.Data;
        }
        public int GetSerialCouponCheckUniqueNew(int MasterID, string SerialNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetSerialCouponCheckUniqueNew",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "MasterID", MasterID.ToString() },
                    new[] { "SerialNo", SerialNo }
               });
            return response.Data;
        }
        public int ModifySerialCouponIssueNew(int MasterID, string SerialNo, string MemberGUID, int IsUnique, long couponId, string loginId, string memberName)
        {
            var data = new SerialCouponIssueModel
            {
                MasterID = MasterID,
                SerialNo = SerialNo,
                MemberGUID = MemberGUID,
                IsUnique = IsUnique,
                CouponId = couponId,
                LoginId = loginId,
                MemberName = memberName
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, SerialCouponIssueModel>(
                   "Promotion/ModifySerialCouponIssueNew",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public List<EventMainListForFront> GetEventMainListFront(int EventNo, int BoardNo, int OrderType, string LoginId, string dateFrom, string dateTo, int ListSize, int CurPage)
        {
            var data = new EventBoardSearchModel
            {
                EventNo = EventNo,
                BoardNo = BoardNo,
                OrderType = OrderType,
                LoginId = LoginId,
                DateFrom = dateFrom,
                DateTo = dateTo,
                ListSize = ListSize,
                CurPage = CurPage,
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainListForFront>>, EventBoardSearchModel>(
                   "Promotion/GetEventMainListFront",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int GetEventMainListFrontPaging(int EventNo, int BoardNo, string LoginId, string dateFrom, string dateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetEventMainListFrontPaging",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "BoardNo", BoardNo.ToString() },
                    new[] { "LoginId",LoginId},
                    new[] { "dateFrom", dateFrom},
                    new[] { "dateTo", dateTo}
               });
            return response.Data;
        }
        public List<EventMainListForFront2> GetEventsInfoLog(int EventNo, int EventId, int OrderType, string LoginId, string dateFrom, string dateTo, string StatusCD, string CellNum, string Email, int ListSize, int CurPage)
        {
            var data = new EventBoardSearchModel
            {
                EventNo = EventNo,
                EventId = EventId,
                OrderType = OrderType,
                LoginId = LoginId,
                DateFrom = dateFrom,
                DateTo = dateTo,
                StatusCD = StatusCD,
                CellNum = CellNum,
                Email = Email,
                ListSize = ListSize,
                CurPage = CurPage,
            };
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainListForFront2>>, EventBoardSearchModel>(
                   "Promotion/GetEventsInfoLog",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int GetEventsInfoLogPaging(int EventNo, string LoginId, string dateFrom, string dateTo, string StatusCD, string CellNum, string Email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/GetEventsInfoLogPaging",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "LoginId",LoginId},
                    new[] { "dateFrom", dateFrom},
                    new[] { "dateTo", dateTo},
                    new[] { "StatusCD", StatusCD},
                    new[] { "CellNum", CellNum},
                    new[] { "Email", Email}
               });
            return response.Data;
        }
        public int InsertEventsInfoLog(int EventNo, string EventTitle, string EventTitle2, string EventTitle3, int EventNum, int EventNum2, int EventNum3,
                    string LoginId, string UserNameCreatedBy, string CellNum, string Email, string StatusCD, string ClientIpCreatedBy, string CookieInfo)
        {
            var data = new EventInfoLog
            {
                EventNo = EventNo,
                EventTitle = EventTitle,
                EventTitle2 = EventTitle2,
                EventTitle3 = EventTitle3,
                EventNum = EventNum,
                EventNum2 = EventNum2,
                EventNum3 = EventNum3,
                LoginId = LoginId,
                UserNameCreatedBy = UserNameCreatedBy,
                CellNum = CellNum,
                Email = Email,
                StatusCD = StatusCD,
                ClientIpCreatedBy = ClientIpCreatedBy,
                CookieInfo = CookieInfo
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, EventInfoLog>(
                   "Promotion/InsertEventsInfoLog",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int UpdateEventsInfoLog(int EventId, string StatusCD, string CellNum, string EventTitle3, int EventNum3)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/UpdateEventsInfoLog",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventId", EventId.ToString() },
                    new[] { "StatusCD", StatusCD},
                    new[] { "CellNum", CellNum},
                    new[] { "EventTitle3", EventTitle3},
                    new[] { "EventNum3", EventNum3.ToString()}
               });
            return response.Data;
        }
        public int InsertEventMainBid(int EventNo, int BidType, int BidNum, string LoginId, string UserIp)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/InsertEventMainBid",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "BidType", BidType.ToString()},
                    new[] { "BidNum", BidNum.ToString()},
                    new[] { "LoginId", LoginId},
                    new[] { "UserIp", UserIp}
               });
            return response.Data;
        }
        public int UpdateEventMainBid(int EventNo, int BidType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/UpdateEventMainBid",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "BidType", BidType.ToString()}
               });
            return response.Data;
        }
        public List<EventMainForFrontBid> SelectEventMainBid(int TopRow, int Type, int EventNo, string LoginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainForFrontBid>>>(
                "Promotion/SelectEventMainBid",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "TopRow", TopRow.ToString() },
                    new[] { "Type", Type.ToString()},
                    new[] { "EventNo", EventNo.ToString()},
                    new[] { "LoginId", LoginId}
               });
            return response.Data;
        }
        public List<SerialCouponSub> SelectSerialCouponDetail(string SerialNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<SerialCouponSub>>>(
                "Promotion/SelectSerialCouponDetail",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "SerialNo", SerialNo }
               });
            return response.Data;
        }
        public string GetEventRandomNum(int isNew, string LoginId, string DateEvent)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Promotion/GetEventRandomNum",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "isNew", isNew.ToString() },
                    new[] { "LoginId", LoginId},
                    new[] { "DateEvent", DateEvent}
               });
            return response.Data;
        }
        public List<DealList> SelectDealList(int CategoryNo, int DealType, int ListSize, int Page, int SortType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DealList>>>(
                "Promotion/SelectDealList",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "CategoryNo", CategoryNo.ToString() },
                    new[] { "DealType", DealType.ToString() },
                    new[] { "ListSize", ListSize.ToString() },
                    new[] { "Page", Page.ToString() },
                    new[] { "SortType", SortType.ToString() }
               });
            return response.Data;
        }
        public int SelectDealListPaging(int CategoryNo, int DealType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Promotion/SelectDealListPaging",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "CategoryNo", CategoryNo.ToString() },
                    new[] { "DealType", DealType.ToString()}
               });
            return response.Data;
        }
        public List<DealDetail> SelectDealDetailFront(int DealNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DealDetail>>>(
                "Promotion/SelectDealDetailFront",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "DealNo", DealNo.ToString() }
               });
            return response.Data;
        }
        public List<DealDetailProduct> SelectDealProduct(int DealNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DealDetailProduct>>>(
                "Promotion/SelectDealProduct",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "DealNo", DealNo.ToString() }
               });
            return response.Data;
        }
        public List<Display_GnbBanner> SelectDisplayGnbBanner()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Display_GnbBanner>>>(
                "Promotion/SelectDisplayGnbBanner",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public List<Display_GnbBanner> SelectDisplayGnbBanner(string typeBanner)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Display_GnbBanner>>>(
                "Promotion/SelectDisplayGnbBanner",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "TypeBanner", typeBanner.ToString() }
               });
            return response.Data;
        }
        public List<Display_BannerManager> SelectDisplayBannerManage(string BannerType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Display_BannerManager>>>(
                "Promotion/SelectDisplayBannerManage",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "BannerType", BannerType }
               });
            return response.Data;
        }
        public EventMain_CheckNum CheckNumInput(string NumInput, int EventNum)
        {
            var response = GetDataFromApiOut<BaseResultAPI<EventMain_CheckNum>>(
                "Promotion/CheckNumInput",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "NumInput", NumInput },
                    new[] { "EventNum", EventNum.ToString() }
               });
            return response.Data;
        }
        public List<EventGetCardFree> EventGetCardFree(string LoaiThe, string MenhGia)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventGetCardFree>>>(
                "Promotion/EventGetCardFree",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "LoaiThe", LoaiThe },
                    new[] { "MenhGia", MenhGia }
               });
            return response.Data;
        }
        public string UpdateEventGetCardFree(int ID, string SDT)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Promotion/UpdateEventGetCardFree",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "ID", ID.ToString() },
                    new[] { "SDT", SDT }
               });
            return response.Data;
        }
        public List<EventCheckBlackList> EventCheckBlackList(string IP)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventCheckBlackList>>>(
                "Promotion/EventCheckBlackList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "IP", IP }
               });
            return response.Data;
        }
        public List<DisplayCatalogContents_ForBrand> GetBannerProForBrandList(int brandNo, string areasId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCatalogContents_ForBrand>>>(
                "Promotion/GetBannerProForBrandList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "brandNo", brandNo.ToString() },
                    new[] { "areasId", areasId },
               });
            return response.Data;
        }
        public KhuyenMaiBannerModel GetKhuyenMaiBanner()
        {
            var response = GetDataFromApiOut<BaseResultAPI<KhuyenMaiBannerModel>>(
                "Promotion/GetKhuyenMaiBanner",
                Method.GET,
                null,
                null);
            return response.Data;
        }
        public EventFEBModel GetEventGift(int EventFEBNoFrom, int EventFEBNoTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<EventFEBModel>>(
                "Promotion/GetEventGift",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "EventFEBNoFrom", EventFEBNoFrom.ToString() },
                    new[] { "EventFEBNoTo", EventFEBNoTo.ToString() }
               });
            return response.Data;
        }
        public List<EventMainModel> GetEventMainListDapper(int EventNo, int BoardNo, int TopRow, int OrderType, string LoginId, string DateFrom, string DateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainModel>>>(
                "Promotion/GetEventMainListDapper",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "BoardNo", BoardNo.ToString() },
                    new[] { "TopRow", TopRow.ToString() },
                    new[] { "OrderType", OrderType.ToString() },
                    new[] { "LoginId", LoginId},
                    new[] { "DateFrom", DateFrom},
                    new[] { "DateTo", DateTo}
               });
            return response.Data;
        }
        public List<EventMainModel> GetEventMain(int EventNo, string DateFrom, string DateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainModel>>>(
                "Promotion/GetEventMain",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() },
                    new[] { "DateFrom", DateFrom},
                    new[] { "DateTo", DateTo }
               });
            return response.Data;
        }
        public List<EventMainModel> GetListWinnerEvent(int EventNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventMainModel>>>(
                "Promotion/GetListWinnerEvent",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventNo", EventNo.ToString() }
               });
            return response.Data;
        }
        public List<TopShareModel> GetTopShareEventTap(int eventNo, DateTime date)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<TopShareModel>>>(
                "Promotion/GetTopShareEventTap",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "eventNo", eventNo.ToString() },
                    new[] { "date", date.ToString() }
               });
            return response.Data;
        }
        public List<TotalOrderAndTotalSerialModel> GetTotalOrderAndTotalSerialNoBySerialNo(string serialNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<TotalOrderAndTotalSerialModel>>>(
                "Promotion/GetTotalOrderAndTotalSerialNoBySerialNo",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "serialNo", serialNo }
               });
            return response.Data;
        }
        public int InsertEventMainByDapper(int EventNo, string LoginId, string UserNameCreatedBy, string DataText1, string DataText2, string DataText3, int DataNumber1, int DataNumber2, int DataNumber3,
            string DataContents, string ClientIpCreatedBy)
        {
            var data = new EventMainModel
            {
                EventNo = EventNo,
                LoginId = LoginId,
                UserNameCreatedBy = UserNameCreatedBy,
                DataText1 = DataText1,
                DataText2 = DataText2,
                DataText3 = DataText3,
                DataNumber1 = DataNumber1,
                DataNumber2 = DataNumber2,
                DataNumber3 = DataNumber3,
                DataContents = DataContents,
                ClientIpCreatedBy = ClientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, EventMainModel>(
                   "Promotion/InsertEventMainByDapper",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int UpdateMainEvent(EventMainModel model)
        {
            var data = new EventMainModel
            {
                BoardNo = model.BoardNo,
                EventNo = model.EventNo,
                LoginId = model.LoginId,
                UserNameCreatedBy = model.UserNameCreatedBy,
                DataText1 = model.DataText1,
                DataText2 = model.DataText2,
                DataText3 = model.DataText3,
                DataNumber1 = model.DataNumber1,
                DataNumber2 = model.DataNumber2,
                DataNumber3 = model.DataNumber3,
                DataContents = model.DataContents,
                ClientIpCreatedBy = model.ClientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, EventMainModel>(
                   "Promotion/UpdateMainEvent",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int InsertEventMainByDapperHasEventFEB(int EventNo, string LoginId, string UserNameCreatedBy, string DataText1, string DataText2, string DataText3, int DataNumber1,
                                                        int DataNumber2, int DataNumber3, string DataContents, string ClientIpCreatedBy)
        {
            var data = new EventMainModel
            {
                EventNo = EventNo,
                LoginId = LoginId,
                UserNameCreatedBy = UserNameCreatedBy,
                DataText1 = DataText1,
                DataText2 = DataText2,
                DataText3 = DataText3,
                DataNumber1 = DataNumber1,
                DataNumber2 = DataNumber2,
                DataNumber3 = DataNumber3,
                DataContents = DataContents,
                ClientIpCreatedBy = ClientIpCreatedBy
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, EventMainModel>(
                   "Promotion/InsertEventMainByDapperHasEventFEB",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int InsertSerialNo(int serialId, string serialNo, DateTime _dateFrom, DateTime _dateEnd, string serialtypecd,
            string customertypecd, string usercreated, string usernamecreated, string statuscd, int fixmax)
        {
            var data = new SerialNoModelPost
            {
                SerialId = serialId,
                SerialNo = serialNo,
                DateFrom = _dateFrom,
                DateEnd = _dateEnd,
                Serialtypecd = serialtypecd,
                Customertypecd = customertypecd,
                Usercreated = usercreated,
                Usernamecreated = usernamecreated,
                Statuscd = statuscd,
                Fixmax = fixmax
            };
            var response = GetDataFromApiOut<BaseResultAPI<int>, SerialNoModelPost>(
                   "Promotion/InsertSerialNo",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public List<DisplayCoupon> SelectDisplayCouponMB()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<DisplayCoupon>>>(
                "Promotion/SelectDisplayCouponMB",
                Method.GET,
                null,
               null);
            return response.Data;
        }
    }
}
