using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalMVC.Models;

namespace FinalMVC.Controllers
{
    class Table01Controller
    {
        public Table01Controller() { }


        Models.DatabaseDataContext db = new DatabaseDataContext();


        public List<tbl_01> GetAll()
        {
            List<tbl_01> rs = db.tbl_01s.ToList();
            return rs;

        }
        public List<tbl_01> Search(string key, string value)
        {
            List<tbl_01> rs = db.tbl_01s.ToList();
            return rs;
        }
    }
}
