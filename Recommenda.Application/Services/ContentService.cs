using Recommenda.Application.DTOs;
using Recommenda.Domain.Entities;

namespace Recommenda.Application.Services;

public class ContentService
{
    private List<Content> _contents = [];

    public ContentResponse Create(ContentRequest contentRequest)
    {
        var content = contentRequest.ToDomain();
        
        _contents.Add(content);

        return new ContentResponse(content);
    }
}