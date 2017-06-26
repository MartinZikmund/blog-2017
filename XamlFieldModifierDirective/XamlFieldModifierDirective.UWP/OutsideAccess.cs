using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlFieldModifierDirective.UWP
{
    public static class OutsideAccess
    {
        public static void ChangeTexts(MainPage page)
        {
            //page.InaccessibleTextBlock.Text = "Accessed"; - does not work
            page.AccessibleTextBlock.Text = "Accessed";
        }
    }
}
