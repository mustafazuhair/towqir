using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TowqirAirSamples.Models;

namespace TowqirAirSamples.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        private TestTEntities db = new TestTEntities();
        public ActionResult Index()
        {
           
            return View();
        }

        //
        // GET: /Test/Details/5

        public ActionResult Details(int id)
        {
            YearlyResult yr = new YearlyResult();
            yr.StationID = 2;
            #region O3
            var temp = from x in db.Table_1 where x.O3 != string.Empty && (!(x.O3.Contains("NULL"))) && (!(x.O3.Contains("-"))) select x;

            decimal? sum = 0;
            int? cnt = 0;
            var t3 = temp.Where(m => m.Date.StartsWith("3"));
            foreach (var a in t3)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2003 = sum / cnt;

            sum = 0;
            cnt = 0;
            var t4 = temp.Where(m => m.Date.StartsWith("4"));
            foreach (var a in t4)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2004 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t5 = temp.Where(m => m.Date.StartsWith("5"));
            foreach (var a in t5)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2005 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t6 = temp.Where(m => m.Date.StartsWith("6"));
            foreach (var a in t6)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2006 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t7 = temp.Where(m => m.Date.StartsWith("7"));
            foreach (var a in t7)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2007 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t8 = temp.Where(m => m.Date.StartsWith("8"));
            foreach (var a in t8)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2008 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t9 = temp.Where(m => m.Date.StartsWith("9"));
            foreach (var a in t9)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2009 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t10 = temp.Where(m => m.Date.StartsWith("10") && m.Date.Length == 6);
            foreach (var a in t10)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2010 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t11 = temp.Where(m => m.Date.StartsWith("11") && m.Date.Length == 6);
            foreach (var a in t11)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2011 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t12 = temp.Where(m => m.Date.StartsWith("12") && m.Date.Length == 6);
            foreach (var a in t12)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2012 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t13 = temp.Where(m => m.Date.StartsWith("13") && m.Date.Length == 6);
            foreach (var a in t13)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2013 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t14 = temp.Where(m => m.Date.StartsWith("14") && m.Date.Length == 6);
            foreach (var a in t14)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2014 = sum / cnt;

            sum = 0;
            cnt = 0;

            var t15 = temp.Where(m => m.Date.StartsWith("15") && m.Date.Length == 6);
            foreach (var a in t15)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) yr.O3_2015 = sum / cnt;

            sum = 0;
            cnt = 0;
            #endregion

            #region PM10
            temp = from x in db.Table_1 where x.PM10 != string.Empty && (!(x.PM10.Contains("NULL"))) && (!(x.PM10.Contains("-"))) select x;


            t3 = temp.Where(m => m.Date.StartsWith("3"));
            foreach (var a in t3)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2003 = sum / cnt;

            sum = 0;
            cnt = 0;
            t4 = temp.Where(m => m.Date.StartsWith("4"));
            foreach (var a in t4)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2004 = sum / cnt;

            sum = 0;
            cnt = 0;

            t5 = temp.Where(m => m.Date.StartsWith("5"));
            foreach (var a in t5)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2005 = sum / cnt;

            sum = 0;
            cnt = 0;

            t6 = temp.Where(m => m.Date.StartsWith("6"));
            foreach (var a in t6)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2006 = sum / cnt;

            sum = 0;
            cnt = 0;

            t7 = temp.Where(m => m.Date.StartsWith("7"));
            foreach (var a in t7)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2007 = sum / cnt;

            sum = 0;
            cnt = 0;

            t8 = temp.Where(m => m.Date.StartsWith("8"));
            foreach (var a in t8)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2008 = sum / cnt;

            sum = 0;
            cnt = 0;

            t9 = temp.Where(m => m.Date.StartsWith("9"));
            foreach (var a in t9)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2009 = sum / cnt;

            sum = 0;
            cnt = 0;

            t10 = temp.Where(m => m.Date.StartsWith("10") && m.Date.Length == 6);
            foreach (var a in t10)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2010 = sum / cnt;

            sum = 0;
            cnt = 0;

            t11 = temp.Where(m => m.Date.StartsWith("11") && m.Date.Length == 6);
            foreach (var a in t11)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2011 = sum / cnt;

            sum = 0;
            cnt = 0;

            t12 = temp.Where(m => m.Date.StartsWith("12") && m.Date.Length == 6);
            foreach (var a in t12)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2012 = sum / cnt;

            sum = 0;
            cnt = 0;

            t13 = temp.Where(m => m.Date.StartsWith("13") && m.Date.Length == 6);
            foreach (var a in t13)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2013 = sum / cnt;

            sum = 0;
            cnt = 0;

            t14 = temp.Where(m => m.Date.StartsWith("14") && m.Date.Length == 6);
            foreach (var a in t14)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2014 = sum / cnt;

            sum = 0;
            cnt = 0;

            t15 = temp.Where(m => m.Date.StartsWith("15") && m.Date.Length == 6);
            foreach (var a in t15)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) yr.PM10_2015 = sum / cnt;

            sum = 0;
            cnt = 0;
            #endregion
            db.YearlyResult.AddObject(yr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public decimal CalcMonthlyAverageO3_less(string yr)
        {
            var temp = from x in db.Table_1 where x.O3 != string.Empty && (!(x.O3.Contains("NULL"))) && (!(x.O3.Contains("-"))) select x;

            decimal? sum = 0;
            int? cnt = 0;
            var t3 = temp.Where(m => m.Date.StartsWith(yr)&& m.Date.Length==5);
            foreach (var a in t3)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) return (decimal)(sum / cnt);
            else return 0;
        }
        public decimal CalcMonthlyAverageO3_more(string yr)
        {
            var temp = from x in db.Table_1 where x.O3 != string.Empty && (!(x.O3.Contains("NULL"))) && (!(x.O3.Contains("-"))) select x;

            decimal? sum = 0;
            int? cnt = 0;
            var t3 = temp.Where(m => m.Date.StartsWith(yr) && m.Date.Length == 6);
            foreach (var a in t3)
            {
                if ((!(a.O3.Contains("NULL"))) && (!(a.O3.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.O3);
                    cnt++;
                }
            }
            if (cnt > 0) return (decimal)(sum / cnt);
            else return 0;
        }
        public decimal CalcMonthlyAveragePM10_less(string yr)
        {
            var temp = from x in db.Table_1 where x.PM10 != string.Empty && (!(x.PM10.Contains("NULL"))) && (!(x.PM10.Contains("-"))) select x;

            decimal? sum = 0;
            int? cnt = 0;
            var t3 = temp.Where(m => m.Date.StartsWith(yr) && m.Date.Length == 5);
            foreach (var a in t3)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) return (decimal)(sum / cnt);
            else return 0;
        }
        public decimal CalcMonthlyAveragePM10_more(string yr)
        {
            var temp = from x in db.Table_1 where x.PM10 != string.Empty && (!(x.PM10.Contains("NULL"))) && (!(x.PM10.Contains("-"))) select x;

            decimal? sum = 0;
            int? cnt = 0;
            var t3 = temp.Where(m => m.Date.StartsWith(yr) && m.Date.Length == 6);
            foreach (var a in t3)
            {
                if ((!(a.PM10.Contains("NULL"))) && (!(a.PM10.Contains("-"))))
                {
                    sum = sum + Convert.ToDecimal(a.PM10);
                    cnt++;
                }
            }
            if (cnt > 0) return (decimal)(sum / cnt);
            else return 0;
        }
        //
        // GET: /Test/Create

        public ActionResult Create()
        {
            for (int i = 2000; i < 2016; i++)
            {
                MonthAverage mon = new MonthAverage();
                mon.StationID = 2;
                mon.RYear = i;
                string temp = "";
                if (i < 2010) temp = i.ToString().Substring(3);
                if (i > 2009) temp = i.ToString().Substring(2);
                if (i < 2010)
                {
                    if (CalcMonthlyAverageO3_less(temp + "01") > 0) mon.O3_Jan = CalcMonthlyAverageO3_less(temp + "01");
                    if (CalcMonthlyAverageO3_less(temp + "02") > 0) mon.O3_Feb = CalcMonthlyAverageO3_less(temp + "02");
                    if (CalcMonthlyAverageO3_less(temp + "03") > 0) mon.O3_Mar = CalcMonthlyAverageO3_less(temp + "03");
                    if (CalcMonthlyAverageO3_less(temp + "04") > 0) mon.O3_Apr = CalcMonthlyAverageO3_less(temp + "04");
                    if (CalcMonthlyAverageO3_less(temp + "05") > 0) mon.O3_May = CalcMonthlyAverageO3_less(temp + "05");
                    if (CalcMonthlyAverageO3_less(temp + "06") > 0) mon.O3_Jun = CalcMonthlyAverageO3_less(temp + "06");
                    if (CalcMonthlyAverageO3_less(temp + "07") > 0) mon.O3_Jul = CalcMonthlyAverageO3_less(temp + "07");
                    if (CalcMonthlyAverageO3_less(temp + "08") > 0) mon.O3_Aug = CalcMonthlyAverageO3_less(temp + "08");
                    if (CalcMonthlyAverageO3_less(temp + "09") > 0) mon.O3_Sep = CalcMonthlyAverageO3_less(temp + "09");
                    if (CalcMonthlyAverageO3_less(temp + "10") > 0) mon.O3_Oct = CalcMonthlyAverageO3_less(temp + "10");
                    if (CalcMonthlyAverageO3_less(temp + "11") > 0) mon.O3_Nov = CalcMonthlyAverageO3_less(temp + "11");
                    if (CalcMonthlyAverageO3_less(temp + "12") > 0) mon.O3_Dec = CalcMonthlyAverageO3_less(temp + "12");

                    if (CalcMonthlyAveragePM10_less(temp + "01") > 0) mon.PM10_Jan = CalcMonthlyAveragePM10_less(temp + "01");
                    if (CalcMonthlyAveragePM10_less(temp + "02") > 0) mon.PM10_Feb = CalcMonthlyAveragePM10_less(temp + "02");
                    if (CalcMonthlyAveragePM10_less(temp + "03") > 0) mon.PM10_Mar = CalcMonthlyAveragePM10_less(temp + "03");
                    if (CalcMonthlyAveragePM10_less(temp + "04") > 0) mon.PM10_Apr = CalcMonthlyAveragePM10_less(temp + "04");
                    if (CalcMonthlyAveragePM10_less(temp + "05") > 0) mon.PM10_May = CalcMonthlyAveragePM10_less(temp + "05");
                    if (CalcMonthlyAveragePM10_less(temp + "06") > 0) mon.PM10_Jun = CalcMonthlyAveragePM10_less(temp + "06");
                    if (CalcMonthlyAveragePM10_less(temp + "07") > 0) mon.PM10_Jul = CalcMonthlyAveragePM10_less(temp + "07");
                    if (CalcMonthlyAveragePM10_less(temp + "08") > 0) mon.PM10_Aug = CalcMonthlyAveragePM10_less(temp + "08");
                    if (CalcMonthlyAveragePM10_less(temp + "09") > 0) mon.PM10_Sep = CalcMonthlyAveragePM10_less(temp + "09");
                    if (CalcMonthlyAveragePM10_less(temp + "10") > 0) mon.PM10_Oct = CalcMonthlyAveragePM10_less(temp + "10");
                    if (CalcMonthlyAveragePM10_less(temp + "11") > 0) mon.PM10_Nov = CalcMonthlyAveragePM10_less(temp + "11");
                    if (CalcMonthlyAveragePM10_less(temp + "12") > 0) mon.PM10_Dec = CalcMonthlyAveragePM10_less(temp + "12");
                }
                if (i > 2009)
                {
                    if (CalcMonthlyAverageO3_more(temp + "01") > 0) mon.O3_Jan = CalcMonthlyAverageO3_more(temp + "01");
                    if (CalcMonthlyAverageO3_more(temp + "02") > 0) mon.O3_Feb = CalcMonthlyAverageO3_more(temp + "02");
                    if (CalcMonthlyAverageO3_more(temp + "03") > 0) mon.O3_Mar = CalcMonthlyAverageO3_more(temp + "03");
                    if (CalcMonthlyAverageO3_more(temp + "04") > 0) mon.O3_Apr = CalcMonthlyAverageO3_more(temp + "04");
                    if (CalcMonthlyAverageO3_more(temp + "05") > 0) mon.O3_May = CalcMonthlyAverageO3_more(temp + "05");
                    if (CalcMonthlyAverageO3_more(temp + "06") > 0) mon.O3_Jun = CalcMonthlyAverageO3_more(temp + "06");
                    if (CalcMonthlyAverageO3_more(temp + "07") > 0) mon.O3_Jul = CalcMonthlyAverageO3_more(temp + "07");
                    if (CalcMonthlyAverageO3_more(temp + "08") > 0) mon.O3_Aug = CalcMonthlyAverageO3_more(temp + "08");
                    if (CalcMonthlyAverageO3_more(temp + "09") > 0) mon.O3_Sep = CalcMonthlyAverageO3_more(temp + "09");
                    if (CalcMonthlyAverageO3_more(temp + "10") > 0) mon.O3_Oct = CalcMonthlyAverageO3_more(temp + "10");
                    if (CalcMonthlyAverageO3_more(temp + "11") > 0) mon.O3_Nov = CalcMonthlyAverageO3_more(temp + "11");
                    if (CalcMonthlyAverageO3_more(temp + "12") > 0) mon.O3_Dec = CalcMonthlyAverageO3_more(temp + "12");

                    if (CalcMonthlyAveragePM10_more(temp + "01") > 0) mon.PM10_Jan = CalcMonthlyAveragePM10_more(temp + "01");
                    if (CalcMonthlyAveragePM10_more(temp + "02") > 0) mon.PM10_Feb = CalcMonthlyAveragePM10_more(temp + "02");
                    if (CalcMonthlyAveragePM10_more(temp + "03") > 0) mon.PM10_Mar = CalcMonthlyAveragePM10_more(temp + "03");
                    if (CalcMonthlyAveragePM10_more(temp + "04") > 0) mon.PM10_Apr = CalcMonthlyAveragePM10_more(temp + "04");
                    if (CalcMonthlyAveragePM10_more(temp + "05") > 0) mon.PM10_May = CalcMonthlyAveragePM10_more(temp + "05");
                    if (CalcMonthlyAveragePM10_more(temp + "06") > 0) mon.PM10_Jun = CalcMonthlyAveragePM10_more(temp + "06");
                    if (CalcMonthlyAveragePM10_more(temp + "07") > 0) mon.PM10_Jul = CalcMonthlyAveragePM10_more(temp + "07");
                    if (CalcMonthlyAveragePM10_more(temp + "08") > 0) mon.PM10_Aug = CalcMonthlyAveragePM10_more(temp + "08");
                    if (CalcMonthlyAveragePM10_more(temp + "09") > 0) mon.PM10_Sep = CalcMonthlyAveragePM10_more(temp + "09");
                    if (CalcMonthlyAveragePM10_more(temp + "10") > 0) mon.PM10_Oct = CalcMonthlyAveragePM10_more(temp + "10");
                    if (CalcMonthlyAveragePM10_more(temp + "11") > 0) mon.PM10_Nov = CalcMonthlyAveragePM10_more(temp + "11");
                    if (CalcMonthlyAveragePM10_more(temp + "12") > 0) mon.PM10_Dec = CalcMonthlyAveragePM10_more(temp + "12");
                }
                db.MonthAverage.AddObject(mon);
                db.SaveChanges();
                db = new TestTEntities();
            }
            return RedirectToAction("Index");
        } 

        //
        // POST: /Test/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Test/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Test/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Test/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Test/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
