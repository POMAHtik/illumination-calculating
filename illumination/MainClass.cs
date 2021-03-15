using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace illumination
{
    public static class MainClass
    {
        static public Results.LogsWindow logsWindow = new Results.LogsWindow();
        public static KPO.KPODh kPODh = new KPO.KPODh();
        public static ReserveRatio.Kz kz = new ReserveRatio.Kz();
        public static int Region = -1;
    }
}
