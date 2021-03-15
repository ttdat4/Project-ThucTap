using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
//using Yes24.DTO.Product;
using Yes24.DTO.Order;

namespace Yes24.APIService.MailSend
{
    public class MailSendAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<MailSendAPI> lazy = new Lazy<MailSendAPI>(() => new MailSendAPI());
        public static MailSendAPI Instance { get { return lazy.Value; } }
        #endregion

        public int SendOrderSuccess(string to, long orderNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MailSend/SendOrderSuccess",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "to", to },
                    new []{ "orderNo", orderNo.ToString() },
                }
                );
            return response.Data;
        }

        public int SendMailOrderNoPayCancel(string to, string orderGUID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MailSend/SendMailOrderNoPayCancel",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "to", to },
                    new []{ "orderGUID", orderGUID },
                }
            );
            return response.Data;
        }

        public int SendOrderCancel(string to, int exceptionNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MailSend/SendOrderCancel",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "to", to },
                    new []{ "exceptionNo", exceptionNo.ToString() },
                }
            );
            return response.Data;
        }

        public int GetSendMemberDetail(string to, string loginId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MailSend/SendMemberDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "to", to },
                    new []{ "loginId", loginId },
                }
            );
            return response.Data;
        }

        public int GetMemberId(string to, string memberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "MailSend/GetMemberId",
                Method.GET,
                null,
                new List<string[]>
                {
                    new []{ "to", to },
                    new []{ "memberGuid", memberGuid },
                }
            );
            return response.Data;
        }
    }
}
