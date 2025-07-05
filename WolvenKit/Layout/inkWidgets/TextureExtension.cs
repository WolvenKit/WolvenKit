using System;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

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

        private string Atlas { get; set; }

        private string Part { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider) => (ImageSource)Application.Current.TryFindResource("ImageSource/" + Atlas + "#" + Part);
    }
}
