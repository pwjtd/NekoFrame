using Microsoft.AspNetCore.Mvc;

namespace NekoFrame.Hub.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MediaController : ControllerBase
{
    [HttpPost("upload")]
    public void UploadMediaAsync(IFormFile mediaFile)
    {
        
    }
}