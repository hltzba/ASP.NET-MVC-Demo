using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class LogHelper
    {
        static LogHelper()
        {
            XmlConfigurator.Configure();
        }

        public static ILog FileLogger { get { return LogManager.GetLogger("failover"); } }
    }
}