using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using WolvenKit.App.ViewModels.Exporters;

namespace WolvenKit.Controls
{
    /// <summary>
    /// Interaction logic for CustomCollectionEditorView.xaml
    /// </summary>
    public partial class CustomCollectionEditorView
    {
        private readonly Func<CallbackArguments, Task> _callback;
        private readonly CallbackArguments _args;

        public CustomCollectionEditorView() => InitializeComponent();
        public CustomCollectionEditorView(Func<CallbackArguments, Task> callback, CallbackArguments args) : this()
        {
            _callback = callback;
            _args = args;

            SetText();
        }

        public IList List
        {
            get => (IList)GetValue(ListProperty);
            set => SetValue(ListProperty, value);
        }
        public static readonly DependencyProperty ListProperty = DependencyProperty.Register(
            nameof(List), typeof(IList), typeof(CustomCollectionEditorView), new PropertyMetadata(null));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            nameof(Text), typeof(string), typeof(CustomCollectionEditorView), new PropertyMetadata("Null"));


        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            await _callback(_args);

            SetText();
        }

        private void SetText()
        {
            if (List is not null)
            {
                var text = $"[{List.Count}]";
                if (List.Count == 1)
                {
                    text += $"{List[0]}";
                }
                else if (List.Count > 1)
                {
                    text += $"{List[0]}, ...";
                }

                SetCurrentValue(TextProperty, text);
            }
        }
    }
}
