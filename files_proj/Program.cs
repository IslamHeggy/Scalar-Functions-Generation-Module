using System;
using System.Windows.Forms;

namespace files_proj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data emp = new Data();
            emp.Get_Data();

            DT dt = new DT();
            dt.get_dt();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
