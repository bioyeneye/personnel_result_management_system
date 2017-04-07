using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalResultManagement.Data
{
    class DataSingleton
    {
        private static PersonalRMSDataContext _personalRmsDataContext;

        /// <summary>
        /// SIngleton Database for the application
        /// </summary>
        /// <returns>PersonalRMSDataContext</returns>
        public static PersonalRMSDataContext CreateDataContext()
        {
            if (_personalRmsDataContext == null)
            {
                _personalRmsDataContext = new PersonalRMSDataContext();
                return _personalRmsDataContext;

            }

            return _personalRmsDataContext;
        }
    }
}
