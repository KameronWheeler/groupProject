using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupProject
{
    public static class CurrentUser
    {
        public static int ID { get; set; }

        public static string MySharedString { get; set; }

        public static bool isManager { get; set; }

        public static DateTime selectedDate { get; set; }
    }
}
