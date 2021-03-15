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
    public class EventTemplateAPI : BaseAPI
    {
        #region Singleton
        private static readonly Lazy<EventTemplateAPI> lazy = new Lazy<EventTemplateAPI>(() => new EventTemplateAPI());
        public static EventTemplateAPI Instance { get { return lazy.Value; } }
        #endregion

        public EventTemplate getEventTemplate(int EventTemplateID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<EventTemplate>>(
                "Event/getEventTemplate",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventTemplateID", EventTemplateID.ToString() },
               });
            return response.Data;
        }
        public List<EventTemplate> getEventTemplateByURL(string url)
        {
            var response = GetDataFromApiOut<BaseResultAPI<List<EventTemplate>>>(
                "Event/getEventTemplateByURL",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "url", url.ToString() },
               });
             return response.Data;
        }
        public EventTemplate getEventTemplateBypromotionID(int promotionID)
        {
            var response = GetDataFromApiOut<BaseResultAPI<EventTemplate>>(
                "Event/getEventTemplateBypromotionID",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "promotionID", promotionID.ToString() },
               });
             return response.Data;
        }
        public EventTemplateData getEventTemplateData(int EventTemplateID, string Environment)
        {
            var response = GetDataFromApiOut<BaseResultAPI<EventTemplateData>>(
                "Event/getEventTemplateData",
                Method.GET,
                null,
                new List<string[]> {
                    new[] { "EventTemplateID", EventTemplateID.ToString() },
                    new[] { "Environment", Environment }
               });
            return response.Data;
        }
    }
}
