using Crud.Models;
using System.Collections.Generic;

namespace Crud.Services
{
    public interface IEventService
    {
        void Create(Event model);
        void Delete(Event model);
        List<Event> Read();
        void Update(Event model);
    }
}