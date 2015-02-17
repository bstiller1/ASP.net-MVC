using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store/
        public String Index()
        {
            return "Hello from Store.Index()";
        }
        // GET: /Store/Browse?genre=Disco
        public String Browse(string genre)
        {
            string message =
                HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
                return message;
        }
        // GET: /Store/Details/5
        public String Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}