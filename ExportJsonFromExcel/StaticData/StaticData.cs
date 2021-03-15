using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExportJsonFromExcel.StaticData
{
    public static class StaticData
    {

        public static List<Product> GetAllProduct()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Áo len trễ vai May's House tay dài gấu cách điệu 130244580650",
                    Link = "https://www.yes24.vn/ao-len-tre-vai-mays-house-tay-dai-gau-cach-dieu-130244580650-p2084298.html",
                    Price = "199.000",
                    SubPrice = "650.000",
                    Promotion = "180.000",
                    ImgUrl = "https://image.yes24.vn/Upload/ProductImage/ANPHUC2018/2084298_L.jpg"
                },
                 new Product()
                {
                    Name = "Áo len trễ vai May's House tay dài gấu cách điệu 130244580650",
                    Link = "https://www.yes24.vn/ao-len-tre-vai-mays-house-tay-dai-gau-cach-dieu-130244580650-p2084298.html",
                    Price = "199.000",
                    SubPrice = "650.000",
                    Promotion = "180.000",
                    ImgUrl = "https://image.yes24.vn/Upload/ProductImage/ANPHUC2018/2084298_L.jpg"
                },
                  new Product()
                {
                    Name = "Áo len trễ vai May's House tay dài gấu cách điệu 130244580650",
                    Link = "https://www.yes24.vn/ao-len-tre-vai-mays-house-tay-dai-gau-cach-dieu-130244580650-p2084298.html",
                    Price = "199.000",
                    SubPrice = "650.000",
                    Promotion = "180.000",
                    ImgUrl = "https://image.yes24.vn/Upload/ProductImage/ANPHUC2018/2084298_L.jpg"
                },
                   new Product()
                {
                    Name = "Áo len trễ vai May's House tay dài gấu cách điệu 130244580650",
                    Link = "https://www.yes24.vn/ao-len-tre-vai-mays-house-tay-dai-gau-cach-dieu-130244580650-p2084298.html",
                    Price = "199.000",
                    SubPrice = "650.000",
                    Promotion = "180.000",
                    ImgUrl = "https://image.yes24.vn/Upload/ProductImage/ANPHUC2018/2084298_L.jpg"
                }
            };
        }


        public class Product
        {
            public string Name { get; set; }
            public string Link { get; set; }
            public string Price { get; set; }
            public string SubPrice { get; set; }
            public string ImgUrl { get; set; }
            public string Promotion { get; set; }
        }


    }
}