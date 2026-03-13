using System.ComponentModel.DataAnnotations;
using Recommenda.Domain.Entities;

namespace Recommenda.Application.DTOs;

public class ContentRequest
{
    [Required(ErrorMessage = "Title is required")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 50 characters")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "Description is required")]
    
    public string Description { get; set; }
    
    //[Required(ErrorMessage = "ReleaseYear is required")]
    //[Range(1888,2030, ErrorMessage = "ReleaseYear must be between 1888 and 2030")]
    public int ReleaseYear { get; private set; } 

    public Content ToDomain() => 
        new (Title, Description, ReleaseYear);

}