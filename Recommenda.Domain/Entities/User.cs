using Recommenda.Domain.Commons;

namespace Recommenda.Domain.Entities;

public class User : BaseEntity
{
    public string Name { get; private set; }
    
    public string Email { get; private set; }

    public int Age => DateTime.Now.Year - DateBorn.Year;

    public DateOnly DateBorn { get; private set; }
    
    //1..1
    public UserConfiguration Configuration { get; set; }

    //1..N
    public List<Rating> Ratings { get; set; }

    public User(string name, string email, DateOnly dateBorn)
    {
        if (dateBorn.Year > DateTime.Now.Year) 
            throw new Exception("The date born cannot be greater than the current year");
        DateBorn = dateBorn;
        
        if (Age < 15) throw new Exception("The age cannot be less than 15 years");
        Name = name;
        Email = email;
    }

    public void Desactive()
    {
        Active = false;
    }
}