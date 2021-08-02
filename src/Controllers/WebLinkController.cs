using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MyGame.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WebLinkController : ControllerBase {
        [HttpGet]
        public IEnumerable<WebLink> Get() {
            return Enumerable.Range(1, 5).Select(index => new WebLink {
                Name = $"Link {index}",
                Description = $"Description of link {index}",
                Image = Array.Empty<byte>(),
                Link = $"http://www.link{index}.com"
            }).ToArray();
        }
    }
}
