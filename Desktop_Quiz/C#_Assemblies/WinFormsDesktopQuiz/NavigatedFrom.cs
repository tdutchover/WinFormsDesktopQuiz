using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    // Allow Form1 (i.e. landing page) to know which child form is returning control
    internal enum NavigatedFrom
    {
        // There is no child form returning control. This state occurs during app startup and also immediately
        // after Form1 accepts control back from the child form.
        ApplicationStartup,

        // Indicates that a quiz completed and has returned control back to the landing page.
        QuizFormSession,

        // Indicates that a quiz completed and has returned control back to the landing page.
        AdminFormSession
    }
}
