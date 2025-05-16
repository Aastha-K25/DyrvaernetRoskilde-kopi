using System.Collections.Generic;
using Dyreinternat.Domain.Models;

namespace Dyreinternat.Domain.Interfaces
{
    public interface IAdoptRepository
    {
        List<Adopt> GetAll();
       
    }
}    
    