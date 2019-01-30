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
        private bool flag;

        public program_string(string file_path, string language)
        {
            this.string_path = file_path;
            this.flag = false; // 아래 get_text 메서드의 MessageBox를 한번만 띄우기 위해 만든 플래그
            initialize_string(language);
        }

        public void initialize_string(string language)
        {
            csv_parser csv = new csv_parser();
            this.data = csv.read(this.string_path + language + ".csv");
        }

        public string get_text(string attribute_name)
        {
            try
            {
                string result = data[attribute_name].ToString();
                return result;
            }
            catch (Exception e)
            {
                error err = new error();
                Console.Write(e.Message);
                if(this.flag == false)
                {
                    MessageBox.Show(err.data_set);
                    this.flag = true;
                }
                return null;
            }
        }
    }
}
