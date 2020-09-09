using eat_rice_service.masterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eat_rice_app.util
{
    public class ServiceStaticBundle
    {
        private static ServiceStaticBundle obj;
        public static ServiceStaticBundle Instance
        {
            get
            {
                if (obj == null)
                    obj = new ServiceStaticBundle(){
                        MasterService = new MasterService(),
                    };
                return obj;
            }
        }

        public MasterService MasterService { set;  get; }
    }
}
