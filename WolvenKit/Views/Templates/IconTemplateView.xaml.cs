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
        public DataTemplate MaterialTemplate { get; set; }
        public DataTemplate MaterialDesignTemplate { get; set; }
        public DataTemplate CodiconsTemplate { get; set; }
        public DataTemplate ForkAwesomeTemplate { get; set; }
        public DataTemplate UniconsTemplate { get; set; }
        public DataTemplate BootstrapTemplate { get; set; }
        public DataTemplate VaadinTemplate { get; set; }
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

    public partial class IconTemplateView : UserControl
    {
        public static readonly DependencyProperty IconPackProperty =
            DependencyProperty.Register(
                nameof(IconPack),
                typeof(IconPackType),
                typeof(IconTemplateView),
                new PropertyMetadata(IconPackType.Empty)
            );
        public static readonly DependencyProperty KindProperty =
            DependencyProperty.Register(
                nameof(Kind),
                typeof(string),
                typeof(IconTemplateView),
                new PropertyMetadata("")
            );
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register(
                nameof(Size),
                typeof(double),
                typeof(IconTemplateView),
                new PropertyMetadata(20.0)
            );
        public static readonly DependencyProperty RotationAngleProperty =
            DependencyProperty.Register(
                nameof(RotationAngle),
                typeof(double),
                typeof(IconTemplateView),
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

        public IconTemplateView()
        {
            InitializeComponent();
            DataContext = this;
            SetResourceReference(SizeProperty, "WolvenKitTinyIconSize");
            SetResourceReference(MarginProperty, "WolvenKitMarginTiny");
        }
    }
}