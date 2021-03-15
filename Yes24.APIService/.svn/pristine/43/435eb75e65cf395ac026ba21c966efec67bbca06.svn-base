using System;
using System.Collections.Generic;
using System.Web;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Profile;
using Yes24.Utilities;

namespace Yes24.APIService.Login
{
    public class LoginAPI : BaseLoginAPI
    {
        #region Singleton
        private static readonly Lazy<LoginAPI> lazy = new Lazy<LoginAPI>(() => new LoginAPI());
        public static LoginAPI Instance { get { return lazy.Value; } }
        #endregion

        public string CheckPhones(string phones)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Login/CheckPhones",
                Method.GET,
                null,
                new List<string[]>
                {
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
                "Login/ResendSMSConfirm",
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
                "Login/SMSForgotPassword",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public string GetVerifyCode(string loginId, string phones)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Login/GetVerifyCode",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId },
                    new[] { "phones", phones }
                });
            return response.Data;
        }

        public int VerifyNewMember(string LoginId, string Verify)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Login/VerifyNewMember",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "LoginId", LoginId },
                    new[] { "Verify", Verify }
                });
            return response.Data;
        }

        public int InsertTokenUser(string Token, string LoginID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Login/InsertTokenUser",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Token", Token },
                    new[] { "LoginId", LoginID },
                });
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
                "Login/AuthUserInfo",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public string GetLoginID(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Login/GetLoginID",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

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
                "Login/Register",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public MemberData GetMemberInfoById(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<MemberData>>(
                "Login/GetMemberInfoById",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public int ConfirmSMS(string loginId, string verifyCode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Login/ConfirmSMS",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId },
                    new[] { "verifyCode", verifyCode }
                });
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
                "Login/GetMemberInfoByGUID",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "memberGUID", memberGUID }
                });

            HttpContext.Current.Session[memberGUID] = response;
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
                "Login/ChangePassword",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public string SearchMemberId(string email)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Login/SearchMemberId",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "email", email }
                });
            return response.Data;
        }

        public List<USP_PRF_MemberSearchPwdV2_Q> SearchMemberPwdV2(string loginId, string cellnum)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_PRF_MemberSearchPwdV2_Q>>>(
                "Login/SearchMemberPwdV2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId },
                    new[] { "cellnum", cellnum }
                });
            return response.Data;
        }

        public int InsertWelcomeLog(string email, bool gender)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Login/InsertWelcomeLog",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "email", email },
                    new[] { "gender", gender.ToString() }
                });
            return response.Data;
        }

        public string SocialNetworkAuthUserInfo(string Provider, string ProviderID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Login/SocialNetworkAuthUserInfo",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "Provider", Provider },
                    new[] { "ProviderID", ProviderID }
                });
            return response.Data;
        }

        public string CheckMemberSocialNetwork_EmailNew(string email, string provider, string providerid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<string>>(
                "Login/CheckMemberSocialNetwork_EmailNew",
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

        public bool IsExistsLoginId(string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<bool>>(
                "Login/IsExistsLoginId",
                Method.GET, 
                null,
                new List<string[]>
                {
                    new[] { "loginId", loginId }
                });
            return response.Data;
        }

        public int ModifySocialNetworkInfo(string Provider, string ProviderID, string LoginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Login/ModifySocialNetworkInfo",
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

        public int RegisterSocial(MemberData data)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, MemberData>(
                "Login/RegisterSocial",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }

        public int LogUser(string LogFunction, string LoginId, int OrderNo, int DeliveryCost, string IPClient, bool IsCartClick, string Errors, string SessionID, string UserAgent)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Login/LogUser",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "LogFunction", LogFunction },
                    new[] { "LoginId", LoginId.ToString() },
                    new[] { "OrderNo", OrderNo.ToString() },
                    new[] { "DeliveryCost", DeliveryCost.ToString() },
                    new[] { "IPClient", IPClient },
                    new[] { "IsCartClick", IsCartClick.ToString() },
                    new[] { "Errors", Errors },
                    new[] { "SessionID", SessionID.ToString() },
                    new[] { "UserAgent", UserAgent.ToString() }
                });
            return response.Data;
        }

        public List<USP_SYS_PostalVinaCode_Q> GetPostalVinaCodeList(int type, string key1, string key2)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<USP_SYS_PostalVinaCode_Q>>>(
                "Login/GetPostalVinaCodeList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "type", type.ToString() },
                    new[] { "key1", key1 },
                    new[] { "key2", key2 }
                });
            return response.Data;
        }
    }
}
