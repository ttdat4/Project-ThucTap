using RestSharp;
using System;
using System.Collections.Generic;
using System.Web;
using Yes24.DTO;
using Yes24.DTO.Profile;
using Yes24.Utilities;
using BaseAPI = Yes24.APIService.Helper.BaseAPI;
using Yes24.Models;

namespace Yes24.APIService.Member
{
    public class MemberAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<MemberAPI> lazy = new Lazy<MemberAPI>(() => new MemberAPI());
        public static MemberAPI Instance { get { return lazy.Value; } }
        #endregion

        public int Register(
            string loginId,
            string memberName,
            string password,
            string gender,
            string pId,
            string email,
            string cellNum,
            string telNum,
            bool isEmail,
            bool isSMS,
            string defaultPostalCode,
            string defaultAddr1,
            string defaultAddr2,
            string introducerId,
            string englishName,
            string nationality,
            string registerPath,
            string bankName,
            string accountNo,
            string accountUserName,
            string VerifyCode,
            string fromCountry,
            string registerDevice,
            string registerFunction
            )
        {
            MemberModel data = new MemberModel
            {
                loginId = loginId,
                memberName = memberName,
                password = password,
                gender = gender,
                pId = pId,
                email = email,
                cellNum = cellNum,
                telNum = telNum,
                isEmail = isEmail,
                isSMS = isSMS,
                defaultPostalCode = defaultPostalCode,
                defaultAddr1 = defaultAddr1,
                defaultAddr2 = defaultAddr2,
                introducerId = introducerId,
                englishName = englishName,
                nationality = nationality,
                registerPath = registerPath,
                bankName = bankName,
                accountNo = accountNo,
                accountUserName = accountUserName,
                VerifyCode = VerifyCode,
                fromCountry = fromCountry,
                registerDevice = registerDevice,
                registerFunction = registerFunction
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, MemberModel>(
                "Member/Register",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int ModifyMemberInfo(
            string memberGUID,
            string email,
            string cellNum,
            string telNum,
            bool isEmail,
            bool isSMS,
            string defaultPostalCode,
            string defaultAddr1,
            string defaultAddr2,
            int accountId,
            string bankName,
            string accountNo,
            string accountUserName,
            string memberPic
            )
        {
            ModifyMemberInfoModel data = new ModifyMemberInfoModel
            {
                memberGUID = memberGUID,
                email = email,
                cellNum = cellNum,
                telNum = telNum,
                isEmail = isEmail,
                isSMS = isSMS,
                defaultPostalCode = defaultPostalCode,
                defaultAddr1 = defaultAddr1,
                defaultAddr2 = defaultAddr2,
                accountId = accountId,
                bankName = bankName,
                accountNo = accountNo,
                accountUserName = accountUserName,
                memberPic = memberPic
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, ModifyMemberInfoModel>(
                 "Member/ModifyMemberInfo",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }

        public MemberData GetMemberInfoByGUID(string memberGUID)
        {
            if (HttpContext.Current.Session[memberGUID] != null &&
                HttpContext.Current.Session[memberGUID] is MemberData)
            {
                return (MemberData)HttpContext.Current.Session[memberGUID];
            }

            var response = GetDataFromApiOut<BaseResultAPI<MemberData>>(
                "Member/GetMemberInfoByGUID",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });

            HttpContext.Current.Session[memberGUID] = response;
            return response.Data;
        }

        public MemberData GetMemberInfoById(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<MemberData>>(
                "Member/GetMemberInfoById",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberAccount_Q> GetAccountList(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberAccount_Q>>>(
                "Member/GetAccountList",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public bool IsExistsLoginId(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Member/IsExistsLoginId",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public int VerifyNewMember(string LoginId, string Verify)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                 "Member/VerifyNewMember",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[] { "LoginId", LoginId },
                    new[] { "Verify", Verify }
                 });
            return response.Data;
        }

        public bool IsExistsCellNum(string CellNum)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Member/IsExistsCellNum",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "CellNum", CellNum }
                });
            return response.Data;
        }

        public int ModifyMemberCellPhone(string memberGUID, string cellphone, string verify, int utype)
        {
            ModifyMemberCellPhoneModel data = new ModifyMemberCellPhoneModel
            {
                memberGUID = memberGUID,
                cellphone = cellphone,
                verify = verify,
                utype = utype
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, ModifyMemberCellPhoneModel>(
                  "Member/ModifyMemberCellPhone",
                  Method.POST,
                  null,
                  null,
                  data);
            return response.Data;
        }

        public bool IsExistsPID(string pID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                  "Member/IsExistsPID",
                  Method.GET,
                  null,
                  new List<string[]>
                  {
                    new[] { "pID", pID }
                  });
            return response.Data;
        }

        public bool AuthUser(string loginId, string password)
        {
            AuthUserModel data = new AuthUserModel
            {
                loginId = loginId,
                password = password
            };

            var response = GetDataFromApiOut<BaseResultAPI<bool>, AuthUserModel>(
                 "Member/AuthUser",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }

        public int AuthUserInfo(string loginId, string password)
        {
            AuthUserModel data = new AuthUserModel
            {
                loginId = loginId,
                password = password
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AuthUserModel>(
                "Member/AuthUserInfo",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int ChangePassword(string LoginId, string password)
        {
            AuthUserModel data = new AuthUserModel
            {
                loginId = LoginId,
                password = EncryptLib.Encrypt(password)
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AuthUserModel>(
                 "Member/ChangePassword",
                 Method.POST,
                 null,
                 null,
                 data);
            return response.Data;
        }

        public string SearchMemberId(string email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Member/SearchMemberId",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "email", email }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberSearchPwd_Q> SearchMemberPwd(string loginId, string email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberSearchPwd_Q>>>(
                "Member/SearchMemberPwd",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId },
                    new[] { "email", email }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberSearchPwd_Q> SearchMemberPwdCompress(string loginId, string email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberSearchPwd_Q>>>(
                "Member/SearchMemberPwdCompress",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId },
                    new[] { "email", email }
                });
            return response.Data;
        }

        public bool CheckWithdrawal(string PID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Member/CheckWithdrawal",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "PID", PID }
                });
            return response.Data;
        }

        public bool CheckDenyEmailReceiveLog(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Member/CheckDenyEmailReceiveLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public int ModifyMemberIsEmail(int emailid, string emailType, string userDenied, string memberGUID, bool isEmail)
        {
            ModifyMemberIsEmailModel data = new ModifyMemberIsEmailModel
            {
                emailid = emailid,
                emailType = emailType,
                userDenied = userDenied,
                memberGUID = memberGUID,
                isEmail = isEmail
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, ModifyMemberIsEmailModel>(
                "Member/ModifyMemberIsEmail",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public double GetMemberMileageInOrder(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<double>>(
                "Member/GetMemberMileageInOrder",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberJoinResultPromotion_Q> GetMemberJoinPromotion(string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberJoinResultPromotion_Q>>>(
                 "Member/GetMemberJoinPromotion",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[] { "MemberGUID", MemberGUID }
                 });
            return response.Data;
        }

        public List<USP_PRF_MemberJoinResultPromotion_Q> GetMemberJoinPromotionCompress(string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberJoinResultPromotion_Q>>>(
                 "Member/GetMemberJoinPromotionCompress",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[] { "MemberGUID", MemberGUID }
                 });
            return response.Data;
        }

        public int ModifyMemberNewsLetter(string memberGUID, string email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/ModifyMemberNewsLetter",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID },
                    new[] { "email", email }
                });
            return response.Data;
        }

        public int ModifyMemberOCBCardNum(string memberGUID, string ocbCardNum)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                   "Member/ModifyMemberOCBCardNum",
                   Method.GET,
                   null,
                   new List<string[]>
                   {
                    new[] { "memberGUID", memberGUID },
                    new[] { "ocbCardNum", ocbCardNum }
                   });
            return response.Data;
        }

        public int ModifyEmailAccount(string memberGUID, string email, string bank, string accountNum, string accountUserName)
        {
            ModifyEmailAccountModel data = new ModifyEmailAccountModel
            {
                memberGUID = memberGUID,
                email = email,
                bank = bank,
                accountNum = accountNum,
                accountUserName = accountUserName
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, ModifyEmailAccountModel>(
                "Member/ModifyEmailAccount",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int InsertPointLogForFront(string memberGUID, int point, string issueTypeCd, int promotionId, Int64 orderNo)
        {
            InsertPointLogForFrontModel data = new InsertPointLogForFrontModel
            {
                memberGUID = memberGUID,
                point = point,
                issueTypeCd = issueTypeCd,
                promotionId = promotionId,
                orderNo = orderNo
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, InsertPointLogForFrontModel>(
                "Member/InsertPointLogForFront",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int MemberVerifyResend(string LoginId, string Cellphone)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/MemberVerifyResend",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "LoginId", LoginId },
                    new[] { "Cellphone", Cellphone }
                });
            return response.Data;
        }

        public bool GetMemberDigiMoneyInOrder(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                 "Member/GetMemberDigiMoneyInOrder",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[] { "loginId", loginId }
                 });
            return response.Data;
        }

        public List<USP_PRF_FrontMemberDetailByLoginId_Q> GetMemberDetailByLoginId(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_FrontMemberDetailByLoginId_Q>>>(
                "Member/GetMemberDetailByLoginId",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public string SocialNetworkAuthUserInfo(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Member/SocialNetworkAuthUserInfo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public string CheckMemberSocialNetwork_EmailNew(string email, string provider, string providerid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                 "Member/CheckMemberSocialNetwork_EmailNew",
                 Method.GET,
                 null,
                 new List<string[]>
                 {
                    new[] { "email", email },
                    new[] { "provider", provider },
                    new[] { "providerid", providerid }
                 });
            return response.Data;
        }

        public int ModifySocialNetworkInfo(string Provider, string ProviderID, string LoginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/ModifySocialNetworkInfo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Provider", Provider },
                    new[] { "ProviderID", ProviderID },
                    new[] { "LoginId", LoginId }
                });
            return response.Data;
        }

        public int InsertADPIAMember(string LoginID, string APINFO, string ORDER_CODE, string PRODUCT_CODE, int ITEM_COUNT, double PRICE,
            string PRODUCT_NAME, string CATEGORY_CODE, string MemberNAME, string REMOTE_ADDR, string STATUSCD)
        {
            InsertADPIAMemberModel data = new InsertADPIAMemberModel
            {
                LoginID = LoginID,
                APINFO = APINFO,
                ORDER_CODE = ORDER_CODE,
                PRODUCT_CODE = PRODUCT_CODE,
                ITEM_COUNT = ITEM_COUNT,
                PRICE = PRICE,
                PRODUCT_NAME = PRODUCT_NAME,
                CATEGORY_CODE = CATEGORY_CODE,
                MemberNAME = MemberNAME,
                REMOTE_ADDR = REMOTE_ADDR,
                STATUSCD = STATUSCD
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, InsertADPIAMemberModel>(
                "Member/InsertADPIAMember",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int InsertADPIAOrder(string LoginID, string APINFO, string ORDER_CODE, string PRODUCT_CODE, int ITEM_COUNT, double PRICE,
            string PRODUCT_NAME, string CATEGORY_CODE, string MemberNAME, string REMOTE_ADDR, string STATUSCD)
        {
            InsertADPIAMemberModel data = new InsertADPIAMemberModel
            {
                LoginID = LoginID,
                APINFO = APINFO,
                ORDER_CODE = ORDER_CODE,
                PRODUCT_CODE = PRODUCT_CODE,
                ITEM_COUNT = ITEM_COUNT,
                PRICE = PRICE,
                PRODUCT_NAME = PRODUCT_NAME,
                CATEGORY_CODE = CATEGORY_CODE,
                MemberNAME = MemberNAME,
                REMOTE_ADDR = REMOTE_ADDR,
                STATUSCD = STATUSCD
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, InsertADPIAMemberModel>(
                "Member/InsertADPIAOrder",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<USP_ADPIA_Member_Q> GetADPIAMember(string yyyymmdd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ADPIA_Member_Q>>>(
                "Member/GetADPIAMember",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "yyyymmdd", yyyymmdd }
                });
            return response.Data;
        }

        public List<USP_ADPIA_Order_Q> GetADPIAOrder(string yyyymmdd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_ADPIA_Order_Q>>>(
                "Member/GetADPIAOrder",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "yyyymmdd", yyyymmdd }
                });
            return response.Data;
        }

        public int MemberInfoUpdate(
            string memberGUID,
            string email,
            string cellNum,
            string telNum,
            bool isEmail,
            bool isSMS,
            string defaultPostalCode,
            string defaultAddr1,
            string defaultAddr2,
            int accountId,
            string bankName,
            string accountNo,
            string accountUserName,
            string memberPic,
            string MemberName,
            string PID,
            string Gender)
        {
            MemberInfoUpdateModel data = new MemberInfoUpdateModel
            {
                memberGUID = memberGUID,
                email = email,
                cellNum = cellNum,
                telNum = telNum,
                isEmail = isEmail,
                isSMS = isSMS,
                defaultPostalCode = defaultPostalCode,
                defaultAddr1 = defaultAddr1,
                defaultAddr2 = defaultAddr2,
                accountId = accountId,
                bankName = bankName,
                accountNo = accountNo,
                accountUserName = accountUserName,
                memberPic = memberPic,
                MemberName = MemberName,
                PID = PID,
                Gender = Gender
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, MemberInfoUpdateModel>(
                "Member/MemberInfoUpdate",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int InsertAppsDeviceToken(string Devicetoken, string OSPlatform, int appName, string DeviceName)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/InsertAppsDeviceToken",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Devicetoken", Devicetoken },
                    new[] { "OSPlatform", OSPlatform },
                    new[] { "appName", appName.ToString() },
                    new[] { "DeviceName", DeviceName }
                });
            return response.Data;
        }

        public void UpdateAppsDeviceTokenSentStatus(int ID, string SentCode)
        {
            var response = GetDataFromApiOut<ResultAPI>(
                "Product/UpdateAppsDeviceTokenSentStatus",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ID", ID.ToString() },
                    new[] { "SentCode", SentCode }
                });
        }

        public List<FSP_Apps_DeviceTokenList_Q> SelectDeviceTokenForPushMgn(int numRow, string OSPlatform, string SentCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_Apps_DeviceTokenList_Q>>>(
                "Member/SelectDeviceTokenForPushMgn",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "numRow", numRow.ToString() },
                    new[] { "OSPlatform", OSPlatform },
                    new[] { "SentCode", SentCode }
                });
            return response.Data;
        }

        public int VerifyNewMemberByEmail(string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/VerifyNewMemberByEmail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGUID", MemberGUID }
                });
            return response.Data;
        }

        public int InsertMemberBenefitGiftLog(int benefitId, string GiftName, int WinType, string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/InsertMemberBenefitGiftLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "benefitId", benefitId.ToString() },
                    new[] { "GiftName", GiftName },
                    new[] { "WinType", WinType.ToString() },
                    new[] { "MemberGUID", MemberGUID }
                });
            return response.Data;
        }

        public List<FSP_PRF_MemberBenefitGiftLog_Q> SelectMemberBenefitGiftLog(string MemberGUID, string DateFrom, string DateTo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_MemberBenefitGiftLog_Q>>>(
                "Member/SelectMemberBenefitGiftLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGUID", MemberGUID },
                    new[] { "DateFrom", DateFrom },
                    new[] { "DateTo", DateTo }
                });
            return response.Data;
        }

        public List<FSP_PRF_MemberBenefitGiftDetail_Q> SelectMemberBenefitGiftDetail(int benefitId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_MemberBenefitGiftDetail_Q>>>(
                "Member/SelectMemberBenefitGiftDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "benefitId", benefitId.ToString() }
                });
            return response.Data;
        }

        public List<FSP_PRF_MemberBenefitGift_Q> SelectMemberBenefitGift(int GradeType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_MemberBenefitGift_Q>>>(
                "Member/SelectMemberBenefitGift",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "GradeType", GradeType.ToString() }
                });
            return response.Data;
        }

        public int UpdateMemberGradeReward(string MemberGUID, int GradePoint)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/UpdateMemberGradeReward",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGUID", MemberGUID },
                    new[] { "GradePoint", GradePoint.ToString() }
                });
            return response.Data;
        }

        public int GetMemberRewardPoint(string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/GetMemberRewardPoint",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGUID", MemberGUID }
                });
            return response.Data;
        }

        public List<FSP_PRF_MembeGradeOrderHistory_Q> SelectMemberOrderHistory(string MemberGUID, int ListType)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_MembeGradeOrderHistory_Q>>>(
                "Member/SelectMemberOrderHistory",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGUID", MemberGUID },
                    new[] { "ListType", ListType.ToString() }
                });
            return response.Data;
        }

        public List<FSP_PRF_MembeGradeOrderHistorySum_Q> SelectMemberOrderHistorySum(string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_MembeGradeOrderHistorySum_Q>>>(
                "Member/SelectMemberOrderHistorySum",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGUID", MemberGUID }
                });
            return response.Data;
        }

        public List<FSP_PRF_TopMemberBenefitGift_Q> SelectMemberBenefitGiftLogMore(int benefitId, int numrow)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_TopMemberBenefitGift_Q>>>(
                "Member/SelectMemberBenefitGiftLogMore",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "benefitId", benefitId.ToString() },
                    new[] { "numrow", numrow.ToString() }
                });
            return response.Data;
        }

        public List<FSP_PRF_GetMembeLastGrade_Q> SelectMemberLastGradeLog(string MemberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_GetMembeLastGrade_Q>>>(
                "Member/SelectMemberLastGradeLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "MemberGUID", MemberGUID }
                });
            return response.Data;
        }

        public int InsertVTCTransactionLog(string Orgtransid, string ResponseCode, string PartnerBalance, string dataSign,
            string VTCTransID, string commandType, string LoginID)
        {
            InsertVTCTransactionLogModel data = new InsertVTCTransactionLogModel
            {
                Orgtransid = Orgtransid,
                ResponseCode = ResponseCode,
                PartnerBalance = PartnerBalance,
                dataSign = dataSign,
                VTCTransID = VTCTransID,
                commandType = commandType,
                LoginID = LoginID
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, InsertVTCTransactionLogModel>(
                "Member/InsertVTCTransactionLog",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int InsertAgencyOrder(string LoginID, string APINFO, string ORDER_CODE, string PRODUCT_CODE, int ITEM_COUNT, double PRICE,
            string PRODUCT_NAME, string CATEGORY_CODE, string MemberNAME, string REMOTE_ADDR, string STATUSCD, string Agency, string ClickId)
        {
            InsertADPIAMemberModel data = new InsertADPIAMemberModel
            {
                LoginID = LoginID,
                APINFO = APINFO,
                ORDER_CODE = ORDER_CODE,
                PRODUCT_CODE = PRODUCT_CODE,
                ITEM_COUNT = ITEM_COUNT,
                PRICE = PRICE,
                PRODUCT_NAME = PRODUCT_NAME,
                CATEGORY_CODE = CATEGORY_CODE,
                MemberNAME = MemberNAME,
                REMOTE_ADDR = REMOTE_ADDR,
                STATUSCD = STATUSCD
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, InsertADPIAMemberModel>(
                "Member/InsertAgencyOrder",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public List<FSP_Agency_OrderList_Q> SelectAgencyOrder(string Agency, int toprow)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_Agency_OrderList_Q>>>(
                "Member/SelectAgencyOrder",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Agency", Agency },
                    new[] { "toprow", toprow.ToString() }
                });
            return response.Data;
        }

        public List<FSP_Agency_OrderList_ForUpdate_Q> SelectAgencyOrderForUpdate(string type, string Agency, int toprow)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_Agency_OrderList_ForUpdate_Q>>>(
                "Member/SelectAgencyOrderForUpdate",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "type", type },
                    new[] { "Agency", Agency },
                    new[] { "toprow", toprow.ToString() }
                });
            return response.Data;
        }

        public int UpdateAgencyOrder(string ORDER_CODE, string PRODUCT_CODE, string STATUSCD, string Agency)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/UpdateAgencyOrder",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ORDER_CODE", ORDER_CODE },
                    new[] { "PRODUCT_CODE", PRODUCT_CODE },
                    new[] { "STATUSCD", STATUSCD },
                    new[] { "Agency", Agency }
                });
            return response.Data;
        }

        public List<FSP_PRF_MemberAuthBtTicket_Q> SelectMemberAuthByTicket(string LoginId, string AuthTicket, string AuthBrowser)
        {
            SelectMemberAuthByTicketLogModel data = new SelectMemberAuthByTicketLogModel
            {
                LoginId = LoginId,
                AuthTicket = AuthTicket,
                AuthBrowser = AuthBrowser
            };

            var response = GetDataFromApiOut<BaseResultAPI<List<FSP_PRF_MemberAuthBtTicket_Q>>, SelectMemberAuthByTicketLogModel>(
                "Member/SelectMemberAuthByTicket",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public void UpdateMemberAuthTicket(string MemberGUID, string AuthTicket, string AuthBrowser)
        {
            UpdateMemberAuthTicketModel data = new UpdateMemberAuthTicketModel
            {
                MemberGUID = MemberGUID,
                AuthTicket = AuthTicket,
                AuthBrowser = AuthBrowser
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, UpdateMemberAuthTicketModel>(
                "Member/UpdateMemberAuthTicket",
                Method.POST,
                null,
                null,
                data);
            //return response.Data;
        }

        public List<USP_PRF_MemberAddressListDetail_Q> SelectAddressListDetail(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberAddressListDetail_Q>>>(
                "Member/SelectAddressListDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID }
                });
            return response.Data;
        }

        public int InsertAddressList(string MemberGuid, string LoginId, string ReceiveName, string Gender, string ReceiveCellnum,
            string ReceiveTellnum, string PostalCode, string DefaulAddress1, string DefaultAddress2, string TypeCd, int IsMain, string StatusCd)
        {
            InsertAddressListModel data = new InsertAddressListModel
            {
                MemberGuid = MemberGuid,
                LoginId = LoginId,
                ReceiveName = ReceiveName,
                Gender = Gender,
                ReceiveCellnum = ReceiveCellnum,
                ReceiveTellnum = ReceiveTellnum,
                PostalCode = PostalCode,
                DefaulAddress1 = DefaulAddress1,
                DefaultAddress2 = DefaultAddress2,
                TypeCd = TypeCd,
                IsMain = IsMain,
                StatusCd = StatusCd
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, InsertAddressListModel>(
                "Member/InsertAddressList",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int UpdateAddressList(int AddressNo, string ReceiveName, string Gender, string ReceiveCellnum,
            string ReceiveTellnum, string PostalCode, string DefaulAddress1, string DefaultAddress2, string TypeCd, int IsMain, string StatusCd)
        {
            UpdateAddressListModel data = new UpdateAddressListModel
            {
                AddressNo = AddressNo,
                ReceiveName = ReceiveName,
                Gender = Gender,
                ReceiveCellnum = ReceiveCellnum,
                ReceiveTellnum = ReceiveTellnum,
                PostalCode = PostalCode,
                DefaulAddress1 = DefaulAddress1,
                DefaultAddress2 = DefaultAddress2,
                TypeCd = TypeCd,
                IsMain = IsMain,
                StatusCd = StatusCd
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, UpdateAddressListModel>(
                "Member/UpdateAddressList",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int UpdateAddressListMain(int AddressNo, int IsMain)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/UpdateAddressListMain",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "AddressNo", AddressNo.ToString() },
                    new[] { "IsMain", IsMain.ToString() }
                });
            return response.Data;
        }

        public int UpdateAddressListStatus(int AddressNo, string StatusCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/UpdateAddressListStatus",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "AddressNo", AddressNo.ToString() },
                    new[] { "StatusCd", StatusCd }
                });
            return response.Data;
        }

        public string CheckPhones(string phones)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Member/CheckPhones",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "phones", phones }
                });
            return response.Data;
        }

        public string GetVerifyCode(string loginId, string phones)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Member/GetVerifyCode",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId },
                    new[] { "phones", phones }
                });
            return response.Data;
        }

        public int ResendSMSConfirm(string loginid, string phone, string verifyCode)
        {
            AddSMSProcessModel data = new AddSMSProcessModel
            {
                ContentCode = "VERIFYMEMBER",
                LoginID = loginid,
                MobileNum = phone,
                Paremeter1 = verifyCode
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AddSMSProcessModel>(
                "Member/AddSMSProcess",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int SMSForgotPassword(string loginid, string phone, string newPassword)
        {
            AddSMSProcessModel data = new AddSMSProcessModel
            {
                ContentCode = "FORGOTPASSWORD",
                LoginID = loginid,
                MobileNum = phone,
                Paremeter1 = newPassword
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AddSMSProcessModel>(
                "Member/AddSMSProcess",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public string SocialNetworkAuthUserInfo(string Provider, string ProviderID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Member/SocialNetworkAuthUserInfo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Provider", Provider },
                    new[] { "ProviderID", ProviderID }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberSearchPwdV2_Q> SearchMemberPwdV2(string loginId, string cellnum)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberSearchPwdV2_Q>>>(
                "Member/SearchPwdV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId },
                    new[] { "cellnum", cellnum }
                });
            return response.Data;
        }

        public List<Yes24.Models.ListNoticeFrontPagingModel> ListNoticeFrontByID(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<Yes24.Models.ListNoticeFrontPagingModel>>>(
                "Member/ListNoticeFrontByID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public int InsertWelcomeLog(string email, bool gender)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/InsertWelcomeLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "email", email },
                    new[] { "gender", gender.ToString() }
                });
            return response.Data;
        }

        public int ConfirmSMS(string loginId, string verifyCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/ConfirmSMS",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId },
                    new[] { "verifyCode", verifyCode }
                });
            return response.Data;
        }

        public int InsertNoticeFront(NoticeFrontModel model)
        {
            var data = model;
            var response = GetDataFromApiOut<BaseResultAPI<int>, NoticeFrontModel>(
                   "Member/InsertNoticeFront",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int UpdateNoticeFront(NoticeFrontModel model)
        {
            var data = model;
            var response = GetDataFromApiOut<BaseResultAPI<int>, NoticeFrontModel>(
                   "Member/UpdateNoticeFront",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int DeleteNoticeFront(int ID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/DeleteNoticeFront",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ID", ID.ToString() }
                });
            return response.Data;
        }
        public int InsertNoticeFrontUser(NoticeFrontUser model)
        {
            var data = model;
            var response = GetDataFromApiOut<BaseResultAPI<int>, NoticeFrontUser>(
                   "Member/InsertNoticeFrontUser",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int UpdateNoticeFrontUser(NoticeFrontUser model)
        {
            var data = model;
            var response = GetDataFromApiOut<BaseResultAPI<int>, NoticeFrontUser>(
                   "Member/UpdateNoticeFrontUser",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }
        public int NoticeFrontUserIsRead(int noteId, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/NoticeFrontUserIsRead",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "noteId", noteId.ToString() },
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }
        public int NoticeFrontUserIsDelete(int noteId, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/NoticeFrontUserIsDelete",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "noteId", noteId.ToString() },
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }
        public int DeleteNoticeFrontUser(int ID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/DeleteNoticeFrontUser",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "ID", ID.ToString() }
                });
            return response.Data;
        }
        public List<ListNoticeFrontPagingModel> GetListListNoticeFrontPaging(string loginId, int type, int pageIndex, int pagelengh, ref int totalRow)
        {
            List<ListNoticeFrontPagingModel> list = new List<ListNoticeFrontPagingModel>();
            var dsProduct = ListListNoticeFrontPaging(loginId, type, pageIndex, pagelengh);
            if (dsProduct != null && dsProduct.Item1 != null && dsProduct.Item1.Count > 0)
            {
                list = dsProduct.Item1;
                totalRow = CommonLib.IsNullInt32(dsProduct.Item2);
            }
            return list;
        }
        public Tuple<List<ListNoticeFrontPagingModel>, int> ListListNoticeFrontPaging(string loginId, int type, int pageIndex, int pagelengh)
        {
            var response = GetDataFromApiOut<BaseResultAPI<Tuple<List<ListNoticeFrontPagingModel>, int>>>(
            "Member/GetListListNoticeFrontPaging",
            Method.GET,
            null,
            new List<string[]>
            {
                new[]{ "loginId", loginId },
                new[]{ "type", type.ToString() },
                new[]{ "pageIndex", pageIndex.ToString() },
                new[]{ "pagelengh", pagelengh.ToString() }
            });
            return response.Data;
        }
        public int DeleteAllNotice(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/DeleteAllNotice",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }
        public int MarkReadAllNotice(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/MarkReadAllNotice",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }
        public DeliveryStatus GetDeliveryStatusCd(int DeliveryOrderNo, int LogisticsNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<DeliveryStatus>>(
                "Member/GetDeliveryStatusCd",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "DeliveryOrderNo", DeliveryOrderNo.ToString() },
                    new[] { "LogisticsNo", LogisticsNo.ToString() },
                });
            return response.Data;
        }
        public MemberBenefitData GetMemberBenefit(string memberGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<MemberBenefitData>>(
                "Member/GetMemberBenefit",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID.ToString() }
                });
            return response.Data;
        }

        public string GetLoginID(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Member/GetLoginID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public string AddMileageLogForFront(string memberGUID, double mileage, string issueTypeCd, int promotionId, Int64 orderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Member/AddMileageLogForFront",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID },
                    new[] { "mileage", mileage.ToString() },
                    new[] { "issueTypeCd", issueTypeCd },
                    new[] { "promotionId", promotionId.ToString() },
                    new[] { "orderNo", orderNo.ToString() }
                });
            return response.Data;
        }

        public int CheckLogYesVi(string partner, string memberGuid, string pinNo, string ipclient)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                   "Member/CheckLogYesVi",
                   Method.POST,
                   null,
                   new List<string[]>
                    {
                        new[] { "partner", partner.ToString() },
                        new[] { "memberGuid", memberGuid.ToString() },
                        new[] { "pinNo", pinNo.ToString() },
                        new[] { "ipclient", ipclient }
                    });
            return response.Data;
        }

        public int InsertYesViChangeLog(GiftPopInsertLogModel model)
        {
            var data = model;
            var response = GetDataFromApiOut<BaseResultAPI<int>, GiftPopInsertLogModel>(
                   "Member/InsertYesViChangeLog",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;
        }

        public int AddDigiMoneyLog(string memberGUID, double mileage, string issueTypeCd, int promotionId, Int64 orderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Member/AddDigiMoneyLog",
                Method.POST,
                null,
                new List<string[]>
                {
                    new[] { "memberGUID", memberGUID },
                    new[] { "mileage", mileage.ToString() },
                    new[] { "issueTypeCd", issueTypeCd },
                    new[] { "promotionId", promotionId.ToString() },
                    new[] { "orderNo", orderNo.ToString() }
                });
            return response.Data;
        }

        public int InsertOneSignalPlayer(string OneSignalPlayerId, string LoginId, string MemberGuid, string MemberTypeCd, string DeviceCd)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                   "Member/InsertOneSignalPlayer",
                   Method.POST,
                   null,
                   new List<string[]>
                    {
                        new[] { "OneSignalPlayerId", OneSignalPlayerId.ToString() },
                        new[] { "LoginId", LoginId.ToString() },
                        new[] { "MemberGuid", MemberGuid.ToString() },
                        new[] { "MemberTypeCd", MemberTypeCd.ToString() },
                        new[] { "DeviceCd", DeviceCd.ToString() }
                    });
            return response.Data;
        }

        public int OrderSMSUnconfirmed(string loginid, string phone, string verifyCode)
        {
            AddSMSProcessModel data = new AddSMSProcessModel
            {
                ContentCode = "ORDERUNCONFIRM",
                LoginID = loginid,
                MobileNum = phone,
                Paremeter1 = verifyCode
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, AddSMSProcessModel>(
                "Member/AddSMSProcess",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }
        public int InsertTokenUser(string Token, string LoginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
              "Member/InsertTokenUser",
              Method.POST,
              null,
              new List<string[]>
              {
                    new[] { "Token", Token },
                    new[] { "LoginId", LoginID },
              });
            return response.Data;
        }
    }
}
