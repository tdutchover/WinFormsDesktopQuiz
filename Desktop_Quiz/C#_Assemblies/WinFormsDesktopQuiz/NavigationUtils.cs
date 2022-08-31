using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDesktopQuiz
{
    internal class NavigationUtils
    {
        public static void NavigateToLandingPage(Form1 toLandingPageForm, Form fromChildForm)
        {
            toLandingPageForm.Show();
            fromChildForm.Hide();
        }
        public static void NavigateToForm(Form toForm, Form fromForm)
        {
            toForm.Show();
            fromForm.Hide();
        }
    }
}
