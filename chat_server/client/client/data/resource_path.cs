using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

using client.common;

namespace client.data
{
    class resource_path
    {
        private Hashtable data;
        private bool flag;

        public resource_path()
        {
            this.flag = false; // 아래 get_text 메서드의 MessageBox를 한번만 띄우기 위해 만든 플래그
            initialize_path();
        }

        public void initialize_path()
        {
            csv_parser csv = new csv_parser();
            this.data = csv.read(common_data.startup_path + @"\\Data\\" + "path.csv");
        }

        public string get_path(string attribute_name)
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
                if (this.flag == false)
                {
                    MessageBox.Show(err.data_set);
                    this.flag = true;
                }
                return null;
            }
        }
    }
}
