using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yes24.APIService.Helper;
using Yes24.DTO;
using Yes24.DTO.SystemManagerment;

namespace Yes24.APIService.CustomerCenter
{
    public class CustomerCenterAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<CustomerCenterAPI> lazy = new Lazy<CustomerCenterAPI>(() => new CustomerCenterAPI());
        public static CustomerCenterAPI Instance { get { return lazy.Value; } }
        #endregion
        public List<FAQForFront> GetFAQList(string faqCategoryCd, string searchText, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FAQForFront>>>(
                "CustomerCenter/GetFAQList",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqCategoryCd", faqCategoryCd },
                    new[] { "searchText", searchText },
                    new[] { "rowCount", rowCount.ToString() }
               });
            return response.Data;
        }
        public byte[] GetFAQListCompress(string faqCategoryCd, string searchText, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "CustomerCenter/GetFAQListCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqCategoryCd", faqCategoryCd },
                    new[] { "searchText", searchText },
                    new[] { "rowCount", rowCount.ToString() }
               });
            return response.Data;
        }
        public List<FAQ> GetFAQDetail(int faqNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FAQ>>>(
                "CustomerCenter/GetFAQDetail",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqNo", faqNo.ToString() }
               });
            return response.Data;
        }
        public byte[] GetFAQDetailCompress(int faqNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<byte[]>>(
                "CustomerCenter/GetFAQDetailCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqNo", faqNo.ToString() }
               });
            return response.Data;
        }
        public int ModifyViewCount(int faqNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "CustomerCenter/ModifyViewCount",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqNo", faqNo.ToString() }
               });
            return response.Data;
        }
        public int ModifyNoticeViewCount(int noticeId)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "CustomerCenter/ModifyNoticeViewCount",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "noticeId", noticeId.ToString() }
               });
            return response.Data;
        }
        public int AddCustomerFind(string title, string contents, string userIdCreatedBy, string userNameCreatedBy)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "CustomerCenter/AddCustomerFind",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "title", title },
                    new[] { "contents", contents },
                    new[] { "userIdCreatedBy", userIdCreatedBy },
                    new[] { "userNameCreatedBy", userNameCreatedBy }
               });
            return response.Data;
        }
        public int ModifyCustomerFind(CustomerFindData customerFindData)
        {
            var data = customerFindData;
            var response = GetDataFromApiOut<BaseResultAPI<int>, CustomerFindData>(
                   "CustomerCenter/ModifyCustomerFind",
                   Method.POST,
                   null,
                   null,
                   data);
            return response.Data;

        }
        public int ModifyCustomerFindViewCount(int findNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "CustomerCenter/ModifyCustomerFindViewCount",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "findNo", findNo.ToString() }
               });
            return response.Data;
        }
        public int RemoveCustomerFind(int findNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<int>>(
                "CustomerCenter/RemoveCustomerFind",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "findNo", findNo.ToString() }
               });
            return response.Data;
        }
        public List<CustomerFind> GetCustomerFindList(string title, string contents)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CustomerFind>>>(
                "CustomerCenter/GetCustomerFindList",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "title", title },
                    new[] { "contents", contents }
               });
            return response.Data;
        }
        public List<CustomerFindDetail> GetCustomerFindDetail(int findNo)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CustomerFindDetail>>>(
                "CustomerCenter/GetCustomerFindDetail",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "findNo", findNo.ToString() }
               });
            return response.Data;
        }
        public List<CustomerFindForFront> GetCustomerFindForFront(string title, string contents, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<CustomerFindForFront>>>(
                "CustomerCenter/GetCustomerFindForFront",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "title", title },
                    new[] { "contents", contents },
                    new[] { "rowCount", rowCount.ToString() },
               });
            return response.Data;
        }
        public List<FAQForFront> GetMBFAQList(string faqCategoryCd, string searchText, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FAQForFront>>>(
                "CustomerCenter/GetMBFAQList",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqCategoryCd", faqCategoryCd },
                    new[] { "searchText", searchText },
                    new[] { "rowCount", rowCount.ToString() },
               });
            return response.Data;
        }
        public List<FAQForFront> GetFaqList(string faqCategoryCd, string searchText, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FAQForFront>>>(
                "CustomerCenter/GetFaqList",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqCategoryCd", faqCategoryCd },
                    new[] { "searchText", searchText },
                    new[] { "rowCount", rowCount.ToString() },
               });
            return response.Data;
        }
        public List<FAQForFront> GetMobileFAQListCompress(string faqCategoryCd, string searchText, int rowCount)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<FAQForFront>>>(
                "CustomerCenter/GetMobileFAQListCompress",
                Method.GET,
                null,
                 new List<string[]> {
                    new[] { "faqCategoryCd", faqCategoryCd },
                    new[] { "searchText", searchText },
                    new[] { "rowCount", rowCount.ToString() },
               });
            return response.Data;
        }
    }
}
