using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

using client.data;
using client.parser;

namespace client.function
{
    class configuration
    {
        static public String file_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\OtterChat";

        // 특정 설정 바꾼거 테이블에 업데이트하기
        public Hashtable change_config_value(Hashtable data, String changing_key, String changed_value)
        {
            if (data.ContainsKey(changing_key))
            {
                data[changing_key] = changed_value;
            }
            return data;
        }

        // 한번 설정했던 파일 찾기(-1 : config와 default 둘 다 없음. 0 : default는 있음. 1 : config 있음.)
        public int finding_config_file()
        {
            file_function file = new file_function(file_path, "\\config.csv");
            if(file.finding_file())
            {
                return 1;
            }
            else
            {
                file = new file_function(file_path, "\\default_config.csv");
                if(file.finding_file())
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

        // 설정 파일 내용 가져오기
        public Hashtable get_config()
        {
            Hashtable data = null;
            csv_parser csv = new csv_parser();
            switch (finding_config_file())
            {
                case -1: // config와 default 둘 다 없음.
                    // 여기다 새로 default 설정 ftp로 가져오는 거 만들 예정.
                    break;
                case 0: // default는 있음.
                    data = csv.read(file_path + @"\\default_config.csv");
                    break;
                case 1: // config 있음.
                    data = csv.read(file_path + @"\\config.csv");
                    break;
            }
            return data;
        }
    }
}
