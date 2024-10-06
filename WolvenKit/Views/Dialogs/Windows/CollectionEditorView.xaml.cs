using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.Views.Dialogs.Windows;
/// <summary>
/// Interaktionslogik für CollectionEditorView.xaml
/// </summary>
public partial class CollectionEditorView : Window
{
    private readonly Type _type;

    public List<object> ResultList { get; } = [];

    public CollectionEditorView(IList items, Type type)
    {
        InitializeComponent();

        _type = type;

        foreach (var item in items)
        {
            ListView.Items.Add(new ValueWrapper(item));
        }
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        foreach (var item in ListView.Items)
        {
            if (item is not ValueWrapper valueWrapper)
            {
                continue;
            }

            valueWrapper.Convert();
            ResultList.Add(valueWrapper.Value);
        }

        DialogResult = true;
        Close();
    }

    private void CancelButton_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    private void AddButton_OnClick(object sender, RoutedEventArgs e)
    {
        ListView.Items.Add(new ValueWrapper(GetDefault(), _type));
    }

    private object GetDefault()
    {
        if (_type.IsValueType)
        {
            return Activator.CreateInstance(_type);
        }

        if (_type == typeof(string))
        {
            return string.Empty;
        }

        return null;
    }

    private void Remove_OnClick(object sender, RoutedEventArgs e)
    {
        var btn = (Button)sender;

        ListView.Items.Remove(btn.DataContext);
    }

    public class ValueWrapper
    {
        public object Value { get; set; }
        public Type TargetType { get; }

        public bool IsTargetType => TargetType == Value.GetType();

        public ValueWrapper(object value)
        {
            Value = value;
            TargetType = value.GetType();
        }

        public ValueWrapper(object value, Type type)
        {
            Value = value;
            TargetType = type;
        }

        public bool Convert()
        {
            if (IsTargetType)
            {
                return true;
            }

            if (Value.GetType() != typeof(string))
            {
                Value = Value.ToString();
            }

            if (TargetType == typeof(int))
            {
                if (!int.TryParse((string)Value, out var tmpVal))
                {
                    return false;
                }

                Value = tmpVal;
                return true;
            }

            if (TargetType == typeof(double))
            {
                if (!double.TryParse((string)Value, CultureInfo.InvariantCulture, out var tmpVal))
                {
                    return false;
                }

                Value = tmpVal;
                return true;
            }

            if (TargetType == typeof(bool))
            {
                if (!bool.TryParse((string)Value, out var tmpVal))
                {
                    return false;
                }

                Value = tmpVal;
                return true;
            }

            return false;
        }
    }
}
