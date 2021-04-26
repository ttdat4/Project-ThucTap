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
        public ActionResult Index( )
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
        public ViewResult SetupLayout(int hour = 0)
        {
            ViewBag.ImageLink = string.Format("https://image.yes24.vn/Upload/Event/{0}/T{1}/", DateTime.Now.Year, DateTime.Now.Month);
            ViewBag.Controll = "SetupLayoutControll";

            if (hour == 0)
                 hour = DateTime.Now.Hour;
            ViewBag.hour = hour;

          
            return View();
        }

        public ActionResult SetupLayoutControll()
        {

          
            return PartialView();
        }
        
        public ActionResult _getDataProduct(int hour = 0)
        {
            List<ModelProduct> modelProducts = new List<ModelProduct>();

            modelProducts.Add(new ModelProduct()
            {
                ID = 01,
                ProductName = "Hồng sâm lát 6 năm tuổi mật ong KGC 6 gói Cheong Kwan Jang",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/JMKOREA2020/1941522_L.png?width=550&height=550",
                Price = 250000,
                PriceDiscount = 2,
                PriceCode = 8,
                Code = "TTD",
                RateDiscount = 20,
                Hour = 0
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 02,
                ProductName = "Ly nhựa có ống hút Lock&Lock HAP507BLU 750ml",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/2053846_L.jpg",
                Price = 150000,
                PriceDiscount = 140000,
                PriceCode = 130000,
                Code = "TTD",
                RateDiscount = 15,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 03,
                ProductName = "[HONEYDEAL19] Hoa tai đá ross màu bạc đính đá trắng Opal - T1017_07",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/opalshop/1864012_L.png",
                Price = 350000,
                PriceDiscount = 320000,
                PriceCode = 310000,
                Code = "TTD",
                RateDiscount = 20,
                Hour = 6
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 04,
                ProductName = "Bình thủy bơm rót Zojirushi 1.85L - Trắng bạc - ZOBT-AAPE-19-OK",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/loclehai/1806249_L.png?width=550&height=550",
                Price = 350000,
                PriceDiscount = 330000,
                PriceCode = 320000,
                Code = "TTD",
                RateDiscount = 22,
                Hour = 9
            });

            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 05,
                ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                Price = 450000,
                PriceDiscount = 410000,
                PriceCode = 400000,
                Code = "TTD",
                RateDiscount = 13,
                Hour = 12
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 06,
                ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                Price = 400000,
                PriceDiscount = 380000,
                PriceCode = 370000,
                Code = "TTD",
                RateDiscount = 26,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 07,
                ProductName = "Đồng hồ nam Royal Crown dây da đen mặt đen vỏ vàng hồng - 8425-ST-RG-BD-B",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/vananh476/2092811_L.jpg?width=550&height=550",
                Price = 300000,
                PriceDiscount = 270000,
                PriceCode = 260000,
                Code = "TTD",
                RateDiscount = 11,
                Hour = 18
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 08,
                ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                Price = 1100000,
                PriceDiscount = 1000000,
                PriceCode = 990000,
                Code = "TTD",
                RateDiscount = 5,
                Hour = 21
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 09,
                ProductName = "Đồng hồ nam SKMEI 9187 màu vàng",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/LeThiPhuongUyen2019/2067278_L.jpg?width=550&height=550",
                Price = 1500000,
                PriceDiscount = 1200000,
                PriceCode = 1190000,
                Code = "TTD",
                RateDiscount = 15,
                Hour = 15
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            modelProducts.Add(new ModelProduct()
            {
                ID = 10,
                ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                Price = 2700000,
                PriceDiscount = 2621000,
                PriceCode = 2611000,
                Code = "TTD",
                RateDiscount = 18,
                Hour = 3
            });
            foreach (var item in modelProducts)
            {
                item.PriceDiscount = Convert.ToInt32(item.Price - ((item.Price * item.RateDiscount) / 100));

                if (item.Code == "TTD")
                    item.PriceCode = Convert.ToInt32(item.PriceDiscount - 10000);
                if (item.Code == "TTD1")
                    item.PriceCode = Convert.ToInt32(item.PriceDiscount - 20000);
                if (item.Code == "TTD2")
                    item.PriceCode = Convert.ToInt32(item.PriceDiscount - 30000);


            }


            modelProducts = modelProducts.Where(x => x.Hour == hour).ToList();

            return PartialView("_getDataProduct", modelProducts);
        }

      
        public class ModelProduct 
        {
            
            public int ID { get; set; }
            public string ProductName { get; set; }
            public string ImageProduct { get; set; }
            public double Price { get; set; }
            public double PriceDiscount { get; set; }
            public double PriceCode { get; set; }
            public string Code { get; set; }
            public double RateDiscount { get; set; }
            

            public int Hour { get; set; }


        }
        public class ListProduct
        {
            private List<ModelProduct> modelProducts = null;
            public ListProduct()
            {
                modelProducts = new List<ModelProduct>();
            }
          
        }
        public class Example
        {
            public static void Main(string[] args)
            {
                List<ModelProduct> modelProducts = new List<ModelProduct>();

                modelProducts.Add(new ModelProduct()
                {
                    ID = 01,
                    ProductName = "Hồng sâm lát 6 năm tuổi mật ong KGC 6 gói Cheong Kwan Jang",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/JMKOREA2020/1941522_L.png?width=550&height=550",
                    Price = 250000,
                    PriceDiscount = 2,
                    PriceCode = 8,
                    Code = "TTD",
                    RateDiscount = 20,
                    Hour = 0
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 02,
                    ProductName = "Ly nhựa có ống hút Lock&Lock HAP507BLU 750ml",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/2053846_L.jpg",
                    Price = 150000,
                    PriceDiscount = 140000,
                    PriceCode = 130000,
                    Code = "TTD",
                    RateDiscount = 15,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 03,
                    ProductName = "[HONEYDEAL19] Hoa tai đá ross màu bạc đính đá trắng Opal - T1017_07",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/opalshop/1864012_L.png",
                    Price = 350000,
                    PriceDiscount = 320000,
                    PriceCode = 310000,
                    Code = "TTD",
                    RateDiscount = 20,
                    Hour = 6
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 04,
                    ProductName = "Bình thủy bơm rót Zojirushi 1.85L - Trắng bạc - ZOBT-AAPE-19-OK",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/loclehai/1806249_L.png?width=550&height=550",
                    Price = 350000,
                    PriceDiscount = 330000,
                    PriceCode = 320000,
                    Code = "TTD",
                    RateDiscount = 22,
                    Hour = 9
                });

                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/maynhabe2017/2096794_L.JPG?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 05,
                    ProductName = "Áo sơ mi nam Novelty dài tay trơn màu xanh xám NSMMMDMTCC200040D",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/hanacobivina/1935886_L.jpg?width=550&height=550",
                    Price = 450000,
                    PriceDiscount = 410000,
                    PriceCode = 400000,
                    Code = "TTD",
                    RateDiscount = 13,
                    Hour = 12
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 06,
                    ProductName = "Đồng hồ nam Julius Homme Hàn Quốc JAH-117C dây thép Đen mặt xanh",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2109172_L.jpg?width=550&height=550",
                    Price = 400000,
                    PriceDiscount = 380000,
                    PriceCode = 370000,
                    Code = "TTD",
                    RateDiscount = 26,
                    Hour = 15
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 07,
                    ProductName = "Đồng hồ nam Royal Crown dây da đen mặt đen vỏ vàng hồng - 8425-ST-RG-BD-B",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/vananh476/2092811_L.jpg?width=550&height=550",
                    Price = 300000,
                    PriceDiscount = 270000,
                    PriceCode = 260000,
                    Code = "TTD",
                    RateDiscount = 11,
                    Hour = 18
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 08,
                    ProductName = "Đồng hồ nam Henry London Regency HL40-S-0366",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/julius2017/2061147_L.jpg?width=550&height=550",
                    Price = 1100000,
                    PriceDiscount = 1000000,
                    PriceCode = 990000,
                    Code = "TTD",
                    RateDiscount = 5,
                    Hour = 21
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 09,
                    ProductName = "Đồng hồ nam SKMEI 9187 màu vàng",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/LeThiPhuongUyen2019/2067278_L.jpg?width=550&height=550",
                    Price = 1500000,
                    PriceDiscount = 1200000,
                    PriceCode = 1190000,
                    Code = "TTD",
                    RateDiscount = 15,
                    Hour = 15
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });
                modelProducts.Add(new ModelProduct()
                {
                    ID = 10,
                    ProductName = "Giày Adidas Ultraboost 19 nam G27504",
                    ImageProduct = "https://image.yes24.vn/Upload/ProductImage/VASPORT/2149809_L.jpg?width=550&height=550",
                    Price = 2700000,
                    PriceDiscount = 2621000,
                    PriceCode = 2611000,
                    Code = "TTD",
                    RateDiscount = 18,
                    Hour = 3
                });



            }
      


        }
      
        
     

        #endregion
    }
}