using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using SugarUtilities;
using ExportJsonFromExcel.Models;
using System.Data;
using System.Text.RegularExpressions;
using ExportJsonFromExcel.StaticData;

namespace ExportJsonFromExcel.Controllers
{
    public class HomeController : BaseController
    {
        private const string DataTableCacheName = "DataExcelCache";
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }

        #region export json
        [HttpGet]
        public ActionResult ExportJson()
        {
            if (Request["clearcache"] != null)
            {

                System.Web.Caching.Cache _Cache = HttpContext.Cache;
                _Cache.Remove(DataTableCacheName);
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExportJson(HttpPostedFileBase file)
        {
            try
            {

                TempData["ShowModal"] = false;

                if (System.IO.Path.GetExtension(file.FileName) != ".xlsx")
                {
                    ModelState.AddModelError("", "File không hợp lệ.");
                    return View();
                }
                try
                {
                    if (!System.IO.Directory.Exists(HostingEnvironment.MapPath(Global.ExcelDirectory)))
                    {
                        System.IO.Directory.CreateDirectory(HostingEnvironment.MapPath(Global.ExcelDirectory));
                    }
                }
                catch
                {

                    throw new Exception("Lỗi khi khởi tạo đường dẫn.");
                }

                string filePath = System.IO.Path.Combine(HostingEnvironment.MapPath(Global.ExcelDirectory), file.FileName);
                file.SaveAs(filePath);

                DataTable dataTable = ExcelRepos.ReadFile(filePath);

                System.Web.Caching.Cache _Cache = HttpContext.Cache;
                _Cache.Remove(DataTableCacheName);
                _Cache.Insert(DataTableCacheName, dataTable, null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);

                ViewData.Model = dataTable;

                ViewBag.Select = new SelectList(JsonObjectCustom.GetAllProperties(), "Key", "Value", "");
            }
            catch (Exception)
            {
                throw;
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitSelectedColumn(FormCollection collection)
        {
            System.Web.Caching.Cache _Cache = HttpContext.Cache;

            if (_Cache[DataTableCacheName] != null)
            {
                var dataTable = _Cache.Get(DataTableCacheName) as DataTable;
                var column = dataTable.Columns.Count;

                List<string> dsUserSelectedIndex = new List<string>();
                for (int i = 1; i <= column; i++)
                {
                    if (!string.IsNullOrEmpty(collection[i.ToString()]))
                    {
                        dsUserSelectedIndex.Add(i.ToString());
                    }
                }

                if (dsUserSelectedIndex.Any())
                {
                    var dt = dataTable.Copy();
                    var removeColumn = dataTable.Columns.Cast<DataColumn>().Where(c => dsUserSelectedIndex.All(a => a != c.ColumnName));

                    foreach (DataColumn col in removeColumn)
                    {
                        dt.Columns.Remove(col.ColumnName);
                    }

                    foreach (var item in dsUserSelectedIndex)
                    {
                        dt.Columns[item].ColumnName = collection[item];
                    }

                    dt.Rows[0].Delete();
                    dt.AcceptChanges();

                    string json = JsonRepos.JsonPrettify(JsonRepos.ConvertFromDataTable(dt));
                    TempData["Json"] = json;

                    string fileName = DateTime.Now.ToString("ddMMyyyyhhmmss") + ".json";
                    TempData["Filename"] = fileName;

                    try
                    {
                        if (!System.IO.Directory.Exists(HostingEnvironment.MapPath(Global.JsonDirectory)))
                        {
                            System.IO.Directory.CreateDirectory(HostingEnvironment.MapPath(Global.JsonDirectory));
                        }
                    }
                    catch
                    {

                        throw new Exception("Lỗi khi khởi tạo đường dẫn.");
                    }

                    System.IO.File.WriteAllText(System.IO.Path.Combine(HostingEnvironment.MapPath(Global.JsonDirectory), fileName), json);

                }

            }
            TempData["ShowModal"] = false;
            return RedirectToAction("ExportJson");
        }

        #endregion

        #region export product code to one line
        public ViewResult ExportProductCode()
        {
            return View();
        }
        public JsonResult ProductCodeResult(string code)
        {
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                return Json(code, JsonRequestBehavior.AllowGet);
            }

            string _code = code.Trim();

            char[] arr = new char[_code.Length];

            int j = 0;
            for (int i = 0; i < _code.Length; i++)
            {

                while (char.IsWhiteSpace(_code[i]) && char.IsWhiteSpace(_code[i + 1]))
                {
                    i++;
                    if (i == _code.Length) break;
                }
                arr[j] = _code[i];
                j++;
            }

            return Json((new string(arr)).Replace(" ", ","), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region download
        public FileResult DownloadJson(string file)
        {
            return DownLoadJsonFile(System.IO.Path.Combine(HostingEnvironment.MapPath(Global.JsonDirectory), file));
        }
        #endregion

        #region Export Html table 

        public ActionResult ExportHtmlTable()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExportHtmlTable(HttpPostedFileBase file)
        {
            try
            {

                TempData["ShowModal"] = false;

                if (System.IO.Path.GetExtension(file.FileName) != ".xlsx")
                {
                    ModelState.AddModelError("", "File không hợp lệ.");
                    return View();
                }
                try
                {
                    if (!System.IO.Directory.Exists(HostingEnvironment.MapPath(Global.ExcelDirectory)))
                    {
                        System.IO.Directory.CreateDirectory(HostingEnvironment.MapPath(Global.ExcelDirectory));
                    }
                }
                catch
                {

                    throw new Exception("Lỗi khi khởi tạo đường dẫn.");
                }

                string filePath = System.IO.Path.Combine(HostingEnvironment.MapPath(Global.ExcelDirectory), file.FileName);
                file.SaveAs(filePath);
                //LoginId	FullName	Address	Phone	Gift Name
                DataTable dt = ExcelRepos.ReadFile(filePath);

                string[] ColumnsToBeDeleted = { "3", "4" };
                foreach (var col in ColumnsToBeDeleted)
                {
                    if (dt.Columns.Contains(col))
                        dt.Columns.Remove(col);
                }
                //System.Web.Caching.Cache _Cache = HttpContext.Cache;
                //_Cache.Remove(DataTableCacheName);
                //_Cache.Insert(DataTableCacheName, dt, null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);

                ViewData.Model = dt;
            }
            catch (Exception)
            {
                throw;
            }

            return View();
        }

        public ActionResult ExportLinkPro()
        {
            return View();
        }

        public ActionResult ExportLinkProTagA(string BgColorCode, string ListLinkPro, string NameImage/*,int NumberFrom, int NumberTo*/)
        {
            try
            {
                int result = 0;
                int NumberTo = 0, NumberFrom = 0;
                var message = "";
                ListLinkPromotion model = new ListLinkPromotion();
                model.BgColorCode = BgColorCode;

                model.ListLinkPro = ListLinkPro.Split(',').ToList();

                //set value NumberTo
                NumberTo = model.ListLinkPro.Count;

                for (var i = 0; i < model.ListLinkPro.Count; i++)
                {
                    var cleanUrl = FormatUrls(model.ListLinkPro[i]);
                    model.ListLinkPro[i] = cleanUrl;
                }


                model.NameImage = NameImage;

                //get 2 last character string
                
                NumberFrom = Convert.ToInt32(NameImage.Substring(NameImage.Length - 2));

                if(NumberFrom != 1)
                    NumberTo += NumberFrom;

                string SourceImg = "@Globals.Yes24Image/Upload/Event/" + DateTime.Now.Year + "/T" + DateTime.Now.Month + "/";

                List<string> ArrDataSourceImg = new List<string>();

                for (var i = NumberFrom; i <= NumberTo ; i++)
                {
                    var lessNine = i <= 9 ? "0" + i : Convert.ToString(i);

                    var nameImg = SourceImg + NameImage.Substring(0, NameImage.Length - 2) + lessNine + ".jpg";
                    ArrDataSourceImg.Add(nameImg);
                }
                model.DataSourceImage = ArrDataSourceImg;
                result = 1;


                ListLinkPromotion modelResult = new ListLinkPromotion
                {
                    BgColorCode = model.BgColorCode,
                    NameImage = NameImage,
                    ListLinkPro = model.ListLinkPro,
                    DataSourceImage = model.DataSourceImage
                };


                




                return Json(new { result = result, model = modelResult }, JsonRequestBehavior.AllowGet);
                //return Content(html);
            }
            catch (Exception ex)
            {
                var mystring = "";
                mystring = ex.Message.ToString();
                return Content(mystring);
            }
        }

        public static string FormatUrls(string input)
        {
            string output = input;
            Regex regx = new Regex("http(s)?://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*([a-zA-Z0-9\\?\\#\\=\\/]){1})?", RegexOptions.IgnoreCase);

            MatchCollection mactches = regx.Matches(output);

            foreach (Match match in mactches)
            {
                //output = output.Replace(match.Value, "<a href='" + match.Value + "' target='blank'>" + match.Value + "</a>");
                output = match.Value;
            }
            return output;
        }




        #endregion

        #region Create Tab
        public ViewResult CreateTab()
        {
            ViewBag.ImageLink = string.Format("@Globals.Yes24Image/Upload/Event/{0}/T{1}/", DateTime.Now.Year, DateTime.Now.Month);
            ViewBag.Controll = "CreateTabControll";
            return View();
        }
        public ActionResult GetAllProductOnCreateTab()
        {
            return View(StaticData.StaticData.GetAllProduct());
        }
        public ActionResult CreateTabControll()
        {
            return PartialView();
        }
        #endregion

        #region setup layout
        public ViewResult SetupLayout()
        {
            ViewBag.ImageLink = string.Format("https://image.yes24.vn/Upload/Event/{0}/T{1}/", DateTime.Now.Year, DateTime.Now.Month);
            ViewBag.Controll = "SetupLayoutControll";
            return View();
        }
        public ActionResult SetupLayoutControll()
        {
            return PartialView();
        }
        #endregion
    }
}