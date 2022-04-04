using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WolvenKit
{
    public static class WkitColors
    {
        public static Color Red = Color.FromRgb(0xDF, 0x29, 0x35);
        public static Color Cyan = Color.FromRgb(0x52, 0xF1, 0xFF);
        public static Color Yellow = Color.FromRgb(0xFF, 0xEA, 0x0A);
        public static Color Purple = Color.FromRgb(0x57, 0x60, 0xB3);
        public static Color Tan = Color.FromRgb(0xD0, 0xA4, 0x67);
    }

    public static class WkitBrushes
    {
        public static SolidColorBrush Red = new SolidColorBrush(WkitColors.Red);
        public static SolidColorBrush Cyan = new SolidColorBrush(WkitColors.Cyan);
        public static SolidColorBrush Yellow = new SolidColorBrush(WkitColors.Yellow);
        public static SolidColorBrush Purple = new SolidColorBrush(WkitColors.Purple);
        public static SolidColorBrush Tan = new SolidColorBrush(WkitColors.Tan);
    }
}
