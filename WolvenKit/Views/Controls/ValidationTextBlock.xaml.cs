using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace WolvenKit.Views.Controls
{
    public partial class ValidationTextBlock : UserControl
    {
        public ValidationTextBlock()
        {
            InitializeComponent();
        }


        #region properties

        public static readonly DependencyProperty BoundControlProperty =
            DependencyProperty.Register(nameof(BoundControl), typeof(TextBox), typeof(ValidationTextBlock),
                new PropertyMetadata(null, OnBoundControlChanged));

        public TextBox BoundControl
        {
            get => (TextBox)GetValue(BoundControlProperty);
            set => SetValue(BoundControlProperty, value);
        }

        public static readonly DependencyProperty DefaultTextProperty =
            DependencyProperty.Register(nameof(DefaultText), typeof(string), typeof(ValidationTextBlock),
                new PropertyMetadata(string.Empty));

        public string DefaultText
        {
            get => (string)GetValue(DefaultTextProperty);
            set
            {
                SetValue(DefaultTextProperty, value);
                SetValue(HasErrorProperty, false);
                SetDefaultText();
            }
        }

        private void SetDefaultText()
        {
            var textValue = UseSecondaryText ? SecondaryText : DefaultText;
            SetCurrentValue(TextProperty, textValue);
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(ValidationTextBlock), new PropertyMetadata(string.Empty));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty SecondaryTextProperty =
            DependencyProperty.Register(nameof(SecondaryText), typeof(string), typeof(ValidationTextBlock),
                new PropertyMetadata(string.Empty));

        public string SecondaryText
        {
            get => (string)GetValue(SecondaryTextProperty);
            set => SetValue(SecondaryTextProperty, value);
        }

        public static readonly DependencyProperty UseSecondaryTextProperty =
            DependencyProperty.Register(nameof(UseSecondaryText), typeof(bool), typeof(ValidationTextBlock), new PropertyMetadata(false));

        public bool UseSecondaryText
        {
            get => (bool)GetValue(UseSecondaryTextProperty);
            set => SetValue(UseSecondaryTextProperty, value);
        }

        public static readonly DependencyProperty HasErrorProperty =
            DependencyProperty.Register(nameof(HasError), typeof(bool), typeof(ValidationTextBlock), new PropertyMetadata(false));

        public bool HasError
        {
            get => (bool)GetValue(HasErrorProperty);
            set => SetValue(HasErrorProperty, value);
        }

        #endregion

        private static void OnBoundControlChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not ValidationTextBlock validationTextBlock)
            {
                return;
            }

            if (e.OldValue is TextBox oldTextBox)
            {
                oldTextBox.TextChanged -= validationTextBlock.OnTextBoxTextChanged;
            }
            else
            {
                // first init
                validationTextBlock.SetDefaultText();
            }

            if (e.NewValue is TextBox newTextBox)
            {
                newTextBox.TextChanged += validationTextBlock.OnTextBoxTextChanged;
            }
        }


        private void OnTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (BoundControl is null)
            {
                return;
            }

            // Force validation update
            BoundControl.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();

            var hasError = Validation.GetHasError(BoundControl);
            SetCurrentValue(HasErrorProperty, hasError);
            SetDefaultText();
            if (hasError)
            {
                SetCurrentValue(TextProperty, Validation.GetErrors(BoundControl).FirstOrDefault()?.ErrorContent?.ToString());
            }
        }
    }
}