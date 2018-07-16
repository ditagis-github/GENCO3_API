using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class Camera
    {
        public string GetImageUrl(string cameraIP)
        {
            switch (cameraIP)
            {
                case "10.156.8.131":
                case "10.156.8.132":
                case "10.156.8.133":
                case "10.156.8.134":
                case "10.156.8.135":
                case "10.156.8.136":
                case "10.156.8.137":
                case "10.156.8.138":
                case "10.156.8.139":
                case "10.156.8.128":
                    return cameraIP + "/jpeg";
                case "10.156.8.143":
                case "10.156.8.145":
                    return cameraIP + "/cgi-bin/mjpeg?resolution=640x360&quality=5&page="+this.GetTimeStamp();
                case "10.156.8.140":
                    return cameraIP+ "/cgi-bin/viewer/video.jpg?streamid=2&resolution=1024x768&quality=5";
                default:
                    return "/public/images/error-camera.jpg";
            }
        }

        private long GetTimeStamp()
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return unixTimestamp;
        }
    }
}
