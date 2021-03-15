using RestSharp;
using System;
using System.Collections.Generic;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.KeoSao;

namespace Yes24.APIService.KeoSao
{
    public class KeoSaoFrontAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<KeoSaoFrontAPI> lazy = new Lazy<KeoSaoFrontAPI>(() => new KeoSaoFrontAPI());
        public static KeoSaoFrontAPI Instance { get { return lazy.Value; } }
        #endregion

        public int SaveKeoSaoForFront(string MemberGuid, int IdRule, string SubCode, int SavePoint, string Data)
        {
            var data = new KeoSaoModel
            {
                Data = Data,
                IdRule = IdRule,
                MemberGuid = MemberGuid,
                SavePoint = SavePoint,
                SubCode = SubCode
            };

            var response = GetDataFromApiOut<BaseResultAPI<int>, KeoSaoModel>(
                "KeoSao/SaveKeoSaoForFront",
                Method.POST,
                null,
                null,
                data);
            return response.Data;
        }
        public void AllCancelPoint(string MemberGuid, int SavePoint, string Subcode)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "KeoSao/AllCancelPoint",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "MemberGuid", MemberGuid },
                    new[] { "SavePoint", SavePoint.ToString() },
                    new[] { "Subcode", Subcode.ToString() },
                  });
            //return response.Data;
        }
        public int EventUsePoint(string MemberGuid, int IdRule, string SubCode, int UsePoint, string data)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "KeoSao/EventUsePoint",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "MemberGuid", MemberGuid },
                    new[] { "IdRule", IdRule.ToString()},
                    new[] { "SubCode", SubCode },
                    new[] { "UsePoint", UsePoint.ToString() },
                    new[] { "data", data },
                  });
            return response.Data;
        }
        public MemberKeoSao SelectMemberPoint(string MemberGuid)
        {
            var response = GetDataFromApiOut<BaseResultAPI<MemberKeoSao>>(
                "KeoSao/SelectMemberPoint",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "MemberGuid", MemberGuid }
                  });
            return response.Data;
        }
    }
}
