using Logic.Model;
using Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repo.Model
{
    public class ExperienceRepo : IExperienceRepo
    {
        //Remeber to add on startup as a services.AddScoped


        private readonly ApplicationDbContext _db;
        public ExperienceRepo(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public bool Create(Experience entity)
        {
            _db.Experiences.Add(entity);
            return Save();
        }

        public bool Delete(Experience entity)
        {

            _db.Experiences.Remove(entity);
            return Save();
        }

        public ICollection<Experience> FindAll()
        {
            return _db.Experiences.ToList<Experience>();
        }

        public Experience FindById(int id)
        {
            return _db.Experiences.Find(id);
        }

        public bool IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Experience entity)
        {
            _db.Experiences.Update(entity);
            return Save();
        }
    }
}
