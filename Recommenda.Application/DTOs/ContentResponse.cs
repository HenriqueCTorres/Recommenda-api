using Recommenda.Domain.Entities;

namespace Recommenda.Application.DTOs;

public class ContentResponse
{
    public string Title { get; set; }

    public ContentResponse(Content content)
    {
        Title = content.Title;
    }

    /*public ContentResponse FromDomain(Content content)
    {
        return new ContentResponse
        {
            Title = content.Title,
        };
    }*/
}