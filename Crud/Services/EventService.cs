using Crud.Data.Context;
using Crud.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Crud.Services
{
    public class EventService : IEventService
    {
        RooydaadDbContext dbContext;
        public EventService(RooydaadDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Event> Read()
        {
            return this.dbContext.Events.ToList();
        }

        public void Create(Event model)
        {
            this.dbContext.Add(model);
            Save();
        }

        public void Update(Event model)
        {
            this.dbContext.Update(model);
            Save();
        }

        public void Delete(Event model)
        {
            this.dbContext.Remove(model);
            Save();
        }

        private void Save()
        {
            this.dbContext.SaveChanges();
        }
    }
}
