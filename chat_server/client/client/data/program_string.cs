using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

using client.parser;

namespace client.data
{
    class program_string
    {
        private string string_path;
        private Hashtable data;

        public program_string(string file_path, string language)
        {
            this.string_path = file_path;
            initialize_string(language);
        }

        public void initialize_string(string language)
        {
            csv_parser csv = new csv_parser();
            this.data = csv.read(this.string_path + language + ".csv");
        }

        // 기본 기획 데이터에 따라 화면에 표시되는 기본 문자열들 초기화 - 중단
        public bool set_string_on_screen(Main_form main)
        {
            return true;
        }

        public string get_text(string attribute_name)
        {
            return data[attribute_name].ToString();
        }
    }
}
