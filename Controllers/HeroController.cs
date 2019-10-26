using HeroMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeroMaker.Controllers
{
    public class HeroController : Controller
    {
        ApplicationDbContext context;
        public HeroController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Hero 
        public ActionResult Index()
        {
            List<Hero> Heroes = context.Heroes.ToList();
            return View(Heroes);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int ID)
        {
           
            Hero foundHero = context.Heroes.Where(h => h.HeroID == ID).FirstOrDefault();
            return View(foundHero);
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            Hero hero = new Hero();
            return View(hero);
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Heroes.Add(hero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            var heroToEdit = context.Heroes.Where(h => h.HeroID == id).FirstOrDefault();
            return View(heroToEdit);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit( Hero heroToEdit ,int id)
        {
            try
            {
                var editedHeros = heroToEdit;
                heroToEdit = context.Heroes.Add(editedHeros);
                var orginalHero = context.Heroes.Where(h => h.HeroID == id).FirstOrDefault();
                context.Heroes.Remove(orginalHero);

                
               
                // TODO: Add update logic here
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete( int id)
        {
            var heroToDelete = context.Heroes.Where(h => h.HeroID == id).FirstOrDefault();
            return View(heroToDelete);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete( int id , Hero heroToDelete)
        {
            try
            {
                heroToDelete =  context.Heroes.Where(h => h.HeroID == id).FirstOrDefault();
                // TODO: Add delete logic here
                context.Heroes.Remove(heroToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
