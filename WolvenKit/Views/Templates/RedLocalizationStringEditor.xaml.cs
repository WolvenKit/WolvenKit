using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;

namespace WolvenKit.Views.Editors;
/// <summary>
/// Interaktionslogik für RedLocalizationStringEditor.xaml
/// </summary>
public partial class RedLocalizationStringEditor : UserControl
{
    public LocalizationString RedLocalizationString
    {
        get => (LocalizationString)GetValue(RedLocalizationStringProperty);
        set => SetValue(RedLocalizationStringProperty, value);
    }
    public static readonly DependencyProperty RedLocalizationStringProperty = DependencyProperty.Register(
        nameof(RedLocalizationString), typeof(LocalizationString), typeof(RedLocalizationStringEditor));

    public RedLocalizationStringEditor()
    {
        InitializeComponent();
    }

    public string Unk1
    {
        get => RedLocalizationString.Unk1.ToString();
        set
        {
            var ulongValue = ulong.Parse(value);
            if (RedLocalizationString.Unk1 != ulongValue)
            {
                // Set the whole LocalizationString instead of Unk1, so the CVM gets notified
                SetValue(RedLocalizationStringProperty, new LocalizationString
                {
                    Unk1 = ulongValue,
                    Value = RedLocalizationString.Value
                });
            }
        }
    }

    public string Value
    {
        get => RedLocalizationString.Value;
        set
        {
            if (RedLocalizationString.Value != value)
            {
                // Set the whole LocalizationString instead of Value, so the CVM gets notified
                SetValue(RedLocalizationStringProperty, new LocalizationString
                {
                    Unk1 = RedLocalizationString.Unk1,
                    Value = value
                });
            }
        }
    }

    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        if (e.Source is not TextBox textBox)
        {
            throw new Exception();
        }
        
        e.Handled = !ulong.TryParse(textBox.Text.Insert(textBox.CaretIndex, e.Text), out _);
    }
}
