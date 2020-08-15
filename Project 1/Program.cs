using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    static class Program
    {
        //is Multiplayer Game or not
        public static bool isMultiplayer;
        public static Form form;
        public static List<User> users = new List<User>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Main();
            form.Show();
            Application.Run();
            
        }
        public static void gotoLogin()
        {
        
                form.Close();
    
            form = new Login();
            form.Show();
            
        }
        public static void gotoPlayerSelect()
        {
           
          
                form.Close();
            
            
            form = new PlayserSelect();
            form.Show();
        }

        public static void gotoMain()
        {
           
                form.Close();
            

            form = new Main();
            form.Show();
        }
    }
}
