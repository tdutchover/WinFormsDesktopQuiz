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
        public static void NavigateToLandingPage(Form toParentForm, Form fromChildForm)
        {
            toParentForm.Show();
            fromChildForm.Hide();
        }
    }
}
