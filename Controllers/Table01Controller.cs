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


        public bool Add(string ma, string ten,string noiDung,string moTa)
        {
            tbl_01 obj = new tbl_01();
            obj.Name = ten;
            obj.Key = ma;
            obj.Content = noiDung;
            obj.Desc = moTa;


            try
            {
                db.tbl_01s.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            } catch (Exception e){

                return false;
            }


        }

        public List<tbl_01> Search(string key, string value)
        {
            List<tbl_01> rs = db.tbl_01s.ToList();
            return rs;
        }
    }
}
