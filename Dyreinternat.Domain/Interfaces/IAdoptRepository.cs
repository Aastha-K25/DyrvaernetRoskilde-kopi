namespace Dyreinternat.Domain.Interfaces
{
    using System.Collections.Generic;
    using Dyreinternat.Domain.Models;

    public interface IAdoptRepository
    {
        List<Adopt> GetAll();
        Adopt GetById(int id);
        List<Adopt> SearchByBreed(string breed);
    }
}