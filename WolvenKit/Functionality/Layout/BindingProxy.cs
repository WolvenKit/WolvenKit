using System.Windows;

namespace WolvenKit.Functionality.Layout
{
    /// <summary>
    /// Implements an XAML proxy which can be used to bind items (TreeViewItem, ListViewItem etc)
    /// with a viewmodel that manages the collections.
    ///
    /// Source: http://www.thomaslevesque.com/2011/03/21/wpf-how-to-bind-to-data-when-the-datacontext-is-not-inherited/
    ///  Issue: http://stackoverflow.com/questions/9994241/mvvm-binding-command-to-contextmenu-item
    /// </summary>
    public class BindingProxy : Freezable
    {
        #region Fields

        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register(nameof(Data), typeof(object), typeof(BindingProxy), new UIPropertyMetadata(null));

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the data object this class is forwarding to everyone
        /// who has a reference to this object.
        /// </summary>
        public object Data
        {
            get => GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Overrides of Freezable
        /// </summary>
        /// <returns></returns>
        protected override Freezable CreateInstanceCore() => new BindingProxy();

        #endregion Methods
    }
}
