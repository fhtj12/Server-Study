using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace client.data
{
    class file_function
    {
        private String file_path;
        private String file_name;

        public file_function(String file_path, String file_name)
        {
            this.file_path = file_path;
            this.file_name = file_name;
        }

        // 파일 찾기
        public bool finding_file()
        {
            try
            {
                String[] file_list = Directory.GetFiles(this.file_path);

                foreach (String file in file_list)
                {
                    if (file == this.file_name)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }
    }
}
