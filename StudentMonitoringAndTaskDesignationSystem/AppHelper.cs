using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StudentMonitoringAndTaskDesignationSystem
{
    public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["StudentMonitoringAndTaskDesignationSystem.Properties.Settings.coach_dbConnectionString"].ConnectionString;
    }
}
