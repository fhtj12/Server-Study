using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.common
{
    public enum Status
    {
        Success,
        Warning,
        Error,
    }

    public static class loading_screen
    {
        static Loading_Form loading_Form = null;

        public static void show_form()
        {
            if(loading_Form == null)
            {
                loading_Form = new Loading_Form();
                loading_Form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                loading_Form.show_form();
            }
        }

        public static void close_form()
        {
            if(loading_Form != null)
            {
                loading_Form.close_form();
                loading_Form = null;
            }
        }

        public static void update_status_text(string text)
        {
            if(loading_Form != null)
            {
                loading_Form.update_status_text(text);
            }
        }

        public static void update_status_text_with_status(string text, Status status)
        {
            if(loading_Form != null)
            {
                loading_Form.update_status_text_with_status(text, status);
            }
        }
    }
}
