using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WolvenKit.Functionality.Layout.inkWidgets
{
    [MarkupExtensionReturnType(typeof(ImageSource))]
    public class TextureExtension : MarkupExtension
    {
        public TextureExtension(string atlas, string part)
        {
            Atlas = atlas;
            Part = part;
        }

        string Atlas { get; set; }

        string Part { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return (ImageSource)Application.Current.TryFindResource("ImageSource/" + Atlas + "#" + Part);
        }
    }
}
