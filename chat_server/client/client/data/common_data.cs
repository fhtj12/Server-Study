using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace client.data
{
    /// <summary>
    /// 로딩할 때, 불러와서 상시 저장해야할 데이터들만 모여있음.
    /// 상시 불러와야할 데이터는 이곳에 선언하지 말 것.
    /// </summary>
    class common_data
    {
        public static Hashtable config = new Hashtable();
        public static error error = new error();
        public static string startup_path;
        public static program_string basic_str;
        public static resource_path resource_Path;
    }
}
