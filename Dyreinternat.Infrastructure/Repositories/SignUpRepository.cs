using System.Collections.Generic;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;

namespace Dyreinternat.Infrastructure.Repositories;

public class SignUpRepository : ISignUpRepository
{
    private static readonly List<SignUp> SignUps = new List<SignUp>();

<<<<<<< HEAD
    public void Add(SignUp signUp)
=======
public void Add(SignUp signUp)
>>>>>>> origin/main
    {
        SignUps.Add(signUp);
    }

    public List<SignUp> GetAll()
    {
        return SignUps;
        
        
    }
    
}
