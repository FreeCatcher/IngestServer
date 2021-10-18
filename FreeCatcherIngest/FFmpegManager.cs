using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FFMpegCore;
using FFMpegCore.Helpers;

namespace FreeCatcherIngest
{
    class FFmpegManager
    {
        public static void CheckInstall()
        {
            // Ensure FFMpeg is correctly installed
            FFMpegHelper.VerifyFFMpegExists(GlobalFFOptions.Current); 
            
        }
    }
}
