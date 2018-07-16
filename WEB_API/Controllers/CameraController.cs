using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEB_API.Controllers
{
    public class CameraController : ApiController
    {
        private Camera camera = new Camera();
        // GET api/camera/10.156.8.128
        
        public String Get(string id)
        {
            return camera.GetImageUrl(id);
        }
    }
}
