using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace UWPListItemStretch
{
    public class ListItem
    {
        public ListItem( Color color, string text )
        {
            Color = color;
            Text = text;
        }

        public Color Color { get; set; }

        public string Text { get; set; }
    }
}
