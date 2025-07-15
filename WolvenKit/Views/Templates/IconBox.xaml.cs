using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.Views.Templates
{
    public enum IconPackType
    {
        Empty,
        Material,
        MaterialDesign,
        Codicons,
        ForkAwesome,
        Unicons,
        Bootstrap,
        Vaadin,
        Octicons
    }

    public class IconPackSelector : DataTemplateSelector
    {
        public DataTemplate EmptyTemplate { get; set; }

        /// <summary>
        /// https://pictogrammers.com/library/mdi/
        /// </summary>
        public DataTemplate MaterialTemplate { get; set; }

        /// <summary>
        /// https://fonts.google.com/icons
        /// </summary>
        public DataTemplate MaterialDesignTemplate { get; set; }

        /// <summary>
        /// https://microsoft.github.io/vscode-codicons/dist/codicon.html
        /// </summary>
        public DataTemplate CodiconsTemplate { get; set; }

        /// <summary>
        /// https://forkaweso.me/Fork-Awesome/cheatsheet/
        /// </summary>
        public DataTemplate ForkAwesomeTemplate { get; set; }

        /// <summary>
        /// https://iconscout.com/unicons/solid-icons
        /// </summary>
        public DataTemplate UniconsTemplate { get; set; }

        /// <summary>
        /// https://icons.getbootstrap.com
        /// </summary>
        public DataTemplate BootstrapTemplate { get; set; }

        /// <summary>
        /// https://vaadin.com/docs/latest/components/icons/default-icons
        /// </summary>
        public DataTemplate VaadinTemplate { get; set; }

        /// <summary>
        /// https://icongr.am/octicons
        /// </summary>
        public DataTemplate OcticonsTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is IconPackType type)
            {
                switch (type)
                {
                    case IconPackType.Empty:
                        return EmptyTemplate;
                    case IconPackType.Material:
                        return MaterialTemplate;
                    case IconPackType.MaterialDesign:
                        return MaterialDesignTemplate;
                    case IconPackType.Codicons:
                        return CodiconsTemplate;
                    case IconPackType.ForkAwesome:
                        return ForkAwesomeTemplate;
                    case IconPackType.Unicons:
                        return UniconsTemplate;
                    case IconPackType.Bootstrap:
                        return BootstrapTemplate;
                    case IconPackType.Vaadin:
                        return VaadinTemplate;
                    case IconPackType.Octicons:
                        return OcticonsTemplate;
                }
            }
            return base.SelectTemplate(item, container);
        }
    }

    public partial class IconBox : UserControl
    {
        public static readonly DependencyProperty IconPackProperty =
            DependencyProperty.Register(
                nameof(IconPack),
                typeof(IconPackType),
                typeof(IconBox),
                new PropertyMetadata(IconPackType.Empty)
            );
        public static readonly DependencyProperty KindProperty =
            DependencyProperty.Register(
                nameof(Kind),
                typeof(string),
                typeof(IconBox),
                new PropertyMetadata("")
            );
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register(
                nameof(Size),
                typeof(double),
                typeof(IconBox),
                new PropertyMetadata(-1.0)
            );
        public static readonly DependencyProperty RotationAngleProperty =
            DependencyProperty.Register(
                nameof(RotationAngle),
                typeof(double),
                typeof(IconBox),
                new PropertyMetadata(0.0)
            );

        public IconPackType IconPack
        {
            get => (IconPackType)GetValue(IconPackProperty);
            set => SetValue(IconPackProperty, value);
        }

        public string Kind
        {
            get => (string)GetValue(KindProperty);
            set => SetValue(KindProperty, value);
        }

        public double Size
        {
            get => (double)GetValue(SizeProperty);
            set => SetValue(SizeProperty, value);
        }

        public double RotationAngle
        {
            get => (double)GetValue(RotationAngleProperty);
            set => SetValue(RotationAngleProperty, value);
        }

        static IconBox()
        {
            MarginProperty.OverrideMetadata(
                typeof(IconBox),
                new FrameworkPropertyMetadata(new Thickness(-1))
            );
        }

        public IconBox()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += OnLoaded;
        }

        private static void OnLoaded(object sender, RoutedEventArgs e)
        {
            var icon = (IconBox)sender;

            if (icon.Size < 0.0)
            {
                icon.SetResourceReference(SizeProperty, "WolvenKitIconTiny");
            }
            if (icon.Margin == new Thickness(-1.0))
            {
                icon.SetResourceReference(MarginProperty, "WolvenKitMarginTiny");
            }
        }
    }
}