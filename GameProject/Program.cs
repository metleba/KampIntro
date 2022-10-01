using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { ID = 1, BirthYear = 1985, 
                 FirstName = "ENGIN", LastName = "DEMIROG",IdentityNumber=12345 });

        }
    }
}
