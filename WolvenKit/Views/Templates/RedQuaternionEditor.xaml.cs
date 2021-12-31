using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedQuaternionEditor.xaml
    /// </summary>
    public partial class RedQuaternionEditor : UserControl
    {
        public RedQuaternionEditor()
        {
            InitializeComponent();
        }

        public CFloat I
        {
            get => (CFloat)this.GetValue(IProperty);
            set => this.SetValue(IProperty, value);
        }
        public static readonly DependencyProperty IProperty = DependencyProperty.Register(
            nameof(I), typeof(CFloat), typeof(RedQuaternionEditor), new PropertyMetadata(default(CFloat)));

        public CFloat J
        {
            get => (CFloat)this.GetValue(JProperty);
            set => this.SetValue(JProperty, value);
        }
        public static readonly DependencyProperty JProperty = DependencyProperty.Register(
            nameof(J), typeof(CFloat), typeof(RedQuaternionEditor), new PropertyMetadata(default(CFloat)));

        public CFloat K
        {
            get => (CFloat)this.GetValue(KProperty);
            set => this.SetValue(KProperty, value);
        }
        public static readonly DependencyProperty KProperty = DependencyProperty.Register(
            nameof(K), typeof(CFloat), typeof(RedQuaternionEditor), new PropertyMetadata(default(CFloat)));

        public CFloat R
        {
            get => (CFloat)this.GetValue(RProperty);
            set => this.SetValue(RProperty, value);
        }
        public static readonly DependencyProperty RProperty = DependencyProperty.Register(
            nameof(R), typeof(CFloat), typeof(RedQuaternionEditor), new PropertyMetadata(default(CFloat)));


        public string IText
        {
            get => GetValueFromIValue();
            set => SetIValue(value);
        }

        public string JText
        {
            get => GetValueFromJValue();
            set => SetJValue(value);
        }

        public string KText
        {
            get => GetValueFromKValue();
            set => SetKValue(value);
        }

        public string RText
        {
            get => GetValueFromRValue();
            set => SetRValue(value);
        }

        private void SetIValue(string value) => SetCurrentValue(IProperty, (CFloat)float.Parse(value));
        private void SetJValue(string value) => SetCurrentValue(JProperty, (CFloat)float.Parse(value));
        private void SetKValue(string value) => SetCurrentValue(KProperty, (CFloat)float.Parse(value));
        private void SetRValue(string value) => SetCurrentValue(RProperty, (CFloat)float.Parse(value));

        private string GetValueFromIValue() => ((float)I).ToString("R");
        private string GetValueFromJValue() => ((float)J).ToString("R");
        private string GetValueFromKValue() => ((float)K).ToString("R");
        private string GetValueFromRValue() => ((float)R).ToString("R");


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9\\.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
