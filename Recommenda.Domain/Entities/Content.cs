using Recommenda.Domain.Commons;
using Recommenda.Domain.Enums;

namespace Recommenda.Domain.Entities;

public class Content : BaseEntity
{
    private const int MinLength = 2;
    
    private const int MaxLength = 20;
    
    public string Title { get; private set; }

    public string Description { get; private set; }

    public int ReleaseYear { get; private set; }

    public ContentType? ContentType { get; private set; }
    
    //N..N - Relacionamento
    public List<Genre> Genres { get; set; }
    
    public Content(string title, string description, int releaseYear, ContentType contentType = Enums.ContentType.Other)
    {
        //Single-responsibility_principle
        
        UpdateTitle(title);
       
       if (string.IsNullOrEmpty(description))
            throw new Exception("Description is empty");

       Description = description;

       //invariante
       if (releaseYear < 1895 || releaseYear > DateTime.Now.AddYears(2).Year)
           throw new Exception("Release year must be greater than 1895");
       
       ReleaseYear = releaseYear;

       
       ContentType = contentType;
    }
    
    public void UpdateTitle(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new Exception("Title is empty");
        
        Title = title.Length switch
        {
            < MinLength => throw new Exception("Title must more 2 characteres"),
            > MaxLength => throw new Exception("Title must 50 characteres"),
            _ => title.Trim()
        };
        
    }
    
    public override string ToString()
    {
        return $"Filme {Title} - {ReleaseYear} - {Description}";
    }
}