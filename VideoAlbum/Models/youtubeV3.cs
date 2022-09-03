using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoAlbum.Models
{
    public class youtubeV3
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public object[] items { get; set; }
        public object[] pageInfo { get; set; }
    }
    //public class itemsModel
    //{
    //    public string kind { get; set; }
    //    public string etag { get; set; }
    //    public string id { get; set; }
    //}
    //public class pageInfoModel
    //{

    //}
}