using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppStarter
{
    public static class Util
    {
        public static Paths myPaths = new Paths();


        public static void clearAllPaths()
        {
            myPaths.pathToCoreApplication = "";
            myPaths.pathToSandboxInstall = "";
            myPaths.pathToSandboxInstallBinFolder = "";
            myPaths.pathToUniVisionGui = "";
            myPaths.projectPath = "";
        }
    }
}
