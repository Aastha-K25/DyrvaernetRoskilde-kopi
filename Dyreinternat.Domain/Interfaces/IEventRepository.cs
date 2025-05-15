using System.Collections.Generic;
using Dyreinternat.Domain.Models;

namespace Dyreinternat.Domain.Interfaces;

public interface IEventRepository
{
    List<Event> GetAll();
    Event GetById(int id);
}