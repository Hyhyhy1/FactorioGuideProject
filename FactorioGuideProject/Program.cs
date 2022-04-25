using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioGuideProject
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var GuideForm = new GuideForm();
            GuideForm.Text = "Гайд по Факторио";
            GuideForm.Size = new System.Drawing.Size(600,550);
            Application.Run(GuideForm);
        }
    }
}
