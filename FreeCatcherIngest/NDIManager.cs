using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTek;
using NewTek.NDI;

namespace FreeCatcherIngest
{
    class NDIManager
    {
        

        NDIManager()
        {
            Initialize();
        }

        public static bool Initialize()
        {
            if (!NDIlib.initialize())
            {
                // Cannot run NDI. Most likely because the CPU is not sufficient (see SDK documentation).
                // you can check this directly with a call to NDIlib_is_supported_CPU()
                return false;
            }

            return true;
        }

        public static bool IsSupportedCPU()
        {
            return NDIlib.is_supported_CPU();
        }

        public static ObservableCollection<Source> GetSources()
        {
            Finder finderInstance = new();
            return finderInstance.Sources;
        }
    }
}
