using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace WolvenKit.App.Extensions;

public static class RichTextBoxExtensions
{
    #region Methods

    //https://stackoverflow.com/a/23402165
    public static void AppendText(this RichTextBox box, string text, string color)
    {
        var bc = new BrushConverter();
        var tr = new TextRange(box.Document.ContentEnd, box.Document.ContentEnd)
        {
            Text = text
        };
        try
        {
            tr.ApplyPropertyValue(TextElement.ForegroundProperty,
                bc.ConvertFromString(color));
        }
        catch (FormatException) { }
    }

    #endregion Methods
}
