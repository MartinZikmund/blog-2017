using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlFieldModifierDirective.WPF
{
    public static class OutsideAccess
    {
        public static void ChangeTexts(MainWindow window)
        {
            window.InaccessibleTextBlock.Text = "Accessed";
            window.AccessibleTextBlock.Text = "Accessed";
        }
    }
}
