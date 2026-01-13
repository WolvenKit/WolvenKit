using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WolvenKit.Converters
{
    public class MsToSecondsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is uint ms)
            {
                return ms / 1000.0;
            }
            return 0.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class InverseBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b)
            {
                return b ? System.Windows.Visibility.Collapsed : System.Windows.Visibility.Visible;
            }
            return System.Windows.Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class MillisecondsToTimeStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is uint milliseconds)
            {
                var timeSpan = TimeSpan.FromMilliseconds(milliseconds);
                if (timeSpan.TotalHours >= 1)
                {
                    return $"{(int)timeSpan.TotalHours}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}.{timeSpan.Milliseconds:D3}";
                }
                else if (timeSpan.TotalMinutes >= 1)
                {
                    return $"{(int)timeSpan.TotalMinutes}:{timeSpan.Seconds:D2}.{timeSpan.Milliseconds:D3}";
                }
                else
                {
                    return $"{timeSpan.Seconds}.{timeSpan.Milliseconds:D3}s";
                }
            }
            return "0s";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class TimeToPixelsConverter : IValueConverter
    {
        private const double PixelsPerMillisecond = 0.2; // 1 pixel = 5ms

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is uint milliseconds)
            {
                // Remove minimum width constraint to fix alignment issues
                // Ensure minimum reasonable width for very short durations
                return Math.Max(200, milliseconds * PixelsPerMillisecond);
            }
            return 200;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class EventTypeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string eventType)
            {
                // Color coding based on event type
                if (eventType == "InstantEvent")
                    return new SolidColorBrush(Color.FromRgb(255, 87, 34)); // Deep Orange - distinctive color for instant events
                else if (eventType.Contains("Dialog"))
                    return new SolidColorBrush(Color.FromRgb(92, 172, 238)); // Light Blue
                else if (eventType.Contains("Audio"))
                    return new SolidColorBrush(Color.FromRgb(92, 184, 92)); // Light Green
                else if (eventType.Contains("Camera"))
                    return new SolidColorBrush(Color.FromRgb(240, 173, 78)); // Orange
                else if (eventType.Contains("Animation") || eventType.Contains("Anim"))
                    return new SolidColorBrush(Color.FromRgb(217, 83, 79)); // Light Red
                else if (eventType.Contains("VFX") || eventType.Contains("Effect"))
                    return new SolidColorBrush(Color.FromRgb(156, 39, 176)); // Purple
                else if (eventType.Contains("LookAt"))
                    return new SolidColorBrush(Color.FromRgb(255, 193, 7)); // Amber
                else if (eventType.Contains("Socket"))
                    return new SolidColorBrush(Color.FromRgb(96, 125, 139)); // Blue Grey
                else
                    return new SolidColorBrush(Color.FromRgb(158, 158, 158)); // Grey
            }
            return new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
} 