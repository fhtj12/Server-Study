using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using client.parser;
using client.data;
using client.function;

namespace client
{
    public partial class Main_form : Form
    {
        public static String file_path = Application.StartupPath;
        public static Hashtable config = new Hashtable();
        private static error error = new error();
        public Main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configuration conf = new configuration();
            config = conf.get_config();

            if (config == null)
            {
                MessageBox.Show(error.config_parse);
                Application.Exit();
            }

            try
            {
                int x = Int32.Parse(config["screen_weight"].ToString());
                int y = Int32.Parse(config["screen_height"].ToString());
                ClientSize = new Size(x, y);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                MessageBox.Show(error.screen_set);
            }
        }
    }
}
