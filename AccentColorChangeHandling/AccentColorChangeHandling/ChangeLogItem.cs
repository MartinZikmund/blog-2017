using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;

namespace AccentColorChangeHandling
{
    public class ChangeLogItem
    {
        public ChangeLogItem( Color color, bool isDarkMode, DateTimeOffset time )
        {
            Color = color;
            Time = time;
            DarkModeVisibility = isDarkMode ? Visibility.Visible : Visibility.Collapsed;
        }

        public Color Color { get; }

        public DateTimeOffset Time { get; }

        public Visibility DarkModeVisibility { get; }
    }
}
