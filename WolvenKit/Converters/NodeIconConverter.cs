using System;
using System.Globalization;
using System.Windows.Data;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Converter that returns the emoji icon for a node title using the centralized GraphNodeStyling
    /// </summary>
    public class NodeIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string nodeTitle)
            {
                return GraphNodeStyling.GetIconForNodeTitle(nodeTitle);
            }
            return "⚪"; // Default fallback
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
} 