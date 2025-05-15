using System.Collections.Generic;
using Dyreinternat.Domain.Models;

namespace Dyreinternat.Domain.Interfaces;

public interface ISignUpRepository
{
    void Add(SignUp signUp);
    List <SignUp> GetAll();
    
}