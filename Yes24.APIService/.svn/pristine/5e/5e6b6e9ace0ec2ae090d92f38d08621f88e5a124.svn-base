using System;
using System.Collections.Generic;
using RestSharp;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.Catalog;
using Yes24.DTO.SystemManagerment;
using Yes24.Models;


namespace Yes24.APIService.Contents
{
    public class ContentsAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<ContentsAPI> lazy = new Lazy<ContentsAPI>(() => new ContentsAPI());
        public static ContentsAPI Instance { get { return lazy.Value; } }
        #endregion

        public List<ContentsBoardListForFront> GetList(string contentsCategory, string title, string contents)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ContentsBoardListForFront>>>(
                "Contents/GetList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "contentsCategory", contentsCategory },
                    new[] { "title", title },
                    new[] { "contents", contents },
                });
            return response.Data;
        }

        public List<ContentsBoardSummaryForFront> GetSummary(string contentsCategory, int rowCount, bool isContents)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ContentsBoardSummaryForFront>>>(
                "Contents/GetSummary",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "contentsCategory", contentsCategory },
                    new[] { "rowCount", rowCount.ToString() },
                    new[] { "isContents", isContents.ToString() }
                });
            return response.Data;
        }

        public List<ContentsBoardSummaryForMain> GetSummaryForMain(int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ContentsBoardSummaryForMain>>>(
                "Contents/GetSummaryForMain",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "rowCount", rowCount.ToString() }
                });
            return response.Data;
        }


        public List<ContentsBoardDetail> GetDetail(int boardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ContentsBoardDetail>>>(
                "Contents/GetDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "boardNo", boardNo.ToString() }
                });
            return response.Data;
        }

        public List<ContentsBoardReplyList> GetReply(int boardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ContentsBoardReplyList>>>(
                "Contents/GetReply",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "boardNo", boardNo.ToString() }
                });
            return response.Data;
        }

        public List<OperationBoardForFront> GetOperationBoardList(int boardType, string title, string contents)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<OperationBoardForFront>>>(
                "Contents/GetOperationBoardList",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "boardType", boardType.ToString() },
                    new[] { "title", title },
                    new[] { "contents", contents },
                });
            return response.Data;
        }

        public List<OperationBoardDetailForFront> GetOperationBoardDetail(int boardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<OperationBoardDetailForFront>>>(
                "Contents/GetOperationBoardDetail",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "boardNo", boardNo.ToString() },
                });
            return response.Data;
        }

        public int ChangeOperationBoardViewCount(int boardNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "Contents/ChangeOperationBoardViewCount",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "boardNo", boardNo.ToString() },
                });
            return response.Data;
        }

        public List<ContentsMagazineForFront> GetListForMain()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ContentsMagazineForFront>>>(
                "Contents/GetListForMain",
                Method.GET);
            return response.Data;
        }

        public List<ProductHitKeywordForFront> GetHitKeyword()
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<ProductHitKeywordForFront>>>(
                "Contents/GetHitKeyword",
                Method.GET);
            return response.Data;
        }

        public List<LanguageModel> GetLanguage(string page)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<LanguageModel>>>(
                "Contents/GetLanguage",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "page", page },
                });
            return response.Data;
        }

        public List<LanguageModel> GetLanguage2(string page, string keyPosition)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<LanguageModel>>>(
                "Contents/GetLanguage2",
                Method.GET,
                null,
                new List<string[]>
                {
                    new[] { "page", page },
                    new[] { "keyPosition", keyPosition },
                });
            return response.Data;
        }

        public int InsertLanguage(LanguageModel model)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, LanguageModel>(
                "Contents/InsertLanguage",
                Method.POST,
                null,
                null,
                model);
            return response.Data;
        }
        public int UpdateLanguage(LanguageModel model)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>, LanguageModel>(
                "Contents/UpdateLanguage",
                Method.POST,
                null,
                null,
                model);
            return response.Data;
        }
    }
}
