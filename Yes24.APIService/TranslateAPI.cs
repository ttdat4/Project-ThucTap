using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Yes24.APIService.Contents;
using Yes24.Models;
using Yes24.Utilities;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using System.Collections.ObjectModel;

namespace Yes24.APIService
{
    public class TranslateAPI
    {
        #region Singleton
        private static readonly Lazy<TranslateAPI> lazy = new Lazy<TranslateAPI>(() => new TranslateAPI());
        public static TranslateAPI Instance { get { return lazy.Value; } }
        #endregion

        #region set server cache
        private static object GetCache(String CacheName)
        {
            System.Web.Caching.Cache _Cache = HttpContext.Current.Cache;
            return (object)_Cache[CacheName];
        }
        private static bool IsCacheDB(String CacheName)
        {
            System.Web.Caching.Cache _Cache = HttpContext.Current.Cache;
            return (_Cache[CacheName] != null ? true : false);
        }
        private static void AddCache(String CacheName, object CacheDB, long timeout)
        {
            System.Web.Caching.Cache _Cache = HttpContext.Current.Cache;
            _Cache.Remove(CacheName);
            _Cache.Insert(CacheName, CacheDB, null, DateTime.Now.AddMinutes(timeout), TimeSpan.Zero);
        }
        private static void RemoveCache(String CacheName)
        {
            System.Web.Caching.Cache _Cache = HttpContext.Current.Cache;
            _Cache.Remove(CacheName);
        }
        private static void ClearServerCache()
        {
            System.Collections.IDictionaryEnumerator enumerator = HttpContext.Current.Cache.GetEnumerator();
            while (enumerator.MoveNext())
            {
                HttpContext.Current.Cache.Remove((string)enumerator.Key);
            }
        }

        #endregion

        #region translate Language
        public string ConvertToUnSign(string text)
        {
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            text = text.Replace(" ", "");

            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");

            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToLower();
        }
        public string TranslateLanguageV2(string page, string content, string position = "")
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(content))
            {
                if (page.ToLower() == "layout")
                {
                    if (string.IsNullOrEmpty(position))
                        position = ConvertToUnSign(content.Replace("&amp;", "&")).ToLower();

                    content = content.Trim();
                    string cookie = CookieHelper.GetCookieValue("ckLanguage2");
                    string targetlan = "vi";
                    if (!string.IsNullOrEmpty(cookie) && cookie == "VN")
                        targetlan = "vi";
                    else if (!string.IsNullOrEmpty(cookie) && cookie == "EN")
                        targetlan = "en";
                    else if (!string.IsNullOrEmpty(cookie) && cookie == "KO")
                        targetlan = "ko";
                    if (targetlan != "vi")//chỉ translate ngôn ngữ khác tiếng việt
                    {
                        result = Util.UtilAPI.Instance.GetLanguageValue(page, position, cookie);
                    }
                }
                else
                {
                    result = TranslateLanguage(page, content, position);
                }
            }
            if (!string.IsNullOrEmpty(result))
                return result;
            return content;
        }

        public string TranslateLanguage(string page, string content, string position = "", string cookieSetup = "")
        {
            string cookie = "";
            //return content;
            if (!string.IsNullOrEmpty(content))
            {
                if (string.IsNullOrEmpty(position))
                    position = ConvertToUnSign(content.Replace("&amp;", "&")).ToLower();
                string CacheKey = "";
                if (position.Length >= 2)
                    CacheKey = position.Substring(0, 2);
                else
                    CacheKey = position;
                content = content.Trim();
                if (!string.IsNullOrEmpty(cookieSetup))
                {
                    cookie = cookieSetup.ToUpper();
                }
                else
                {
                    cookie = CookieHelper.GetCookieValue("ckLanguage2");
                }
                //string cookie = CookieHelper.GetCookieValue("ckLanguage2");
                string targetlan = "vi";
                if (!string.IsNullOrEmpty(cookie) && cookie == "VN")
                    targetlan = "vi";
                else if (!string.IsNullOrEmpty(cookie) && cookie == "EN")
                    targetlan = "en";
                else if (!string.IsNullOrEmpty(cookie) && cookie == "KO")
                    targetlan = "ko";
                if (targetlan != "vi")//chỉ translate ngôn ngữ khác tiếng việt
                {
                    List<LanguageModel> language = new List<LanguageModel>();
                    //đã lưu cache tách nhỏ
                    if (IsCacheDB($"TranslateLanguage-{CacheKey}-{page}"))
                    {
                        language = GetCache($"TranslateLanguage-{CacheKey}-{page}") as List<LanguageModel>;
                    }
                    //chưa lưu cache tách nhỏ
                    else
                    {
                        //kiểm tra lưu cache page
                        //if (IsCacheDB($"TranslateLanguage-{page}"))
                        //{
                        //    language = GetCache($"TranslateLanguage-{page}") as List<LanguageModel>;
                        //}
                        //else
                        //{
                        //    //get database
                        //    language = ContentsAPI.Instance.GetLanguage(page);
                        //    AddCache($"TranslateLanguage-{page}", language, 365 * 24 * 60);
                        //}

                        language = ContentsAPI.Instance.GetLanguage2(page, CacheKey);
                        AddCache($"TranslateLanguage-{CacheKey}-{page}", language, 365 * 24 * 60);

                    }
                    //đã có page trong DB
                    if (language != null && language.Count > 0)
                    {
                        var item = language.Where(m => m.Pages == page && m.Position == position).OrderBy(m => m.Id).FirstOrDefault();
                        //đã có trong Database
                        if (item != null)
                        {
                            //check đã đầy đủ ngôn ngữ chưa
                            if (string.IsNullOrEmpty(item.KeywordEN) || string.IsNullOrEmpty(item.KeywordKO))
                            {
                                if (string.IsNullOrEmpty(item.KeywordEN) && targetlan == "en")
                                    item.KeywordEN = GoogleTranslate(content, "en");
                                if (string.IsNullOrEmpty(item.KeywordKO) && targetlan == "ko")
                                    item.KeywordKO = GoogleTranslate(content, "ko");

                                //cập nhật lại list
                                var obj = language.FirstOrDefault(r => r.Id == item.Id);
                                if (obj != null)
                                {
                                    obj.KeywordEN = item.KeywordEN;
                                    obj.KeywordKO = item.KeywordKO;
                                }
                                //update database
                                if (item.KeywordEN != item.KeywordKO && item.KeywordVN != item.KeywordKO)
                                    ContentsAPI.Instance.UpdateLanguage(item);
                            }
                            //update cache
                            RemoveCache($"TranslateLanguage-{CacheKey}-{page}");
                            AddCache($"TranslateLanguage-{CacheKey}-{page}", language, 365 * 24 * 60);

                            if (!string.IsNullOrEmpty(cookie) && cookie == "VN")
                                return CommonLib.IsNullString(item.KeywordVN, content);
                            else if (!string.IsNullOrEmpty(cookie) && cookie == "EN")
                                return CommonLib.IsNullString(item.KeywordEN, item.KeywordEN);
                            else if (!string.IsNullOrEmpty(cookie) && cookie == "KO")
                                return CommonLib.IsNullString(item.KeywordKO, item.KeywordKO);
                            else
                                return content;
                        }
                        //Chua co trong database
                        else
                        {
                            //if (string.IsNullOrEmpty(position))
                            //    position = ConvertToUnSign(content.Replace("&amp;", "&")).ToLower();
                            string transEN = string.Empty;
                            string transKO = string.Empty;
                            if (targetlan == "en")
                                transEN = GoogleTranslate(content, "en");
                            if (targetlan == "ko")
                                transKO = GoogleTranslate(content, "ko");

                            if (!string.IsNullOrEmpty(transEN) || !string.IsNullOrEmpty(transKO))
                            {
                                LanguageModel p = new LanguageModel
                                {
                                    Devies = string.Empty,
                                    Pages = page,
                                    Position = position,
                                    KeywordVN = content,
                                    KeywordEN = transEN,
                                    KeywordKO = transKO,
                                };
                                //luu vao Database
                                if (p.KeywordEN != p.KeywordKO && p.KeywordVN != p.KeywordKO)
                                {
                                    int id = ContentsAPI.Instance.InsertLanguage(p);
                                    if (id > 0)
                                    {
                                        p.Id = id;
                                        language.Add(p);
                                    }
                                }
                                //update cache
                                RemoveCache($"TranslateLanguage-{CacheKey}-{page}");
                                AddCache($"TranslateLanguage-{CacheKey}-{page}", language, 365 * 24 * 60);

                                if (!string.IsNullOrEmpty(cookie) && cookie == "VN")
                                    return CommonLib.IsNullString(content);
                                else if (!string.IsNullOrEmpty(cookie) && cookie == "EN")
                                    return CommonLib.IsNullString(transEN, transEN);
                                else if (!string.IsNullOrEmpty(cookie) && cookie == "KO")
                                    return CommonLib.IsNullString(transKO, transKO);
                                else
                                    return content;
                            }
                            else
                            {
                                return content;
                            }
                        }
                    }
                    //chưa có page trong database
                    else
                    {
                        //if (string.IsNullOrEmpty(position))
                        //    position = ConvertToUnSign(content.Replace("&amp;", "&")).ToLower();
                        string transEN = string.Empty;
                        string transKO = string.Empty;
                        if (targetlan == "en")
                            transEN = GoogleTranslate(content, "en");
                        if (targetlan == "ko")
                            transKO = GoogleTranslate(content, "ko");

                        if (!string.IsNullOrEmpty(transEN) || !string.IsNullOrEmpty(transKO))
                        {
                            LanguageModel p = new LanguageModel
                            {
                                Devies = string.Empty,
                                Pages = page,
                                Position = position,
                                KeywordVN = content,
                                KeywordEN = transEN,
                                KeywordKO = transKO,
                            };
                            //luu vao Database
                            if (p.KeywordEN != p.KeywordKO && p.KeywordVN != p.KeywordKO)
                            {
                                int id = ContentsAPI.Instance.InsertLanguage(p);
                                if (id > 0)
                                {
                                    p.Id = id;
                                    language.Add(p);

                                }
                            }
                            //update cache
                            RemoveCache($"TranslateLanguage-{CacheKey}-{page}");
                            AddCache($"TranslateLanguage-{CacheKey}-{page}", language, 365 * 24 * 60);

                            if (!string.IsNullOrEmpty(cookie) && cookie == "VN")
                                return CommonLib.IsNullString(content);
                            else if (!string.IsNullOrEmpty(cookie) && cookie == "EN")
                                return CommonLib.IsNullString(transEN, transEN);
                            else if (!string.IsNullOrEmpty(cookie) && cookie == "KO")
                                return CommonLib.IsNullString(transKO, transKO);
                            else
                                return content;
                        }
                        else
                        {
                            return content;
                        }
                    }
                }
                else
                    return content;
            }
            else
                return content;
        }
        public string GoogleTranslate(string Text, string targetlan)
        {
            return Text;
            //try
            //{
            //    LanguagesListResponse ls = new LanguagesListResponse();
            //    Google.Apis.Translate.v2.Data.LanguagesResource ss = new Google.Apis.Translate.v2.Data.LanguagesResource();
            //    ss.Language = targetlan;

            //    // GetLanguageCode
            //    //string googlekey = "AIzaSyDdFpgkY528NSBICTaUuZzPLhU5uZ6Tep0";
            //    //string googlekey = "AIzaSyCE-yvmijUcMigu6whnnCDvqbydin4g990";

            //    string[] ArrGoogleApiKey = { "AIzaSyCHihTQ8kRIgatpO55AFU64oPugLdvaPw0", "AIzaSyC_vS092aIQl37bwZE9DbJqb3_BDPI7SdI", "AIzaSyBP_1Yzn14DG-joa-sgA7JQ4Oc1IgLEL00", "AIzaSyBnSBcUYdn7-078ZSHV-4cJoYaU8Q3sPpw", "AIzaSyDnQMEVUXkdhcDylqVw_bjLfF0rjQd5r2M" };
            //    //string[] ArrGoogleApiKey = { "AIzaSyBUy3q96lJQyN2oOO9FkxJnbw3a3ict5NM", "AIzaSyB661vZmox0oedvwJvaRtRU5bUCw4b5tTc", "AIzaSyB80CkUGsVBl4rrKqcnnJi0nSbeB4evioY", "AIzaSyBSdmbQws7tv8sjg7tAYXm2zgkbiWWMm6o", "AIzaSyCFiZi6-cqzgSYDoEfm-UQ5HzkVCEJVyYM" };
            //    Random rand = new Random();
            //    int index = rand.Next(ArrGoogleApiKey.Length);

            //    var service = new TranslateService(new BaseClientService.Initializer()
            //    {
            //        ApiKey = ArrGoogleApiKey[index]
            //    });
            //    //new TranslateService { Key = googlekey };
            //    ICollection<string> data = new Collection<string>();
            //    string[] srcText = new[] { Text };
            //    TranslationsListResponse response = service.Translations.List(srcText, targetlan).Execute();
            //    //var translations = new List<string>();

            //    // We need to change this code...
            //    // currently this code
            //    if (response.Translations != null && response.Translations.Count > 0)
            //    {
            //        Google.Apis.Translate.v2.Data.TranslationsResource translation = response.Translations.FirstOrDefault();
            //        return translation.TranslatedText;
            //    }
            //    else return Text;
            //    //foreach (Google.Apis.Translate.v2.Data.TranslationsResource translation in response.Translations)
            //    //{
            //    //    translations.Add(translation.TranslatedText);
            //    //}
            //    //return translations[0];
            //}
            //catch (Exception ex)
            //{
            //    WriteLog.Current.WriteFileLog("Yes24.APIService\\TranslateAPI", "TranslateAPI=>GoogleTranslate", ex);
            //    return Text;
            //}
        }


        #endregion
        public static bool ShowDiscountProduct(DateTime date)
        {
            bool result = false;
            DiscountModel model = new DiscountModel();
            try
            {
                if (CacheHelper.IsCacheDB($"DiscountProduct-{DateTime.Now.ToString("ddMMyyyy")}"))
                {
                    result = CommonLib.IsNullBool(CacheHelper.GetCache($"DiscountProduct-{DateTime.Now.ToString("ddMMyyyy")}"));
                }
                else
                {

                    var list = JsonCacheHepler.GetJsonContent<List<DiscountModel>>("/Upload/xml", "DiscountProduct");
                    if (list != null && list.Count > 0)
                    {
                        var item = list.Where(m => m.StartDate <= date && m.EndDate >= date && m.IsShow == 1).FirstOrDefault();
                        if (item != null)
                            result = true;
                    }
                    CacheHelper.AddCache($"DiscountProduct-{DateTime.Now.ToString("ddMMyyyy")}", result, 24 * 60);
                }
            }
            catch (Exception ex)
            {

                WriteLog.Current.WriteFileLog("DataAccess\\ProductRP", "ProductRP=>ShowDiscountProduct", ex);
            }

            return result;
        }


    }
}
