using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.server
{
    class information
    {
        private const String protocol = "http";
        private const String server_address = "localhost";
        private const String server_port = "9503";

        public String get_server_info()
        {
            return protocol + "://" + server_address + ":" + server_port + "/";
        }
    }
}
