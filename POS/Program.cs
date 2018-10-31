using POS.Models;
using POS.ViewModels;
using POS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public class Program
    {
        /// <summary>
        /// 執行主程式
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main(string[] args)
        {
            Form startUpForm = new StartUpForm();
            Application.Run(startUpForm);
        }
    }
}
