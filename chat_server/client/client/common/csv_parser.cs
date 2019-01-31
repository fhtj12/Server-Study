using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace client.common
{
    class csv_parser
    {
        public Hashtable read(String file_name)
        {
            try
            {
                StreamReader sr = new StreamReader(file_name, Encoding.GetEncoding("UTF-8"));
                Hashtable result = new Hashtable();
                while (!sr.EndOfStream)
                {
                    String str = sr.ReadLine();
                    String[] temp = str.Split('=');
                    result.Add(temp[0], temp[1]);
                }
                sr.Dispose();
                return result;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
        public bool write(String file_name, Hashtable data)
        {
            try
            {
                StreamWriter sw = new StreamWriter(file_name);
                foreach (DictionaryEntry entry in data)
                {
                    String line = String.Format("{0}={1}", entry.Key, entry.Value);
                    sw.WriteLine(line);
                }
                sw.Dispose();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }
    }
}
