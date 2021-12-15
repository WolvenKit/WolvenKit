using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WolvenKit.Views.Others
{
    /// <summary>
    /// Interaction logic for FileIcon.xaml
    /// </summary>
    public partial class FileIcon : UserControl
    {
        public FileIcon()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty FullIconProperty = DependencyProperty.Register(
            nameof(FullIcon), typeof(string), typeof(FileIcon),
            new PropertyMetadata("", new PropertyChangedCallback(OnIconChanged)));

        public string FullIcon
        {
            get { return (string)GetValue(FullIconProperty); }
            set { SetValue(FullIconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            nameof(Icon), typeof(string), typeof(FileIcon),
            new PropertyMetadata("", new PropertyChangedCallback(OnIconChanged)));

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register(
            nameof(Type), typeof(string), typeof(FileIcon),
            new PropertyMetadata("", new PropertyChangedCallback(OnIconChanged)));

        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
        private static void OnIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var instance = d as FileIcon;
            if (instance != null)
            {
                instance.FullIcon = instance.Icon + instance.Type;
            }

        }
    }
}
