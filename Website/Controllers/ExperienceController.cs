using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Logic.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repo.Interfaces;
using Website.Models;

namespace Website.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceRepo _repo;
        private readonly IMapper _mapper;
        public ExperienceController(IExperienceRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: Experience
        public ActionResult Index()
        {
            var experiences = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Experience>, List<ExperienceVM>>(experiences);
            return View(model);
        }


        // GET: Experience/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Experience/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExperienceVM model)
        {
            try
            {
                //check quality of data
                if (!ModelState.IsValid)
                    return View(model);

                var experience = _mapper.Map<Experience>(model);

                if (!_repo.Create(experience))
                {
                    ModelState.AddModelError("", "something went wrong");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));


            }
            catch
            {
                ModelState.AddModelError("", "something went wrong");
                return View();
            }
        }

        // GET: Experience/Edit/5
        public ActionResult Edit(int id)
        {

            if (!_repo.IsExists(id))
                return NotFound();

            var experience = _repo.FindById(id);
            var model = _mapper.Map<ExperienceVM>(experience);
            return View(model);
        }

        // POST: Experience/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ExperienceVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);
                var experience = _mapper.Map<Experience>(model);
                var updated = _repo.Update(experience);

                if (!updated)
                {
                    ModelState.AddModelError("", "Something went wrong");
                    return View();
                }

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
        }

        // GET: Experience/Delete/5
        public ActionResult Delete(int id)
        {
            if (!_repo.IsExists(id))
                return NotFound();

            var experience = _repo.FindById(id);
            var deleted = _repo.Delete(experience);

            if (!deleted)
                return BadRequest();

            return RedirectToAction(nameof(Index));
        }

            // POST: Experience/Delete/5
            [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
