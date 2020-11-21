using System.Windows;

namespace WolvenKit.UI.Views
{
    /// <summary>
    /// Represents a view that can be shown to the user.
    /// </summary>
    public interface IView
    {
        string Title { get; set; }
        object DataContext { get; set; }
        bool IsActive { get; }
        void Show();
        void Close();
        Window Owner { get; set; }
    }
}